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
    public partial class RedWin : Form
    {
        public RedWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PlayField_Player.ActiveForm.Close();
            PlayField_Player newField = new PlayField_Player();
            
            newField.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            PlayField_Player.ActiveForm.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void RedWin_Load(object sender, EventArgs e)
        {

        }
    }
}
