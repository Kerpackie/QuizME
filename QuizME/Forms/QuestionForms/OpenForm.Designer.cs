using System.ComponentModel;

namespace QuizME.Forms.QuestionForms
{
	partial class OpenForm
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
			this.gbOpenQuestion = new System.Windows.Forms.GroupBox();
			this.rtbNotes = new System.Windows.Forms.RichTextBox();
			this.lblNotes = new System.Windows.Forms.Label();
			this.gbOpenQuestion.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbOpenQuestion
			// 
			this.gbOpenQuestion.Controls.Add(this.lblNotes);
			this.gbOpenQuestion.Controls.Add(this.rtbNotes);
			this.gbOpenQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.gbOpenQuestion.Location = new System.Drawing.Point(36, 108);
			this.gbOpenQuestion.Name = "gbOpenQuestion";
			this.gbOpenQuestion.Size = new System.Drawing.Size(745, 323);
			this.gbOpenQuestion.TabIndex = 6;
			this.gbOpenQuestion.TabStop = false;
			this.gbOpenQuestion.Text = "Open Question";
			// 
			// rtbNotes
			// 
			this.rtbNotes.Location = new System.Drawing.Point(22, 60);
			this.rtbNotes.Name = "rtbNotes";
			this.rtbNotes.Size = new System.Drawing.Size(705, 243);
			this.rtbNotes.TabIndex = 0;
			this.rtbNotes.Text = "";
			// 
			// lblNotes
			// 
			this.lblNotes.Location = new System.Drawing.Point(22, 34);
			this.lblNotes.Name = "lblNotes";
			this.lblNotes.Size = new System.Drawing.Size(100, 23);
			this.lblNotes.TabIndex = 1;
			this.lblNotes.Text = "Notes:";
			// 
			// OpenForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gbOpenQuestion);
			this.Name = "OpenForm";
			this.Text = "OpenForm";
			this.Controls.SetChildIndex(this.gbOpenQuestion, 0);
			this.gbOpenQuestion.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.RichTextBox rtbNotes;
		private System.Windows.Forms.Label lblNotes;

		private System.Windows.Forms.GroupBox gbOpenQuestion;

		#endregion
	}
}