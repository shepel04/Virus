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
    public partial class DrawForm : Form
    {
        public DrawForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PlayField_Player.ActiveForm.Close();
            PlayField_Player newField = new PlayField_Player();
            newField.Size = new Size(800, 400);
            newField.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            PlayField_Player.ActiveForm.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void DrawForm_Load(object sender, EventArgs e)
        {

        }
    }
}
