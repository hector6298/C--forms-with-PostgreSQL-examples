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
    public partial class MainEst : System.Windows.Forms.Form
    {
        public MainEst()
        {
            InitializeComponent();
        }

     
        private void BtnReg_Click(object sender, EventArgs e)
        {
            RegEst est = new RegEst();
            est.ShowDialog();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            DelEst de = new DelEst();
            de.ShowDialog();
        }

        private void GridEst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainEst_Load(object sender, EventArgs e)
        {
            string str;


            try
            {
                gridEst.AllowUserToAddRows = false;
                gridEst.ColumnCount = 8;
                gridEst.RowCount = 0;

                gridEst.Columns[0].HeaderText = "ID";
                gridEst.Columns[1].HeaderText = "Nombre";
                gridEst.Columns[2].HeaderText = "Apellido";
                gridEst.Columns[3].HeaderText = "Semestre";
                gridEst.Columns[4].HeaderText = "Carrera";
                gridEst.Columns[5].HeaderText = " Telefono";
                gridEst.Columns[6].HeaderText = "Residencia";
                gridEst.Columns[7].HeaderText = "Fecha registro";

                str = "SELECT * FROM estudiante";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = str;
                cmd.Connection = Main2.conn;
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cboIDSearch.Items.Add(dr[0]);
                    cboSearch.Items.Add(dr[1].ToString()+" "+dr[2].ToString());
                    gridEst.Rows.Add();
                    gridEst.Rows[gridEst.RowCount - 1].Cells[0].Value = dr[0];
                    gridEst.Rows[gridEst.RowCount - 1].Cells[1].Value = dr[1];
                    gridEst.Rows[gridEst.RowCount - 1].Cells[2].Value = dr[2];
                    gridEst.Rows[gridEst.RowCount - 1].Cells[3].Value = dr[3];
                    gridEst.Rows[gridEst.RowCount - 1].Cells[4].Value = dr[4];
                    gridEst.Rows[gridEst.RowCount - 1].Cells[5].Value = dr[5];
                    gridEst.Rows[gridEst.RowCount - 1].Cells[6].Value = dr[6];
                    gridEst.Rows[gridEst.RowCount - 1].Cells[7].Value = dr[7];
                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        private void CboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboIDSearch.SelectedIndex = cboSearch.SelectedIndex;
            
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            this.gridEst.EndEdit();
            gridEst.Update();
            gridEst.Refresh();
        }

        private void CboIDSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gridEst.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in gridEst.Rows)
                {
                    string str = cboIDSearch.SelectedItem.ToString();


                    if (row.Cells[0].Value.ToString().Equals(str))
                    {

                        gridEst.CurrentCell = row.Cells[0];
                        return;

                    }
                }
            }
        }
    }
}