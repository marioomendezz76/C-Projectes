namespace CRUD_Northwind.FORMULARIS
{
    partial class FrmAMBRegio
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Red;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Location = new System.Drawing.Point(272, 109);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(73, 27);
            this.btCancel.TabIndex = 16;
            this.btCancel.Text = "&Cancelar";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.Color.Lime;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(84, 109);
            this.btOk.Margin = new System.Windows.Forms.Padding(2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(73, 27);
            this.btOk.TabIndex = 15;
            this.btOk.Text = "&Acceptar";
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(93, 68);
            this.tbDesc.Margin = new System.Windows.Forms.Padding(2);
            this.tbDesc.MaxLength = 50;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(309, 20);
            this.tbDesc.TabIndex = 13;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(93, 27);
            this.tbId.Margin = new System.Windows.Forms.Padding(2);
            this.tbId.MaxLength = 20;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(132, 20);
            this.tbId.TabIndex = 12;
            // 
            // lbId
            // 
            this.lbId.BackColor = System.Drawing.Color.Goldenrod;
            this.lbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbId.Location = new System.Drawing.Point(11, 24);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Padding = new System.Windows.Forms.Padding(3);
            this.lbId.Size = new System.Drawing.Size(65, 25);
            this.lbId.TabIndex = 11;
            this.lbId.Text = "Id.";
            this.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDesc
            // 
            this.lbDesc.BackColor = System.Drawing.Color.Goldenrod;
            this.lbDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDesc.Location = new System.Drawing.Point(11, 64);
            this.lbDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Padding = new System.Windows.Forms.Padding(3);
            this.lbDesc.Size = new System.Drawing.Size(65, 25);
            this.lbDesc.TabIndex = 10;
            this.lbDesc.Text = "Descripcio";
            this.lbDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmAMBRegio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 160);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbDesc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAMBRegio";
            this.Text = "FrmAMBRegio";
            this.Load += new System.EventHandler(this.FrmAMBRegio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbDesc;
    }
}