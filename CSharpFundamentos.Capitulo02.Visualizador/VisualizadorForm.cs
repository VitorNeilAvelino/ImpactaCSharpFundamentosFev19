using System;
using System.Windows.Forms;

namespace CSharpFundamentos.Capitulo02.Visualizador
{
    public partial class VisualizadorForm : Form
    {
        public VisualizadorForm()
        {
            InitializeComponent();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            imagemOpenFileDialog.Filter = "Arquivos de imagens |*.jpg;*.bmp;*.png|Arquivos jpg|*.jpg";

            imagemOpenFileDialog.ShowDialog();
            imagemPictureBox.ImageLocation = imagemOpenFileDialog.FileName;
        }
    }
}
