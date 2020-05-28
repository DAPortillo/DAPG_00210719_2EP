using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class AfterLogin : Form
    {
        private string username;
        private UserControl current;
        public AfterLogin(string pUsername)
        {
            username =pUsername;
            InitializeComponent();
        }
        
        private void AfterLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Hugo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    e.Cancel = false;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ha sucedido un error...", "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AfterLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void AfterLogin_Load(object sender, EventArgs e)
        {
            var adminYN = ConnectionDB.ExecuteQuery($"select usertype from appuser where username ='{username}'");
            var adminYNFinal = new List<string>();
            foreach (DataRow dr in adminYN.Rows)
            { adminYNFinal.Add(dr[0].ToString()); }

            if (adminYNFinal[0] == "False"){
                buttonNegocios.Visible = false;
                buttonProductos.Visible = false;
                buttonUsuarios.Visible = false;
                buttonHistorialOrdenes.Visible = false;
            }
        }

        private void buttonAddress_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Direcciones(username);
            tableLayoutPanel1.Controls.Add(current, 1, 1);
            tableLayoutPanel1.SetColumnSpan(current, 4);
            tableLayoutPanel1.SetRowSpan(current, 3);
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Ordenar(username);
            tableLayoutPanel1.Controls.Add(current, 1, 1);
            tableLayoutPanel1.SetColumnSpan(current, 4);
            tableLayoutPanel1.SetRowSpan(current, 3);
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Usuarios();
            tableLayoutPanel1.Controls.Add(current, 1, 1);
            tableLayoutPanel1.SetColumnSpan(current, 4);
            tableLayoutPanel1.SetRowSpan(current, 3);
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Productos();
            tableLayoutPanel1.Controls.Add(current, 1, 1);
            tableLayoutPanel1.SetColumnSpan(current, 4);
            tableLayoutPanel1.SetRowSpan(current, 3);
        }

        private void buttonNegocios_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Negocios();
            tableLayoutPanel1.Controls.Add(current, 1, 1);
            tableLayoutPanel1.SetColumnSpan(current, 4);
            tableLayoutPanel1.SetRowSpan(current, 3);
        }

        private void buttonHistorialOrdenes_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new OrderHistory();
            tableLayoutPanel1.Controls.Add(current, 1, 1);
            tableLayoutPanel1.SetColumnSpan(current, 4);
            tableLayoutPanel1.SetRowSpan(current, 3);
        }
        
    }
}