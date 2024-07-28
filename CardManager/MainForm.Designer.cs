namespace CreditCardApp
{
    partial class MainForm
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
            this.btnAddCard = new System.Windows.Forms.Button();
            this.btnDeleteCard = new System.Windows.Forms.Button();
            this.btnCopyCardInfo = new System.Windows.Forms.Button();
            this.lstCards = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddCard
            // 
            this.btnAddCard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCard.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCard.Location = new System.Drawing.Point(12, 12);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(100, 53);
            this.btnAddCard.TabIndex = 0;
            this.btnAddCard.Text = "Kart Ekle";
            this.btnAddCard.UseVisualStyleBackColor = false;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // btnDeleteCard
            // 
            this.btnDeleteCard.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteCard.Location = new System.Drawing.Point(12, 71);
            this.btnDeleteCard.Name = "btnDeleteCard";
            this.btnDeleteCard.Size = new System.Drawing.Size(100, 55);
            this.btnDeleteCard.TabIndex = 1;
            this.btnDeleteCard.Text = "Kart Sil";
            this.btnDeleteCard.UseVisualStyleBackColor = true;
            this.btnDeleteCard.Click += new System.EventHandler(this.btnDeleteCard_Click);
            // 
            // btnCopyCardInfo
            // 
            this.btnCopyCardInfo.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCopyCardInfo.Location = new System.Drawing.Point(12, 132);
            this.btnCopyCardInfo.Name = "btnCopyCardInfo";
            this.btnCopyCardInfo.Size = new System.Drawing.Size(100, 53);
            this.btnCopyCardInfo.TabIndex = 2;
            this.btnCopyCardInfo.Text = "Kart No Kopyala";
            this.btnCopyCardInfo.UseVisualStyleBackColor = true;
            this.btnCopyCardInfo.Click += new System.EventHandler(this.btnCopyCardInfo_Click);
            // 
            // lstCards
            // 
            this.lstCards.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstCards.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstCards.FormattingEnabled = true;
            this.lstCards.ItemHeight = 17;
            this.lstCards.Location = new System.Drawing.Point(131, 12);
            this.lstCards.Name = "lstCards";
            this.lstCards.Size = new System.Drawing.Size(397, 174);
            this.lstCards.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(540, 211);
            this.Controls.Add(this.lstCards);
            this.Controls.Add(this.btnCopyCardInfo);
            this.Controls.Add(this.btnDeleteCard);
            this.Controls.Add(this.btnAddCard);
            this.Name = "MainForm";
            this.Text = "Ana Menü";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.Button btnDeleteCard;
        private System.Windows.Forms.Button btnCopyCardInfo;
        private System.Windows.Forms.ListBox lstCards;
    }
}
