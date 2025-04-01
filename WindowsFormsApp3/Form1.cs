using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private List<Figura> figuras = new List<Figura>();
        private Color colorSeleccionado = Color.Black;

        public Form1()
        {
            InitializeComponent();
        }
        //Selección de color
        private void pictureBoxColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorSeleccionado = colorDialog.Color;
                    pictureBoxColor.BackColor = colorSeleccionado;
                }
            }
        }


        private void btnDibujar_Click(object sender, EventArgs e)
        {
            //Creción de figura

            try
            {
                int x = int.Parse(txtX.Text);
                int y = int.Parse(txtY.Text);

                Figura rectangulo = FiguraFactory.CrearFigura("Rectangulo", colorSeleccionado, x, y);
                figuras.Add(rectangulo);

                txtContador.Text = Rectangulo.ObtenerContador().ToString();

                this.Invalidate();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos para X e Y.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            /// Dibujo de figura
            base.OnPaint(e);

            foreach (var figura in figuras)
            {
                figura.Dibujar(e.Graphics);
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}