namespace BryceGrahamExercise0Recursive
{
    partial class Exercise0Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.stringBox1 = new System.Windows.Forms.TextBox();
            this.stringBox2 = new System.Windows.Forms.TextBox();
            this.interleaveButton = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sumStringDifferenceButton = new System.Windows.Forms.Button();
            this.checkCharsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stringBox1
            // 
            this.stringBox1.Location = new System.Drawing.Point(90, 31);
            this.stringBox1.Name = "stringBox1";
            this.stringBox1.Size = new System.Drawing.Size(100, 20);
            this.stringBox1.TabIndex = 0;
            // 
            // stringBox2
            // 
            this.stringBox2.Location = new System.Drawing.Point(90, 57);
            this.stringBox2.Name = "stringBox2";
            this.stringBox2.Size = new System.Drawing.Size(100, 20);
            this.stringBox2.TabIndex = 1;
            // 
            // interleaveButton
            // 
            this.interleaveButton.Location = new System.Drawing.Point(90, 83);
            this.interleaveButton.Name = "interleaveButton";
            this.interleaveButton.Size = new System.Drawing.Size(109, 23);
            this.interleaveButton.TabIndex = 2;
            this.interleaveButton.Text = "Interleave Strings";
            this.interleaveButton.UseVisualStyleBackColor = true;
            this.interleaveButton.Click += new System.EventHandler(this.interleaveButton_Click);
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(32, 138);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(576, 96);
            this.displayBox.TabIndex = 3;
            this.displayBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "String 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "String 2";
            // 
            // sumStringDifferenceButton
            // 
            this.sumStringDifferenceButton.Location = new System.Drawing.Point(224, 83);
            this.sumStringDifferenceButton.Name = "sumStringDifferenceButton";
            this.sumStringDifferenceButton.Size = new System.Drawing.Size(127, 23);
            this.sumStringDifferenceButton.TabIndex = 6;
            this.sumStringDifferenceButton.Text = "Sum String Difference";
            this.sumStringDifferenceButton.UseVisualStyleBackColor = true;
            this.sumStringDifferenceButton.Click += new System.EventHandler(this.sumStringDifferenceButton_Click);
            // 
            // checkCharsButton
            // 
            this.checkCharsButton.Location = new System.Drawing.Point(389, 83);
            this.checkCharsButton.Name = "checkCharsButton";
            this.checkCharsButton.Size = new System.Drawing.Size(123, 23);
            this.checkCharsButton.TabIndex = 7;
            this.checkCharsButton.Text = "Check Characters";
            this.checkCharsButton.UseVisualStyleBackColor = true;
            this.checkCharsButton.Click += new System.EventHandler(this.checkCharsButton_Click);
            // 
            // Exercise0Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 261);
            this.Controls.Add(this.checkCharsButton);
            this.Controls.Add(this.sumStringDifferenceButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.interleaveButton);
            this.Controls.Add(this.stringBox2);
            this.Controls.Add(this.stringBox1);
            this.Name = "Exercise0Form";
            this.Text = "Exercise 0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stringBox1;
        private System.Windows.Forms.TextBox stringBox2;
        private System.Windows.Forms.Button interleaveButton;
        private System.Windows.Forms.RichTextBox displayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sumStringDifferenceButton;
        private System.Windows.Forms.Button checkCharsButton;
    }
}

