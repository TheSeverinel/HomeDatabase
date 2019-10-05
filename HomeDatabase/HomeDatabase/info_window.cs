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
    public partial class info_window : Form
    {
        
        public info_window()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Info_window_end_button_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
