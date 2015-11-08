using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GB_lesson_forms
{
	public partial class MainForm : Form
	{
		int counter = 0;

		public MainForm()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Blah blah blah...", "About", MessageBoxButtons.OK);
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			counter = (counter <= int.MaxValue - 1) ? counter + 1 : counter;
			counterLabel.Text = counter.ToString();
		}

		private void btnMinus_Click(object sender, EventArgs e)
		{
			counter = (counter >= int.MinValue + 1) ? counter - 1 : counter;
			counterLabel.Text = counter.ToString();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			counter = 0;
			counterLabel.Text = counter.ToString();
		}
	}
}
