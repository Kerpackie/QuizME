using System.ComponentModel;

namespace QuizME.Forms.QuestionForms
{
	partial class TrueFalseForm
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
			this.gbTrueFalse = new System.Windows.Forms.GroupBox();
			this.rbTrue = new System.Windows.Forms.RadioButton();
			this.rbFalse = new System.Windows.Forms.RadioButton();
			this.lblAnswer = new System.Windows.Forms.Label();
			this.gbTrueFalse.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbTrueFalse
			// 
			this.gbTrueFalse.Controls.Add(this.lblAnswer);
			this.gbTrueFalse.Controls.Add(this.rbFalse);
			this.gbTrueFalse.Controls.Add(this.rbTrue);
			this.gbTrueFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.gbTrueFalse.Location = new System.Drawing.Point(31, 111);
			this.gbTrueFalse.Name = "gbTrueFalse";
			this.gbTrueFalse.Size = new System.Drawing.Size(750, 102);
			this.gbTrueFalse.TabIndex = 8;
			this.gbTrueFalse.TabStop = false;
			this.gbTrueFalse.Text = "True False";
			// 
			// rbTrue
			// 
			this.rbTrue.Location = new System.Drawing.Point(229, 44);
			this.rbTrue.Name = "rbTrue";
			this.rbTrue.Size = new System.Drawing.Size(104, 24);
			this.rbTrue.TabIndex = 0;
			this.rbTrue.TabStop = true;
			this.rbTrue.Text = "True";
			this.rbTrue.UseVisualStyleBackColor = true;
			// 
			// rbFalse
			// 
			this.rbFalse.Location = new System.Drawing.Point(453, 44);
			this.rbFalse.Name = "rbFalse";
			this.rbFalse.Size = new System.Drawing.Size(104, 24);
			this.rbFalse.TabIndex = 1;
			this.rbFalse.TabStop = true;
			this.rbFalse.Text = "False";
			this.rbFalse.UseVisualStyleBackColor = true;
			// 
			// lblAnswer
			// 
			this.lblAnswer.Location = new System.Drawing.Point(82, 46);
			this.lblAnswer.Name = "lblAnswer";
			this.lblAnswer.Size = new System.Drawing.Size(75, 23);
			this.lblAnswer.TabIndex = 2;
			this.lblAnswer.Text = "Answer:";
			// 
			// TrueFalseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 232);
			this.Controls.Add(this.gbTrueFalse);
			this.Name = "TrueFalseForm";
			this.Text = "TrueFalseForm";
			this.Controls.SetChildIndex(this.gbTrueFalse, 0);
			this.gbTrueFalse.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.RadioButton rbTrue;
		private System.Windows.Forms.RadioButton rbFalse;
		private System.Windows.Forms.Label lblAnswer;

		private System.Windows.Forms.GroupBox gbTrueFalse;

		private System.Windows.Forms.GroupBox gbPreview;

		#endregion
	}
}