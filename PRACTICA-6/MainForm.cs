/*
 * Created by SharpDevelop.
 * User: user
 * Date: 18/04/2013
 * Time: 09:22 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practica6
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void MaskedTextBox5MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			
		}
		
	
		
		void FacturarClick(object sender, EventArgs e)
		{
			double num1= double.Parse(producto1.Text);
			double num2= double.Parse(producto2.Text);
			double num3= double.Parse(producto3.Text);			
			
		    double suma= num1 + num2 + num3;
			double iva= suma *.16;
			double total= iva + suma;
			
			SUB.Text= suma.ToString();
			IVA1.Text= iva.ToString();
			total1.Text= total.ToString();
		}
		
		void LimpiarClick(object sender, EventArgs e)
		{
			int num1= 0;
			
			producto1.Text= num1.ToString();
			producto2.Text= num1.ToString();
			producto3.Text= num1.ToString();
			
			SUB.Text= num1.ToString();
			IVA1.Text= num1.ToString();
			total1.Text= num1.ToString();
		}
		
	}
}
