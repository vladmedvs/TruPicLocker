using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace rgr
{
    public partial class Form1 : Form
    {

        private SolidBrush myBrush;
        private Graphics myGraphics;
        private bool IsPainting = false;
        bool test1 = false;
        bool test2 = false;
        bool test3 = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                
            {
                myBrush.Color = colorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myBrush = new SolidBrush(panel2.BackColor);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            IsPainting = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            IsPainting = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
            if (IsPainting == true)
            {
                label7.Text = Convert.ToString(e.X);
                label8.Text = Convert.ToString(e.Y);
                myGraphics = panel1.CreateGraphics();
                myGraphics.FillEllipse(myBrush, e.X, e.Y, trackBar1.Value, trackBar1.Value);

                if (myBrush.Color == Color.Yellow && trackBar1.Value == 10 && e.Y == 106 && e.X == 241)
                {


                    test1 = true;
                   // pictureBox1 = true;
                    //label3.Visible = true;
                    pictureBox1.Visible = true;

                }
                if (myBrush.Color == Color.Red && trackBar1.Value == 10 && e.X == 239 && e.Y == 97)
                {

                    test2 = true;
                   // label4.Visible = true;
                    pictureBox2.Visible = true;

                }
                if (myBrush.Color == Color.Green && trackBar1.Value == 10 && e.X == 241 && e.Y == 115)
                {

                    test3 = true; 

                    //label9.Visible = true;
                    pictureBox3.Visible = true;

                }
                if (test1 == true && test2 == true && test3 == true)
                {
                    IsPainting = false;
                    this.Visible = false;
                    this.Enabled = false;

                    //Timer timer = new Timer();


                    
                    Form2 fm = new Form2();

                    
                    fm.Show();


                }
                /*if (test1 == true && test2 == true)
                {
                    IsPainting = false;
                    Form2 fm = new Form2();
                    fm.Show();

                    Form1 f1 = new Form1();
                    f1.Close();
                }
                 */
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //if (test1 == true && test2 == true && test3 == true)
            //{
            //    IsPainting = false;
            //    this.Visible = false;
            //    this.Enabled = false;
                
            //    Form2 fm = new Form2();
            //    fm.Show();


            //}
            //else 
            //   MessageBox.Show("Error");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myBrush.Color = Color.Yellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myBrush.Color = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myBrush.Color = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myBrush.Color = Color.Black;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            myBrush.Color = Color.Blue;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            myBrush.Color = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
