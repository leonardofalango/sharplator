namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double firstNumber { get; set; }
        private double secondNumber { get; set; }
        private char op { get; set; }
        private bool isClickedOp { get; set; } = false;
        private bool isFloat { get; set; } = false;
        private void TransformToFloat()
        {
            if (isFloat)
                return;
            Result.Text += ".";
            this.isFloat = true;
            
        }
        private void AddNumber(int number)
        {
            Result.Text += number.ToString();
            this.isClickedOp = false;
        }

        private void AddFirstNumber()
        {
            this.firstNumber = double.Parse(Result.Text);
        }

        private void AddSecundNumber()
        {
            int start = Result.Text.IndexOf(this.op.ToString());
            string secundNumber = Result.Text.Substring(start, Result.Text.Length - start);
            this.secondNumber = double.Parse(secundNumber);
        }

        private void DeleteDigit()
        {
            if (Result.Text.Reverse().ToArray()[0] == '.')
                this.isFloat = false;
            

            Result.Text = new string(Result
                .Text
                .Reverse()
                .Skip(1)
                .Reverse()
                .ToArray());
        }
        
        private void AddOperation(char op)
        {
            if (isClickedOp)
                DeleteDigit();
            this.op = op;
            Result.Text += op.ToString();
            isClickedOp = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isClickedOp)
            {
                AddFirstNumber();
                this.isFloat = false;
                Result.Text = "";
                FirstNumber.Text = "";
            }
            AddNumber(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddNumber(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AddNumber(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AddNumber(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AddNumber(5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            AddNumber(6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            AddNumber(7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            AddNumber(8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            AddNumber(9);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            AddNumber(0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DeleteDigit();
            this.isClickedOp = false;
        }

        private void Division(object sender, EventArgs e)
        {
            AddOperation('/');
            this.isClickedOp = true;
        }

        private void Multiply(object sender, EventArgs e)
        {
            AddOperation('*');
            this.isClickedOp = true;
        }

        private void Sub(object sender, EventArgs e)
        {
            AddOperation('-');
            this.isClickedOp = true;
        }

        private void Add(object sender, EventArgs e)
        {
            AddOperation('+');
            this.isClickedOp = true;
        }
        private void Float(object sender, EventArgs e)
        {
            TransformToFloat();
            this.isFloat = true;
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            Result.Text = "";
        }
    }
}