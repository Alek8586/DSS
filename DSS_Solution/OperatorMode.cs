using System;
using System.Windows.Forms;

namespace DSS
{
    public partial class OperatorMode : Form
    {
        public OperatorMode()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void buttonToSuplliersForm_Click(object sender, EventArgs e)
        {
            Suppliers SuppliersForm = new Suppliers();
            SuppliersForm.Show();
        }

        private void buttonProjects_Click(object sender, EventArgs e)
        {
            Projects ProjectsForm = new Projects();
            ProjectsForm.Show();
        }

        private void buttonToLogInForm_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
            this.Hide();
        }

        private void FormOperatorMode_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
