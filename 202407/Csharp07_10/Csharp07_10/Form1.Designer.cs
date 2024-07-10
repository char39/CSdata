namespace Csharp07_10
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
            First_Label = new Label();
            Text_num1 = new TextBox();
            Second_Label = new Label();
            Text_num2 = new TextBox();
            Ready_Label = new Label();
            Line_Label = new Label();
            Result_Label = new Label();
            Text_Result = new TextBox();
            Plus_Button = new Button();
            Clear_Button = new Button();
            Minus_Button = new Button();
            Multi_Button = new Button();
            Divide_Button = new Button();
            SuspendLayout();
            // 
            // First_Label
            // 
            First_Label.AutoSize = true;
            First_Label.Font = new Font("돋움", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            First_Label.Location = new Point(74, 55);
            First_Label.Name = "First_Label";
            First_Label.Size = new Size(144, 27);
            First_Label.TabIndex = 0;
            First_Label.Text = "첫 번째 수";
            // 
            // Text_num1
            // 
            Text_num1.Font = new Font("돋움", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Text_num1.Location = new Point(308, 52);
            Text_num1.Name = "Text_num1";
            Text_num1.Size = new Size(341, 39);
            Text_num1.TabIndex = 1;
            // 
            // Second_Label
            // 
            Second_Label.AutoSize = true;
            Second_Label.Font = new Font("돋움", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Second_Label.Location = new Point(74, 135);
            Second_Label.Name = "Second_Label";
            Second_Label.Size = new Size(144, 27);
            Second_Label.TabIndex = 0;
            Second_Label.Text = "두 번째 수";
            // 
            // Text_num2
            // 
            Text_num2.Font = new Font("돋움", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Text_num2.Location = new Point(308, 132);
            Text_num2.Name = "Text_num2";
            Text_num2.Size = new Size(341, 39);
            Text_num2.TabIndex = 1;
            // 
            // Ready_Label
            // 
            Ready_Label.AutoSize = true;
            Ready_Label.Font = new Font("돋움", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Ready_Label.Location = new Point(105, 239);
            Ready_Label.Name = "Ready_Label";
            Ready_Label.Size = new Size(76, 21);
            Ready_Label.TabIndex = 2;
            Ready_Label.Text = "Ready!";
            // 
            // Line_Label
            // 
            Line_Label.AutoSize = true;
            Line_Label.Font = new Font("돋움", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Line_Label.Location = new Point(219, 239);
            Line_Label.Name = "Line_Label";
            Line_Label.Size = new Size(514, 21);
            Line_Label.TabIndex = 2;
            Line_Label.Text = "------------------------------------------";
            // 
            // Result_Label
            // 
            Result_Label.AutoSize = true;
            Result_Label.Font = new Font("돋움", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Result_Label.Location = new Point(105, 315);
            Result_Label.Name = "Result_Label";
            Result_Label.Size = new Size(68, 27);
            Result_Label.TabIndex = 0;
            Result_Label.Text = "결과";
            // 
            // Text_Result
            // 
            Text_Result.Font = new Font("돋움", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Text_Result.Location = new Point(308, 312);
            Text_Result.Name = "Text_Result";
            Text_Result.Size = new Size(341, 39);
            Text_Result.TabIndex = 1;
            // 
            // Plus_Button
            // 
            Plus_Button.Font = new Font("돋움", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Plus_Button.Location = new Point(308, 386);
            Plus_Button.Name = "Plus_Button";
            Plus_Button.Size = new Size(55, 38);
            Plus_Button.TabIndex = 3;
            Plus_Button.Text = "+";
            Plus_Button.UseVisualStyleBackColor = true;
            Plus_Button.Click += Plus_Button_Click;
            // 
            // Clear_Button
            // 
            Clear_Button.Font = new Font("돋움", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Clear_Button.Location = new Point(93, 386);
            Clear_Button.Name = "Clear_Button";
            Clear_Button.Size = new Size(88, 38);
            Clear_Button.TabIndex = 4;
            Clear_Button.Text = "Clear";
            Clear_Button.UseVisualStyleBackColor = true;
            Clear_Button.Click += Clear_Button_Click;
            // 
            // Minus_Button
            // 
            Minus_Button.Font = new Font("돋움", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Minus_Button.Location = new Point(404, 386);
            Minus_Button.Name = "Minus_Button";
            Minus_Button.Size = new Size(55, 38);
            Minus_Button.TabIndex = 5;
            Minus_Button.Text = "-";
            Minus_Button.UseVisualStyleBackColor = true;
            Minus_Button.Click += Minus_Button_Click;
            // 
            // Multi_Button
            // 
            Multi_Button.Font = new Font("돋움", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Multi_Button.Location = new Point(500, 386);
            Multi_Button.Name = "Multi_Button";
            Multi_Button.Size = new Size(55, 38);
            Multi_Button.TabIndex = 6;
            Multi_Button.Text = "*";
            Multi_Button.UseVisualStyleBackColor = true;
            Multi_Button.Click += Multi_Button_Click;
            // 
            // Divide_Button
            // 
            Divide_Button.Font = new Font("돋움", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Divide_Button.Location = new Point(594, 384);
            Divide_Button.Name = "Divide_Button";
            Divide_Button.Size = new Size(55, 38);
            Divide_Button.TabIndex = 7;
            Divide_Button.Text = "/";
            Divide_Button.UseVisualStyleBackColor = true;
            Divide_Button.Click += Divide_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Controls.Add(Divide_Button);
            Controls.Add(Multi_Button);
            Controls.Add(Minus_Button);
            Controls.Add(Clear_Button);
            Controls.Add(Plus_Button);
            Controls.Add(Line_Label);
            Controls.Add(Ready_Label);
            Controls.Add(Text_Result);
            Controls.Add(Text_num2);
            Controls.Add(Text_num1);
            Controls.Add(Result_Label);
            Controls.Add(Second_Label);
            Controls.Add(First_Label);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label First_Label;
        private TextBox Text_num1;
        private Label Second_Label;
        private TextBox Text_num2;
        private Label Ready_Label;
        private Label Line_Label;
        private Label Result_Label;
        private TextBox Text_Result;
        private Button Plus_Button;
        private Button Clear_Button;
        private Button Minus_Button;
        private Button Multi_Button;
        private Button Divide_Button;
    }
}
