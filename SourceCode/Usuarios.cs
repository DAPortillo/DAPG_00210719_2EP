using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class Usuarios : UserControl
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            var usuarios = ConnectionDB.ExecuteQuery("select username from appuser");
            var usuarioslist = new List<string>();
            foreach (DataRow dr in usuarios.Rows) 
            { usuarioslist.Add(dr[0].ToString()); }

            bool unicusername=true;
            foreach (var usuario in usuarioslist)
            {
                if (usuario.Equals(TextBoxUsername.Text))
                {
                    unicusername = false;
                }
            }

            if (unicusername)
            {
                ConnectionDB.ExecuteNonQuery($"insert into appuser(fullname, username, password, usertype) " +
                                             $"values('{textBoxFullName.Text}','{TextBoxUsername.Text}','{TextBoxUsername.Text}','{radioButton1.Checked}')");
                MessageBox.Show("¡Usuario agregado con exito!, su contraseña es igual al nombre de usuario.", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("¡Nombre de usuario no disponible!", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var usuarios = ConnectionDB.ExecuteQuery($"select iduser from appuser where username = '{comboBoxUsuarios.SelectedItem.ToString()}'");
                var usuariosCombo = new List<string>();
                foreach (DataRow dr in usuarios.Rows) 
                { usuariosCombo.Add(dr[0].ToString()); }
                int id = Convert.ToInt32(usuariosCombo[0]);
                ConnectionDB.ExecuteNonQuery($"delete from address where iduser = {id}");
                ConnectionDB.ExecuteNonQuery($"delete from appuser where iduser = {id}");
                MessageBox.Show("¡Usuario eliminado con exito!", 
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
            comboBoxUsuarios.DataSource = null;
            comboBoxUsuarios.ValueMember = "contraseña";
            comboBoxUsuarios.DisplayMember = "usuario";
            var usuarios = ConnectionDB.ExecuteQuery("select username from appuser");
            var usuariosCombo = new List<string>();
            foreach (DataRow dr in usuarios.Rows) 
            { usuariosCombo.Add(dr[0].ToString()); }
            comboBoxUsuarios.DataSource = usuariosCombo;
            //Actualizar DataGrid1
            var datagridusuarios = ConnectionDB.ExecuteQuery("select * from appuser");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = datagridusuarios;
        }
    }
}