using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputerAssignment
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            new SelectForm().Show();
                this.Hide();
        }

        private void SaveOrderButton_Click(object sender, EventArgs e)
        {
            new ProductInfoForm().Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveOrderButton_Click_1(object sender, EventArgs e)
        {

        }

        private void ExItButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
