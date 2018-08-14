using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace SB_test_win_form
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void СontextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Full Exit Application!!!
            Close();
        }

        private void AddDataButton_Click(object sender, EventArgs e)
        {
            AddDataToDBForms addDataToDBForms = new AddDataToDBForms();
            addDataToDBForms.Show();
            
        }
    }
}
