using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus
{
    public partial class LoseForm : Form
    {
        public LoseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PlayField.ActiveForm.Close();
            PlayField newField = new PlayField();
            newField.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            PlayField.ActiveForm.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
