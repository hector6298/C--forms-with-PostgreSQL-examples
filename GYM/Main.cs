using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace GYM
{
    public partial class Main : System.Windows.Forms.Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public static NpgsqlConnection conn = new NpgsqlConnection();
        private void BtnIng_Click(object sender, EventArgs e)
        {

            try
            {
                string str;
                str = "Server=127.0.0.1;";
                str = str + "Port=5432;";
                str = str + "Database=GYM_management;";
                str = str + "User ID="+tbUs.Text+";";
                str = str + "Password="+tbCon.Text+";";
                conn.ConnectionString = str;
                conn.Open();
                MessageBox.Show("Se conecto exitosamente");

                Main2 m = new Main2();
                m.ShowDialog();
                this.Close();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
