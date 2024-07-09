namespace Csharp07_09WinFormsApp
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
            num1Txt = new TextBox();
            num1_label = new Label();
            num2_label = new Label();
            num2Txt = new TextBox();
            btn1 = new Button();
            SuspendLayout();
            // 
            // num1Txt
            // 
            num1Txt.Font = new Font("돋움", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            num1Txt.Location = new Point(312, 25);
            num1Txt.Name = "num1Txt";
            num1Txt.Size = new Size(416, 50);
            num1Txt.TabIndex = 0;
            num1Txt.TextChanged += textBox1_TextChanged;
            // 
            // num1_label
            // 
            num1_label.AutoSize = true;
            num1_label.Font = new Font("돋움", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            num1_label.Location = new Point(43, 37);
            num1_label.Name = "num1_label";
            num1_label.Size = new Size(219, 27);
            num1_label.TabIndex = 1;
            num1_label.Text = "첫번째 숫자 입력";
            // 
            // num2_label
            // 
            num2_label.AutoSize = true;
            num2_label.Font = new Font("돋움", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            num2_label.Location = new Point(43, 115);
            num2_label.Name = "num2_label";
            num2_label.Size = new Size(219, 27);
            num2_label.TabIndex = 1;
            num2_label.Text = "두번째 숫자 입력";
            // 
            // num2Txt
            // 
            num2Txt.Font = new Font("돋움", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            num2Txt.Location = new Point(312, 103);
            num2Txt.Name = "num2Txt";
            num2Txt.Size = new Size(416, 50);
            num2Txt.TabIndex = 0;
            num2Txt.TextChanged += textBox1_TextChanged;
            // 
            // btn1
            // 
            btn1.Font = new Font("돋움", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn1.Location = new Point(109, 200);
            btn1.Name = "btn1";
            btn1.Size = new Size(89, 46);
            btn1.TabIndex = 2;
            btn1.Text = "+";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 425);
            Controls.Add(btn1);
            Controls.Add(num2_label);
            Controls.Add(num1_label);
            Controls.Add(num2Txt);
            Controls.Add(num1Txt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox num1Txt;
        private Label num1_label;
        private Label num2_label;
        private TextBox num2Txt;
        private Button btn1;
    }
}
