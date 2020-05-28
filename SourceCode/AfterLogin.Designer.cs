using System.ComponentModel;

namespace SourceCode
{
    partial class AfterLogin
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
                new System.ComponentModel.ComponentResourceManager(typeof(AfterLogin));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonHistorialOrdenes = new System.Windows.Forms.Button();
            this.buttonNegocios = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonUsuarios = new System.Windows.Forms.Button();
            this.buttonAddress = new System.Windows.Forms.Button();
            this.buttonProductos = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))),
                ((int) (((byte) (40)))), ((int) (((byte) (125)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonHistorialOrdenes, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNegocios, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOrdenar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonUsuarios, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonProductos, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 519);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonHistorialOrdenes
            // 
            this.buttonHistorialOrdenes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonHistorialOrdenes.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))),
                ((int) (((byte) (40)))), ((int) (((byte) (125)))));
            this.buttonHistorialOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHistorialOrdenes.Font = new System.Drawing.Font("Unispace", 14.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonHistorialOrdenes.ForeColor = System.Drawing.Color.White;
            this.buttonHistorialOrdenes.Location = new System.Drawing.Point(747, 3);
            this.buttonHistorialOrdenes.Name = "buttonHistorialOrdenes";
            this.buttonHistorialOrdenes.Size = new System.Drawing.Size(183, 97);
            this.buttonHistorialOrdenes.TabIndex = 6;
            this.buttonHistorialOrdenes.Text = "Historial de ordenes";
            this.buttonHistorialOrdenes.UseVisualStyleBackColor = false;
            this.buttonHistorialOrdenes.Click += new System.EventHandler(this.buttonHistorialOrdenes_Click);
            // 
            // buttonNegocios
            // 
            this.buttonNegocios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNegocios.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))),
                ((int) (((byte) (40)))), ((int) (((byte) (125)))));
            this.buttonNegocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNegocios.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonNegocios.ForeColor = System.Drawing.Color.White;
            this.buttonNegocios.Location = new System.Drawing.Point(561, 3);
            this.buttonNegocios.Name = "buttonNegocios";
            this.buttonNegocios.Size = new System.Drawing.Size(180, 97);
            this.buttonNegocios.TabIndex = 5;
            this.buttonNegocios.Text = "Negocios";
            this.buttonNegocios.UseVisualStyleBackColor = false;
            this.buttonNegocios.Click += new System.EventHandler(this.buttonNegocios_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOrdenar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))),
                ((int) (((byte) (40)))), ((int) (((byte) (125)))));
            this.buttonOrdenar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOrdenar.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonOrdenar.ForeColor = System.Drawing.Color.White;
            this.buttonOrdenar.Location = new System.Drawing.Point(3, 442);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(180, 74);
            this.buttonOrdenar.TabIndex = 3;
            this.buttonOrdenar.Text = "Ordenar";
            this.buttonOrdenar.UseVisualStyleBackColor = false;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUsuarios.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))),
                ((int) (((byte) (40)))), ((int) (((byte) (125)))));
            this.buttonUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUsuarios.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonUsuarios.ForeColor = System.Drawing.Color.White;
            this.buttonUsuarios.Location = new System.Drawing.Point(189, 3);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Size = new System.Drawing.Size(180, 97);
            this.buttonUsuarios.TabIndex = 1;
            this.buttonUsuarios.Text = "Usuarios";
            this.buttonUsuarios.UseVisualStyleBackColor = false;
            this.buttonUsuarios.Click += new System.EventHandler(this.buttonUsuarios_Click);
            // 
            // buttonAddress
            // 
            this.buttonAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddress.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))),
                ((int) (((byte) (40)))), ((int) (((byte) (125)))));
            this.buttonAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddress.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonAddress.ForeColor = System.Drawing.Color.White;
            this.buttonAddress.Location = new System.Drawing.Point(3, 365);
            this.buttonAddress.Name = "buttonAddress";
            this.buttonAddress.Size = new System.Drawing.Size(180, 71);
            this.buttonAddress.TabIndex = 2;
            this.buttonAddress.Text = "Direcciones";
            this.buttonAddress.UseVisualStyleBackColor = false;
            this.buttonAddress.Click += new System.EventHandler(this.buttonAddress_Click);
            // 
            // buttonProductos
            // 
            this.buttonProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonProductos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))),
                ((int) (((byte) (40)))), ((int) (((byte) (125)))));
            this.buttonProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonProductos.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonProductos.ForeColor = System.Drawing.Color.White;
            this.buttonProductos.Location = new System.Drawing.Point(375, 3);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Size = new System.Drawing.Size(180, 97);
            this.buttonProductos.TabIndex = 4;
            this.buttonProductos.Text = "Productos";
            this.buttonProductos.UseVisualStyleBackColor = false;
            this.buttonProductos.Click += new System.EventHandler(this.buttonProductos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 253);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // AfterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "AfterLogin";
            this.Text = "Hugo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AfterLogin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AfterLogin_FormClosed);
            this.Load += new System.EventHandler(this.AfterLogin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonUsuarios;
        private System.Windows.Forms.Button buttonProductos;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Button buttonNegocios;
        private System.Windows.Forms.Button buttonAddress;
        private System.Windows.Forms.Button buttonHistorialOrdenes;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}