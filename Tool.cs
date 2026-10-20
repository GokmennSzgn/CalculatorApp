using CustomRoundButton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public static class Tool
    {

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        public static void MoveForm(this Control control, IntPtr Handle)
        {
            control.MouseMove += new MouseEventHandler(Move);
            void Move(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }


        public static void DragForm(IntPtr Handle)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }



        static double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }

        static double Subtract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }

        static double Multiply(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }

        static double Divide(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }

        static double Square(double num)
        {
            return num * num;
        }

        static double Sqrt(double num)
        {
            return Math.Sqrt(num);
        }

        static double Reciprocal(double num)
        {
            return 1 / num;
        }
        public static double Percentage(double num, double percent)
        {
            return num * (percent / 100);
        }

        public static double Sin(double num)
        {
            return Math.Sin(num);
        }

        public static double Cos(double num)
        {
            return Math.Cos(num);
        }

        public static double Tan(double num)
        {
            return Math.Tan(num);
        }


        public static double Log(double num)
        {
            return Math.Log10(num);
        }

        public static string Get_Symbol(this Operation operation)
        {
            switch (operation)
            {
                case Operation.Add:
                    return "+";
                case Operation.Subtract:
                    return "-";
                case Operation.Multiply:
                    return "×";
                case Operation.Divide:
                    return "÷";
                case Operation.Square:
                    return "x²";
                case Operation.Sqrt:
                    return "√x";
                case Operation.Reciprocal:
                    return "1/x";
                case
                    Operation.Sin:
                    return "sin";
                case
                    Operation.Cos:
                    return "cos";
                case
                    Operation.Tan:
                    return "tan";
                case
                    Operation.Log:
                    return "log";
                default:
                    return string.Empty;
            }
        }



        public static double Calculate(this Operation operation, string firstNum, string secondNum, TextBox operationDisplay)
        {

            if (string.IsNullOrEmpty(firstNum))
            {
                operationDisplay.Text = Operation_Display_WithResult(string.Empty, operation, string.Empty, "0");
                return 0;
            }

            double result = 0;
            double num1 = double.Parse(firstNum);
            double num2 = 0;

            if (operation == Operation.Add || operation == Operation.Subtract ||
        operation == Operation.Multiply || operation == Operation.Divide)
            {
                if (!string.IsNullOrEmpty(secondNum))
                    num2 = double.Parse(secondNum);
            }

            switch (operation)
            {
                case Operation.Add:
                    result = Add(num1, num2);
                    break;
                case Operation.Subtract:
                    result = Subtract(num1, num2);
                    break;
                case Operation.Multiply:
                    result = Multiply(num1, num2);
                    break;
                case Operation.Divide:
                    result = Divide(num1, num2);
                    break;
                case Operation.Square:
                    result = Square(num1);
                    break;
                case Operation.Sqrt:
                    result = Sqrt(num1);
                    break;
                case Operation.Reciprocal:
                    result = Reciprocal(num1);
                    break;


                case Operation.Sin:

                    result = Math.Sin(num1 * (Math.PI / 180.0));
                    break;
                case Operation.Cos:
                    result = Math.Cos(num1 * (Math.PI / 180.0));
                    break;
                case Operation.Tan:
                    result = Math.Tan(num1 * (Math.PI / 180.0));
                    break;
                case Operation.Log:
                    result = Math.Log10(num1);
                    break;



            }

            operationDisplay.Text = Operation_Display_WithResult(firstNum, operation, secondNum, result.ToString());
            return result;
        }

        public static void Operation_Display(this TextBox textBox, string firstNum, Operation operation)
        {
            string displayText = string.Empty;
            if (operation == Operation.Sqrt || operation == Operation.Reciprocal)
                displayText = $"{operation.Get_Symbol()}{firstNum}";
            else
                displayText = $"{firstNum} {operation.Get_Symbol()}";
            textBox.Text = displayText;
        }
        public static string Operation_Display_WithResult(string firstNum, Operation operation, string secondNum, string result)
        {

            if (operation == Operation.Log || operation == Operation.Sin || operation == Operation.Cos || operation == Operation.Tan)
            {

                return string.IsNullOrEmpty(firstNum)
                    ? $"{operation.Get_Symbol()}()"
                    : $"{operation.Get_Symbol()}({firstNum}) = {result}";
            }

            string displayText = string.Empty;
            if (operation == Operation.Square)
                displayText = $"{firstNum} {operation.Get_Symbol()} = {result}";
            else if (operation == Operation.Sqrt)
                displayText = $"{operation.Get_Symbol()}({firstNum}) = {result}";
            else if (operation == Operation.Reciprocal)
                displayText = $"{operation.Get_Symbol()}({firstNum}) = {result}";
            else
                displayText = $"{firstNum} {operation.Get_Symbol()}  {secondNum} = {result}";
            return displayText;
        }

        public static async void Animate_Panel(this Panel pnl)
        {
            int initalHeight = pnl.Height;
            int finalHeight = 260;
            const int AnimationDuration = 120;
            const int Steps = 12;


            int deltaHeight = (finalHeight - initalHeight) / Steps;
            int interval = AnimationDuration / Steps;

            for (int i = 0; i < Steps; i++)
            {
                pnl.Height += deltaHeight;
                await Task.Delay(interval);
            }
            pnl.Height = finalHeight;

        }
        public static void RichTextBox_Settings(this RichTextBox richTextBox, Panel pnl)
        {
            pnl.Controls.Add(richTextBox);
            pnl.BringToFront();
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.BackColor = Color.FromArgb(23, 19, 19);
            richTextBox.BorderStyle = BorderStyle.None;
            richTextBox.ReadOnly = true;
            richTextBox.Cursor = Cursors.Arrow;
        }

        public static void Display_Panel(this Panel pnl, RichTextBox textbox)
        {

            pnl.Animate_Panel();
            pnl.BackColor = Color.Transparent;
            foreach (Control control in pnl.Controls.OfType<RichTextBox>())
            {
                control.Hide();
            }
            textbox.Show();
        }
        public static void Hide_Panel(this Panel pnl)
        {
            pnl.Height = 0;

        }
        public static void Show_Memory(this RichTextBox textBox, string memory)
        {
            textBox.Font = new Font("Swgoe UI", 28, FontStyle.Bold);
            textBox.ForeColor = Color.WhiteSmoke;
            textBox.Text = memory;
            textBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        public static void Show_History(this RichTextBox textBox, string firstNum, string secondNum, string result, Operation operation)
        {
            textBox.SelectionAlignment = HorizontalAlignment.Right;
            Font font1 = new Font("Segoe UI", 12);
            Font font2 = new Font("Segoe UI", 18, FontStyle.Bold);
            textBox.SelectionFont = font1;
            textBox.SelectionColor = Color.Gray;

            string line1 = string.Empty;

            if (operation == Operation.Sin || operation == Operation.Cos || operation == Operation.Tan || operation == Operation.Log)
            {
                line1 = $"{operation.Get_Symbol()}({firstNum}) = ";
            }
            else if (operation == Operation.Square) line1 = $"{firstNum} {operation.Get_Symbol()} = ";
            else if (operation == Operation.Sqrt) line1 = $"{operation.Get_Symbol()}({firstNum}) = ";
            else if (operation == Operation.Reciprocal) line1 = $"{operation.Get_Symbol()}({firstNum}) = ";
            else line1 = $"{firstNum} {operation.Get_Symbol()} {secondNum} = ";
            textBox.SelectedText = Environment.NewLine + line1 + Environment.NewLine;
            textBox.SelectionFont = font2;
            textBox.SelectionColor = Color.White;
            textBox.SelectedText = result + Environment.NewLine;

        }

        public static void Add_ClearButton(this RichTextBox textBox, Panel pnl)
        {
            RoundedButton clearbutton = new RoundedButton();
            clearbutton.Text = string.Empty;
            clearbutton.Image = Properties.Resources.clear;
            clearbutton.Size = new Size(30, 30);
            clearbutton.BackColor = Color.FromArgb(23, 19, 19);
            clearbutton.BorderRadius = 2;
            clearbutton.Dock = DockStyle.Bottom;
            clearbutton.Click += new EventHandler(ClearButton_Click);
            void ClearButton_Click(object sender, EventArgs e)
            {
                textBox.Clear();
                pnl.Hide_Panel();
            }
            textBox.Controls.Add(clearbutton);
            clearbutton.Show();
        }


        public enum Operation
        {
            Add, Subtract, Multiply, Divide, Square, Sqrt, Reciprocal, Sin, Cos, Tan, Log
        }

    }
}
