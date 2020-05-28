using System.Security.AccessControl;

namespace SourceCode
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.buttonCmbContra = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.labelUsuario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelContraseña, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxUsuarios, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxContraseña, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonCmbContra, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonLogin, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelUsuario
            // 
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUsuario.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))),
                ((int) (((byte) (40)))), ((int) (((byte) (125)))));
            this.labelUsuario.Location = new System.Drawing.Point(3, 129);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(227, 129);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario:";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelContraseña
            // 
            this.labelContraseña.BackColor = System.Drawing.Color.Transparent;
            this.labelContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelContraseña.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelContraseña.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))),
                ((int) (((byte) (40)))), ((int) (((byte) (125)))));
            this.labelContraseña.Location = new System.Drawing.Point(3, 258);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(227, 129);
            this.labelContraseña.TabIndex = 1;
            this.labelContraseña.Text = "Contraseña:";
            this.labelContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(236, 182);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(226, 23);
            this.comboBoxUsuarios.TabIndex = 2;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContraseña.Location = new System.Drawing.Point(236, 311);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(226, 23);
            this.textBoxContraseña.TabIndex = 3;
            this.textBoxContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxContraseña_KeyDown);
            // 
            // buttonCmbContra
            // 
            this.buttonCmbContra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCmbContra.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))),
                ((int) (((byte) (40)))), ((int) (((byte) (125)))));
            this.buttonCmbContra.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCmbContra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmbContra.FlatAppearance.BorderSize = 0;
            this.buttonCmbContra.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonCmbContra.ForeColor = System.Drawing.Color.White;
            this.buttonCmbContra.Location = new System.Drawing.Point(3, 390);
            this.buttonCmbContra.Name = "buttonCmbContra";
            this.buttonCmbContra.Size = new System.Drawing.Size(227, 126);
            this.buttonCmbContra.TabIndex = 4;
            this.buttonCmbContra.Text = "Cambiar contraseña";
            this.buttonCmbContra.UseVisualStyleBackColor = false;
            this.buttonCmbContra.Click += new System.EventHandler(this.buttonCmbContra_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))), ((int) (((byte) (40)))),
                ((int) (((byte) (125)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(236, 390);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(227, 126);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Iniciar sesion";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hugo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCmbContra;
    }
}