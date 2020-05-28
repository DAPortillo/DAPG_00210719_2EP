using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class Direcciones : UserControl
    {
        private int iduser;
        public Direcciones(string username)
        {
            var ids = ConnectionDB.ExecuteQuery($"select iduser from appuser where username = '{username}'");
            var idsl = new List<string>();
            foreach (DataRow dr in ids.Rows) 
            { idsl.Add(dr[0].ToString()); }
            iduser = Convert.ToInt32(idsl[0]);
            InitializeComponent();
        }

        private void Direcciones_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
                ConnectionDB.ExecuteNonQuery($"insert into address(iduser, address) values({iduser}, '{textBox1.Text}')");
                MessageBox.Show("¡Se ha agregado correctamente!", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                actualizar();
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionDB.ExecuteNonQuery($"delete from address where iduser = {iduser} and address = '{comboBoxD.SelectedItem.ToString()}'");
                MessageBox.Show("¡Se ha eliminado correctamente!", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                actualizar();
            }
            catch (Exception exception)
            {
                MessageBox.Show("¡Ha ocurrido un error!", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void actualizar()
        {
            // Actualizar ComboBox
            comboBoxD.DataSource = null;
            var usuarios = ConnectionDB.ExecuteQuery($"select address from address where iduser = {iduser}");
            var usuariosCombo = new List<string>();
            foreach (DataRow dr in usuarios.Rows) 
            { usuariosCombo.Add(dr[0].ToString()); }
            comboBoxD.DataSource = usuariosCombo;
            
        }
    }
}