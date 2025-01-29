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
            inputTextBox = new TextBox();
            convertButton = new Button();
            outputTextBox = new TextBox();
            convertTxt = new Button();
            convertPdf = new Button();
            convertAndTranslatebutton = new Button();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.BackColor = Color.Ivory;
            inputTextBox.Location = new Point(12, 12);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(1228, 123);
            inputTextBox.TabIndex = 0;
            // 
            // convertButton
            // 
            convertButton.BackColor = Color.Honeydew;
            convertButton.FlatStyle = FlatStyle.Flat;
            convertButton.Location = new Point(12, 141);
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
            outputTextBox.Location = new Point(12, 170);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(430, 413);
            outputTextBox.TabIndex = 2;
            // 
            // convertTxt
            // 
            convertTxt.BackColor = Color.Honeydew;
            convertTxt.FlatStyle = FlatStyle.Flat;
            convertTxt.Location = new Point(93, 141);
            convertTxt.Name = "convertTxt";
            convertTxt.Size = new Size(96, 23);
            convertTxt.TabIndex = 3;
            convertTxt.Text = "Open TxT";
            convertTxt.UseVisualStyleBackColor = false;
            convertTxt.Click += convertTxt_Click;
            // 
            // convertPdf
            // 
            convertPdf.BackColor = Color.Honeydew;
            convertPdf.FlatStyle = FlatStyle.Flat;
            convertPdf.Location = new Point(195, 141);
            convertPdf.Name = "convertPdf";
            convertPdf.Size = new Size(96, 23);
            convertPdf.TabIndex = 4;
            convertPdf.Text = "Open Pdf";
            convertPdf.UseVisualStyleBackColor = false;
            convertPdf.Click += convertPdf_Click;
            // 
            // convertAndTranslatebutton
            // 
            convertAndTranslatebutton.BackColor = Color.Honeydew;
            convertAndTranslatebutton.FlatStyle = FlatStyle.Flat;
            convertAndTranslatebutton.Location = new Point(297, 141);
            convertAndTranslatebutton.Name = "convertAndTranslatebutton";
            convertAndTranslatebutton.Size = new Size(145, 23);
            convertAndTranslatebutton.TabIndex = 5;
            convertAndTranslatebutton.Text = "Convert and Translate";
            convertAndTranslatebutton.UseVisualStyleBackColor = false;
            convertAndTranslatebutton.Click += convertAndTranslatebutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1252, 595);
            Controls.Add(convertAndTranslatebutton);
            Controls.Add(convertPdf);
            Controls.Add(convertTxt);
            Controls.Add(outputTextBox);
            Controls.Add(convertButton);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputTextBox;
        private Button convertButton;
        private TextBox outputTextBox;
        private Button convertTxt;
        private Button convertPdf;
        private Button convertAndTranslatebutton;
    }
}
