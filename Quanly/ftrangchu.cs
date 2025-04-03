using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly
{
    public partial class ftrangchu : Form
    {
        public ftrangchu()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChillldForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //OpenChillldForm(new QLkho());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //OpenChillldForm(new QLsuachua());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //OpenChillldForm(new QTriHeThong());
        }

        private void logo_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChillldForm(new QLThongKe());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
