using System.ComponentModel;

namespace SourceCode
{
    partial class Productos
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameP = new System.Windows.Forms.TextBox();
            this.buttonAddP = new System.Windows.Forms.Button();
            this.comboBoxnegocios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboboxP = new System.Windows.Forms.ComboBox();
            this.buttonDeletP = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))),
                ((int) (((byte) (40)))), ((int) (((byte) (125)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comboboxP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNameP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddP, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxnegocios, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonDeletP, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(721, 423);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto a agregar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNameP
            // 
            this.textBoxNameP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNameP.Location = new System.Drawing.Point(3, 111);
            this.textBoxNameP.Name = "textBoxNameP";
            this.textBoxNameP.Size = new System.Drawing.Size(353, 30);
            this.textBoxNameP.TabIndex = 1;
            // 
            // buttonAddP
            // 
            this.buttonAddP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddP.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))), ((int) (((byte) (40)))),
                ((int) (((byte) (125)))));
            this.buttonAddP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddP.Location = new System.Drawing.Point(3, 339);
            this.buttonAddP.Name = "buttonAddP";
            this.buttonAddP.Size = new System.Drawing.Size(354, 81);
            this.buttonAddP.TabIndex = 2;
            this.buttonAddP.Text = "Agregar producto";
            this.buttonAddP.UseVisualStyleBackColor = false;
            this.buttonAddP.Click += new System.EventHandler(this.buttonAddP_Click);
            // 
            // comboBoxnegocios
            // 
            this.comboBoxnegocios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.comboBoxnegocios, 2);
            this.comboBoxnegocios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxnegocios.FormattingEnabled = true;
            this.comboBoxnegocios.Location = new System.Drawing.Point(183, 280);
            this.comboBoxnegocios.Name = "comboBoxnegocios";
            this.comboBoxnegocios.Size = new System.Drawing.Size(354, 31);
            this.comboBoxnegocios.TabIndex = 3;
            // 
            // label2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(715, 84);
            this.label2.TabIndex = 4;
            this.label2.Text = "Negocio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(363, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 84);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eliminar un producto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboboxP
            // 
            this.comboboxP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboboxP.FormattingEnabled = true;
            this.comboboxP.Location = new System.Drawing.Point(363, 110);
            this.comboboxP.Name = "comboboxP";
            this.comboboxP.Size = new System.Drawing.Size(354, 31);
            this.comboboxP.TabIndex = 6;
            // 
            // buttonDeletP
            // 
            this.buttonDeletP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDeletP.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))),
                ((int) (((byte) (40)))), ((int) (((byte) (125)))));
            this.buttonDeletP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeletP.Location = new System.Drawing.Point(363, 339);
            this.buttonDeletP.Name = "buttonDeletP";
            this.buttonDeletP.Size = new System.Drawing.Size(355, 81);
            this.buttonDeletP.TabIndex = 7;
            this.buttonDeletP.Text = "Eliminar producto";
            this.buttonDeletP.UseVisualStyleBackColor = false;
            this.buttonDeletP.Click += new System.EventHandler(this.buttonDeletP_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Productos";
            this.Size = new System.Drawing.Size(721, 423);
            this.Load += new System.EventHandler(this.Productos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxnegocios;
        private System.Windows.Forms.Button buttonAddP;
        private System.Windows.Forms.Button buttonDeletP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboboxP;
    }
}