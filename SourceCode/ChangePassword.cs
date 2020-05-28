using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void buttonCambiarContraseña_Click(object sender, EventArgs e)
        {
            DataTable dt = ConnectionDB.ExecuteQuery($"select password from appuser where username = '{comboBoxUsuarios.SelectedItem.ToString()}'");
            var dtvalor = new List<string>();
            foreach (DataRow dr in dt.Rows)
            { dtvalor.Add(dr[0].ToString()); }
            bool actualIgual = textBoxContraActual.Text.Equals(dtvalor[0]);
            bool nuevaIgual = textBoxNuevaContra.Text.Equals(textBoxRNuevaContra.Text);
            bool nuevaValida = textBoxNuevaContra.Text.Length > 0;
            
            if (actualIgual && nuevaIgual && nuevaValida)
            {
                try
                {
                    ConnectionDB.ExecuteNonQuery($"UPDATE APPUSER SET password = '{textBoxNuevaContra.Text}' WHERE username = '{comboBoxUsuarios.SelectedItem.ToString()}'");
                                
                    MessageBox.Show("¡Contraseña actualizada exitosamente!", 
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Contraseña no actualizada! Favor intente mas tarde.", 
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("¡¡Favor verifique que los datos sean correctos!", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            comboBoxUsuarios.DataSource = null;
            comboBoxUsuarios.ValueMember = "contraseña";
            comboBoxUsuarios.DisplayMember = "usuario";
            var usuarios = ConnectionDB.ExecuteQuery("select username from appuser");
            var usuariosCombo = new List<string>();
            foreach (DataRow dr in usuarios.Rows) 
            { usuariosCombo.Add(dr[0].ToString()); }
            comboBoxUsuarios.DataSource = usuariosCombo;
        }
    }
}