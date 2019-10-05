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
    public partial class add_window : Form
    {
        string con_str = "Data Source=T430\\HOMEDB;Initial Catalog=electro;Integrated Security=True";

        public add_window()
        {
            InitializeComponent();
            Search_window f = new Search_window();
            f.Fill_combo("[dbo].[category]", category_combo);
            f.Fill_combo("[dbo].[location]", location_combo);
        }

        private string Create_Insert_Command()
        {
            string command = "INSERT INTO [dbo].[equipment] (eq_name, eq_category, eq_location) VALUES (";
            string name = name_box.Text;
            string category = category_combo.Text;
            int category_nr = Replace_cat_string(category);
            string location = location_combo.Text;
            int location_nr = Replace_loc_string(location);
            command += "'" + name + "', " + category_nr + ", " + location_nr + ")";
            return command;
        }

        private int Replace_cat_string(string category)
        {
            int cat_id;
            switch (category)
            {
                case "aparat":
                    cat_id = 8;
                    break;
                case "audio":
                    cat_id = 7;
                    break;
                case "ekran":
                    cat_id = 1;
                    break;
                case "inne":
                    cat_id = 9;
                    break;
                case "kabel":
                    cat_id = 6;
                    break;
                case "komponent":
                    cat_id = 4;
                    break;
                case "komputer":
                    cat_id = 3;
                    break;
                case "konsola":
                    cat_id = 2;
                    break;
                case "urządzenie mobilne":
                    cat_id = 5;
                    break;
                default:
                    cat_id = 9;
                    break;
            }
            return cat_id;
        }

        private int Replace_loc_string(string location)
        {
            int loc_id = 0;
            switch (location)
            {
                case "Prawa szafa":
                    loc_id = 1;
                    break;
                case "Lewa szafa":
                    loc_id = 2;
                    break;
                case "Regał":
                    loc_id = 3;
                    break;
                case "Czarne biurko":
                    loc_id = 4;
                    break;
                case "Brązowe biurko":
                    loc_id = 5;
                    break;
                case "Biblioteczka":
                    loc_id = 6;
                    break;
                case "Pawlacz":
                    loc_id = 7;
                    break;
                case "Góra":
                    loc_id = 8;
                    break;
                case "Dół":
                    loc_id = 9;
                    break;
                case "Szafka":
                    loc_id = 10;
                    break;
                default:
                    break;
            }
            return loc_id;
        }

        private void Add_window_Load(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(con_str);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Create_Insert_Command(), connection);
                connection.Close();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
