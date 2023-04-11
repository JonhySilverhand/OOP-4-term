using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class AuthorsForm : Form
    {
        public AuthorsForm()
        {
            InitializeComponent();
            CurrentAuthorsList = new List<Author>();
        }
        public List<Author> CurrentAuthorsList { get; private set; }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            //if (textBoxName.Text == "" || textBoxID.Text == "" || textBoxCountry.Text == "")
            //    return;
            try
            {
                if (textBoxName.Text.Length > 35 || textBoxID.Text.Length > 5 || textBoxCountry.Text.Length > 30)
                    throw new Exception("Превышен размер входных данных");
                if (textBoxName.Text == "" || textBoxID.Text == "" || textBoxCountry.Text == "")
                    throw new NullReferenceException();

                string name = textBoxName.Text;
                int id = int.Parse(textBoxID.Text);
                string country = textBoxCountry.Text;

                var newAuthor = new Author(name, country, id);
                CurrentAuthorsList.Add(newAuthor);
                listBoxAuthors.Items.Add(newAuthor);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Заполните все поля");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            CurrentAuthorsList.Clear();
            listBoxAuthors.Items.Clear();
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(GroupBox))
                    foreach (Control d in c.Controls)
                        if (d.GetType() == typeof(TextBox))
                            d.Text = string.Empty;

                if (c.GetType() == typeof(TextBox))
                    c.Text = string.Empty;
            }
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32) return;
            e.Handled = true;
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) return;
            e.Handled = true;
        }

        private void textBoxCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32) return;
            e.Handled = true;
        }
    }
}
