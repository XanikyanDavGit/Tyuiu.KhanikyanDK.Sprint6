using System;
using System.Windows.Forms;
using Tyuiu.KhanikyanDK.Sprint6.Task0.V12.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.KhanikyanDK.Sprint6.Task0.V12
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(textBoxX.Text);
                double y = ds.Calculate(x);
                textBoxResult.Text = y.ToString("F3");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное целое число для x", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПБ-23-1 Ханикян Давит Каренович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}