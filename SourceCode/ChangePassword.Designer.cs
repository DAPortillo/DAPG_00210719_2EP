using System.ComponentModel;

namespace SourceCode
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
                new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContraActual = new System.Windows.Forms.TextBox();
            this.textBoxNuevaContra = new System.Windows.Forms.TextBox();
            this.textBoxRNuevaContra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCambiarContraseña = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(456, 73);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(310, 22);
            this.comboBoxUsuarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxContraActual
            // 
            this.textBoxContraActual.Location = new System.Drawing.Point(457, 184);
            this.textBoxContraActual.Name = "textBoxContraActual";
            this.textBoxContraActual.PasswordChar = '*';
            this.textBoxContraActual.Size = new System.Drawing.Size(309, 22);
            this.textBoxContraActual.TabIndex = 2;
            // 
            // textBoxNuevaContra
            // 
            this.textBoxNuevaContra.Location = new System.Drawing.Point(457, 234);
            this.textBoxNuevaContra.Name = "textBoxNuevaContra";
            this.textBoxNuevaContra.PasswordChar = '*';
            this.textBoxNuevaContra.Size = new System.Drawing.Size(309, 22);
            this.textBoxNuevaContra.TabIndex = 3;
            // 
            // textBoxRNuevaContra
            // 
            this.textBoxRNuevaContra.Location = new System.Drawing.Point(457, 285);
            this.textBoxRNuevaContra.Name = "textBoxRNuevaContra";
            this.textBoxRNuevaContra.PasswordChar = '*';
            this.textBoxRNuevaContra.Size = new System.Drawing.Size(309, 22);
            this.textBoxRNuevaContra.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(126, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña actual:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(126, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nueva Contraseña:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(126, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repetir Nueva Contraseña:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCambiarContraseña
            // 
            this.buttonCambiarContraseña.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCambiarContraseña.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))),
                ((int) (((byte) (40)))), ((int) (((byte) (125)))));
            this.buttonCambiarContraseña.ForeColor = System.Drawing.Color.White;
            this.buttonCambiarContraseña.Location = new System.Drawing.Point(510, 341);
            this.buttonCambiarContraseña.Name = "buttonCambiarContraseña";
            this.buttonCambiarContraseña.Size = new System.Drawing.Size(256, 73);
            this.buttonCambiarContraseña.TabIndex = 9;
            this.buttonCambiarContraseña.Text = "Cambiar Contraseña";
            this.buttonCambiarContraseña.UseVisualStyleBackColor = false;
            this.buttonCambiarContraseña.Click += new System.EventHandler(this.buttonCambiarContraseña_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))), ((int) (((byte) (40)))),
                ((int) (((byte) (125)))));
            this.ClientSize = new System.Drawing.Size(835, 449);
            this.Controls.Add(this.buttonCambiarContraseña);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRNuevaContra);
            this.Controls.Add(this.textBoxNuevaContra);
            this.Controls.Add(this.textBoxContraActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUsuarios);
            this.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.Text = "Hugo";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
        private System.Windows.Forms.TextBox textBoxContraActual;
        private System.Windows.Forms.TextBox textBoxNuevaContra;
        private System.Windows.Forms.TextBox textBoxRNuevaContra;
        private System.Windows.Forms.Button buttonCambiarContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}