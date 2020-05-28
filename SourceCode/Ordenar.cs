using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class Ordenar : UserControl
    {
        private int iduser;
        public Ordenar(string username)
        {
            var ids = ConnectionDB.ExecuteQuery($"select iduser from appuser where username = '{username}'");
            var idsl = new List<string>();
            foreach (DataRow dr in ids.Rows) 
            { idsl.Add(dr[0].ToString()); }
            iduser = Convert.ToInt32(idsl[0]);
            InitializeComponent();
        }

        private void Ordenar_Load(object sender, EventArgs e)
        {
            actualizarComponentes();
        }

        private void buttonOrd_Click(object sender, EventArgs e)
        {
            
            var add = ConnectionDB.ExecuteQuery($"select idaddress from address where address = '{comboBoxD.SelectedItem.ToString()}'");
            var addCombo = new List<string>();
            foreach (DataRow dr in add.Rows) 
            { addCombo.Add(dr[0].ToString()); }
            int idadd = Convert.ToInt32(addCombo[0]);
            var pr = ConnectionDB.ExecuteQuery($"select idproduct from product where name = '{comboBoxP.SelectedItem.ToString()}'");
            var prCombo = new List<string>();
            foreach (DataRow dr in pr.Rows) 
            { prCombo.Add(dr[0].ToString()); }
            int idpr = Convert.ToInt32(prCombo[0]);
            ConnectionDB.ExecuteNonQuery($"insert into apporder(createdate, idproduct, idaddress) values('{DateTime.Now.ToString()}', {idpr}, {idadd})");
            MessageBox.Show($"¡Orden realizada!", "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            actualizarComponentes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionDB.ExecuteNonQuery($"delete from apporder where idorder ='{ordenes.SelectedItem.ToString()}'");
                MessageBox.Show($"¡Orden eliminada!", "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                actualizarComponentes();
            }
            catch (Exception exception)
            {
                MessageBox.Show("¡Ha ocurrido un error!", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizarComponentes()
        {
            //actualizando las combo box de agregar
            comboBoxP.DataSource = null;
            comboBoxD.DataSource = null;
            var add = ConnectionDB.ExecuteQuery($"select address from address where iduser = {iduser}");
            var addCombo = new List<string>();
            foreach (DataRow dr in add.Rows) 
            { addCombo.Add(dr[0].ToString()); }
            comboBoxD.DataSource = addCombo;
            var pr = ConnectionDB.ExecuteQuery($"select name from product");
            var prCombo = new List<string>();
            foreach (DataRow dr in pr.Rows) 
            { prCombo.Add(dr[0].ToString()); }
            comboBoxP.DataSource = prCombo;
            
            //actualizando combo y datagrid historial
            ordenes.DataSource = null;
            var datagriOrders = ConnectionDB.ExecuteQuery("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                                              "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                                              "WHERE ao.idProduct = pr.idProduct "+
                                              "AND ao.idAddress = ad.idAddress " +
                                              "AND ad.idUser = au.idUser "+
                                              $"AND au.idUser = {iduser};");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = datagriOrders;
            var order = ConnectionDB.ExecuteQuery("SELECT ao.idOrder " +
                                                  "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                                                  "WHERE ao.idProduct = pr.idProduct "+
                                                  "AND ao.idAddress = ad.idAddress " +
                                                  "AND ad.idUser = au.idUser "+
                                                  $"AND au.idUser = {iduser};");
            var orderCombo = new List<string>();
            foreach (DataRow dr in order.Rows) 
            { orderCombo.Add(dr[0].ToString()); }
            ordenes.DataSource = orderCombo;
        }
    }
}