using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse_Turn
{
    public partial class Form1 : Form
    {
        private Panel[ , ] _chessBoardPanels;


        //int[ , ] ChessDesk = new int[n,m];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            const int titleSize = 40;
            const int gridSize = 12;
            var clr1 = Color.DarkGray;
            var clr2 = Color.White;

            _chessBoardPanels = new Panel[gridSize, gridSize];

            for (var n = 0; n < gridSize; n++)
            {
                for (var m = 0; m < gridSize; m++)
                {
                    var newPanel = new Panel
                    {
                        Size = new Size(titleSize, titleSize),
                        Location = new Point(titleSize * n, titleSize * m)
                    };
                    Controls.Add(newPanel);
                    _chessBoardPanels[n, m] = newPanel;

                    if (n % 2 == 0)
                        newPanel.BackColor = m % 2 != 0 ? clr1 : clr2;
                    else
                        newPanel.BackColor = m % 2 != 0 ? clr2 : clr1;
                }

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int n;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int m;
        }
    }
}
