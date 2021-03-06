using System;
using System.Windows;

namespace MHW_Save_Editor
{
    public partial class InputBox : Window
    {
        public InputBox(string question, string defaultAnswer = "", int sizeLimit = 0)
        {
            InitializeComponent();
            lblQuestion.Content = question;
            txtAnswer.Text = defaultAnswer;
            txtAnswer.MaxLength = sizeLimit;
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtAnswer.SelectAll();
            txtAnswer.Focus();
        }

        public string Answer
        {
            get { return txtAnswer.Text; }
        }
    }
}
