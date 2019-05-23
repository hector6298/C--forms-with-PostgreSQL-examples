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
    public partial class DelEst : System.Windows.Forms.Form
    {
        public DelEst()
        {
            InitializeComponent();
        }
        NpgsqlCommand cmd = new NpgsqlCommand();
        private void BtnDel_Click(object sender, EventArgs e)
        {
            String str;
            if (tbID.Text.Equals(""))
            {
                str = "DELETE FROM estudiante WHERE nombre || ' ' || apel = "
               + tbNom.Text;
            }
            else
            {
                str = "DELETE FROM estudiante WHERE ID = "
               + tbID.Text;
            }
            try
            {
                cmd.CommandText = str;
                cmd.Connection = Main2.conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
