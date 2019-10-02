using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomeDatabase
{
    public partial class Search_window : Form
    {
        
        string con_str = "Data Source=T430\\HOMEDB;Initial Catalog=electro;Integrated Security=True";
        string name_entered;
        string sql_all = "SELECT * FROM equipment;";

        public Search_window()
        {
            InitializeComponent();
            Show_DB();
        }


        private void Test_Connection (string connection_string)
        {
            using (SqlConnection sql_con = new SqlConnection(connection_string))
            {
                try
                {
                    sql_con.Open();
                    MessageBox.Show("Opened!");
                    sql_con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not open.");
                }
            }
        }

        private void Show_DB()
        {
                using (SqlConnection connection = new SqlConnection(con_str))
                {
                    try 
                    {
                    //connection.Open();
                    SqlDataAdapter data_adapter = new SqlDataAdapter(sql_all, connection);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(data_adapter);
                    DataSet data_set = new DataSet();
                    data_adapter.Fill(data_set);
                    dataGridView1.DataSource = data_set.Tables[0];
                        


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nie udało się połączyć z bazą");
                    }

            }
            
        }

        private void Check_checks()
        {

        }

        private void Search_by_name()
        {
            

        }

        private void Search_by_two()
        {

        }
        private void Search_by_three()
        {

        }

        private void Search_window_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            name_box.ReadOnly = !(name_box.ReadOnly);
        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            name_entered = name_box.Text.ToString();
        }

        private void Category_chekbox_CheckedChanged(object sender, EventArgs e)
        {
            category_combo.Enabled = !(category_combo.Enabled);
        }

        private void Location_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            location_combo.Enabled = !(location_combo.Enabled);
        }

        private void DataGridView1_CellContentClick(object sender, EventArgs e)
        {

        }

        private void Test_button_Click(object sender, EventArgs e)
        {
            Test_Connection(con_str);
        }
    }
}
