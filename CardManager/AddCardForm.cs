using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions;


namespace CreditCardApp
{
    public partial class AddCardForm : Form
    {
        private List<CreditCard> creditCards;
        private Random random = new Random();

        public AddCardForm(List<CreditCard> creditCards)
        {
            InitializeComponent();
            this.creditCards = creditCards;
            GenerateRandomNumpad();
            txtNumber.TextChanged += TxtNumber_TextChanged;
            txtExpiryDate.TextChanged += TxtExpiryDate_TextChanged;
        }

        private void GenerateRandomNumpad()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++) numbers.Add(i);

            foreach (Control control in pnlNumpad.Controls)
            {
                if (control is Button btn && btn.Text != "Sil")
                {
                    int index = random.Next(numbers.Count);
                    btn.Text = numbers[index].ToString();
                    numbers.RemoveAt(index);
                }
            }
        }

        private void btnNumpad_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                txtNumber.Text += btn.Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber.Text = txtNumber.Text.Substring(0, txtNumber.Text.Length - 1);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string number = txtNumber.Text.Replace(" ", ""); // Remove spaces
            string expiryDate = txtExpiryDate.Text;
            string cvc = txtCVC.Text;

            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Adı kısmı yalnızca harflerden oluşmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(number, @"^\d{16}$"))
            {
                MessageBox.Show("Kart No kısmı yalnızca 16 haneli bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*if (!Regex.IsMatch(expiryDate, @"^(0[1-9]|1[0-2])\/\d{2}$"))
            {
                MessageBox.Show("Son Kullanma kısmı MM/YY formatında olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            if (!Regex.IsMatch(cvc, @"^\d{3}$"))
            {
                MessageBox.Show("CVC kısmı yalnızca 3 haneli bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreditCard newCard = new CreditCard
            {
                Name = name,
                Number = txtNumber.Text, // Store with spaces
                ExpiryDate = expiryDate,
                CVC = cvc
            };

            creditCards.Add(newCard);
            MessageBox.Show("Kart eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void TxtNumber_TextChanged(object sender, EventArgs e)
        {
            string text = txtNumber.Text.Replace(" ", "");
            if (text.Length > 0)
            {
                text = Regex.Replace(text, ".{4}", "$0 ");
                txtNumber.Text = text.Trim();
                txtNumber.SelectionStart = txtNumber.Text.Length;
            }
        }

        private void TxtExpiryDate_TextChanged(object sender, EventArgs e)
        {
            string text = txtExpiryDate.Text.Replace("/", "");
            if (text.Length > 2)
            {
                text = text.Insert(2, "/");
                txtExpiryDate.Text = text;
                txtExpiryDate.SelectionStart = txtExpiryDate.Text.Length;
            }
        }
    }
}
