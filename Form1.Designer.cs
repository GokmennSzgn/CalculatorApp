namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblCalculator = new System.Windows.Forms.Label();
            this.pictureCalculator = new System.Windows.Forms.PictureBox();
            this.btnMinimized = new System.Windows.Forms.PictureBox();
            this.btnMaximized = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.TextOperationDisplay = new System.Windows.Forms.Panel();
            this.txtMode = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnHistory = new System.Windows.Forms.PictureBox();
            this.txtOperationDisplay = new System.Windows.Forms.TextBox();
            this.TextResultDisplay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlText = new System.Windows.Forms.Panel();
            this.btnScientific = new CustomRoundButton.RoundedButton();
            this.btnStandart = new CustomRoundButton.RoundedButton();
            this.btnTan = new CustomRoundButton.RoundedButton();
            this.btnLog = new CustomRoundButton.RoundedButton();
            this.btnCos = new CustomRoundButton.RoundedButton();
            this.btnSin = new CustomRoundButton.RoundedButton();
            this.btnClear = new CustomRoundButton.RoundedButton();
            this.btnBackspace = new CustomRoundButton.RoundedButton();
            this.btnClearEntry = new CustomRoundButton.RoundedButton();
            this.btnPercent = new CustomRoundButton.RoundedButton();
            this.btnSquare = new CustomRoundButton.RoundedButton();
            this.btnDivide = new CustomRoundButton.RoundedButton();
            this.btnReclprocal = new CustomRoundButton.RoundedButton();
            this.btnSqrt = new CustomRoundButton.RoundedButton();
            this.btn9 = new CustomRoundButton.RoundedButton();
            this.btnMultipy = new CustomRoundButton.RoundedButton();
            this.btn8 = new CustomRoundButton.RoundedButton();
            this.btn7 = new CustomRoundButton.RoundedButton();
            this.btn6 = new CustomRoundButton.RoundedButton();
            this.btnSubtract = new CustomRoundButton.RoundedButton();
            this.btn5 = new CustomRoundButton.RoundedButton();
            this.btn4 = new CustomRoundButton.RoundedButton();
            this.btn3 = new CustomRoundButton.RoundedButton();
            this.btnAdd = new CustomRoundButton.RoundedButton();
            this.btn2 = new CustomRoundButton.RoundedButton();
            this.btn1 = new CustomRoundButton.RoundedButton();
            this.btnDeclmal = new CustomRoundButton.RoundedButton();
            this.btnEquals = new CustomRoundButton.RoundedButton();
            this.btn0 = new CustomRoundButton.RoundedButton();
            this.btnNegate = new CustomRoundButton.RoundedButton();
            this.btnMClear = new CustomRoundButton.RoundedButton();
            this.btnMRecall = new CustomRoundButton.RoundedButton();
            this.btnMAdd = new CustomRoundButton.RoundedButton();
            this.btnMSubtract = new CustomRoundButton.RoundedButton();
            this.btnMemorySave = new CustomRoundButton.RoundedButton();
            this.btnShowMemory = new CustomRoundButton.RoundedButton();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCalculator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.TextOperationDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblCalculator);
            this.panelTop.Controls.Add(this.pictureCalculator);
            this.panelTop.Controls.Add(this.btnMinimized);
            this.panelTop.Controls.Add(this.btnMaximized);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(223, 29);
            this.panelTop.TabIndex = 0;
            // 
            // lblCalculator
            // 
            this.lblCalculator.AutoSize = true;
            this.lblCalculator.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalculator.ForeColor = System.Drawing.Color.White;
            this.lblCalculator.Location = new System.Drawing.Point(26, 8);
            this.lblCalculator.Name = "lblCalculator";
            this.lblCalculator.Size = new System.Drawing.Size(58, 13);
            this.lblCalculator.TabIndex = 1;
            this.lblCalculator.Text = "Calculator";
            // 
            // pictureCalculator
            // 
            this.pictureCalculator.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureCalculator.Image = ((System.Drawing.Image)(resources.GetObject("pictureCalculator.Image")));
            this.pictureCalculator.Location = new System.Drawing.Point(0, 0);
            this.pictureCalculator.Name = "pictureCalculator";
            this.pictureCalculator.Size = new System.Drawing.Size(27, 29);
            this.pictureCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureCalculator.TabIndex = 4;
            this.pictureCalculator.TabStop = false;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.Location = new System.Drawing.Point(142, 0);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(27, 29);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimized.TabIndex = 3;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            this.btnMinimized.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnMinimized.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMaximized_MouseMove);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Location = new System.Drawing.Point(169, 0);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(27, 29);
            this.btnMaximized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximized.TabIndex = 2;
            this.btnMaximized.TabStop = false;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            this.btnMaximized.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnMaximized.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMaximized_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(196, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 29);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseMove);
            // 
            // TextOperationDisplay
            // 
            this.TextOperationDisplay.Controls.Add(this.txtMode);
            this.TextOperationDisplay.Controls.Add(this.btnMenu);
            this.TextOperationDisplay.Controls.Add(this.btnHistory);
            this.TextOperationDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextOperationDisplay.Location = new System.Drawing.Point(0, 29);
            this.TextOperationDisplay.Name = "TextOperationDisplay";
            this.TextOperationDisplay.Size = new System.Drawing.Size(223, 29);
            this.TextOperationDisplay.TabIndex = 1;
            // 
            // txtMode
            // 
            this.txtMode.AutoSize = true;
            this.txtMode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMode.ForeColor = System.Drawing.Color.White;
            this.txtMode.Location = new System.Drawing.Point(28, 5);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(60, 17);
            this.txtMode.TabIndex = 2;
            this.txtMode.Text = "Standart";
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(27, 29);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 3;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMaximized_MouseMove);
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.Location = new System.Drawing.Point(196, 0);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(27, 29);
            this.btnHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHistory.TabIndex = 2;
            this.btnHistory.TabStop = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            this.btnHistory.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnHistory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMaximized_MouseMove);
            // 
            // txtOperationDisplay
            // 
            this.txtOperationDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtOperationDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOperationDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtOperationDisplay.Enabled = false;
            this.txtOperationDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOperationDisplay.ForeColor = System.Drawing.Color.White;
            this.txtOperationDisplay.Location = new System.Drawing.Point(0, 58);
            this.txtOperationDisplay.Multiline = true;
            this.txtOperationDisplay.Name = "txtOperationDisplay";
            this.txtOperationDisplay.Size = new System.Drawing.Size(223, 29);
            this.txtOperationDisplay.TabIndex = 2;
            this.txtOperationDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextResultDisplay
            // 
            this.TextResultDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TextResultDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextResultDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextResultDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextResultDisplay.ForeColor = System.Drawing.Color.White;
            this.TextResultDisplay.Location = new System.Drawing.Point(0, 87);
            this.TextResultDisplay.Multiline = true;
            this.TextResultDisplay.Name = "TextResultDisplay";
            this.TextResultDisplay.ReadOnly = true;
            this.TextResultDisplay.Size = new System.Drawing.Size(223, 40);
            this.TextResultDisplay.TabIndex = 3;
            this.TextResultDisplay.Text = "0";
            this.TextResultDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMClear);
            this.panel1.Controls.Add(this.btnMRecall);
            this.panel1.Controls.Add(this.btnMAdd);
            this.panel1.Controls.Add(this.btnMSubtract);
            this.panel1.Controls.Add(this.btnMemorySave);
            this.panel1.Controls.Add(this.btnShowMemory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 25);
            this.panel1.TabIndex = 4;
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.Controls.Add(this.btnScientific);
            this.pnlSideMenu.Controls.Add(this.btnStandart);
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 58);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(69, 69);
            this.pnlSideMenu.TabIndex = 12;
            // 
            // pnlText
            // 
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlText.Location = new System.Drawing.Point(0, 518);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(223, 0);
            this.pnlText.TabIndex = 33;
            // 
            // btnScientific
            // 
            this.btnScientific.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnScientific.FlatAppearance.BorderSize = 0;
            this.btnScientific.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScientific.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnScientific.ForeColor = System.Drawing.Color.White;
            this.btnScientific.Location = new System.Drawing.Point(0, 34);
            this.btnScientific.Name = "btnScientific";
            this.btnScientific.Size = new System.Drawing.Size(69, 32);
            this.btnScientific.TabIndex = 1;
            this.btnScientific.Text = "Scientific";
            this.btnScientific.UseVisualStyleBackColor = false;
            this.btnScientific.Click += new System.EventHandler(this.Scientific_Click);
            // 
            // btnStandart
            // 
            this.btnStandart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnStandart.FlatAppearance.BorderSize = 0;
            this.btnStandart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStandart.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnStandart.ForeColor = System.Drawing.Color.White;
            this.btnStandart.Location = new System.Drawing.Point(0, 0);
            this.btnStandart.Name = "btnStandart";
            this.btnStandart.Size = new System.Drawing.Size(69, 32);
            this.btnStandart.TabIndex = 0;
            this.btnStandart.Text = "Standart";
            this.btnStandart.UseVisualStyleBackColor = false;
            this.btnStandart.Click += new System.EventHandler(this.btnStandart_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.btnTan.FlatAppearance.BorderSize = 0;
            this.btnTan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnTan.ForeColor = System.Drawing.Color.White;
            this.btnTan.Location = new System.Drawing.Point(112, 463);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(45, 45);
            this.btnTan.TabIndex = 32;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(163, 463);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(45, 45);
            this.btnLog.TabIndex = 31;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.btnCos.FlatAppearance.BorderSize = 0;
            this.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnCos.ForeColor = System.Drawing.Color.White;
            this.btnCos.Location = new System.Drawing.Point(61, 463);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(45, 45);
            this.btnCos.TabIndex = 30;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.btnSin.FlatAppearance.BorderSize = 0;
            this.btnSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSin.ForeColor = System.Drawing.Color.White;
            this.btnSin.Location = new System.Drawing.Point(10, 463);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(45, 45);
            this.btnSin.TabIndex = 29;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(112, 159);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 45);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBackspace.FlatAppearance.BorderSize = 0;
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnBackspace.ForeColor = System.Drawing.Color.White;
            this.btnBackspace.Location = new System.Drawing.Point(163, 161);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(45, 45);
            this.btnBackspace.TabIndex = 27;
            this.btnBackspace.Text = "⬅";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.BackColor = System.Drawing.Color.DimGray;
            this.btnClearEntry.FlatAppearance.BorderSize = 0;
            this.btnClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearEntry.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClearEntry.ForeColor = System.Drawing.Color.White;
            this.btnClearEntry.Location = new System.Drawing.Point(61, 161);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(45, 45);
            this.btnClearEntry.TabIndex = 26;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = false;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.DimGray;
            this.btnPercent.FlatAppearance.BorderSize = 0;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercent.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnPercent.ForeColor = System.Drawing.Color.White;
            this.btnPercent.Location = new System.Drawing.Point(10, 161);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(45, 45);
            this.btnPercent.TabIndex = 25;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSquare.ForeColor = System.Drawing.Color.White;
            this.btnSquare.Location = new System.Drawing.Point(112, 211);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(45, 45);
            this.btnSquare.TabIndex = 24;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnDivide.ForeColor = System.Drawing.Color.White;
            this.btnDivide.Location = new System.Drawing.Point(163, 212);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(45, 45);
            this.btnDivide.TabIndex = 23;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnReclprocal
            // 
            this.btnReclprocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnReclprocal.FlatAppearance.BorderSize = 0;
            this.btnReclprocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReclprocal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnReclprocal.ForeColor = System.Drawing.Color.White;
            this.btnReclprocal.Location = new System.Drawing.Point(61, 212);
            this.btnReclprocal.Name = "btnReclprocal";
            this.btnReclprocal.Size = new System.Drawing.Size(45, 45);
            this.btnReclprocal.TabIndex = 22;
            this.btnReclprocal.Text = "1/x";
            this.btnReclprocal.UseVisualStyleBackColor = false;
            this.btnReclprocal.Click += new System.EventHandler(this.btnReclprocal_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSqrt.FlatAppearance.BorderSize = 0;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSqrt.ForeColor = System.Drawing.Color.White;
            this.btnSqrt.Location = new System.Drawing.Point(10, 212);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(45, 45);
            this.btnSqrt.TabIndex = 21;
            this.btnSqrt.Text = "√x";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(112, 259);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 45);
            this.btn9.TabIndex = 20;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btnMultipy
            // 
            this.btnMultipy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMultipy.FlatAppearance.BorderSize = 0;
            this.btnMultipy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultipy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnMultipy.ForeColor = System.Drawing.Color.White;
            this.btnMultipy.Location = new System.Drawing.Point(163, 259);
            this.btnMultipy.Name = "btnMultipy";
            this.btnMultipy.Size = new System.Drawing.Size(45, 45);
            this.btnMultipy.TabIndex = 19;
            this.btnMultipy.Text = "x";
            this.btnMultipy.UseVisualStyleBackColor = false;
            this.btnMultipy.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(61, 259);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 45);
            this.btn8.TabIndex = 18;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(10, 259);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 45);
            this.btn7.TabIndex = 17;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(112, 310);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 45);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSubtract.FlatAppearance.BorderSize = 0;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSubtract.ForeColor = System.Drawing.Color.White;
            this.btnSubtract.Location = new System.Drawing.Point(163, 310);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(45, 45);
            this.btnSubtract.TabIndex = 15;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(61, 310);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 45);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(10, 310);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 45);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(112, 361);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 45);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(163, 361);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 45);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(61, 361);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 45);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(10, 361);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 45);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btnDeclmal
            // 
            this.btnDeclmal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnDeclmal.FlatAppearance.BorderSize = 0;
            this.btnDeclmal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeclmal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnDeclmal.ForeColor = System.Drawing.Color.White;
            this.btnDeclmal.Location = new System.Drawing.Point(112, 412);
            this.btnDeclmal.Name = "btnDeclmal";
            this.btnDeclmal.Size = new System.Drawing.Size(45, 45);
            this.btnDeclmal.TabIndex = 8;
            this.btnDeclmal.Text = ".";
            this.btnDeclmal.UseVisualStyleBackColor = false;
            this.btnDeclmal.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnEquals.ForeColor = System.Drawing.Color.White;
            this.btnEquals.Location = new System.Drawing.Point(163, 412);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(45, 45);
            this.btnEquals.TabIndex = 7;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(61, 412);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(45, 45);
            this.btn0.TabIndex = 6;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btnNegate
            // 
            this.btnNegate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnNegate.FlatAppearance.BorderSize = 0;
            this.btnNegate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNegate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnNegate.ForeColor = System.Drawing.Color.White;
            this.btnNegate.Location = new System.Drawing.Point(10, 412);
            this.btnNegate.Name = "btnNegate";
            this.btnNegate.Size = new System.Drawing.Size(45, 45);
            this.btnNegate.TabIndex = 5;
            this.btnNegate.Text = "+/-";
            this.btnNegate.UseVisualStyleBackColor = false;
            this.btnNegate.Click += new System.EventHandler(this.btnNegate_Click);
            // 
            // btnMClear
            // 
            this.btnMClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnMClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMClear.Enabled = false;
            this.btnMClear.FlatAppearance.BorderSize = 0;
            this.btnMClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnMClear.ForeColor = System.Drawing.Color.White;
            this.btnMClear.Location = new System.Drawing.Point(1, 0);
            this.btnMClear.Name = "btnMClear";
            this.btnMClear.Size = new System.Drawing.Size(37, 25);
            this.btnMClear.TabIndex = 11;
            this.btnMClear.Text = "MC";
            this.btnMClear.UseVisualStyleBackColor = false;
            this.btnMClear.Click += new System.EventHandler(this.btnMClear_Click);
            // 
            // btnMRecall
            // 
            this.btnMRecall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnMRecall.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMRecall.Enabled = false;
            this.btnMRecall.FlatAppearance.BorderSize = 0;
            this.btnMRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMRecall.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnMRecall.ForeColor = System.Drawing.Color.White;
            this.btnMRecall.Location = new System.Drawing.Point(38, 0);
            this.btnMRecall.Name = "btnMRecall";
            this.btnMRecall.Size = new System.Drawing.Size(37, 25);
            this.btnMRecall.TabIndex = 10;
            this.btnMRecall.Text = "MR";
            this.btnMRecall.UseVisualStyleBackColor = false;
            this.btnMRecall.Click += new System.EventHandler(this.btnMRecall_Click);
            // 
            // btnMAdd
            // 
            this.btnMAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnMAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMAdd.FlatAppearance.BorderSize = 0;
            this.btnMAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnMAdd.ForeColor = System.Drawing.Color.White;
            this.btnMAdd.Location = new System.Drawing.Point(75, 0);
            this.btnMAdd.Name = "btnMAdd";
            this.btnMAdd.Size = new System.Drawing.Size(37, 25);
            this.btnMAdd.TabIndex = 9;
            this.btnMAdd.Text = "M+";
            this.btnMAdd.UseVisualStyleBackColor = false;
            this.btnMAdd.Click += new System.EventHandler(this.btnMAdd_Click);
            // 
            // btnMSubtract
            // 
            this.btnMSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnMSubtract.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMSubtract.FlatAppearance.BorderSize = 0;
            this.btnMSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMSubtract.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnMSubtract.ForeColor = System.Drawing.Color.White;
            this.btnMSubtract.Location = new System.Drawing.Point(112, 0);
            this.btnMSubtract.Name = "btnMSubtract";
            this.btnMSubtract.Size = new System.Drawing.Size(37, 25);
            this.btnMSubtract.TabIndex = 8;
            this.btnMSubtract.Text = "M-";
            this.btnMSubtract.UseVisualStyleBackColor = false;
            this.btnMSubtract.Click += new System.EventHandler(this.btnMSubtract_Click);
            // 
            // btnMemorySave
            // 
            this.btnMemorySave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnMemorySave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMemorySave.FlatAppearance.BorderSize = 0;
            this.btnMemorySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemorySave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnMemorySave.ForeColor = System.Drawing.Color.White;
            this.btnMemorySave.Location = new System.Drawing.Point(149, 0);
            this.btnMemorySave.Name = "btnMemorySave";
            this.btnMemorySave.Size = new System.Drawing.Size(37, 25);
            this.btnMemorySave.TabIndex = 7;
            this.btnMemorySave.Text = "MS";
            this.btnMemorySave.UseVisualStyleBackColor = false;
            this.btnMemorySave.Click += new System.EventHandler(this.btnMemorySave_Click);
            // 
            // btnShowMemory
            // 
            this.btnShowMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnShowMemory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowMemory.Enabled = false;
            this.btnShowMemory.FlatAppearance.BorderSize = 0;
            this.btnShowMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMemory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnShowMemory.ForeColor = System.Drawing.Color.White;
            this.btnShowMemory.Location = new System.Drawing.Point(186, 0);
            this.btnShowMemory.Name = "btnShowMemory";
            this.btnShowMemory.Size = new System.Drawing.Size(37, 25);
            this.btnShowMemory.TabIndex = 6;
            this.btnShowMemory.Text = "Mv";
            this.btnShowMemory.UseVisualStyleBackColor = false;
            this.btnShowMemory.Click += new System.EventHandler(this.btnShowMemory_Click);
            // 
            // menuTimer
            // 
            this.menuTimer.Interval = 15;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(223, 518);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnReclprocal);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnMultipy);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnDeclmal);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnNegate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextResultDisplay);
            this.Controls.Add(this.txtOperationDisplay);
            this.Controls.Add(this.TextOperationDisplay);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "C";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCalculator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.TextOperationDisplay.ResumeLayout(false);
            this.TextOperationDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureCalculator;
        private System.Windows.Forms.PictureBox btnMinimized;
        private System.Windows.Forms.PictureBox btnMaximized;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label lblCalculator;
        private System.Windows.Forms.Panel TextOperationDisplay;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox btnHistory;
        private System.Windows.Forms.Label txtMode;
        private System.Windows.Forms.TextBox txtOperationDisplay;
        private System.Windows.Forms.TextBox TextResultDisplay;
        private System.Windows.Forms.Panel panel1;
        private CustomRoundButton.RoundedButton btnMClear;
        private CustomRoundButton.RoundedButton btnMRecall;
        private CustomRoundButton.RoundedButton btnMAdd;
        private CustomRoundButton.RoundedButton btnMSubtract;
        private CustomRoundButton.RoundedButton btnMemorySave;
        private CustomRoundButton.RoundedButton btnShowMemory;
        private CustomRoundButton.RoundedButton btnNegate;
        private CustomRoundButton.RoundedButton btn0;
        private CustomRoundButton.RoundedButton btnEquals;
        private CustomRoundButton.RoundedButton btnDeclmal;
        private CustomRoundButton.RoundedButton btn3;
        private CustomRoundButton.RoundedButton btnAdd;
        private CustomRoundButton.RoundedButton btn2;
        private CustomRoundButton.RoundedButton btn1;
        private CustomRoundButton.RoundedButton btn9;
        private CustomRoundButton.RoundedButton btnMultipy;
        private CustomRoundButton.RoundedButton btn8;
        private CustomRoundButton.RoundedButton btn7;
        private CustomRoundButton.RoundedButton btn6;
        private CustomRoundButton.RoundedButton btnSubtract;
        private CustomRoundButton.RoundedButton btn5;
        private CustomRoundButton.RoundedButton btn4;
        private CustomRoundButton.RoundedButton btnClear;
        private CustomRoundButton.RoundedButton btnBackspace;
        private CustomRoundButton.RoundedButton btnClearEntry;
        private CustomRoundButton.RoundedButton btnPercent;
        private CustomRoundButton.RoundedButton btnSquare;
        private CustomRoundButton.RoundedButton btnDivide;
        private CustomRoundButton.RoundedButton btnReclprocal;
        private CustomRoundButton.RoundedButton btnSqrt;
        private CustomRoundButton.RoundedButton btnTan;
        private CustomRoundButton.RoundedButton btnLog;
        private CustomRoundButton.RoundedButton btnCos;
        private CustomRoundButton.RoundedButton btnSin;
        private System.Windows.Forms.Panel pnlSideMenu;
        private CustomRoundButton.RoundedButton btnStandart;
        private CustomRoundButton.RoundedButton btnScientific;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Timer menuTimer;
    }
}

