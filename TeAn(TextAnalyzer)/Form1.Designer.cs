namespace TeAn_TextAnalyzer_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            inputTextBox = new TextBox();
            convertButton = new Button();
            outputTextBox = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(698, 181);
            textBox1.TabIndex = 0;
            // 
            // inputTextBox
            // 
            inputTextBox.BackColor = Color.Ivory;
            inputTextBox.Location = new Point(12, 12);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(776, 236);
            inputTextBox.TabIndex = 0;
            // 
            // convertButton
            // 
            convertButton.BackColor = Color.Honeydew;
            convertButton.FlatStyle = FlatStyle.Flat;
            convertButton.Location = new Point(363, 270);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(75, 23);
            convertButton.TabIndex = 1;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = false;
            convertButton.Click += convertButton_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.BackColor = Color.Ivory;
            outputTextBox.Location = new Point(12, 345);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(776, 93);
            outputTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(outputTextBox);
            Controls.Add(convertButton);
            Controls.Add(inputTextBox);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox inputTextBox;
        private Button convertButton;
        private TextBox outputTextBox;
    }
}
