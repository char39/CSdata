namespace Csharp07_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  // 각종 위젯을 초기화하는 함수. 이 함수가 없으면 위젯이 생성되지 않는다.
        }
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()    // Clear 함수
        {
            this.Text_num1.Text = string.Empty;
            this.Text_num2.Text = string.Empty;
            this.Text_Result.Text = string.Empty;
            this.Ready_Label.Text = "Ready!";
        }
        private void Plus_Button_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(this.Text_num1.Text);
            double num2 = double.Parse(this.Text_num2.Text);
            double result = num1 + num2;
            this.Text_Result.Text = result.ToString();
            this.Ready_Label.Text = "+";
        }
        private void Minus_Button_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(this.Text_num1.Text);
            double num2 = double.Parse(this.Text_num2.Text);
            double result = num1 - num2;
            this.Text_Result.Text = result.ToString();
            this.Ready_Label.Text = "-";
        }
        private void Multi_Button_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(this.Text_num1.Text);
            double num2 = double.Parse(this.Text_num2.Text);
            double result = num1 * num2;
            this.Text_Result.Text = result.ToString();
            this.Ready_Label.Text = "*";
        }
        private void Divide_Button_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(this.Text_num1.Text);
            double num2 = double.Parse(this.Text_num2.Text);
            if(num2 == 0)
            {
                this.Text_Result.Text = "0 으로 나눌 수 없어요!";
                this.Ready_Label.Text = "/";
            }
            else
            {
                double result = num1 / num2;
                this.Text_Result.Text = result.ToString();
                this.Ready_Label.Text = "/";
            }
        }
    }
}
