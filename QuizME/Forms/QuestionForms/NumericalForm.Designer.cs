using System.ComponentModel;

namespace QuizME.Forms.QuestionForms
{
	partial class NumericalForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gbNumerical = new System.Windows.Forms.GroupBox();
			this.lblXMin = new System.Windows.Forms.Label();
			this.lblMaxValueX = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbXMin = new System.Windows.Forms.TextBox();
			this.tbXMax = new System.Windows.Forms.TextBox();
			this.tbYMin = new System.Windows.Forms.TextBox();
			this.tbYMax = new System.Windows.Forms.TextBox();
			this.cbOperator = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.gbNumerical.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbNumerical
			// 
			this.gbNumerical.Controls.Add(this.label3);
			this.gbNumerical.Controls.Add(this.cbOperator);
			this.gbNumerical.Controls.Add(this.tbYMax);
			this.gbNumerical.Controls.Add(this.tbYMin);
			this.gbNumerical.Controls.Add(this.tbXMax);
			this.gbNumerical.Controls.Add(this.tbXMin);
			this.gbNumerical.Controls.Add(this.label5);
			this.gbNumerical.Controls.Add(this.label4);
			this.gbNumerical.Controls.Add(this.lblMaxValueX);
			this.gbNumerical.Controls.Add(this.lblXMin);
			this.gbNumerical.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.gbNumerical.Location = new System.Drawing.Point(31, 107);
			this.gbNumerical.Name = "gbNumerical";
			this.gbNumerical.Size = new System.Drawing.Size(751, 121);
			this.gbNumerical.TabIndex = 8;
			this.gbNumerical.TabStop = false;
			this.gbNumerical.Text = "Numerical Question";
			// 
			// lblXMin
			// 
			this.lblXMin.Location = new System.Drawing.Point(36, 38);
			this.lblXMin.Name = "lblXMin";
			this.lblXMin.Size = new System.Drawing.Size(146, 23);
			this.lblXMin.TabIndex = 0;
			this.lblXMin.Text = "Minimum Value X:";
			// 
			// lblMaxValueX
			// 
			this.lblMaxValueX.Location = new System.Drawing.Point(36, 77);
			this.lblMaxValueX.Name = "lblMaxValueX";
			this.lblMaxValueX.Size = new System.Drawing.Size(146, 23);
			this.lblMaxValueX.TabIndex = 1;
			this.lblMaxValueX.Text = "Maximum Value X:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(290, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(146, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Minimum Value Y:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(290, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(146, 23);
			this.label5.TabIndex = 3;
			this.label5.Text = "Maximum Value Y:";
			// 
			// tbXMin
			// 
			this.tbXMin.Location = new System.Drawing.Point(188, 35);
			this.tbXMin.Name = "tbXMin";
			this.tbXMin.Size = new System.Drawing.Size(90, 26);
			this.tbXMin.TabIndex = 4;
			// 
			// tbXMax
			// 
			this.tbXMax.Location = new System.Drawing.Point(188, 74);
			this.tbXMax.Name = "tbXMax";
			this.tbXMax.Size = new System.Drawing.Size(90, 26);
			this.tbXMax.TabIndex = 5;
			// 
			// tbYMin
			// 
			this.tbYMin.Location = new System.Drawing.Point(442, 35);
			this.tbYMin.Name = "tbYMin";
			this.tbYMin.Size = new System.Drawing.Size(90, 26);
			this.tbYMin.TabIndex = 6;
			// 
			// tbYMax
			// 
			this.tbYMax.Location = new System.Drawing.Point(442, 74);
			this.tbYMax.Name = "tbYMax";
			this.tbYMax.Size = new System.Drawing.Size(90, 26);
			this.tbYMax.TabIndex = 7;
			// 
			// cbOperator
			// 
			this.cbOperator.FormattingEnabled = true;
			this.cbOperator.Location = new System.Drawing.Point(668, 35);
			this.cbOperator.Name = "cbOperator";
			this.cbOperator.Size = new System.Drawing.Size(62, 28);
			this.cbOperator.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(581, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Operator:";
			// 
			// NumericalForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 264);
			this.Controls.Add(this.gbNumerical);
			this.Name = "NumericalForm";
			this.Text = "NumericalForm";
			this.Controls.SetChildIndex(this.gbNumerical, 0);
			this.gbNumerical.ResumeLayout(false);
			this.gbNumerical.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Label lblXMin;
		private System.Windows.Forms.Label lblMaxValueX;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbXMin;
		private System.Windows.Forms.TextBox tbXMax;
		private System.Windows.Forms.TextBox tbYMin;
		private System.Windows.Forms.TextBox tbYMax;
		private System.Windows.Forms.ComboBox cbOperator;
		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.GroupBox gbNumerical;

		#endregion
	}
}