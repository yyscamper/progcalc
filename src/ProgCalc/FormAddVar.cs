using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CalcEngine;

namespace yyscamper.ProgCalc
{
	public partial class FormAddVar : Form
	{
		private VariableInputListen m_listen = null;
		private VarChangeMode m_varChangeMode = VarChangeMode.ADD_NEW;

		public FormAddVar()
		{
			InitializeComponent();
		}

		public FormAddVar(VariableInputListen listen, 
					string title, string varName, object varValue, VarChangeMode mode)
		{
			InitializeComponent();
			m_listen = listen;
			this.Text = title;
			if (varName != null)
				tboxVarName.Text = varName;
			if (varValue != null)
				tboxVarValue.Text = varValue.ToString();
			m_varChangeMode = mode;
			if (m_varChangeMode == VarChangeMode.UPDATE)
				tboxVarName.Enabled = false;
		}

		private void FormAddVar_Load(object sender, EventArgs e)
		{

		}

		private void btnCancle_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (tboxVarValue.Text.Trim().Length <= 0)
			{
				MessageBox.Show("Value is emptry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (tboxVarName.Text.Trim().Length <= 0)
			{
				MessageBox.Show("Name is emptry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			/*
			try
			{
				ExpTool.GetInstance().Eva(tboxVarValue.Text, CalcEngine.IntegerFormat.DEC, IntegerBits.BITS_64, false);
			}
			catch
			{
				if (DialogResult.No == MessageBox.Show(
					"The value cannot be evaluated, do you still want to " 
					+ (m_varChangeMode == VarChangeMode.UPDATE ? "update" : "add") + " it?",
					"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
					return;
				}
			}*/

			if (m_listen != null)
			{
				try
				{
					m_listen.VariableInputCallback(
						CalcVar.ValidateName(tboxVarName.Text.Trim()),
						CalcVar.ParseValue(tboxVarValue.Text),
						m_varChangeMode);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			this.Close();
		}
	}
}
