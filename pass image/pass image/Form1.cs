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
    public partial class Form1 : Form
    {
        
        Form2 f2 = null;
        public Form1()
        {
            InitializeComponent();
             this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            //this.image = image;
            //image= Image.FromFile(@"..\..\pic\1.bmp");
           // pictureBox1.Image = image;
           // Form2 f2 = new Form2(image);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         /*Form2 f2 = new Form2(image);
            f2.Show();*/
            if (f2 == null || f2.IsDisposed)
                f2= new Form2();

            f2.Show();

            f2.AddPicture(this.pictureBox1.Image);
            

        }
        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.pictureBox1.Image != null)
                this.pictureBox1.Image.Dispose();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Image image;
            image = Image.FromFile(@"..\..\pic\1.jpg");
            
            this.pictureBox1.Image = image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
