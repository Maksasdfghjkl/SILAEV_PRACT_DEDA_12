using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SILAEV_PRACT_DEDA_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Panel[] panel1 = new Panel[0];
        private TextBox[] txtbx = new TextBox[0];
        private int count = 0;
        private int x = 0;
        private int []c = new int[0];
        private int xPos = 10;
        private int yPos = 50;

        private void button1_Click(object sender, EventArgs e)
        {
            if (xPos + 110 > ClientSize.Width)
            {
                yPos += 110;
                xPos = 10;
            }
            if (yPos + 110 < ClientSize.Height)
            {
                Array.Resize(ref panel1, panel1.Length + 1);
                panel1[count] = new Panel();
                panel1[count].Location = new Point(xPos, yPos);
                Controls.Add(panel1[count]);
                xPos += 110;
                panel1[count].Name = "panel" + (count + 1).ToString();
                panel1[count].Size = new Size(100, 100);
                panel1[count].TabIndex = 2;
                panel1[count].BackColor = Color.AliceBlue;
                count++;
                Array.Resize(ref c, c.Length + 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 0;
            foreach(var panel in Controls.OfType<Panel>())
            {
                x++;
            }
            for (int i = 0; i < x; i++)
            {
                if (c[i] < 3)
                {
                    Array.Resize(ref txtbx, txtbx.Length + 1);
                    txtbx[i] = new TextBox();
                    txtbx[i].Text = "TextBox";
                    txtbx[i].Location = new Point(10, 10 * ((c[i] + 1) * 2));
                    txtbx[i].Size = new Size(80, 80);
                    Controls.OfType<Panel>().ToArray()[i].Controls.Add(txtbx[i]);
                }
                c[i]++;
            }
        }
    }
}
