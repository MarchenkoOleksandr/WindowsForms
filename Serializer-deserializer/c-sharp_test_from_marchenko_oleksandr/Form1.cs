using System.Windows.Forms;

namespace c_sharp_test_from_marchenko_oleksandr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonRun_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButtonSerialize.Checked)
            {
                folderBrowserDialog1.Description = "Please select a path to the folder for packing:";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                else
                {
                    labelResult.Text = "Please wait! Serialization process...";
                    buttonRun.Enabled = false;
                    Update();
                    Packing.Serialization(folderBrowserDialog1.SelectedPath);
                    buttonRun.Enabled = true;
                    labelResult.Text = "";
                }
            }
            else
            {
                openFileDialog1.Title = "Please enter path to the serializated file *.bin";
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                folderBrowserDialog1.Description = "Please input a path to the destination folder for unpacking";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                else
                {
                    labelResult.Text = "Please wait! Deserialization process...";
                    buttonRun.Enabled = false;
                    Update();
                    Packing.Deserialization(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath);
                    buttonRun.Enabled = true;
                    labelResult.Text = "";
                }
            }
        }
    }
}