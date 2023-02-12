using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Calculator : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Calculator()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            labelDiag.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
            label8.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            labelResult.BackColor = System.Drawing.Color.Transparent;
            labelResultKkal.BackColor = System.Drawing.Color.Transparent;
            labelHiddenWeight.BackColor = System.Drawing.Color.Transparent;
            labelHiddenTime.BackColor = System.Drawing.Color.Transparent;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            player.SoundLocation = "Китайская-Коммунистическая-Песня-_2_-_256-kbps_.wav";
            player.Play();
        }

        

        

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int height = int.Parse(textBoxHeight.Text);
                if(height < 0 || height > 200)
                    throw new ArgumentException();
            }
            catch
            {
                MessageBox.Show("Некорректный рост");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSex.SelectedIndex == -1 && textBoxWeight.Text == "" && textBoxHeight.Text == ""
                    && textBoxAge.Text == "" && comboBoxTarget.SelectedIndex == -1)
                    throw new NullReferenceException();
                
                int height = int.Parse(textBoxHeight.Text);
                int weight = int.Parse(textBoxWeight.Text);
                  

                int result = checked(weight / ((height * height) / 10000));
                if (result < 16)
                {
                    labelDiag.Text = "Крайний недостаток веса";
                }
                else if (result > 16 && result < 18)
                    labelDiag.Text = "Недостаток в весе";
                else if (result > 18 && result < 25)
                    labelDiag.Text = "Нормальный вес тела";
                else if (result > 25 && result < 30)
                    labelDiag.Text = "Избыточная масса тела";
                else if (result > 30 && result < 35)
                    labelDiag.Text = "Ожирение(Класс 1)";
                else if (result > 35 && result < 40)
                    labelDiag.Text = "Ожирение(Класс 2)";
                else if (result > 40)
                    labelDiag.Text = "Ожирение(Класс 3)";

                var comboBoxTargetText = comboBoxTarget.Text;
                if (comboBoxTargetText == "Поддержание веса и размеров")
                {
                    labelResultKkal.Text = result.ToString();
                    labelResult.Text = new Random().Next(1900, 3000).ToString();
                }
                else
                {
                    int HiddenTime = int.Parse(textBoxHiddenTime.Text);
                    int HiddenWeight = int.Parse(textBoxHiddenWeight.Text);

                    if (comboBoxTargetText == "Увеличение веса")
                    {
                        if (HiddenWeight <= weight)
                            throw new ApplicationException();
                        labelResultKkal.Text = result.ToString();
                        labelResult.Text = checked((new Random().Next(1, 10000) + (HiddenWeight - weight)) / HiddenTime).ToString();
                    }
                    else if(comboBoxTargetText == "Снижение веса")
                    {
                        if (HiddenWeight >= weight)
                            throw new ApplicationException();
                        labelResultKkal.Text = result.ToString();
                        labelResult.Text = checked((new Random().Next(1000, 10000) + (weight - HiddenWeight)) / HiddenTime).ToString();
                    }
                }
            }
            catch (ApplicationException)
            {
                MessageBox.Show("Желаемый вес не соотносится с целью");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Заполните все поля!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxWeight_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int weight = int.Parse(textBoxWeight.Text);
                if (weight < 0 || weight > 160)
                    throw new ArgumentException();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Некорректный вес!!!!!");
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxAge_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int age = int.Parse(textBoxAge.Text);
                if (age < 0 || age > 99)
                    throw new ArgumentException();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Некорректный возраст!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxHiddenWeight_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int weighthidden = int.Parse(textBoxHiddenWeight.Text);
                if (weighthidden < 0 || weighthidden > 200)
                    throw new ArgumentException();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Некорректный желаемый вес!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxHiddenTime_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int timehidden = int.Parse(textBoxHiddenTime.Text);
                if (timehidden < 0 || timehidden > 72)
                    throw new ArgumentException();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Некорректный срок!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxTarget_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var targetText = (sender as ComboBox).Text;
            
            if (targetText == "Поддержание веса и размеров")
            {
                if (labelHiddenTime.Visible == false) return;
                labelHiddenTime.Visible = false;
                labelHiddenWeight.Visible = false;
                textBoxHiddenTime.Visible = false;
                textBoxHiddenWeight.Visible = false;
            }
            else
            {
                if (labelHiddenTime.Visible == true) return;
                labelHiddenTime.Visible = true;
                labelHiddenWeight.Visible = true;
                textBoxHiddenTime.Visible = true;
                textBoxHiddenWeight.Visible = true;
            }
        }
    }
}
