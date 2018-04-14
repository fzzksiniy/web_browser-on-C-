using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Favourites : Form
    {
        public Favourites()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("H:\\WEB_BROWSER\fav.txt", "Название " + textBox2.Text + "\n" + textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
                MessageBox.Show(FBD.SelectedPath);
        }
    }
}
