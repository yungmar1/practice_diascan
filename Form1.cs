using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClosedXML.Excel;

namespace practice_diascan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void accountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            e.Handled = !Char.IsDigit(ch) && !Char.IsControl(ch);
        }

        private void currentIndications_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            e.Handled = !Char.IsDigit(ch) && !Char.IsControl(ch);
        }

        private void previousIndications_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            e.Handled = !Char.IsDigit(ch) && !Char.IsControl(ch);
        }

        private void createExcel()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Export", "data.xlsx");
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("ЖКХ электроэнергия");

            worksheet.Cell("A1").Value = "№ лицевого счета";
            worksheet.Cell("B1").Value = "ФИО";
            worksheet.Cell("C1").Value = "Адрес";
            worksheet.Cell("D1").Value = "Дата";
            worksheet.Cell("C2").Style.NumberFormat.Format = "dd/mm/yyyy";
            worksheet.Cell("A4").Value = "Предыдущие показания";
            worksheet.Cell("B4").Value = "Текущие показания";
            worksheet.Cell("C4").Value = "Объем услуг";
            worksheet.Cell("D4").Value = "Тариф за оказанную услугу, руб";
            worksheet.Cell("E4").Value = "Задолжность/переплата(-) (при наличии)";
            worksheet.Cell("F4").Value = "Итого к оплате";
            worksheet.Cell("D5").Style.NumberFormat.Format = "#,##0.00";
            worksheet.Cell("E5").Style.NumberFormat.Format = "#,##0.00";
            worksheet.Cell("F5").Style
             .Border.SetTopBorder(XLBorderStyleValues.Medium)
             .Border.SetRightBorder(XLBorderStyleValues.Medium)
             .Border.SetBottomBorder(XLBorderStyleValues.Medium)
             .Border.SetLeftBorder(XLBorderStyleValues.Medium)
             .NumberFormat.Format = "#,##0.00";
            worksheet.Columns().AdjustToContents();
           
            string account_number_value = accountNumber.Text;
            string fio_value = fio.Text;
            string adress_value = adress.Text;
            string date_value = dt.Value.ToShortDateString();
            float tax = 6.73F;
            string current_value = currentIndications.Text;
            string previous_value = previousIndications.Text;
            string underpay_value = underpay.Text;
            int current_value_int = Convert.ToInt32(current_value);
            int previous_value_int = Convert.ToInt32(previous_value);
            float underpay_value_f = Convert.ToSingle(underpay_value);
            float res = tax * (current_value_int - previous_value_int) + underpay_value_f;

            worksheet.Cell("A2").SetValue(account_number_value);
            worksheet.Cell("B2").SetValue(fio_value);
            worksheet.Cell("C2").SetValue(adress_value);
            worksheet.Cell("D2").SetValue(date_value);
            worksheet.Cell("A5").SetValue(current_value);
            worksheet.Cell("B5").SetValue(previous_value);
            worksheet.Cell("C5").SetValue(current_value_int - previous_value_int);
            worksheet.Cell("D5").SetValue(tax);
            worksheet.Cell("E5").SetValue(underpay_value_f);
            worksheet.Cell("F5").SetValue(res);

            workbook.SaveAs(path);
        }

        private void create_Click(object sender, EventArgs e)
        {
            createExcel();
            
            if (accountNumber.Text == "" || fio.Text == ""  || currentIndications.Text == "" || previousIndications.Text == ""
                || underpay.Text == "")
            {
                MessageBox.Show(this, "Проверьте корректность ввода данных", "Ошибка");
            }
            else
            {
                MessageBox.Show(this, "Файл успешно создан", "Успешно");
            }
        }
    }
}
