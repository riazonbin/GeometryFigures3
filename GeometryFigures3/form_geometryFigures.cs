// Sharipov Kamil 220th group, 24.05.22 Figures-3

using System;
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

                default:
                    MessageBox.Show("Выберите фигуру из предложенных в списке!",
                                    "Предупреждение", MessageBoxButtons.OK, 
                                    MessageBoxIcon.Warning);
                    return;

            }

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                tb_aboutFigures.AppendText(Figures.LastFigure().Draw()
                                          + Environment.NewLine);
            }
        }

        private void btn_saveFile_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Figures.Save(saveFileDialog.FileName);
            }
        }

        private void btn_loadFile_Click(object sender, EventArgs e)
        {
            if(loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                Figures.Load(loadFileDialog.FileName);
                tb_aboutFigures.Text = Figures.Draw();
            }
        }

        private void btn_clearFigures_Click(object sender, EventArgs e)
        {
            Figures.Clear();
            tb_aboutFigures.Text = string.Empty;
        }
    }
}
