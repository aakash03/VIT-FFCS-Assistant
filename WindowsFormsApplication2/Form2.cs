using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pictureBox1.LoadAsync ("http://aakashmalhotra.tk/update1.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            if (sfd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                string path = sfd.FileName;
                pictureBox1.Image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg );
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
