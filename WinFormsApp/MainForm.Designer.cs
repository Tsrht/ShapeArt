
namespace WinFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBoxPaint = new System.Windows.Forms.PictureBox();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonUndo = new System.Windows.Forms.Button();
            this.ButtonRedo = new System.Windows.Forms.Button();
            this.ButtonLoadFigure = new System.Windows.Forms.Button();
            this.LabelFigure = new System.Windows.Forms.Label();
            this.LabelColor = new System.Windows.Forms.Label();
            this.LabelColorR = new System.Windows.Forms.Label();
            this.LabelColorG = new System.Windows.Forms.Label();
            this.LabelColorB = new System.Windows.Forms.Label();
            this.LabelWidth = new System.Windows.Forms.Label();
            this.LabelFill = new System.Windows.Forms.Label();
            this.LabelAddPoint = new System.Windows.Forms.Label();
            this.LabelAddPointX = new System.Windows.Forms.Label();
            this.LabelAddPointY = new System.Windows.Forms.Label();
            this.ComboBoxFigures = new System.Windows.Forms.ComboBox();
            this.TrackBarColorR = new System.Windows.Forms.TrackBar();
            this.TrackBarColorB = new System.Windows.Forms.TrackBar();
            this.TrackBarColorG = new System.Windows.Forms.TrackBar();
            this.NumericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxFill = new System.Windows.Forms.CheckBox();
            this.ButtonAddPoint = new System.Windows.Forms.Button();
            this.TextBoxAddPointX = new System.Windows.Forms.TextBox();
            this.TextBoxAddPointY = new System.Windows.Forms.TextBox();
            this.ButtonFinishPaint = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColorR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColorG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxPaint
            // 
            this.PictureBoxPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxPaint.BackColor = System.Drawing.Color.White;
            this.PictureBoxPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxPaint.Location = new System.Drawing.Point(25, 75);
            this.PictureBoxPaint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBoxPaint.Name = "PictureBoxPaint";
            this.PictureBoxPaint.Size = new System.Drawing.Size(650, 650);
            this.PictureBoxPaint.TabIndex = 0;
            this.PictureBoxPaint.TabStop = false;
            this.PictureBoxPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxPaint_Paint);
            this.PictureBoxPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxPaint_MouseDown);
            this.PictureBoxPaint.MouseLeave += new System.EventHandler(this.PictureBoxPaint_MouseLeave);
            this.PictureBoxPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxPaint_MouseMove);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(5, 5);
            this.ButtonOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(150, 40);
            this.ButtonOpen.TabIndex = 1;
            this.ButtonOpen.Text = "Открыть";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(155, 5);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(150, 40);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonUndo
            // 
            this.ButtonUndo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonUndo.Location = new System.Drawing.Point(355, 5);
            this.ButtonUndo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonUndo.Name = "ButtonUndo";
            this.ButtonUndo.Size = new System.Drawing.Size(150, 40);
            this.ButtonUndo.TabIndex = 3;
            this.ButtonUndo.Text = "Отменить";
            this.ButtonUndo.UseVisualStyleBackColor = true;
            this.ButtonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
            // 
            // ButtonRedo
            // 
            this.ButtonRedo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonRedo.Location = new System.Drawing.Point(505, 5);
            this.ButtonRedo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonRedo.Name = "ButtonRedo";
            this.ButtonRedo.Size = new System.Drawing.Size(150, 40);
            this.ButtonRedo.TabIndex = 4;
            this.ButtonRedo.Text = "Вернуть";
            this.ButtonRedo.UseVisualStyleBackColor = true;
            this.ButtonRedo.Click += new System.EventHandler(this.ButtonRedo_Click);
            // 
            // ButtonLoadFigure
            // 
            this.ButtonLoadFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLoadFigure.Location = new System.Drawing.Point(730, 5);
            this.ButtonLoadFigure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonLoadFigure.Name = "ButtonLoadFigure";
            this.ButtonLoadFigure.Size = new System.Drawing.Size(250, 40);
            this.ButtonLoadFigure.TabIndex = 5;
            this.ButtonLoadFigure.Text = "Загрузить фигуру";
            this.ButtonLoadFigure.UseVisualStyleBackColor = true;
            this.ButtonLoadFigure.Click += new System.EventHandler(this.ButtonLoadFigure_Click);
            // 
            // LabelFigure
            // 
            this.LabelFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFigure.AutoSize = true;
            this.LabelFigure.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelFigure.Location = new System.Drawing.Point(700, 80);
            this.LabelFigure.Name = "LabelFigure";
            this.LabelFigure.Size = new System.Drawing.Size(142, 25);
            this.LabelFigure.TabIndex = 6;
            this.LabelFigure.Text = "Выбор фигуры:";
            // 
            // LabelColor
            // 
            this.LabelColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelColor.AutoSize = true;
            this.LabelColor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelColor.Location = new System.Drawing.Point(700, 220);
            this.LabelColor.Name = "LabelColor";
            this.LabelColor.Size = new System.Drawing.Size(58, 25);
            this.LabelColor.TabIndex = 7;
            this.LabelColor.Text = "Цвет:";
            // 
            // LabelColorR
            // 
            this.LabelColorR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelColorR.AutoSize = true;
            this.LabelColorR.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelColorR.Location = new System.Drawing.Point(760, 180);
            this.LabelColorR.Name = "LabelColorR";
            this.LabelColorR.Size = new System.Drawing.Size(23, 25);
            this.LabelColorR.TabIndex = 8;
            this.LabelColorR.Text = "R";
            // 
            // LabelColorG
            // 
            this.LabelColorG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelColorG.AutoSize = true;
            this.LabelColorG.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelColorG.Location = new System.Drawing.Point(760, 220);
            this.LabelColorG.Name = "LabelColorG";
            this.LabelColorG.Size = new System.Drawing.Size(25, 25);
            this.LabelColorG.TabIndex = 9;
            this.LabelColorG.Text = "G";
            // 
            // LabelColorB
            // 
            this.LabelColorB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelColorB.AutoSize = true;
            this.LabelColorB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelColorB.Location = new System.Drawing.Point(760, 260);
            this.LabelColorB.Name = "LabelColorB";
            this.LabelColorB.Size = new System.Drawing.Size(23, 25);
            this.LabelColorB.TabIndex = 10;
            this.LabelColorB.Text = "B";
            // 
            // LabelWidth
            // 
            this.LabelWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelWidth.AutoSize = true;
            this.LabelWidth.CausesValidation = false;
            this.LabelWidth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelWidth.Location = new System.Drawing.Point(700, 320);
            this.LabelWidth.Name = "LabelWidth";
            this.LabelWidth.Size = new System.Drawing.Size(95, 25);
            this.LabelWidth.TabIndex = 11;
            this.LabelWidth.Text = "Толщина:";
            // 
            // LabelFill
            // 
            this.LabelFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFill.AutoSize = true;
            this.LabelFill.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelFill.Location = new System.Drawing.Point(700, 380);
            this.LabelFill.Name = "LabelFill";
            this.LabelFill.Size = new System.Drawing.Size(86, 25);
            this.LabelFill.TabIndex = 12;
            this.LabelFill.Text = "Заливка:";
            // 
            // LabelAddPoint
            // 
            this.LabelAddPoint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelAddPoint.AutoSize = true;
            this.LabelAddPoint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelAddPoint.Location = new System.Drawing.Point(740, 450);
            this.LabelAddPoint.Name = "LabelAddPoint";
            this.LabelAddPoint.Size = new System.Drawing.Size(178, 25);
            this.LabelAddPoint.TabIndex = 13;
            this.LabelAddPoint.Text = "Добавление точки:";
            // 
            // LabelAddPointX
            // 
            this.LabelAddPointX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelAddPointX.AutoSize = true;
            this.LabelAddPointX.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelAddPointX.Location = new System.Drawing.Point(740, 480);
            this.LabelAddPointX.Name = "LabelAddPointX";
            this.LabelAddPointX.Size = new System.Drawing.Size(23, 25);
            this.LabelAddPointX.TabIndex = 14;
            this.LabelAddPointX.Text = "X";
            // 
            // LabelAddPointY
            // 
            this.LabelAddPointY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelAddPointY.AutoSize = true;
            this.LabelAddPointY.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelAddPointY.Location = new System.Drawing.Point(830, 480);
            this.LabelAddPointY.Name = "LabelAddPointY";
            this.LabelAddPointY.Size = new System.Drawing.Size(23, 25);
            this.LabelAddPointY.TabIndex = 15;
            this.LabelAddPointY.Text = "Y";
            // 
            // ComboBoxFigures
            // 
            this.ComboBoxFigures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxFigures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFigures.FormattingEnabled = true;
            this.ComboBoxFigures.Location = new System.Drawing.Point(700, 120);
            this.ComboBoxFigures.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxFigures.Name = "ComboBoxFigures";
            this.ComboBoxFigures.Size = new System.Drawing.Size(270, 28);
            this.ComboBoxFigures.TabIndex = 16;
            this.ComboBoxFigures.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFigures_SelectedIndexChanged);
            // 
            // TrackBarColorR
            // 
            this.TrackBarColorR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBarColorR.LargeChange = 51;
            this.TrackBarColorR.Location = new System.Drawing.Point(780, 180);
            this.TrackBarColorR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TrackBarColorR.Maximum = 255;
            this.TrackBarColorR.Name = "TrackBarColorR";
            this.TrackBarColorR.Size = new System.Drawing.Size(190, 56);
            this.TrackBarColorR.TabIndex = 17;
            this.TrackBarColorR.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarColorR.Scroll += new System.EventHandler(this.TrackBarColorR_Scroll);
            // 
            // TrackBarColorB
            // 
            this.TrackBarColorB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBarColorB.LargeChange = 51;
            this.TrackBarColorB.Location = new System.Drawing.Point(780, 260);
            this.TrackBarColorB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TrackBarColorB.Maximum = 255;
            this.TrackBarColorB.Name = "TrackBarColorB";
            this.TrackBarColorB.Size = new System.Drawing.Size(190, 56);
            this.TrackBarColorB.TabIndex = 18;
            this.TrackBarColorB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarColorB.Scroll += new System.EventHandler(this.TrackBarColorB_Scroll);
            // 
            // TrackBarColorG
            // 
            this.TrackBarColorG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBarColorG.LargeChange = 51;
            this.TrackBarColorG.Location = new System.Drawing.Point(780, 220);
            this.TrackBarColorG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TrackBarColorG.Maximum = 255;
            this.TrackBarColorG.Name = "TrackBarColorG";
            this.TrackBarColorG.Size = new System.Drawing.Size(190, 56);
            this.TrackBarColorG.TabIndex = 19;
            this.TrackBarColorG.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarColorG.Scroll += new System.EventHandler(this.TrackBarColorG_Scroll);
            // 
            // NumericUpDownWidth
            // 
            this.NumericUpDownWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericUpDownWidth.Location = new System.Drawing.Point(800, 320);
            this.NumericUpDownWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericUpDownWidth.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NumericUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownWidth.Name = "NumericUpDownWidth";
            this.NumericUpDownWidth.Size = new System.Drawing.Size(50, 27);
            this.NumericUpDownWidth.TabIndex = 20;
            this.NumericUpDownWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDownWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownWidth.ValueChanged += new System.EventHandler(this.NumericUpDownWidth_ValueChanged);
            // 
            // CheckBoxFill
            // 
            this.CheckBoxFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxFill.AutoSize = true;
            this.CheckBoxFill.Checked = true;
            this.CheckBoxFill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxFill.Location = new System.Drawing.Point(800, 385);
            this.CheckBoxFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBoxFill.Name = "CheckBoxFill";
            this.CheckBoxFill.Size = new System.Drawing.Size(18, 17);
            this.CheckBoxFill.TabIndex = 21;
            this.CheckBoxFill.UseVisualStyleBackColor = true;
            this.CheckBoxFill.CheckedChanged += new System.EventHandler(this.CheckBoxFill_CheckedChanged);
            // 
            // ButtonAddPoint
            // 
            this.ButtonAddPoint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonAddPoint.Location = new System.Drawing.Point(900, 500);
            this.ButtonAddPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAddPoint.Name = "ButtonAddPoint";
            this.ButtonAddPoint.Size = new System.Drawing.Size(40, 40);
            this.ButtonAddPoint.TabIndex = 22;
            this.ButtonAddPoint.Text = "OK";
            this.ButtonAddPoint.UseVisualStyleBackColor = true;
            this.ButtonAddPoint.Click += new System.EventHandler(this.ButtonAddPoint_Click);
            // 
            // TextBoxAddPointX
            // 
            this.TextBoxAddPointX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxAddPointX.Location = new System.Drawing.Point(720, 510);
            this.TextBoxAddPointX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxAddPointX.MaxLength = 4;
            this.TextBoxAddPointX.Name = "TextBoxAddPointX";
            this.TextBoxAddPointX.Size = new System.Drawing.Size(60, 27);
            this.TextBoxAddPointX.TabIndex = 23;
            // 
            // TextBoxAddPointY
            // 
            this.TextBoxAddPointY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxAddPointY.Location = new System.Drawing.Point(810, 510);
            this.TextBoxAddPointY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxAddPointY.Name = "TextBoxAddPointY";
            this.TextBoxAddPointY.Size = new System.Drawing.Size(60, 27);
            this.TextBoxAddPointY.TabIndex = 24;
            // 
            // ButtonFinishPaint
            // 
            this.ButtonFinishPaint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonFinishPaint.Location = new System.Drawing.Point(730, 560);
            this.ButtonFinishPaint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonFinishPaint.Name = "ButtonFinishPaint";
            this.ButtonFinishPaint.Size = new System.Drawing.Size(200, 40);
            this.ButtonFinishPaint.TabIndex = 25;
            this.ButtonFinishPaint.Text = "Закончить рисование";
            this.ButtonFinishPaint.UseVisualStyleBackColor = true;
            this.ButtonFinishPaint.Click += new System.EventHandler(this.ButtonFinishPaint_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClear.Location = new System.Drawing.Point(760, 680);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(150, 40);
            this.ButtonClear.TabIndex = 26;
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonFinishPaint);
            this.Controls.Add(this.TextBoxAddPointY);
            this.Controls.Add(this.TextBoxAddPointX);
            this.Controls.Add(this.ButtonAddPoint);
            this.Controls.Add(this.CheckBoxFill);
            this.Controls.Add(this.NumericUpDownWidth);
            this.Controls.Add(this.TrackBarColorB);
            this.Controls.Add(this.TrackBarColorG);
            this.Controls.Add(this.TrackBarColorR);
            this.Controls.Add(this.ComboBoxFigures);
            this.Controls.Add(this.LabelAddPointY);
            this.Controls.Add(this.LabelAddPointX);
            this.Controls.Add(this.LabelAddPoint);
            this.Controls.Add(this.LabelFill);
            this.Controls.Add(this.LabelWidth);
            this.Controls.Add(this.LabelColorB);
            this.Controls.Add(this.LabelColorG);
            this.Controls.Add(this.LabelColorR);
            this.Controls.Add(this.LabelColor);
            this.Controls.Add(this.LabelFigure);
            this.Controls.Add(this.ButtonLoadFigure);
            this.Controls.Add(this.ButtonUndo);
            this.Controls.Add(this.ButtonRedo);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.PictureBoxPaint);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "FormMain";
            this.Text = "ShapeArt";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColorR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColorG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxPaint;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonUndo;
        private System.Windows.Forms.Button ButtonRedo;
        private System.Windows.Forms.Button ButtonLoadFigure;
        private System.Windows.Forms.Label LabelFigure;
        private System.Windows.Forms.Label LabelColor;
        private System.Windows.Forms.Label LabelColorR;
        private System.Windows.Forms.Label LabelColorG;
        private System.Windows.Forms.Label LabelColorB;
        private System.Windows.Forms.Label LabelWidth;
        private System.Windows.Forms.Label LabelFill;
        private System.Windows.Forms.Label LabelAddPoint;
        private System.Windows.Forms.Label LabelAddPointX;
        private System.Windows.Forms.Label LabelAddPointY;
        private System.Windows.Forms.ComboBox ComboBoxFigures;
        private System.Windows.Forms.TrackBar TrackBarColorR;
        private System.Windows.Forms.TrackBar TrackBarColorB;
        private System.Windows.Forms.TrackBar TrackBarColorG;
        private System.Windows.Forms.NumericUpDown NumericUpDownWidth;
        private System.Windows.Forms.CheckBox CheckBoxFill;
        private System.Windows.Forms.Button ButtonAddPoint;
        private System.Windows.Forms.TextBox TextBoxAddPointX;
        private System.Windows.Forms.TextBox TextBoxAddPointY;
        private System.Windows.Forms.Button ButtonFinishPaint;
        private System.Windows.Forms.Button ButtonClear;
    }
}

