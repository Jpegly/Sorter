using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorterApp
{
    public partial class SorterForm : Form
    {
        public SorterForm()
        {
            InitializeComponent();
            ComboBoxItems();
        }

        //Обработчик нажатия кнопки 'Пуск'
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                var a = new Logic();
                a.Text = txtInput.Text;
                a.Rule = comboBox.SelectedItem.ToString();
                a.Sorting();
                txtOutput.Text = a.Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Заполнение combobox объектами
        void ComboBoxItems()
        {
            comboBox.Items.Add("КЗС");
            comboBox.Items.Add("КСЗ");
            comboBox.Items.Add("СКЗ");
            comboBox.Items.Add("СЗК");
            comboBox.Items.Add("ЗКС");
            comboBox.Items.Add("ЗСК");
            comboBox.SelectedIndex = 0;
        }

        //Оброботчик ввода символов в поле 'Входной массив'
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 'К' & e.KeyChar != 'к' & e.KeyChar != 'З' & e.KeyChar != 'з' 
                & e.KeyChar != 'С' & e.KeyChar != 'с' & e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnStart.Focus();
            }
        }
    }
}
