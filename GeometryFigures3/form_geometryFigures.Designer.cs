// Zaripov Riyaz 220th group, 24.05.22 Figures-3

namespace GeometryFigures3
{
    partial class form_geometryFigures
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
            this.tb_aboutFigures = new System.Windows.Forms.TextBox();
            this.cb_chooseFigure = new System.Windows.Forms.ComboBox();
            this.btn_addFigure = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btn_saveFile = new System.Windows.Forms.Button();
            this.btn_loadFile = new System.Windows.Forms.Button();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_clearFigures = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_aboutFigures
            // 
            this.tb_aboutFigures.AcceptsReturn = true;
            this.tb_aboutFigures.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_aboutFigures.Location = new System.Drawing.Point(259, 65);
            this.tb_aboutFigures.Multiline = true;
            this.tb_aboutFigures.Name = "tb_aboutFigures";
            this.tb_aboutFigures.ReadOnly = true;
            this.tb_aboutFigures.Size = new System.Drawing.Size(334, 321);
            this.tb_aboutFigures.TabIndex = 0;
            // 
            // cb_chooseFigure
            // 
            this.cb_chooseFigure.FormattingEnabled = true;
            this.cb_chooseFigure.Items.AddRange(new object[] {
            "Segment",
            "Triangle",
            "Rectangle",
            "Circle"});
            this.cb_chooseFigure.Location = new System.Drawing.Point(12, 149);
            this.cb_chooseFigure.Name = "cb_chooseFigure";
            this.cb_chooseFigure.Size = new System.Drawing.Size(121, 23);
            this.cb_chooseFigure.TabIndex = 1;
            // 
            // btn_addFigure
            // 
            this.btn_addFigure.Location = new System.Drawing.Point(139, 149);
            this.btn_addFigure.Name = "btn_addFigure";
            this.btn_addFigure.Size = new System.Drawing.Size(75, 23);
            this.btn_addFigure.TabIndex = 2;
            this.btn_addFigure.Text = "Add";
            this.btn_addFigure.UseVisualStyleBackColor = true;
            this.btn_addFigure.Click += new System.EventHandler(this.btn_addFigure_Click);
            // 
            // btn_saveFile
            // 
            this.btn_saveFile.Location = new System.Drawing.Point(610, 149);
            this.btn_saveFile.Name = "btn_saveFile";
            this.btn_saveFile.Size = new System.Drawing.Size(75, 41);
            this.btn_saveFile.TabIndex = 3;
            this.btn_saveFile.Text = "Save figures";
            this.btn_saveFile.UseVisualStyleBackColor = true;
            this.btn_saveFile.Click += new System.EventHandler(this.btn_saveFile_Click);
            // 
            // btn_loadFile
            // 
            this.btn_loadFile.Location = new System.Drawing.Point(704, 149);
            this.btn_loadFile.Name = "btn_loadFile";
            this.btn_loadFile.Size = new System.Drawing.Size(75, 41);
            this.btn_loadFile.TabIndex = 4;
            this.btn_loadFile.Text = "Load figures";
            this.btn_loadFile.UseVisualStyleBackColor = true;
            this.btn_loadFile.Click += new System.EventHandler(this.btn_loadFile_Click);
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.FileName = "openFileDialog1";
            // 
            // btn_clearFigures
            // 
            this.btn_clearFigures.Location = new System.Drawing.Point(12, 206);
            this.btn_clearFigures.Name = "btn_clearFigures";
            this.btn_clearFigures.Size = new System.Drawing.Size(114, 23);
            this.btn_clearFigures.TabIndex = 5;
            this.btn_clearFigures.Text = "Clear figures";
            this.btn_clearFigures.UseVisualStyleBackColor = true;
            this.btn_clearFigures.Click += new System.EventHandler(this.btn_clearFigures_Click);
            // 
            // form_geometryFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clearFigures);
            this.Controls.Add(this.btn_loadFile);
            this.Controls.Add(this.btn_saveFile);
            this.Controls.Add(this.btn_addFigure);
            this.Controls.Add(this.cb_chooseFigure);
            this.Controls.Add(this.tb_aboutFigures);
            this.Name = "form_geometryFigures";
            this.Text = "Geometry figures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_chooseFigure;
        private System.Windows.Forms.Button btn_addFigure;
        public System.Windows.Forms.TextBox tb_aboutFigures;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btn_saveFile;
        private System.Windows.Forms.Button btn_loadFile;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.Button btn_clearFigures;
    }
}

