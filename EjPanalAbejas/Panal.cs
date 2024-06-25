using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjPanalAbejas
{
    public partial class Panal : Form
    {
        private int sideLength;
        private float scaleFactor = 10.0f;

        public Panal()
        {
            InitializeComponent();
            picCanvas.Resize += PicCanvas_Resize;
            btnGraficar.Click += BtnGraficar_Click;
            btnLimpiar.Click += BtnLimpiar_Click;
            btnSalir.Click += BtnSalir_Click;
        }

        private void Panal_Load(object sender, EventArgs e) { }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLado.Text, out sideLength) && sideLength > 0)
            {
                if (float.TryParse(txtLado.Text, out scaleFactor) && scaleFactor > 0)
                {
                    DrawHexagons();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido para el factor de escalamiento.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el lado del hexágono.");
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            picCanvas.Image = null;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicCanvas_Resize(object sender, EventArgs e)
        {
            if (sideLength > 0)
            {
                DrawHexagons();
            }
        }

        private void DrawHexagons()
        {
            float scaledSideLength = sideLength * scaleFactor;
            float a = scaledSideLength * (float)Math.Sqrt(3) / 2;

            Bitmap bitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.FromArgb(255, 255, 153, 0));

                int numHexagonsX = (int)Math.Ceiling(picCanvas.Width / (1.5f * scaledSideLength));
                int numHexagonsY = (int)Math.Ceiling(picCanvas.Height / (a * 2));

                for (int i = 0; i < numHexagonsY + 1; i++)
                {
                    for (int j = 0; j < numHexagonsX + 1; j++)
                    {
                        float offsetX = j * 1.5f * scaledSideLength;
                        float offsetY = i * a * 2;

                        // Si la columna es impar, desplazar el hexágono hacia abajo
                        if (j % 2 != 0)
                        {
                            offsetY += a;
                        }

                        // Dibujar el hexágono
                        Hexagon hex = new Hexagon(scaledSideLength);
                        hex.Draw(g, offsetX, offsetY);
                    }
                }
            }

            picCanvas.Image = bitmap;
        }

    }

}
              