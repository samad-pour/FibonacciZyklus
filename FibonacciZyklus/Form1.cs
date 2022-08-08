namespace FibonacciZyklus
{
    public partial class Form1 : Form
    {
        int moves;
        //Thread thread;

        public Form1()
        {
            InitializeComponent();

            timer.Start();
            moves = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static int FibonacciNumber(int folgeNumber)
        {
            int firstNumber = 0, secondNumber = 1, nextNumber = 0;
            
            if (folgeNumber == 0)
                return firstNumber;
            for (int i = 2; i <= folgeNumber; i++)
            {
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
            return secondNumber;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //   double pi = Math.PI;
            //   thread = new Thread(Draw);
            //   thread.IsBackground = true;
            //   thread.Start();

            int x, y, theta, px, py;
            x = 380;
            y = 380;
            theta = FibonacciNumber(moves);

            px = Convert.ToInt16(theta * Math.Cos(moves) + x);
            py = Convert.ToInt16(theta * Math.Sin(moves) + y);

            panel1.Location = new Point(px, py);
            panel1.Location = new Point(px, py);

            moves += 1;
            lbl_output_numbers.Text = moves.ToString();

            if (moves == 16) 
            {
                moves = 0;
                timer.Stop();
                panel1.Location = new Point(x, y);
            }
        }
    }
}