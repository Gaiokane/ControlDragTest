using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDragTest
{
    public partial class Form1 : Form
    {
        //UserControl1 uc1 = new UserControl1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.AllowDrop = true;
            panel2.AllowDrop = true;
            panel3.AllowDrop = true;
            panel4.AllowDrop = true;
        }

        private void btn1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                //button1.DoDragDrop(button1, DragDropEffects.Copy | DragDropEffects.Move);
                btn1.DoDragDrop(btn1, DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        private void btn2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                //button1.DoDragDrop(button1, DragDropEffects.Copy | DragDropEffects.Move);
                btn2.DoDragDrop(btn2, DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        private void btn3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                //button1.DoDragDrop(button1, DragDropEffects.Copy | DragDropEffects.Move);
                btn3.DoDragDrop(btn3, DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        private void btn4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                //button1.DoDragDrop(button1, DragDropEffects.Copy | DragDropEffects.Move);
                btn4.DoDragDrop(btn4, DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            //MessageBox.Show(e.Data.GetData(typeof(Button)).ToString() + "\n" + getBtnText(e.Data.GetData(typeof(Button)).ToString()));
            uc1.labtxt = getBtnText(e.Data.GetData(typeof(Button)).ToString());
            panel1.Controls.Clear();
            panel1.Controls.Add(uc1);
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            //MessageBox.Show(e.Data.GetData(typeof(Button)).ToString() + "\n" + getBtnText(e.Data.GetData(typeof(Button)).ToString()));
            uc1.labtxt = getBtnText(e.Data.GetData(typeof(Button)).ToString());
            panel2.Controls.Clear();
            panel2.Controls.Add(uc1);
        }

        private void panel3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel3_DragDrop(object sender, DragEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            //MessageBox.Show(e.Data.GetData(typeof(Button)).ToString() + "\n" + getBtnText(e.Data.GetData(typeof(Button)).ToString()));
            uc1.labtxt = getBtnText(e.Data.GetData(typeof(Button)).ToString());
            panel3.Controls.Clear();
            panel3.Controls.Add(uc1);
        }

        private void panel4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel4_DragDrop(object sender, DragEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            //MessageBox.Show(e.Data.GetData(typeof(Button)).ToString() + "\n" + getBtnText(e.Data.GetData(typeof(Button)).ToString()));
            uc1.labtxt = getBtnText(e.Data.GetData(typeof(Button)).ToString());
            panel4.Controls.Clear();
            panel4.Controls.Add(uc1);
        }

        private string getBtnText(string btntext)
        {
            string[] temp = btntext.Split(' ');
            return temp[2];
        }
    }
}