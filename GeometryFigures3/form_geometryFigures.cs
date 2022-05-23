using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometryFigures3
{
    public partial class form_geometryFigures : Form
    {
        public form_geometryFigures()
        {
            InitializeComponent();
        }

        private void btn_addFigure_Click(object sender, EventArgs e)
        {
            form_addingFigure form = new form_addingFigure();

            switch (cb_chooseFigure.Text)
            {
                case "Triangle":
                    form.panel_triangle.Visible = true;
                    break;

                case "Rectangle":
                    form.panel_rectangle.Visible = true;
                    break;

                case "Segment":
                    form.panel_seg.Visible = true;
                    break;

                case "Circle":
                    form.panel_circle.Visible = true;
                    break;

            }

            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                tb_aboutFigures.AppendText(Figures.LastFigure().Draw()
                                          + Environment.NewLine);
            }
        }
    }
}
