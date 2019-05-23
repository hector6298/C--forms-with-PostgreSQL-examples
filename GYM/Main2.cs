using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class Main2 : System.Windows.Forms.Form
    {
        public Main2()
        {
            InitializeComponent();
        }
        
        public static NpgsqlConnection conn = new NpgsqlConnection();

        private void BtnEst_Click(object sender, EventArgs e)
        {
            MainEst Est = new MainEst();
            Est.ShowDialog();
        }

        private void BtnEnt_Click(object sender, EventArgs e)
        {
            MainEnt Ent = new MainEnt();
            Ent.ShowDialog();
        }

        private void BntMens_Click(object sender, EventArgs e)
        {
            MainMens Mens = new MainMens();
            Mens.ShowDialog();
        }

        private void BtnImp_Click(object sender, EventArgs e)
        {
            MainImp Imp = new MainImp();
            Imp.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            conn = Main.conn;
        }

        private void BtnReg_D_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO registro_diario VALUES ( current_date,current_time,1.00, "
                    + tbReg_D.Text + ")";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se registro exitosamente");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BtnDia_Click(object sender, EventArgs e)
        {
            DispDiario dd = new DispDiario();
            dd.ShowDialog();
        }
    }
}
