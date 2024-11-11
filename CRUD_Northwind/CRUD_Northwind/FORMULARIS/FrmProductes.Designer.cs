namespace CRUD_Northwind.FORMULARIS
{
    partial class FrmProductes
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.cbxCategoria = new System.Windows.Forms.CheckBox();
            this.cbxProveidors = new System.Windows.Forms.CheckBox();
            this.cbProveidors = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CRUD_Northwind.Properties.Resources.cancel50;
            this.pictureBox2.Location = new System.Drawing.Point(406, 500);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRUD_Northwind.Properties.Resources.add50;
            this.pictureBox1.Location = new System.Drawing.Point(322, 500);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgDades
            // 
            this.dgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDades.Location = new System.Drawing.Point(5, 117);
            this.dgDades.Margin = new System.Windows.Forms.Padding(2);
            this.dgDades.Name = "dgDades";
            this.dgDades.RowHeadersWidth = 62;
            this.dgDades.RowTemplate.Height = 28;
            this.dgDades.Size = new System.Drawing.Size(465, 362);
            this.dgDades.TabIndex = 8;
            this.dgDades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDades_CellDoubleClick);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.AutoSize = true;
            this.cbxCategoria.Location = new System.Drawing.Point(322, 82);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(134, 17);
            this.cbxCategoria.TabIndex = 12;
            this.cbxCategoria.Text = "Per categoria producte";
            this.cbxCategoria.UseVisualStyleBackColor = true;
            this.cbxCategoria.CheckedChanged += new System.EventHandler(this.cbxCategoria_CheckedChanged);
            // 
            // cbxProveidors
            // 
            this.cbxProveidors.AutoSize = true;
            this.cbxProveidors.Location = new System.Drawing.Point(322, 37);
            this.cbxProveidors.Name = "cbxProveidors";
            this.cbxProveidors.Size = new System.Drawing.Size(91, 17);
            this.cbxProveidors.TabIndex = 13;
            this.cbxProveidors.Text = "Per proveïdor";
            this.cbxProveidors.UseVisualStyleBackColor = true;
            this.cbxProveidors.CheckedChanged += new System.EventHandler(this.cbxProveidors_CheckedChanged);
            // 
            // cbProveidors
            // 
            this.cbProveidors.FormattingEnabled = true;
            this.cbProveidors.Location = new System.Drawing.Point(22, 33);
            this.cbProveidors.Name = "cbProveidors";
            this.cbProveidors.Size = new System.Drawing.Size(278, 21);
            this.cbProveidors.TabIndex = 14;
            this.cbProveidors.SelectedIndexChanged += new System.EventHandler(this.cbProveidors_SelectedIndexChanged);
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(22, 80);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(278, 21);
            this.cbCategoria.TabIndex = 15;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // FrmProductes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 561);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbProveidors);
            this.Controls.Add(this.cbxProveidors);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgDades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmProductes";
            this.Text = "FrmProductes";
            this.Load += new System.EventHandler(this.FrmProductes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgDades;
        private System.Windows.Forms.CheckBox cbxCategoria;
        private System.Windows.Forms.CheckBox cbxProveidors;
        private System.Windows.Forms.ComboBox cbProveidors;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}