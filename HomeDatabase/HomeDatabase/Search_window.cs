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
        
        string sql_all = "SELECT eq_id AS 'L.P.', eq_name AS Nazwa, category_name AS Kategoria, location_name AS Lokacja, room_name AS Pomieszczenie FROM category RIGHT JOIN equipment ON category.category_id = equipment.eq_category LEFT JOIN location ON equipment.eq_location = location.location_id LEFT JOIN rooms ON location.location_room = rooms.room_id ";



        string name_entered;


        
        public Search_window()
        {
            InitializeComponent();
            Search_DB(sql_all);
            Fill_combo("[dbo].[location]", location_combo);
            Fill_combo("[dbo].[category]", category_combo);
        }


        private void Test_Connection (string connection_string)
        {
            using (SqlConnection sql_con = new SqlConnection(connection_string))
            {
                try
                {
                    sql_con.Open();
                    MessageBox.Show("Otwarto!");
                    sql_con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie udało sie otworzyć.");
                }
            }
        }

        private void Search_DB(string sql_command)
        {
            using (SqlConnection connection = new SqlConnection(con_str))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter data_adapter = new SqlDataAdapter(sql_command, connection);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(data_adapter);
                    DataSet data_set = new DataSet();
                    data_adapter.Fill(data_set);
                    dataGridView1.DataSource = data_set.Tables[0];
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie udało się połączyć z bazą");
                }
            } 
        }

        public void Fill_combo(string table, ComboBox comboBox)
        {
            string sql_command = "SELECT * FROM " + table;
            SqlConnection connection = new SqlConnection(con_str);
            SqlCommand command = new SqlCommand(sql_command, connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string column_values = reader.GetString(1);
                    comboBox.Items.Add(column_values);
                }
                connection.Close();
            }
            catch (Exception ex)
            {

            }

        }


        private string Pre_searching()
        {
            string command = sql_all;
            string help = null;
            if (name_radio.Checked)
            {
                help = "WHERE eq_name LIKE '"+name_box.Text+"%'";
            }
            else if (category_radio.Checked)
            {
                help = "WHERE category_name = '"+category_combo.Text+"'";
            }
            else if (location_radio.Checked) 
            {
                help = "WHERE location_name = '"+location_combo.Text+"'";
            }
            else
            {

            }
            command += help;
            
            return command;
        }

        private void Search_window_Load(object sender, EventArgs e)
        {
           
        }


        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //name_entered = name_entered + name_box.Text.ToString();
            //Search_by_name();
        }


        private void Test_button_Click(object sender, EventArgs e)
        {
            Test_Connection(con_str);
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            Search_DB(Pre_searching());
        }

        private void DataGridView1_CellContentClick(object sender, EventArgs e)
        {
            
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            name_box.Enabled = !(name_box.Enabled);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            category_combo.Enabled = !(category_combo.Enabled);
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            location_combo.Enabled = !(location_combo.Enabled);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
