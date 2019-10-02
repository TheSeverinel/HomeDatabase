using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeDatabase
{
    public partial class Base_window : Form
    {
        int i = 0;
        string message = "W razie dalszych pytań skontaktuj się z autorem mailowo: patrycja.juszczyk98@gmail.com";
        string caption = "Wszystko okej?";
        MessageBoxButtons buttons = MessageBoxButtons.OK;
        DialogResult result;
        public Base_window()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_MouseClick(object sender, MouseEventArgs e)
        {
            info_window f = new info_window();

            f.Show();
            i++;


            if ((i % 3) == 0)
            {
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Search_window sw = new Search_window();
            sw.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
