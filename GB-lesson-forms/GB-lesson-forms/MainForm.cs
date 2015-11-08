﻿using System;
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
		Random rnd;

		public MainForm()
		{
			rnd = new Random();
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

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			int num1 = Convert.ToInt32(udGenMin.Value);
			int num2 = Convert.ToInt32(udGenMax.Value);
			int randnum = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2) + 1);
			generatorLabel.Text = randnum.ToString();
			generatorHistory.AppendText(randnum + "\n");
			if (generatorUniques.Text.IndexOf(randnum.ToString()) == -1)
			{
				generatorUniques.AppendText(randnum + "\n");
			}
		}

		private void genbtnClear_Click(object sender, EventArgs e)
		{
			generatorLabel.Text = "0";
			generatorHistory.Clear();
			generatorUniques.Clear();
		}

		private void genBtnCopy_Click(object sender, EventArgs e)
		{
			if(generatorHistory.Text != "")
			{
				Clipboard.SetText(generatorHistory.Text);
			}
		}

		private void insertDateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			notepad.AppendText(DateTime.Now.ToShortDateString() + " ");
		}

		private void insertTimeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			notepad.AppendText(DateTime.Now.ToShortTimeString() + " ");
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				notepad.LoadFile("notepad.rtf");
			}
			catch
			{
				MessageBox.Show("Failed loading file"); 
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				notepad.SaveFile("notepad.rtf");
			}
			catch
			{
				MessageBox.Show("Failed saving file"); 
			}
		}
	}
}
