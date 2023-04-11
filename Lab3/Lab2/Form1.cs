using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private readonly AuthorsForm _authorsForm = new AuthorsForm();
        private readonly SearchForm _searchForm = new SearchForm();

        public Form1()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            radioButtonPDF.BackColor = System.Drawing.Color.Transparent;
            radioButtonTXT.BackColor = System.Drawing.Color.Transparent;
            radioButtonFB2.BackColor = System.Drawing.Color.Transparent;
            radioButtonEPUB.BackColor = System.Drawing.Color.Transparent;
            _authorsForm.Hide();
        }

        private void authors_Click(object sender, EventArgs e)
        {
            _authorsForm.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var BookFilesList = (from object item in listBoxInfo.Items select item as FileBook).ToList();

            using (var reader = new StreamWriter(@"D:\University\4th_term\ООП\Lab3\Lab2\JSON\Lab2.json"))
            {
                string jsonString = JsonConvert.SerializeObject(BookFilesList);
                reader.Write(jsonString);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var BookFilesList = new List<FileBook>();
            using (var reader = new StreamReader(@"D:\University\4th_term\ООП\Lab3\Lab2\JSON\Lab2.json"))
            {
                BookFilesList = JsonConvert.DeserializeObject<List<FileBook>>(reader.ReadToEnd());
            }

            foreach (var bookFile in BookFilesList)
                listBoxInfo.Items.Add(bookFile);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_authorsForm.CurrentAuthorsList == null) return;
            //if (Controls.OfType<RadioButton>().Any(r => r.Checked) == false) return;
            

            var name = "";
            var size = 0;
            var numberOfPages = 0;
            var udc = "";
            var format = Format.FB2;
            int year = DateTime.Now.Year;

            try
            {
                if (Controls.OfType<RadioButton>().Any(r => r.Checked) == false || textBoxName.Text == "" || textBoxSize.Text == "" || textBoxNumberOfPages.Text == "" || textBoxUDK.Text == "")
                    throw new Exception("Заполните поля!");
                if (textBoxName.Text.Length > 30 || textBoxSize.Text.Length > 30 || textBoxNumberOfPages.Text.Length > 30 ||
                    textBoxUDK.Text.Length > 30)
                    throw new Exception("Превышен размер входных данных");

                name = textBoxName.Text;
                size = int.Parse(textBoxSize.Text);
                numberOfPages = int.Parse(textBoxNumberOfPages.Text);
                udc = textBoxUDK.Text;
                year = dateTimePickerYear.Value.Year;

                var checkedRadioButton = Controls.OfType<RadioButton>().First(r => r.Checked);
                switch (checkedRadioButton.Name)
                {
                    case "radioButtonFormatPDF":
                        format = Format.PDF;
                        break;
                    case "radioButtonFormatTXT":
                        format = Format.TXT;
                        break;
                    case "radioButtonFormatFB2":
                        format = Format.FB2;
                        break;
                    case "radioButtonFormatEPUB":
                        format = Format.EPUB;
                        break;
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Числа великоваты");
                return;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            var authorsList = new List<Author>(_authorsForm.CurrentAuthorsList);
            if (_authorsForm.textBoxName.Text == "" && _authorsForm.textBoxCountry.Text == "" && _authorsForm.textBoxID.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните информацию об авторе!");
                return;
            }
            var bookFile = new FileBook(format, size, name, udc, numberOfPages, year, _authorsForm.textBoxName.Text, _authorsForm.textBoxCountry.Text, Convert.ToInt32(_authorsForm.textBoxID.Text));
            var results = new List<ValidationResult>();
            var context = new ValidationContext(bookFile);
            if (Validator.TryValidateObject(bookFile, context, results, true) == false)
            {
                var errorString = new StringBuilder();

                foreach (var validationResult in results)
                {
                    errorString.Append(validationResult.ErrorMessage + "\n");
                }
                MessageBox.Show(errorString.ToString());
                return;
            }
            listBoxInfo.Items.Add(bookFile);

            _authorsForm.Clear();

        }

        private void textBoxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) return;
            e.Handled = true;
        }

        private void textBoxUDK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46) return;
            e.Handled = true;
        }

        private void textBoxNumberOfPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) return;
            e.Handled = true;
        }

        private void listBoxBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBookFile = ((ListBox)sender).SelectedItem as FileBook;

            if (selectedBookFile == null) return;
        }

        private void textBoxDigitsOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) return;
            e.Handled = true;
        }


        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            var BookFilesList = new List<FileBook>();
            using (var reader = new StreamReader(@"../../Json/DB.json"))
            {
                BookFilesList = JsonConvert.DeserializeObject<List<FileBook>>(reader.ReadToEnd());
            }

            foreach (var bookFile in BookFilesList) listBoxInfo.Items.Add(bookFile);
        }

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            var BookFilesList = (from object item in listBoxInfo.Items select item as FileBook).ToList();

            using (var reader = new StreamWriter(@"D:\University\4th_term\ООП\Lab3\Lab2\JSON\Lab2.json"))
            {
                string jsonString = JsonConvert.SerializeObject(BookFilesList);
                reader.Write(jsonString);
            }
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _searchForm.Show();
            _searchForm.GetBookFilesFromBaseListbox(listBoxInfo.Items);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор : SVY , Версия : 1.0");
        }

        private void поНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedBookFiles = listBoxInfo.Items.OfType<FileBook>().OrderBy(x => x.Name).ToList();
            listBoxInfo.Items.Clear();

            foreach (var sortedBookFile in sortedBookFiles)
            {
                listBoxInfo.Items.Add(sortedBookFile);
            }
        }

        private void датеЗагрузкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedBookFiles = listBoxInfo.Items.OfType<FileBook>().OrderBy(x => x.Year).ToList();
            listBoxInfo.Items.Clear();

            foreach (var sortedBookFile in sortedBookFiles)
            {
                listBoxInfo.Items.Add(sortedBookFile);
            }
        }

        private void toolStripButtonClearBase_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
        }

        private void панельИнструментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = toolStrip1.Visible == false;
        }
    }
}