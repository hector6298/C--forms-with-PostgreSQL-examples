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
    public partial class MainImp : System.Windows.Forms.Form
    {
        public MainImp()
        {
            InitializeComponent();
        }
        NpgsqlCommand cmd = new NpgsqlCommand();
        string str;
        private void MainImp_Load(object sender, EventArgs e)
        {
            


            try
            {
                GridImp.AllowUserToAddRows = false;
                GridImp.ColumnCount = 7;
                GridImp.RowCount = 0;

                GridImp.Columns[0].HeaderText = "Codigo";
                GridImp.Columns[1].HeaderText = "Nombre ";
                GridImp.Columns[2].HeaderText = "Marca";
                GridImp.Columns[3].HeaderText = "Estado";
                GridImp.Columns[4].HeaderText = "Tipo";
                GridImp.Columns[5].HeaderText = "id_gimnasio";
                GridImp.Columns[6].HeaderText = "";



                NpgsqlCommand cmd = new NpgsqlCommand();
                str = "SELECT * FROM equipamento";
                
                cmd.CommandText = str;
                cmd.Connection = Main2.conn;
                NpgsqlDataReader dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    


                    GridImp.Rows.Add();
                    GridImp.Rows[GridImp.RowCount - 1].Cells[0].Value = dr[0].ToString().Substring(dr[0].ToString().Length-2);
                    GridImp.Rows[GridImp.RowCount - 1].Cells[1].Value = dr[1];
                    GridImp.Rows[GridImp.RowCount - 1].Cells[2].Value = dr[2];
                    GridImp.Rows[GridImp.RowCount - 1].Cells[3].Value = dr[3];
                    GridImp.Rows[GridImp.RowCount - 1].Cells[4].Value = dr[4];
                    GridImp.Rows[GridImp.RowCount - 1].Cells[5].Value = dr[5];
                    GridImp.Rows[GridImp.RowCount - 1].Cells[6].Value = dr[6];



                }
                dr.Close();

                NpgsqlCommand cmd2 = new NpgsqlCommand();
                str = "SELECT distinct nombre FROM equipamento";
                cmd2.Connection = Main2.conn;
                cmd2.CommandText = str;
                NpgsqlDataReader dr2 = cmd2.ExecuteReader();

                while (dr2.Read())
                {
                    cboSearch.Items.Add(dr2[0]);
                }
                dr2.Close();
            }
            
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            RegImp ri = new RegImp();
            ri.ShowDialog();
        }

        private void CboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (GridImp.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in GridImp.Rows)
                {
                    string str = cboCodSearch.SelectedItem.ToString();


                    if (row.Cells[0].Value.ToString().Equals(str))
                    {

                        GridImp.CurrentCell = row.Cells[0];
                        return;

                    }
                }
            }
        }

        private void CboSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                str = "Select codigo FROM equipamento WHERE nombre = '" + cboSearch.Text + "'";
                cmd.Connection = Main2.conn;
                cmd.CommandText = str;
                NpgsqlDataReader dr = cmd.ExecuteReader();
                cboCodSearch.Items.Clear();
                while (dr.Read())
                {
                    cboCodSearch.Items.Add(dr[0]);
                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void CboCodSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
