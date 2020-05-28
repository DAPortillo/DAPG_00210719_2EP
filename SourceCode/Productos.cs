using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class Productos : UserControl
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            actucombobox();
        }

        private void buttonAddP_Click(object sender, EventArgs e)
        {
            try
            {
                int id = idbusi(comboBoxnegocios.SelectedItem.ToString());
                ConnectionDB.ExecuteNonQuery($"insert into product(idBusiness, name) values({id}, '{textBoxNameP.Text}')");
                MessageBox.Show("¡Producto agregado exitosamente!", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                actucombobox();
            }
            catch (Exception exception)
            {
                MessageBox.Show("¡Ha ocurrido un error!", 
                                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeletP_Click(object sender, EventArgs e)
        {
            try
            {
                int id = idbusi(comboBoxnegocios.SelectedItem.ToString());
                var products = ConnectionDB.ExecuteQuery($"select idproduct from product where idbusiness = {id} and name = '{comboboxP.SelectedItem.ToString()}'");
                var PCombo = new List<string>();
                foreach (DataRow dr in products.Rows) 
                { PCombo.Add(dr[0].ToString()); }
                ConnectionDB.ExecuteNonQuery($"delete from product where idproduct = {PCombo[0]}");
                MessageBox.Show("¡Producto eliminado exitosamente!", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                actucombobox();
            }
            catch (Exception exception)
            {
                MessageBox.Show("¡Ha ocurrido un error!", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void actucombobox()
        {
            // Actualizar ComboBoxProductos
            comboboxP.DataSource = null;
            var products = ConnectionDB.ExecuteQuery("select name from product");
            var PCombo = new List<string>();
            foreach (DataRow dr in products.Rows) 
            { PCombo.Add(dr[0].ToString()); }
            comboboxP.DataSource = PCombo;
            
            comboBoxnegocios.DataSource = null;
            var busi = ConnectionDB.ExecuteQuery("select name from business");
            var busiCombo = new List<string>();
            foreach (DataRow dr in busi.Rows) 
            { busiCombo.Add(dr[0].ToString()); }
            comboBoxnegocios.DataSource = busiCombo;
        }

        private int idbusi(string businessName)
        {
            var busiid = ConnectionDB.ExecuteQuery($"select idbusiness from business where name = '{businessName}'");
            var busiidlist = new List<string>();
            foreach (DataRow dr in busiid.Rows) 
            { busiidlist.Add(dr[0].ToString()); }
            int id = Convert.ToInt32(busiidlist[0]);
            return id;
        }
    }
}