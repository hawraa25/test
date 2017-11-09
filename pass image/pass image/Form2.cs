using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pass_image
{
    public partial class Form2 : Form
    {
        Image image;

        public Form2()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);

                      
        }
        public Form2(Image image)
        {
            
            this.image = image;
        }
        void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.pictureBox1.Image != null)
                this.pictureBox1.Image.Dispose();
        }
        internal void AddPicture(Image img)
        {
            Image iOld = this.pictureBox1.Image;
            this.pictureBox1.Image = (Image)img.Clone();

            if (iOld != null)
                iOld.Dispose();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
