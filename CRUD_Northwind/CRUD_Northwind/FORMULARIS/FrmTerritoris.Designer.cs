namespace CRUD_Northwind.FORMULARIS
{
    partial class FrmTerritoris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTerritoris));
            this.lbRegio = new System.Windows.Forms.Label();
            this.cbRegions = new System.Windows.Forms.ComboBox();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.ckbTotes = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRegio
            // 
            this.lbRegio.BackColor = System.Drawing.Color.Goldenrod;
            this.lbRegio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRegio.Location = new System.Drawing.Point(8, 18);
            this.lbRegio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRegio.Name = "lbRegio";
            this.lbRegio.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lbRegio.Size = new System.Drawing.Size(86, 25);
            this.lbRegio.TabIndex = 0;
            this.lbRegio.Text = "Regio";
            this.lbRegio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbRegions
            // 
            this.cbRegions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegions.FormattingEnabled = true;
            this.cbRegions.Location = new System.Drawing.Point(109, 21);
            this.cbRegions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRegions.Name = "cbRegions";
            this.cbRegions.Size = new System.Drawing.Size(253, 21);
            this.cbRegions.TabIndex = 1;
            this.cbRegions.SelectedIndexChanged += new System.EventHandler(this.cbRegions_SelectedIndexChanged);
            // 
            // dgDades
            // 
            this.dgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDades.Location = new System.Drawing.Point(1, 55);
            this.dgDades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgDades.Name = "dgDades";
            this.dgDades.RowHeadersWidth = 62;
            this.dgDades.RowTemplate.Height = 28;
            this.dgDades.Size = new System.Drawing.Size(465, 362);
            this.dgDades.TabIndex = 2;
            this.dgDades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDades_CellDoubleClick);
            // 
            // ckbTotes
            // 
            this.ckbTotes.AutoSize = true;
            this.ckbTotes.Location = new System.Drawing.Point(365, 23);
            this.ckbTotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbTotes.Name = "ckbTotes";
            this.ckbTotes.Size = new System.Drawing.Size(95, 17);
            this.ckbTotes.TabIndex = 3;
            this.ckbTotes.Text = "Totes Regions";
            this.ckbTotes.UseVisualStyleBackColor = true;
            this.ckbTotes.CheckedChanged += new System.EventHandler(this.ckbTotes_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CRUD_Northwind.Properties.Resources.cancel50;
            this.pictureBox2.Location = new System.Drawing.Point(395, 433);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRUD_Northwind.Properties.Resources.add50;
            this.pictureBox1.Location = new System.Drawing.Point(319, 433);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmTerritoris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(468, 484);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ckbTotes);
            this.Controls.Add(this.dgDades);
            this.Controls.Add(this.cbRegions);
            this.Controls.Add(this.lbRegio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmTerritoris";
            this.Text = "Territoris";
            this.Load += new System.EventHandler(this.FrmTerritoris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRegio;
        private System.Windows.Forms.ComboBox cbRegions;
        private System.Windows.Forms.DataGridView dgDades;
        private System.Windows.Forms.CheckBox ckbTotes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}