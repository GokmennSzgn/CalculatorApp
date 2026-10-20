using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static CalculatorApp.Tool;

namespace CalculatorApp
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            Height = 464;
            pnlSideMenu.Visible = false;
            pnlSideMenu.BackColor = Color.Transparent;
            panelTop.MoveForm(Handle);
            TextResultDisplay.SelectionStart = 0;
            historyTextBox.RichTextBox_Settings(pnlText);
            memoryTextBox.RichTextBox_Settings(pnlText);
            historyTextBox.Add_ClearButton(pnlText);
            lblCalculator.MoveForm(Handle);
            pictureCalculator.MoveForm(Handle);
            pnlSideMenu.Width = 0;
            pnlSideMenu.Visible = false;
        }

        bool operationStarted = false;
        string secondNumber = string.Empty;
        string firstNumber = string.Empty;
        string result = string.Empty;
        string memory = string.Empty;
        bool isDarkMode = true;
        Operation Operation { get; set; }

        RichTextBox historyTextBox = new RichTextBox();
        RichTextBox memoryTextBox = new RichTextBox();

        bool menuExpand = false; 
        const int menuMaxWidth = 69; 
        const int menuStep = 20; 

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized) WindowState = FormWindowState.Normal;

            else WindowState = FormWindowState.Maximized;

        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.FromArgb(200, 44, 20);
        }

        private void btnMaximized_MouseMove(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.FromArgb(45, 40, 40);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Transparent;
        }

        bool isScientificWaiting = false;
        private void NumButtons_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "." && TextResultDisplay.Text.Contains('.')) return;
            if (TextResultDisplay.Text == "0") TextResultDisplay.Text = string.Empty;

            if (operationStarted) TextResultDisplay.Text = ((Button)sender).Text;
            else TextResultDisplay.Text += ((Button)sender).Text;
            operationStarted = false;

        }

        private Panel GetTextOperationDisplay()
        {
            return TextOperationDisplay;
        }

        private void Operations_MouseDown(object sender, MouseEventArgs e)
        {
            firstNumber = TextResultDisplay.Text;
            operationStarted = true;
            txtOperationDisplay.Operation_Display(firstNumber, Operation);
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (TextResultDisplay.Text.Length > 0) TextResultDisplay.Text = TextResultDisplay.Text.Substring(0, TextResultDisplay.Text.Length - 1);
            if (TextResultDisplay.Text == string.Empty) TextResultDisplay.Text = "0";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextResultDisplay.Text = "0";
            TextOperationDisplay.Text = string.Empty;
            firstNumber = string.Empty;
            secondNumber = string.Empty;
            result = string.Empty;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            TextResultDisplay.Text = "0";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (isScientificWaiting)
            {

                firstNumber = TextResultDisplay.Text;
                result = Tool.Calculate(Operation, firstNumber, string.Empty, txtOperationDisplay).ToString();
                TextResultDisplay.Text = result;
                historyTextBox.Show_History(firstNumber, string.Empty, result, Operation);
                isScientificWaiting = false;
                operationStarted = true;
            }
            else if (firstNumber != string.Empty)
            {

                secondNumber = TextResultDisplay.Text;
                result = Tool.Calculate(Operation, firstNumber, secondNumber, txtOperationDisplay).ToString();
                TextResultDisplay.Text = result;
                historyTextBox.Show_History(firstNumber, secondNumber, result, Operation);
                operationStarted = true;
                firstNumber = string.Empty;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExecuteKeyOperation(Operation.Add);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            ExecuteKeyOperation(Operation.Subtract);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            ExecuteKeyOperation(Operation.Multiply);
        }


        private void btnSin_Click(object sender, EventArgs e)
        {
            Operation = Operation.Sin;
            ExecuteScientificOperation();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            Operation = Operation.Cos;
            ExecuteScientificOperation();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            Operation = Operation.Tan;
            ExecuteScientificOperation();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Operation = Operation.Log;
            ExecuteScientificOperation();
        }


        private void ExecuteScientificOperation()
        {

            operationStarted = true;
            isScientificWaiting = true;

            firstNumber = string.Empty;

            txtOperationDisplay.Text = Tool.Get_Symbol(Operation) + "()";
        }


        private void btnDivide_Click(object sender, EventArgs e)
        {
            ExecuteKeyOperation(Operation.Divide);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            ExecuteKeyOperation(Operation.Sqrt);
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            ExecuteKeyOperation(Operation.Square);
        }

        private void btnReclprocal_Click(object sender, EventArgs e)
        {
            ExecuteKeyOperation(Operation.Reciprocal);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TextResultDisplay.Text) || TextResultDisplay.Text == "0")
            {
                TextResultDisplay.Text = "0%";
            }
            else
            {

                TextResultDisplay.Text += "%";
            }


            operationStarted = false;

        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            TextResultDisplay.Text = (-1 * double.Parse(TextResultDisplay.Text)).ToString();
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            memory = TextResultDisplay.Text;
            btnMClear.Enabled = true;
            btnMRecall.Enabled = true;
            btnShowMemory.Enabled = true;
        }

        private void btnMClear_Click(object sender, EventArgs e)
        {
            memory = string.Empty;
            btnMClear.Enabled = false;
            btnMRecall.Enabled = false;
            btnShowMemory.Enabled = false;
            memoryTextBox.Clear();
            pnlText.Hide_Panel();
        }
        bool memoryPanelOn = false;
        private void btnShowMemory_Click(object sender, EventArgs e)
        {
            if (!memoryPanelOn)
            {
                memoryTextBox.Clear();
                pnlText.Display_Panel(memoryTextBox);
                memoryTextBox.Show_Memory(memory);
                memoryPanelOn = true;

            }
            else
            {
                pnlText.Hide_Panel();
                memoryPanelOn = false;
            }

        }

        private void TextResultDisplay_Click(object sender, EventArgs e)
        {
            pnlText.Hide_Panel();
        }

        private void btnMRecall_Click(object sender, EventArgs e)
        {
            TextResultDisplay.Text = memory;
        }

        double memoryTemp = 0;
        bool memorySet = false;
        private void btnMAdd_Click(object sender, EventArgs e)
        {
            memoryTextBox.Clear();
            double mem = double.Parse(memory);
            if (!memorySet)
            {
                memoryTemp = mem;
                memorySet = true;
            }
            double res = mem + memoryTemp;
            memory = res.ToString();
            memoryTextBox.Show_Memory(memory);
        }

        private void btnMSubtract_Click(object sender, EventArgs e)
        {
            memoryTextBox.Clear();
            double mem = double.Parse(memory);
            if (!memorySet)
            {
                memoryTemp = mem;
                memorySet = true;
            }
            double res = mem - memoryTemp;
            memory = res.ToString();
            memoryTextBox.Show_Memory(memory);
        }

        bool historyPanelOn = false;
        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (!historyPanelOn)
            {
                pnlText.Display_Panel(historyTextBox);
                historyPanelOn = true;
            }
            else
            {
                pnlText.Hide_Panel();
                historyPanelOn = false;
            }

            
            
            
        }

        private void lblCalculator_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            pnlSideMenu.Visible = true; 
            pnlSideMenu.BringToFront(); 
            menuTimer.Start();

        }



        public enum CalculatorMode
        {
            Standard,
            Scientific
        }




        CalculatorMode currentMode = CalculatorMode.Standard;

        public void btnStandart_Click(object sender, EventArgs e)
        {
            currentMode = CalculatorMode.Standard;
            this.Height = 464;
            btnStandart.Text = "Standart";
            pnlSideMenu.Visible = false;
            txtMode.Text = "Standart";
            txtMode.ForeColor = Color.White;
        }

        public void Scientific_Click(object sender, EventArgs e)
        {
            currentMode = CalculatorMode.Scientific;
            this.Height = 518;
            btnScientific.Text = "Scientific";
            pnlSideMenu.Visible = false;
            txtMode.Text = "Scientific";
            txtMode.ForeColor = Color.FromArgb(230, 92, 0);

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if ((keyData >= Keys.D0 && keyData <= Keys.D9) || (keyData >= Keys.NumPad0 && keyData <= Keys.NumPad9))
            {
                string key = keyData.ToString().Replace("D", "").Replace("NumPad", "");
                Control[] btn = this.Controls.Find("btn" + key, true);
                if (btn.Length > 0 && btn[0] is Button)
                {
                    ((Button)btn[0]).PerformClick();
                    return true;
                }
            }


            switch (keyData)
            {
                case Keys.Add:
                case Keys.Oemplus:
                    ExecuteKeyOperation(Operation.Add);
                    return true;
                case Keys.Subtract:
                case Keys.OemMinus:
                    ExecuteKeyOperation(Operation.Subtract);
                    return true;
                case Keys.Multiply:
                    ExecuteKeyOperation(Operation.Multiply);
                    return true;
                case Keys.Divide:
                    ExecuteKeyOperation(Operation.Divide);
                    return true;
                case Keys.Enter:
                    btnEquals.PerformClick();
                    return true;
                case Keys.Back:
                    btnBackspace.PerformClick();
                    return true;
                case Keys.Escape:
                    btnClear.PerformClick();
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void ExecuteKeyOperation(Operation op)
        {
            Operation = op;
            firstNumber = TextResultDisplay.Text;
            operationStarted = true;

            txtOperationDisplay.Operation_Display(firstNumber, Operation);
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {

            if (menuExpand == false)
            {
                
                pnlSideMenu.Width += 10; 
                if (pnlSideMenu.Width >= 180) 
                {
                    pnlSideMenu.Width = 69;
                    menuTimer.Stop();
                    menuExpand = true; 
                }
            }
            else
            {
                
                pnlSideMenu.Width -= 10;
                if (pnlSideMenu.Width <= 0)
                {
                    pnlSideMenu.Width = 0;
                    menuTimer.Stop();
                    menuExpand = false; 
                    pnlSideMenu.Visible = false;
                }
            }

            if (pnlText.Visible)
            {
                
                if (pnlText.Width > 0)
                {
                    pnlText.Width -= 20; 
                }
                else
                {
                    pnlText.Visible = false;
                    menuTimer.Stop();
                }
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (menuExpand) 
            {
                menuTimer.Start(); 
            }
        }
    }
}
