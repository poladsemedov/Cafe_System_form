namespace Cafe_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Zəhmət olmasa əvvəlcə 'Yekun Hesab' düyməsini vurun və müştərinin verdiyi məbləği daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                double hesabMeblegi = Convert.ToDouble(textBox4.Text.Replace(" AZN", "").Trim());
                double daxilEdilenPul = Convert.ToDouble(textBox2.Text.Trim());

                if (daxilEdilenPul < hesabMeblegi)
                {
                    MessageBox.Show("Daxil edilən məbləğ hesabdan azdır", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double qaliq = daxilEdilenPul - hesabMeblegi;
                    textBox3.Text = qaliq.ToString("0.00") + " AZN";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Zəhmət olmasa məbləğ xanasına düzgün rəqəm daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string secilenMehsul = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(listBox1.SelectedItem);
                MessageBox.Show(secilenMehsul + " səbətdən silindi", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa silmək üçün səbətdən bir məhsul seçin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Səbətdə yemək yoxdur!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double toplamHesab = 0;

            foreach (var item in listBox1.Items)
            {
                string mehsulMetni = item.ToString();

                string[] hisseler = mehsulMetni.Split('-');
                if (hisseler.Length > 1)
                {
                    string qiymetStr = hisseler[1].Replace("AZN", "").Trim();

                    
                    if (double.TryParse(qiymetStr, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double qiymet))
                    {
                        toplamHesab += qiymet;
                    }
                }
            }

            textBox4.Text = toplamHesab.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + " AZN";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tort - 5.00 AZN");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kola - 2.00 AZN");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Portağal suyu - 3.00 AZN");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hamburger - 6.00 AZN");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sendviç - 4.00 AZN");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pizza - 7.00 AZN");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Keks - 3.00 AZN");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hot-dog - 4.00 AZN");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Peçenye - 2.00 AZN");
        }
    }
}
