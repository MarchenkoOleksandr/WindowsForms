using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinForms_homework3_2_bestOil
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> oilTypes = new Dictionary<string, double>()
        {
            {"А-76", 28.55},
            {"А-92", 30.49},
            {"А-95", 31.49},
            {"А-95+", 32.49},
            {"Дизель", 28.99},
            {"Газ", 13.20}
        };
        double totalMoney = 0.0f;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_MouseClick(object sender, MouseEventArgs e)
        {
            if (buttonCalculate.Text == "Прорахувати")
            {
                if (radioButton1.Checked)
                    labelTotalSum.Text = (Double.Parse(labelSumForOil.Text) + Double.Parse(labelSumForFood.Text)).ToString("F2");
                else if (Double.TryParse(textBoxSum.Text, out double sumForOil))
                    labelTotalSum.Text = (sumForOil + Double.Parse(labelSumForFood.Text)).ToString("F2");
                else
                    labelTotalSum.Text = (Double.Parse(labelSumForFood.Text)).ToString("F2");
                timer1.Start();
            }
            else
            {
                totalMoney += Double.Parse(labelTotalSum.Text);
                DefaultSettings();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, double> keyValue in oilTypes)
                comboBoxOilType.Items.Add(keyValue.Key.ToString());
            comboBoxOilType.SelectedIndex = 0;
            textBoxOilPrice.Text = oilTypes[comboBoxOilType.SelectedItem.ToString()].ToString();
        }

        private void ComboBoxOilType_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxOilPrice.Text = oilTypes[comboBoxOilType.SelectedItem.ToString()].ToString();
            if (radioButton1.Checked && textBoxLiters.Text.Length > 0)
                TextBoxLiters_TextChanged(sender, e);
            else if (radioButton2.Checked && textBoxSum.Text.Length > 0)
                TextBoxSum_TextChanged(sender, e);
        }

        private void TextBoxLiters_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Double.TryParse(textBoxLiters.Text, out double liters))
                labelSumForOil.Text = (Double.Parse(textBoxOilPrice.Text) * liters).ToString("F2");
            else if (textBoxLiters.Text.Contains('.'))
            {
                errorProvider1.SetError(textBoxLiters, "Введіть число через кому!");
                labelSumForOil.Text = "0,00";
            }
            else
            {
                errorProvider1.SetError(textBoxLiters, "Помилка вводу!");
                labelSumForOil.Text = "0,00";
            }
        }

        private void TextBoxSum_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Double.TryParse(textBoxSum.Text, out double sum))
                labelSumForOil.Text = (sum / Double.Parse(textBoxOilPrice.Text)).ToString("F2");
            else if (textBoxSum.Text.Contains('.'))
            {
                errorProvider1.SetError(textBoxSum, "Введіть число через кому!");
                labelSumForOil.Text = "0,00";
            }
            else
            {
                errorProvider1.SetError(textBoxSum, "Помилка вводу!");
                labelSumForOil.Text = "0,00";
            }

        }

        private void RadioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxLiters.ReadOnly = false;
            textBoxSum.Text = "";
            textBoxSum.ReadOnly = true;
            labelHrnOrLiter.Text = "грн.";
            groupBox3.Text = "До оплати";
        }

        private void RadioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxLiters.Text = "";
            textBoxLiters.ReadOnly = true;
            textBoxSum.ReadOnly = false;
            labelHrnOrLiter.Text = "л.";
            groupBox3.Text = "До видачі";
        }

        private void CheckBoxHotDog_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBoxHotDog.Checked)
            {
                textBoxNumberHotDog.ReadOnly = false;
                textBoxNumberHotDog.Text = "1";
            }
            else
            {
                textBoxNumberHotDog.ReadOnly = true;
                textBoxNumberHotDog.Text = "0";
            }
        }

        private void CheckBoxHamburger_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBoxHamburger.Checked)
            {
                textBoxNumberHamburger.ReadOnly = false;
                textBoxNumberHamburger.Text = "1";
            }
            else
            {
                textBoxNumberHamburger.ReadOnly = true;
                textBoxNumberHamburger.Text = "0";
            }
        }

        private void CheckBoxFri_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBoxFri.Checked)
            {
                textBoxNumberFri.ReadOnly = false;
                textBoxNumberFri.Text = "1";
            }
            else
            {
                textBoxNumberFri.ReadOnly = true;
                textBoxNumberFri.Text = "0";
            }
        }

        private void CheckBoxCola_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBoxCola.Checked)
            {
                textBoxNumberCola.ReadOnly = false;
                textBoxNumberCola.Text = "1";
            }
            else
            {
                textBoxNumberCola.ReadOnly = true;
                textBoxNumberCola.Text = "0";
            }
        }

        private void TextBoxNumberHotDog_TextChanged(object sender, EventArgs e)
        {
            CalculatingFood();
        }

        private void TextBoxNumberHamburger_TextChanged(object sender, EventArgs e)
        {
            CalculatingFood();
        }

        private void TextBoxNumberFri_TextChanged(object sender, EventArgs e)
        {
            CalculatingFood();
        }

        private void TextBoxNumberCola_TextChanged(object sender, EventArgs e)
        {
            CalculatingFood();
        }

        private void CalculatingFood()
        {
            errorProvider1.Clear();
            if (!Int32.TryParse(textBoxNumberHotDog.Text, out int hotdogs))
            {
                errorProvider1.SetError(textBoxNumberHotDog, "Помилка вводу!");
                labelSumForFood.Text = "0,00";
                return;
            }
            if (!Int32.TryParse(textBoxNumberHamburger.Text, out int hamburgers))
            {
                errorProvider1.SetError(textBoxNumberHamburger, "Помилка вводу!");
                labelSumForFood.Text = "0,00";
                return;
            }
            if (!Int32.TryParse(textBoxNumberFri.Text, out int fri))
            {
                errorProvider1.SetError(textBoxNumberFri, "Помилка вводу!");
                labelSumForFood.Text = "0,00";
                return;
            }
            if (!Int32.TryParse(textBoxNumberCola.Text, out int colas))
            {
                errorProvider1.SetError(textBoxNumberCola, "Помилка вводу!");
                labelSumForFood.Text = "0,00";
                return;
            }
            labelSumForFood.Text = ((Double.Parse(textBoxPriceHotDog.Text) * hotdogs) + (Double.Parse(textBoxPriceHamburger.Text) * hamburgers) +
                (Double.Parse(textBoxPriceFri.Text) * fri) + (Double.Parse(textBoxPriceCola.Text) * colas)).ToString("F2");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            buttonCalculate.Text = "Очистити форму";
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void DefaultSettings()
        {
            textBoxLiters.Text = "";
            textBoxSum.Text = "";
            checkBoxHotDog.Checked = false;
            textBoxNumberHotDog.ReadOnly = true;
            textBoxNumberHotDog.Text = "0";
            checkBoxHamburger.Checked = false;
            textBoxNumberHamburger.ReadOnly = true;
            textBoxNumberHamburger.Text = "0";
            checkBoxFri.Checked = false;
            textBoxNumberFri.ReadOnly = true;
            textBoxNumberFri.Text = "0";
            checkBoxCola.Checked = false;
            textBoxNumberCola.ReadOnly = true;
            textBoxNumberCola.Text = "0";
            labelTotalSum.Text = "0,00";
            buttonCalculate.Text = "Прорахувати";
            errorProvider1.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Виручка за день склала {totalMoney} грн.", "Підсумок дня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}