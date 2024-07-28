using System;
using System.Windows.Forms;

namespace CreditCardApp
{
    partial class AddCardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblCVC = new System.Windows.Forms.Label();
            this.pnlNumpad = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(93, 38);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.ReadOnly = true;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(93, 64);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(100, 20);
            this.txtExpiryDate.TabIndex = 2;
            // 
            // txtCVC
            // 
            this.txtCVC.Location = new System.Drawing.Point(93, 90);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(100, 20);
            this.txtCVC.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Kart Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Adı:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 41);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(55, 13);
            this.lblNumber.TabIndex = 6;
            this.lblNumber.Text = "Kart No:";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(12, 67);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(75, 13);
            this.lblExpiryDate.TabIndex = 7;
            this.lblExpiryDate.Text = "Son Kullanma:";
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Location = new System.Drawing.Point(12, 93);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(34, 13);
            this.lblCVC.TabIndex = 8;
            this.lblCVC.Text = "CVC:";
            // 
            // pnlNumpad
            // 
            this.pnlNumpad.Location = new System.Drawing.Point(220, 12);
            this.pnlNumpad.Name = "pnlNumpad";
            this.pnlNumpad.Size = new System.Drawing.Size(200, 200);
            this.pnlNumpad.TabIndex = 9;
            // 
            // AddCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.pnlNumpad);
            this.Controls.Add(this.lblCVC);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCVC);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Name = "AddCardForm";
            this.Text = "Kart Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

            // Create numpad buttons
            for (int i = 0; i < 10; i++)
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Size = new System.Drawing.Size(45, 45);
                btn.Click += new System.EventHandler(this.btnNumpad_Click);
                pnlNumpad.Controls.Add(btn);
            }

            // Add delete button
            System.Windows.Forms.Button btnDelete = new System.Windows.Forms.Button();
            btnDelete.Size = new System.Drawing.Size(45, 45);
            btnDelete.Text = "Sil";
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            pnlNumpad.Controls.Add(btnDelete);

            // Arrange numpad buttons
            for (int i = 0; i < pnlNumpad.Controls.Count; i++)
            {
                int row = i / 3;
                int col = i % 3;
                pnlNumpad.Controls[i].Location = new System.Drawing.Point(col * 50, row * 50);
            }
        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.Panel pnlNumpad;
    }
}
