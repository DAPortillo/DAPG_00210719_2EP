using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class Negocios : UserControl
    {
        public Negocios()
        {
            InitializeComponent();
        }

        private void Negocios_Load(object sender, EventArgs e)
        {
            actucombobox();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionDB.ExecuteNonQuery($"insert into business(name, description) values('{textBoxName.Text}', '{textBoxDesc.Text}')");
                MessageBox.Show("¡Negocio añadido correctamente!", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                actucombobox();
            }
            catch (Exception exception)
            {
                MessageBox.Show("¡Ha ocurrido un error!", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery($"select idbusiness from business where name = '{comboBoxnegocios.SelectedItem.ToString()}'");
                var dtCombo = new List<string>();
                foreach (DataRow dr in dt.Rows) 
                { dtCombo.Add(dr[0].ToString()); }
                int id = Convert.ToInt32(dtCombo[0]);
                ConnectionDB.ExecuteNonQuery($"delete from product where idbusiness = {id}");
                ConnectionDB.ExecuteNonQuery($"delete from business where idbusiness = {id}");
                MessageBox.Show("¡Negocio eliminado correctamente!", 
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
            // Actualizar ComboBox
            comboBoxnegocios.DataSource = null;
            var usuarios = ConnectionDB.ExecuteQuery("select name from business");
            var usuariosCombo = new List<string>();
            foreach (DataRow dr in usuarios.Rows) 
            { usuariosCombo.Add(dr[0].ToString()); }
            comboBoxnegocios.DataSource = usuariosCombo;
        }
    }
}