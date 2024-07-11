namespace Csharp07_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  // 각종 위젯을 초기화하는 함수. 이 함수가 없으면 위젯이 생성되지 않는다.
        }

        double Calculator(string sx, string sy, string op)      // Calculator 함수
        {
            if (string.IsNullOrEmpty(sx) || string.IsNullOrEmpty(sy))   // sx, sy가 비어있으면 예외처리
            {
                MessageBox.Show("이 공간은 비워둘 수 없습니다. 숫자를 다시 입력해주세요.");
                this.Clear();
                throw new Exception("이 공간은 비워둘 수 없습니다. 숫자를 다시 입력해주세요.");
            }
            if (!double.TryParse(sx, out double tryX) || !double.TryParse(sy, out double tryY))     // sx, sy가 숫자가 아니면 예외처리
            {
                MessageBox.Show("다른 문자를 입력할 수 없습니다. 숫자를 다시 입력해주세요.");
                this.Clear();
                throw new Exception("다른 문자를 입력할 수 없습니다. 숫자를 다시 입력해주세요.");
            }
            try
            {
                double x = double.Parse(sx.Trim());
                double y = double.Parse(sy.Trim());
                double result = 0;
                switch (op)    // 각 연산자에 따라 계산
                {
                    case "+": result = x + y; break;
                    case "-": result = x - y; break;
                    case "*": result = x * y; break;
                    case "/": result = x / y; break;
                }
                return result;
            }
            catch
            {
                MessageBox.Show("예외가 발생했습니다. 숫자를 다시 입력해주세요.");
                this.Clear();
                throw new Exception("예외가 발생했습니다. 숫자를 다시 입력해주세요.");
            }
        }
        void Clear()    // Clear 함수
        {
            this.Text_num1.Text = string.Empty;
            this.Text_num2.Text = string.Empty;
            this.Text_Result.Text = string.Empty;
            this.Ready_Label.Text = "Ready!";
        }
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Plus_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double result = Calculator(this.Text_num1.Text, this.Text_num2.Text, "+");
                this.Text_Result.Text = result.ToString();
                this.Ready_Label.Text = "+";
            }
            catch
            {

            }
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
