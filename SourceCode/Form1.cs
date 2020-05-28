using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actucombobox();
        }
        private void actucombobox()
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
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ConnectionDB.ExecuteQuery($"select password from appuser where username = '{comboBoxUsuarios.SelectedItem.ToString()}'");
                var dtvalor = new List<string>();
                foreach (DataRow dr in dt.Rows)
                { dtvalor.Add(dr[0].ToString()); }
                bool contraIgual = textBoxContraseña.Text.Equals(dtvalor[0]);
                if (contraIgual)
                {
                    var ventana = new AfterLogin(comboBoxUsuarios.SelectedItem.ToString());
                    this.Hide();
                    ventana.ShowDialog();
                    actucombobox();
                }
                else
                {
                    MessageBox.Show("¡Contraseña incorrecta!", 
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("¡Ha ocurrido un error!", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCmbContra_Click(object sender, EventArgs e)
        { 
            var ventana = new ChangePassword(); 
            ventana.ShowDialog();
            actucombobox();
        }
        private void textBoxContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonLogin_Click(sender, e);
        }
    }
}