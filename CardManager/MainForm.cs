using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCardApp
{
    public partial class MainForm : Form
    {
        private List<CreditCard> creditCards = new List<CreditCard>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            AddCardForm addCardForm = new AddCardForm(creditCards);
            addCardForm.ShowDialog();
            UpdateCardList();
        }

        private void btnDeleteCard_Click(object sender, EventArgs e)
        {
            if (lstCards.SelectedIndex >= 0)
            {
                creditCards.RemoveAt(lstCards.SelectedIndex);
                UpdateCardList();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir kart seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopyCardInfo_Click(object sender, EventArgs e)
        {
            if (lstCards.SelectedIndex >= 0)
            {
                var card = creditCards[lstCards.SelectedIndex];
                Clipboard.SetText($"Ad Soyad: {card.Name}\nKart No: {card.Number}\nSon Kullanma Tarihi: {card.ExpiryDate}\nCVC: {card.CVC}");
                MessageBox.Show("Kart bilgileri kopyalandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen kopyalamak için bir kart seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCardList()
        {
            lstCards.Items.Clear();
            foreach (var card in creditCards)
            {
                lstCards.Items.Add($"{card.Name} - {GetMaskedCardNumber(card.Number)}");
            }
        }

        private string GetMaskedCardNumber(string cardNumber)
        {
            if (cardNumber.Length == 19) // with spaces
            {
                cardNumber = cardNumber.Replace(" ", "");
            }
            if (cardNumber.Length == 16)
            {
                return $"{cardNumber.Substring(0, 2)}************{cardNumber.Substring(14, 2)}";
            }
            return cardNumber;
        }
    }

    public class CreditCard
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string ExpiryDate { get; set; }
        public string CVC { get; set; }
    }
}
