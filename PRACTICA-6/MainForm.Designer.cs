/*
 * Created by SharpDevelop.
 * User: user
 * Date: 18/04/2013
 * Time: 09:22 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica6
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.producto1 = new System.Windows.Forms.MaskedTextBox();
			this.producto2 = new System.Windows.Forms.MaskedTextBox();
			this.producto3 = new System.Windows.Forms.MaskedTextBox();
			this.SUB = new System.Windows.Forms.MaskedTextBox();
			this.IVA1 = new System.Windows.Forms.MaskedTextBox();
			this.P1 = new System.Windows.Forms.Label();
			this.P2 = new System.Windows.Forms.Label();
			this.P3 = new System.Windows.Forms.Label();
			this.Subtotal = new System.Windows.Forms.Label();
			this.IVA = new System.Windows.Forms.Label();
			this.Total = new System.Windows.Forms.Label();
			this.total1 = new System.Windows.Forms.MaskedTextBox();
			this.Facturar = new System.Windows.Forms.Button();
			this.Limpiar = new System.Windows.Forms.Button();
			this.Subtotal1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// producto1
			// 
			this.producto1.Location = new System.Drawing.Point(82, 21);
			this.producto1.Name = "producto1";
			this.producto1.Size = new System.Drawing.Size(109, 20);
			this.producto1.TabIndex = 0;
			// 
			// producto2
			// 
			this.producto2.Location = new System.Drawing.Point(82, 71);
			this.producto2.Name = "producto2";
			this.producto2.Size = new System.Drawing.Size(110, 20);
			this.producto2.TabIndex = 1;
			// 
			// producto3
			// 
			this.producto3.Location = new System.Drawing.Point(82, 117);
			this.producto3.Name = "producto3";
			this.producto3.Size = new System.Drawing.Size(109, 20);
			this.producto3.TabIndex = 2;
			// 
			// SUB
			// 
			this.SUB.Enabled = false;
			this.SUB.Location = new System.Drawing.Point(82, 219);
			this.SUB.Name = "SUB";
			this.SUB.Size = new System.Drawing.Size(109, 20);
			this.SUB.TabIndex = 3;
			// 
			// IVA1
			// 
			this.IVA1.Enabled = false;
			this.IVA1.Location = new System.Drawing.Point(82, 241);
			this.IVA1.Name = "IVA1";
			this.IVA1.Size = new System.Drawing.Size(109, 20);
			this.IVA1.TabIndex = 4;
			this.IVA1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox5MaskInputRejected);
			// 
			// P1
			// 
			this.P1.Location = new System.Drawing.Point(8, 23);
			this.P1.Name = "P1";
			this.P1.Size = new System.Drawing.Size(59, 17);
			this.P1.TabIndex = 5;
			this.P1.Text = "Producto 1";
			// 
			// P2
			// 
			this.P2.Location = new System.Drawing.Point(8, 70);
			this.P2.Name = "P2";
			this.P2.Size = new System.Drawing.Size(68, 20);
			this.P2.TabIndex = 6;
			this.P2.Text = "Producto 2";
			// 
			// P3
			// 
			this.P3.Location = new System.Drawing.Point(8, 117);
			this.P3.Name = "P3";
			this.P3.Size = new System.Drawing.Size(69, 19);
			this.P3.TabIndex = 7;
			this.P3.Text = "Producto 3";
			// 
			// Subtotal
			// 
			this.Subtotal.Location = new System.Drawing.Point(0, 0);
			this.Subtotal.Name = "Subtotal";
			this.Subtotal.Size = new System.Drawing.Size(100, 23);
			this.Subtotal.TabIndex = 14;
			// 
			// IVA
			// 
			this.IVA.Location = new System.Drawing.Point(12, 241);
			this.IVA.Name = "IVA";
			this.IVA.Size = new System.Drawing.Size(69, 23);
			this.IVA.TabIndex = 9;
			this.IVA.Text = "IVA";
			// 
			// Total
			// 
			this.Total.Location = new System.Drawing.Point(8, 293);
			this.Total.Name = "Total";
			this.Total.Size = new System.Drawing.Size(68, 21);
			this.Total.TabIndex = 10;
			this.Total.Text = "Total";
			// 
			// total1
			// 
			this.total1.Enabled = false;
			this.total1.Location = new System.Drawing.Point(82, 290);
			this.total1.Name = "total1";
			this.total1.Size = new System.Drawing.Size(109, 20);
			this.total1.TabIndex = 11;
			// 
			// Facturar
			// 
			this.Facturar.Location = new System.Drawing.Point(22, 364);
			this.Facturar.Name = "Facturar";
			this.Facturar.Size = new System.Drawing.Size(87, 29);
			this.Facturar.TabIndex = 12;
			this.Facturar.Text = "Facturar";
			this.Facturar.UseVisualStyleBackColor = true;
			this.Facturar.Click += new System.EventHandler(this.FacturarClick);
			// 
			// Limpiar
			// 
			this.Limpiar.Location = new System.Drawing.Point(143, 363);
			this.Limpiar.Name = "Limpiar";
			this.Limpiar.Size = new System.Drawing.Size(87, 29);
			this.Limpiar.TabIndex = 13;
			this.Limpiar.Text = "Limpiar";
			this.Limpiar.UseVisualStyleBackColor = true;
			this.Limpiar.Click += new System.EventHandler(this.LimpiarClick);
			// 
			// Subtotal1
			// 
			this.Subtotal1.Location = new System.Drawing.Point(8, 219);
			this.Subtotal1.Name = "Subtotal1";
			this.Subtotal1.Size = new System.Drawing.Size(51, 14);
			this.Subtotal1.TabIndex = 15;
			this.Subtotal1.Text = "Subtotal";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 404);
			this.Controls.Add(this.Subtotal1);
			this.Controls.Add(this.Limpiar);
			this.Controls.Add(this.Facturar);
			this.Controls.Add(this.total1);
			this.Controls.Add(this.Total);
			this.Controls.Add(this.IVA);
			this.Controls.Add(this.Subtotal);
			this.Controls.Add(this.P3);
			this.Controls.Add(this.P2);
			this.Controls.Add(this.P1);
			this.Controls.Add(this.IVA1);
			this.Controls.Add(this.SUB);
			this.Controls.Add(this.producto3);
			this.Controls.Add(this.producto2);
			this.Controls.Add(this.producto1);
			this.Name = "MainForm";
			this.Text = "Practica6";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label Subtotal1;
		private System.Windows.Forms.Button Limpiar;
		private System.Windows.Forms.Button Facturar;
		private System.Windows.Forms.MaskedTextBox total1;
		private System.Windows.Forms.Label Total;
		private System.Windows.Forms.Label IVA;
		private System.Windows.Forms.Label Subtotal;
		private System.Windows.Forms.Label P3;
		private System.Windows.Forms.Label P2;
		private System.Windows.Forms.Label P1;
		private System.Windows.Forms.MaskedTextBox IVA1;
		private System.Windows.Forms.MaskedTextBox SUB;
		private System.Windows.Forms.MaskedTextBox producto3;
		private System.Windows.Forms.MaskedTextBox producto2;
		private System.Windows.Forms.MaskedTextBox producto1;
	}
}
