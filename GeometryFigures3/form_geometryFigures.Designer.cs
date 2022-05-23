
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
            this.components = new System.ComponentModel.Container();
            this.tb_aboutFigures = new System.Windows.Forms.TextBox();
            this.cb_chooseFigure = new System.Windows.Forms.ComboBox();
            this.btn_addFigure = new System.Windows.Forms.Button();
            this.erprov_gf = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erprov_gf)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_aboutFigures
            // 
            this.tb_aboutFigures.AcceptsReturn = true;
            this.tb_aboutFigures.Location = new System.Drawing.Point(335, 71);
            this.tb_aboutFigures.Multiline = true;
            this.tb_aboutFigures.Name = "tb_aboutFigures";
            this.tb_aboutFigures.Size = new System.Drawing.Size(334, 298);
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
            this.btn_addFigure.Location = new System.Drawing.Point(207, 149);
            this.btn_addFigure.Name = "btn_addFigure";
            this.btn_addFigure.Size = new System.Drawing.Size(75, 23);
            this.btn_addFigure.TabIndex = 2;
            this.btn_addFigure.Text = "Add";
            this.btn_addFigure.UseVisualStyleBackColor = true;
            this.btn_addFigure.Click += new System.EventHandler(this.btn_addFigure_Click);
            // 
            // erprov_gf
            // 
            this.erprov_gf.ContainerControl = this;
            // 
            // form_geometryFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addFigure);
            this.Controls.Add(this.cb_chooseFigure);
            this.Controls.Add(this.tb_aboutFigures);
            this.Name = "form_geometryFigures";
            this.Text = "Geometry figures";
            ((System.ComponentModel.ISupportInitialize)(this.erprov_gf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_chooseFigure;
        private System.Windows.Forms.Button btn_addFigure;
        public System.Windows.Forms.TextBox tb_aboutFigures;
        private System.Windows.Forms.ErrorProvider erprov_gf;
    }
}

