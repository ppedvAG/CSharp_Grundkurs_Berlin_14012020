using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloWinforms
{
    public partial class Form1 : Form
    {
        int klickCount = 0;


        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            klickCount++;
            textBox1.BackColor = Color.Magenta;
            textBox1.Left += 3;

            button1.Text = klickCount + " klicks";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // DialogResult dialogResult = MessageBox.Show("Dies ist eine Meldung", "Nachrichtenfenster", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            //if (dialogResult == DialogResult.Yes)
            //{

            //}
            Cursor.Current = Cursors.WaitCursor;

            Thread.Sleep(5000);

            Cursor.Current = Cursors.Default;



            //this.Close();
        }
    }
}
