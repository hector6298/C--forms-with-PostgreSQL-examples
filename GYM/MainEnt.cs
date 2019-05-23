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
    public partial class MainEnt : System.Windows.Forms.Form
    {
        public MainEnt()
        {
            InitializeComponent();
        }

     

    

        private void BtnDelEnt_Click(object sender, EventArgs e)
        {
            DelEnt de = new DelEnt();
            de.ShowDialog();
        }

        private void btnRegEnt_Click(object sender, EventArgs e)
        {
            RegEnt re = new RegEnt();
            re.ShowDialog();
        }

        private void BtnRegEst_Ent_Click(object sender, EventArgs e)
        {
            RegEstEnt regest = new RegEstEnt();
            regest.ShowDialog();
        }

        private void MainEnt_Load(object sender, EventArgs e)
        {
            string str;


            try
            {
                GridEnt.AllowUserToAddRows = false;
                GridEnt.ColumnCount = 5;
                GridEnt.RowCount = 0;

                GridEnt.Columns[0].HeaderText = "ID_entrenador";
                GridEnt.Columns[1].HeaderText = "Telefono";
                GridEnt.Columns[2].HeaderText = "Nombre";
                GridEnt.Columns[3].HeaderText = "Apellido";
                GridEnt.Columns[4].HeaderText = "Fecha Inicio";
               

                str = "SELECT * FROM entrenador";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = str;
                cmd.Connection = Main2.conn;
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cboEntSearch.Items.Add(dr[2].ToString()+" "+dr[3].ToString());
                    cboIDSearch.Items.Add(dr[0]);
                    GridEnt.Rows.Add();
                    GridEnt.Rows[GridEnt.RowCount - 1].Cells[0].Value = dr[0];
                    GridEnt.Rows[GridEnt.RowCount - 1].Cells[1].Value = dr[1];
                    GridEnt.Rows[GridEnt.RowCount - 1].Cells[2].Value = dr[2];
                    GridEnt.Rows[GridEnt.RowCount - 1].Cells[3].Value = dr[3];
                    GridEnt.Rows[GridEnt.RowCount - 1].Cells[4].Value = dr[4];
                    
                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void CboEntSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboIDSearch.SelectedIndex = cboEntSearch.SelectedIndex;
            
        }

        private void CboIDSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridEnt.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in GridEnt.Rows)
                {
                    string str = cboIDSearch.SelectedItem.ToString();


                    if (row.Cells[0].Value.ToString().Equals(str))
                    {

                        GridEnt.CurrentCell = row.Cells[0];
                        return;

                    }
                }
            }
        }
    }
}
