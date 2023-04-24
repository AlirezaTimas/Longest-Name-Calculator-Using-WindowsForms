namespace Longest_Name_Calculator_Using_WindowsForm
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
            StudentLabel = new Label();
            EnterButton = new Button();
            NameListBox = new ListBox();
            LengthListBox = new ListBox();
            StudentNameTextBox = new TextBox();
            StudentNumberListBox = new ListBox();
            StudentNumberTextBox = new TextBox();
            StudentNumberLabel = new Label();
            ResultButton = new Button();
            SuspendLayout();
            // 
            // StudentLabel
            // 
            StudentLabel.AutoSize = true;
            StudentLabel.Location = new Point(863, 136);
            StudentLabel.Margin = new Padding(2, 0, 2, 0);
            StudentLabel.Name = "StudentLabel";
            StudentLabel.Size = new Size(89, 19);
            StudentLabel.TabIndex = 0;
            StudentLabel.Text = "StudentLabel";
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(886, 294);
            EnterButton.Margin = new Padding(2);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(179, 52);
            EnterButton.TabIndex = 1;
            EnterButton.Text = "Enter";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // NameListBox
            // 
            NameListBox.FormattingEnabled = true;
            NameListBox.ItemHeight = 19;
            NameListBox.Location = new Point(10, 7);
            NameListBox.Margin = new Padding(2);
            NameListBox.Name = "NameListBox";
            NameListBox.Size = new Size(280, 517);
            NameListBox.TabIndex = 2;
            // 
            // LengthListBox
            // 
            LengthListBox.FormattingEnabled = true;
            LengthListBox.ItemHeight = 19;
            LengthListBox.Location = new Point(294, 7);
            LengthListBox.Margin = new Padding(2);
            LengthListBox.Name = "LengthListBox";
            LengthListBox.Size = new Size(290, 517);
            LengthListBox.TabIndex = 3;
            LengthListBox.SelectedIndexChanged += LengthListBox_SelectedIndexChanged;
            // 
            // StudentNameTextBox
            // 
            StudentNameTextBox.Location = new Point(886, 174);
            StudentNameTextBox.Margin = new Padding(2);
            StudentNameTextBox.Name = "StudentNameTextBox";
            StudentNameTextBox.Size = new Size(173, 26);
            StudentNameTextBox.TabIndex = 4;
            // 
            // StudentNumberListBox
            // 
            StudentNumberListBox.FormattingEnabled = true;
            StudentNumberListBox.ItemHeight = 19;
            StudentNumberListBox.Location = new Point(588, 7);
            StudentNumberListBox.Margin = new Padding(2);
            StudentNumberListBox.Name = "StudentNumberListBox";
            StudentNumberListBox.Size = new Size(271, 517);
            StudentNumberListBox.TabIndex = 5;
            // 
            // StudentNumberTextBox
            // 
            StudentNumberTextBox.Location = new Point(886, 248);
            StudentNumberTextBox.Margin = new Padding(2);
            StudentNumberTextBox.Name = "StudentNumberTextBox";
            StudentNumberTextBox.Size = new Size(173, 26);
            StudentNumberTextBox.TabIndex = 6;
            // 
            // StudentNumberLabel
            // 
            StudentNumberLabel.AutoSize = true;
            StudentNumberLabel.Location = new Point(863, 218);
            StudentNumberLabel.Margin = new Padding(2, 0, 2, 0);
            StudentNumberLabel.Name = "StudentNumberLabel";
            StudentNumberLabel.Size = new Size(45, 19);
            StudentNumberLabel.TabIndex = 7;
            StudentNumberLabel.Text = "label1";
            // 
            // ResultButton
            // 
            ResultButton.Location = new Point(886, 363);
            ResultButton.Margin = new Padding(2);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(179, 116);
            ResultButton.TabIndex = 8;
            ResultButton.Text = "Check";
            ResultButton.UseVisualStyleBackColor = true;
            ResultButton.Click += ResultButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 541);
            Controls.Add(ResultButton);
            Controls.Add(StudentNumberLabel);
            Controls.Add(StudentNumberTextBox);
            Controls.Add(StudentNumberListBox);
            Controls.Add(StudentNameTextBox);
            Controls.Add(LengthListBox);
            Controls.Add(NameListBox);
            Controls.Add(EnterButton);
            Controls.Add(StudentLabel);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentLabel;
        private Button EnterButton;
        private ListBox NameListBox;
        private ListBox LengthListBox;
        private TextBox StudentNameTextBox;
        private ListBox StudentNumberListBox;
        private TextBox StudentNumberTextBox;
        private Label StudentNumberLabel;
        private Button ResultButton;
    }
}