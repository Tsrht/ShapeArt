using BasicFigures;
using DrawingInformation;
using FigureBasis;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using static Newtonsoft.Json.JsonConvert;

namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        public DrawInfo Info = new DrawInfo();

        public class FigureFabricItem
        {
            public readonly string Text;
            public readonly IFigureFabric Value;
            public override string ToString() => Text;
            public FigureFabricItem(IFigureFabric fabric)
            {
                Text = fabric.Produce().Name;
                Value = fabric;
            }
        }

        public FormMain()
        {
            InitializeComponent();

            Info.Availables.Add(new LineFabric());
            Info.Availables.Add(new RectangleFabric());
            Info.Availables.Add(new EllipseFabric());
            Info.Availables.Add(new PolylineFabric());
            Info.Availables.Add(new PolygonFabric());

            ComboBoxFigures.Items.AddRange(Info.Availables.Select(f => new FigureFabricItem(f)).ToArray());
        }

        private void Redraw()
        {
            if (!(Info.CurrentFigure is null))
            {
                Info.CurrentFigure.Filled = Info.CurrentFill;
                Info.CurrentFigure.Pen = Info.CurrentPen.Clone() as Pen;
            }
            PictureBoxPaint.Refresh();
        }

        private void FinishDrawing()
        {
            Redraw();
            if (!(Info.CurrentFigure is null))
            {
                if (Info.CurrentFigure.IsFigureOkay())
                {
                    Info.Figures.Add(Info.CurrentFigure);
                    Info.Trash.Clear();
                }
            }
            if (!(Info.CurrentFabric is null))
            {
                Info.CurrentFigure = Info.CurrentFabric.Produce();
            }
            Redraw();
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog() { DefaultExt = ".json", Filter = "JSON Files (*.json)|*json", AddExtension = true };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json;
                    using (var fs = new FileStream(dialog.FileName, FileMode.Open))
                    {
                        var sr = new StreamReader(fs);
                        json = sr.ReadToEnd();
                        sr.Close();
                    }
                    List<Figure> figures = DeserializeObject<List<Figure>>(
                        json,
                        new JsonSerializerSettings()
                        {
                            TypeNameHandling = TypeNameHandling.All
                        });
                    if (!(figures is null))
                    {
                        FinishDrawing();
                        Info.Trash.Clear();
                        Info.Figures = figures;
                        Redraw();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog() { DefaultExt = ".json", Filter = "JSON Files (*.json)|*json", AddExtension = true };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var fs = new FileStream(dialog.FileName, FileMode.Create))
                    {
                        string json = SerializeObject(
                            Info.Figures,
                            Formatting.Indented,
                            new JsonSerializerSettings()
                            {
                                TypeNameHandling = TypeNameHandling.All
                            });
                        var sw = new StreamWriter(fs);
                        sw.Write(json);
                        sw.Flush();
                        sw.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Saving error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonUndo_Click(object sender, EventArgs e)
        {
            if (Info.Figures.Count > 0)
            {
                Info.Trash.Add(Info.Figures.Last());
                Info.Figures.RemoveAt(Info.Figures.Count - 1);
                Redraw();
            }
        }

        private void ButtonRedo_Click(object sender, EventArgs e)
        {
            if (Info.Trash.Count > 0)
            {
                Info.Figures.Add(Info.Trash.Last());
                Info.Trash.RemoveAt(Info.Trash.Count - 1);
                Redraw();
            }
        }

        private void ButtonLoadFigure_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            Info.CurrentFabric = (ComboBoxFigures.SelectedItem as FigureFabricItem).Value;
            FinishDrawing();
        }

        private void TrackBarColorR_Scroll(object sender, EventArgs e)
        {
            Info.CurrentPen.Color = Color.FromArgb(TrackBarColorR.Value, Info.CurrentPen.Color.G, Info.CurrentPen.Color.B);
            Redraw();
        }

        private void TrackBarColorG_Scroll(object sender, EventArgs e)
        {
            Info.CurrentPen.Color = Color.FromArgb(Info.CurrentPen.Color.R, TrackBarColorG.Value, Info.CurrentPen.Color.B);
            Redraw();
        }

        private void TrackBarColorB_Scroll(object sender, EventArgs e)
        {
            Info.CurrentPen.Color = Color.FromArgb(Info.CurrentPen.Color.R, Info.CurrentPen.Color.G, TrackBarColorB.Value);
            Redraw();
        }

        private void NumericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            Info.CurrentPen.Width = (float)NumericUpDownWidth.Value;
            Redraw();
        }

        private void CheckBoxFill_CheckedChanged(object sender, EventArgs e)
        {
            Info.CurrentFill = CheckBoxFill.Checked;
            Redraw();
        }

        private void ButtonAddPoint_Click(object sender, EventArgs e)
        {
            int xpos = 0, ypos = 0;
            bool valid = 
                int.TryParse(TextBoxAddPointX.Text, out xpos) 
                && int.TryParse(TextBoxAddPointX.Text, out ypos)
                && xpos >= 0 && ypos >= 0;
            if (valid)
            {
                Info.CurrentFigure.TryAddPoint(new Point(xpos, ypos));
                Redraw();
            }
        }

        private void ButtonFinishPaint_Click(object sender, EventArgs e)
        {
            FinishDrawing();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            FinishDrawing();
            Info.Figures.Clear();
            Info.Trash.Clear();
            Redraw();
        }

        private void PictureBoxPaint_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure figure in Info.Figures)
            {
                figure.Draw(e.Graphics);
            }
            if (!(Info.CurrentFigure is null))
            {
                Info.CurrentFigure.Draw(e.Graphics);
            }
        }

        private void PictureBoxPaint_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(Info.CurrentFigure is null))
            {
                if (e.Button == MouseButtons.Left)
                {
                    Info.CurrentFigure.TryAddPoint(e.Location);
                    Redraw();
                }
                else
                if (e.Button == MouseButtons.Right)
                {
                    FinishDrawing();
                }
            }
        }

        private void PictureBoxPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (!(Info.CurrentFigure is null))
            {
                if (Info.CurrentFigure.TryAddPoint(e.Location))
                {
                    Redraw();
                    Info.CurrentFigure.Points.RemoveAt(Info.CurrentFigure.Points.Count - 1);
                }
            }
        }

        private void PictureBoxPaint_MouseLeave(object sender, EventArgs e)
        {
            Redraw();
        }
    }
}
