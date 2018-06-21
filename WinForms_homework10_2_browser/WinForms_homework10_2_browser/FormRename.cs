using System;
using System.Windows.Forms;

namespace WinForms_homework10_2_browser
{
    public partial class FormRename : Form
    {
        public FormRename()
        {
            InitializeComponent();
        }

        public FormRename(string newName) : this()
        {
            textBoxRenameField.Text = newName;
        }

        private void TextBoxRenameField_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRenameField.Text.Length == 0)
                buttonOK.Enabled = false;
            else
                buttonOK.Enabled = true;
        }
    }
}
