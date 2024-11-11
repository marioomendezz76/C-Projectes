namespace CRUD_Northwind.FORMULARIS
{
    partial class FrmAMBTerritoris
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
            this.lbRegio = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.cbRegions = new System.Windows.Forms.ComboBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRegio
            // 
            this.lbRegio.BackColor = System.Drawing.Color.Goldenrod;
            this.lbRegio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRegio.Location = new System.Drawing.Point(12, 157);
            this.lbRegio.Name = "lbRegio";
            this.lbRegio.Padding = new System.Windows.Forms.Padding(5);
            this.lbRegio.Size = new System.Drawing.Size(96, 37);
            this.lbRegio.TabIndex = 1;
            this.lbRegio.Text = "Regio";
            this.lbRegio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDesc
            // 
            this.lbDesc.BackColor = System.Drawing.Color.Goldenrod;
            this.lbDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDesc.Location = new System.Drawing.Point(12, 99);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Padding = new System.Windows.Forms.Padding(5);
            this.lbDesc.Size = new System.Drawing.Size(96, 37);
            this.lbDesc.TabIndex = 2;
            this.lbDesc.Text = "Descripcio";
            this.lbDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbId
            // 
            this.lbId.BackColor = System.Drawing.Color.Goldenrod;
            this.lbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbId.Location = new System.Drawing.Point(12, 37);
            this.lbId.Name = "lbId";
            this.lbId.Padding = new System.Windows.Forms.Padding(5);
            this.lbId.Size = new System.Drawing.Size(96, 37);
            this.lbId.TabIndex = 3;
            this.lbId.Text = "Id.";
            this.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(135, 42);
            this.tbId.MaxLength = 20;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(196, 26);
            this.tbId.TabIndex = 4;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(135, 104);
            this.tbDesc.MaxLength = 50;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(462, 26);
            this.tbDesc.TabIndex = 5;
            // 
            // cbRegions
            // 
            this.cbRegions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegions.FormattingEnabled = true;
            this.cbRegions.Location = new System.Drawing.Point(135, 162);
            this.cbRegions.Name = "cbRegions";
            this.cbRegions.Size = new System.Drawing.Size(238, 28);
            this.cbRegions.TabIndex = 6;
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.Color.Lime;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(135, 228);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(109, 41);
            this.btOk.TabIndex = 7;
            this.btOk.Text = "&Acceptar";
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Red;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Location = new System.Drawing.Point(417, 228);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(109, 41);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "&Cancelar";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FrmAMBTerritoris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 312);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.cbRegions);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbRegio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAMBTerritoris";
            this.Text = "FrmAMBTerritoris";
            this.Load += new System.EventHandler(this.FrmAMBTerritoris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRegio;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.ComboBox cbRegions;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
    }
}