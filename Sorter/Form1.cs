namespace Sorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComboBoxItems();
            toolTip.SetToolTip(txtInput, "������� �����");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                var a = new Logic();
                a.Text = txtInput.Text;
                a.Sort = cmbBox.SelectedItem.ToString();
                a.Sorting();
                txtOutput.Text = a.Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ComboBoxItems()
        {
            cmbBox.Items.Add("���");
            cmbBox.Items.Add("���");
            cmbBox.Items.Add("���");
            cmbBox.Items.Add("���");
            cmbBox.Items.Add("���");
            cmbBox.Items.Add("���");
            cmbBox.SelectedIndex = 0;
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != '�' & e.KeyChar != '�' & e.KeyChar != '�' & e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnOk.Focus();
            }
        }

        private async void Error(Control control, string text)
        {
            eProvider.SetError(control, text);
            await Task.Delay(TimeSpan.FromSeconds(5));
            eProvider.SetError(txtInput, string.Empty);
        }
    }
}