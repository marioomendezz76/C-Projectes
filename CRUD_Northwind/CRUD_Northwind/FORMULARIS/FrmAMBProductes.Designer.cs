namespace CRUD_Northwind.FORMULARIS
{
    partial class FrmAMBProductes
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
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbPreu = new System.Windows.Forms.TextBox();
            this.lbpreu = new System.Windows.Forms.Label();
            this.tbDescontinuat = new System.Windows.Forms.TextBox();
            this.lbDescontinuat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Red;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Location = new System.Drawing.Point(183, 189);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(73, 27);
            this.btCancel.TabIndex = 22;
            this.btCancel.Text = "&Cancelar";
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.Color.Lime;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(51, 189);
            this.btOk.Margin = new System.Windows.Forms.Padding(2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(73, 27);
            this.btOk.TabIndex = 21;
            this.btOk.Text = "&Acceptar";
            this.btOk.UseVisualStyleBackColor = false;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(95, 60);
            this.tbNom.Margin = new System.Windows.Forms.Padding(2);
            this.tbNom.MaxLength = 50;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(191, 20);
            this.tbNom.TabIndex = 20;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(95, 19);
            this.tbId.Margin = new System.Windows.Forms.Padding(2);
            this.tbId.MaxLength = 20;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(132, 20);
            this.tbId.TabIndex = 19;
            // 
            // lbId
            // 
            this.lbId.BackColor = System.Drawing.Color.Goldenrod;
            this.lbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbId.Location = new System.Drawing.Point(13, 16);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Padding = new System.Windows.Forms.Padding(3);
            this.lbId.Size = new System.Drawing.Size(65, 25);
            this.lbId.TabIndex = 18;
            this.lbId.Text = "Id.";
            this.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNom
            // 
            this.lbNom.BackColor = System.Drawing.Color.Goldenrod;
            this.lbNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNom.Location = new System.Drawing.Point(13, 56);
            this.lbNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Padding = new System.Windows.Forms.Padding(3);
            this.lbNom.Size = new System.Drawing.Size(65, 25);
            this.lbNom.TabIndex = 17;
            this.lbNom.Text = "Nom";
            this.lbNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPreu
            // 
            this.tbPreu.Location = new System.Drawing.Point(107, 102);
            this.tbPreu.Margin = new System.Windows.Forms.Padding(2);
            this.tbPreu.MaxLength = 50;
            this.tbPreu.Name = "tbPreu";
            this.tbPreu.Size = new System.Drawing.Size(108, 20);
            this.tbPreu.TabIndex = 24;
            // 
            // lbpreu
            // 
            this.lbpreu.BackColor = System.Drawing.Color.Goldenrod;
            this.lbpreu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbpreu.Location = new System.Drawing.Point(13, 97);
            this.lbpreu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpreu.Name = "lbpreu";
            this.lbpreu.Padding = new System.Windows.Forms.Padding(3);
            this.lbpreu.Size = new System.Drawing.Size(80, 25);
            this.lbpreu.TabIndex = 23;
            this.lbpreu.Text = "Preu";
            this.lbpreu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDescontinuat
            // 
            this.tbDescontinuat.Location = new System.Drawing.Point(107, 146);
            this.tbDescontinuat.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescontinuat.MaxLength = 50;
            this.tbDescontinuat.Name = "tbDescontinuat";
            this.tbDescontinuat.Size = new System.Drawing.Size(108, 20);
            this.tbDescontinuat.TabIndex = 26;
            // 
            // lbDescontinuat
            // 
            this.lbDescontinuat.BackColor = System.Drawing.Color.Goldenrod;
            this.lbDescontinuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDescontinuat.Location = new System.Drawing.Point(13, 141);
            this.lbDescontinuat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescontinuat.Name = "lbDescontinuat";
            this.lbDescontinuat.Padding = new System.Windows.Forms.Padding(3);
            this.lbDescontinuat.Size = new System.Drawing.Size(80, 25);
            this.lbDescontinuat.TabIndex = 25;
            this.lbDescontinuat.Text = "Descontinuat";
            this.lbDescontinuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmAMBProductes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 306);
            this.Controls.Add(this.tbDescontinuat);
            this.Controls.Add(this.lbDescontinuat);
            this.Controls.Add(this.tbPreu);
            this.Controls.Add(this.lbpreu);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbNom);
            this.Name = "FrmAMBProductes";
            this.Text = "FrmAMBProductes";
            this.Load += new System.EventHandler(this.FrmAMBProductes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbPreu;
        private System.Windows.Forms.Label lbpreu;
        private System.Windows.Forms.TextBox tbDescontinuat;
        private System.Windows.Forms.Label lbDescontinuat;
    }
}