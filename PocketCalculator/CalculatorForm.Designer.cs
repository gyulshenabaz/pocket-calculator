namespace PocketCalculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.button_DivideOneByX = new System.Windows.Forms.Button();
            this.button_Divide = new System.Windows.Forms.Button();
            this.button_Multiply = new System.Windows.Forms.Button();
            this.button_Subtract = new System.Windows.Forms.Button();
            this.button_Addition = new System.Windows.Forms.Button();
            this.button_Equal = new System.Windows.Forms.Button();
            this.button_Power = new System.Windows.Forms.Button();
            this.button_SquareRoot = new System.Windows.Forms.Button();
            this.button_Backspace = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_Number_9 = new System.Windows.Forms.Button();
            this.button_Number_8 = new System.Windows.Forms.Button();
            this.button_Number_6 = new System.Windows.Forms.Button();
            this.button_MemoryMinus = new System.Windows.Forms.Button();
            this.button_MemoryPlus = new System.Windows.Forms.Button();
            this.button_MemoryStore = new System.Windows.Forms.Button();
            this.button_MemoryRecall = new System.Windows.Forms.Button();
            this.buttonMemoryClear = new System.Windows.Forms.Button();
            this.button_PercentageC = new System.Windows.Forms.Button();
            this.button_Number_5 = new System.Windows.Forms.Button();
            this.button_ClearEntry = new System.Windows.Forms.Button();
            this.button_Number_3 = new System.Windows.Forms.Button();
            this.button_Number_7 = new System.Windows.Forms.Button();
            this.button_Number_2 = new System.Windows.Forms.Button();
            this.button_Number_4 = new System.Windows.Forms.Button();
            this.button_Point = new System.Windows.Forms.Button();
            this.button_Number_0 = new System.Windows.Forms.Button();
            this.button_PlusMinus = new System.Windows.Forms.Button();
            this.button_Number_1 = new System.Windows.Forms.Button();
            this.operationsResult = new System.Windows.Forms.Label();
            this.memoryIndicator_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label.Location = new System.Drawing.Point(12, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(137, 35);
            this.Label.TabIndex = 2;
            this.Label.Text = "Calculator";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ControlLight;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.result.Enabled = false;
            this.result.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.result.Location = new System.Drawing.Point(10, 78);
            this.result.Name = "result";
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result.Size = new System.Drawing.Size(257, 51);
            this.result.TabIndex = 3;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // button_DivideOneByX
            // 
            this.button_DivideOneByX.BackColor = System.Drawing.SystemColors.Control;
            this.button_DivideOneByX.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_DivideOneByX.FlatAppearance.BorderSize = 0;
            this.button_DivideOneByX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DivideOneByX.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_DivideOneByX.Location = new System.Drawing.Point(208, 196);
            this.button_DivideOneByX.Name = "button_DivideOneByX";
            this.button_DivideOneByX.Size = new System.Drawing.Size(60, 30);
            this.button_DivideOneByX.TabIndex = 4;
            this.button_DivideOneByX.TabStop = false;
            this.button_DivideOneByX.Text = "¹⁄ₓ";
            this.button_DivideOneByX.UseVisualStyleBackColor = false;
            this.button_DivideOneByX.Click += new System.EventHandler(this.button_DivideOneByX_Click);
            this.button_DivideOneByX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Divide
            // 
            this.button_Divide.BackColor = System.Drawing.SystemColors.Control;
            this.button_Divide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Divide.FlatAppearance.BorderSize = 0;
            this.button_Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Divide.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Divide.Location = new System.Drawing.Point(208, 232);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(60, 30);
            this.button_Divide.TabIndex = 29;
            this.button_Divide.TabStop = false;
            this.button_Divide.Text = "÷";
            this.button_Divide.UseVisualStyleBackColor = false;
            this.button_Divide.Click += new System.EventHandler(this.button_Operator_Click);
            this.button_Divide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Multiply
            // 
            this.button_Multiply.BackColor = System.Drawing.SystemColors.Control;
            this.button_Multiply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Multiply.FlatAppearance.BorderSize = 0;
            this.button_Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Multiply.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Multiply.Location = new System.Drawing.Point(208, 268);
            this.button_Multiply.Name = "button_Multiply";
            this.button_Multiply.Size = new System.Drawing.Size(60, 30);
            this.button_Multiply.TabIndex = 28;
            this.button_Multiply.TabStop = false;
            this.button_Multiply.Text = "X";
            this.button_Multiply.UseVisualStyleBackColor = false;
            this.button_Multiply.Click += new System.EventHandler(this.button_Operator_Click);
            this.button_Multiply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Subtract
            // 
            this.button_Subtract.BackColor = System.Drawing.SystemColors.Control;
            this.button_Subtract.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Subtract.FlatAppearance.BorderSize = 0;
            this.button_Subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Subtract.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Subtract.Location = new System.Drawing.Point(208, 304);
            this.button_Subtract.Name = "button_Subtract";
            this.button_Subtract.Size = new System.Drawing.Size(60, 30);
            this.button_Subtract.TabIndex = 27;
            this.button_Subtract.TabStop = false;
            this.button_Subtract.Text = "−";
            this.button_Subtract.UseVisualStyleBackColor = false;
            this.button_Subtract.Click += new System.EventHandler(this.button_Operator_Click);
            this.button_Subtract.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Addition
            // 
            this.button_Addition.BackColor = System.Drawing.SystemColors.Control;
            this.button_Addition.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Addition.FlatAppearance.BorderSize = 0;
            this.button_Addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Addition.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Addition.Location = new System.Drawing.Point(208, 340);
            this.button_Addition.Name = "button_Addition";
            this.button_Addition.Size = new System.Drawing.Size(60, 30);
            this.button_Addition.TabIndex = 26;
            this.button_Addition.TabStop = false;
            this.button_Addition.Text = "+";
            this.button_Addition.UseVisualStyleBackColor = false;
            this.button_Addition.Click += new System.EventHandler(this.button_Operator_Click);
            this.button_Addition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Equal
            // 
            this.button_Equal.BackColor = System.Drawing.SystemColors.Control;
            this.button_Equal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Equal.FlatAppearance.BorderSize = 0;
            this.button_Equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Equal.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Equal.Location = new System.Drawing.Point(208, 376);
            this.button_Equal.Name = "button_Equal";
            this.button_Equal.Size = new System.Drawing.Size(60, 30);
            this.button_Equal.TabIndex = 25;
            this.button_Equal.TabStop = false;
            this.button_Equal.Text = "=";
            this.button_Equal.UseVisualStyleBackColor = false;
            this.button_Equal.Click += new System.EventHandler(this.button_Equal_Click);
            this.button_Equal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Power
            // 
            this.button_Power.BackColor = System.Drawing.SystemColors.Control;
            this.button_Power.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Power.FlatAppearance.BorderSize = 0;
            this.button_Power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Power.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Power.Location = new System.Drawing.Point(142, 196);
            this.button_Power.Name = "button_Power";
            this.button_Power.Size = new System.Drawing.Size(60, 30);
            this.button_Power.TabIndex = 24;
            this.button_Power.TabStop = false;
            this.button_Power.Text = "x²";
            this.button_Power.UseVisualStyleBackColor = false;
            this.button_Power.Click += new System.EventHandler(this.button_Power_Click);
            this.button_Power.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_SquareRoot
            // 
            this.button_SquareRoot.BackColor = System.Drawing.SystemColors.Control;
            this.button_SquareRoot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_SquareRoot.FlatAppearance.BorderSize = 0;
            this.button_SquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SquareRoot.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_SquareRoot.Location = new System.Drawing.Point(76, 196);
            this.button_SquareRoot.Name = "button_SquareRoot";
            this.button_SquareRoot.Size = new System.Drawing.Size(60, 30);
            this.button_SquareRoot.TabIndex = 23;
            this.button_SquareRoot.TabStop = false;
            this.button_SquareRoot.Text = "√";
            this.button_SquareRoot.UseVisualStyleBackColor = false;
            this.button_SquareRoot.Click += new System.EventHandler(this.button_SquareRoot_Click);
            this.button_SquareRoot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Backspace
            // 
            this.button_Backspace.BackColor = System.Drawing.SystemColors.Control;
            this.button_Backspace.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Backspace.FlatAppearance.BorderSize = 0;
            this.button_Backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Backspace.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Backspace.Location = new System.Drawing.Point(142, 232);
            this.button_Backspace.Name = "button_Backspace";
            this.button_Backspace.Size = new System.Drawing.Size(60, 30);
            this.button_Backspace.TabIndex = 22;
            this.button_Backspace.TabStop = false;
            this.button_Backspace.Text = "⌫";
            this.button_Backspace.UseVisualStyleBackColor = false;
            this.button_Backspace.Click += new System.EventHandler(this.button_Backspace_Click);
            this.button_Backspace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_C
            // 
            this.button_C.BackColor = System.Drawing.SystemColors.Control;
            this.button_C.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_C.FlatAppearance.BorderSize = 0;
            this.button_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_C.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_C.Location = new System.Drawing.Point(76, 232);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(60, 30);
            this.button_C.TabIndex = 21;
            this.button_C.TabStop = false;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = false;
            this.button_C.Click += new System.EventHandler(this.button_Clear);
            this.button_C.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Number_9
            // 
            this.button_Number_9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Number_9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Number_9.FlatAppearance.BorderSize = 0;
            this.button_Number_9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_Number_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Number_9.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Number_9.Location = new System.Drawing.Point(142, 268);
            this.button_Number_9.Name = "button_Number_9";
            this.button_Number_9.Size = new System.Drawing.Size(60, 30);
            this.button_Number_9.TabIndex = 20;
            this.button_Number_9.TabStop = false;
            this.button_Number_9.Text = "9";
            this.button_Number_9.UseVisualStyleBackColor = false;
            this.button_Number_9.Click += new System.EventHandler(this.numberButton_Click);
            this.button_Number_9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Number_8
            // 
            this.button_Number_8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Number_8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Number_8.FlatAppearance.BorderSize = 0;
            this.button_Number_8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_Number_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Number_8.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Number_8.Location = new System.Drawing.Point(76, 268);
            this.button_Number_8.Name = "button_Number_8";
            this.button_Number_8.Size = new System.Drawing.Size(60, 30);
            this.button_Number_8.TabIndex = 19;
            this.button_Number_8.TabStop = false;
            this.button_Number_8.Text = "8";
            this.button_Number_8.UseVisualStyleBackColor = false;
            this.button_Number_8.Click += new System.EventHandler(this.numberButton_Click);
            this.button_Number_8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Number_6
            // 
            this.button_Number_6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Number_6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Number_6.FlatAppearance.BorderSize = 0;
            this.button_Number_6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_Number_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Number_6.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Number_6.Location = new System.Drawing.Point(142, 304);
            this.button_Number_6.Name = "button_Number_6";
            this.button_Number_6.Size = new System.Drawing.Size(60, 30);
            this.button_Number_6.TabIndex = 18;
            this.button_Number_6.TabStop = false;
            this.button_Number_6.Text = "6";
            this.button_Number_6.UseVisualStyleBackColor = false;
            this.button_Number_6.Click += new System.EventHandler(this.numberButton_Click);
            this.button_Number_6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_MemoryMinus
            // 
            this.button_MemoryMinus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_MemoryMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_MemoryMinus.FlatAppearance.BorderSize = 0;
            this.button_MemoryMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MemoryMinus.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_MemoryMinus.Location = new System.Drawing.Point(222, 160);
            this.button_MemoryMinus.Name = "button_MemoryMinus";
            this.button_MemoryMinus.Size = new System.Drawing.Size(47, 30);
            this.button_MemoryMinus.TabIndex = 17;
            this.button_MemoryMinus.TabStop = false;
            this.button_MemoryMinus.Text = "M-";
            this.button_MemoryMinus.UseVisualStyleBackColor = false;
            this.button_MemoryMinus.Click += new System.EventHandler(this.button_MemoryMinus_Click);
            this.button_MemoryMinus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_MemoryPlus
            // 
            this.button_MemoryPlus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_MemoryPlus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_MemoryPlus.FlatAppearance.BorderSize = 0;
            this.button_MemoryPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MemoryPlus.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_MemoryPlus.Location = new System.Drawing.Point(169, 160);
            this.button_MemoryPlus.Name = "button_MemoryPlus";
            this.button_MemoryPlus.Size = new System.Drawing.Size(47, 30);
            this.button_MemoryPlus.TabIndex = 16;
            this.button_MemoryPlus.TabStop = false;
            this.button_MemoryPlus.Text = "M+";
            this.button_MemoryPlus.UseVisualStyleBackColor = false;
            this.button_MemoryPlus.Click += new System.EventHandler(this.button_MemoryPlus_Click);
            this.button_MemoryPlus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_MemoryStore
            // 
            this.button_MemoryStore.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_MemoryStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_MemoryStore.FlatAppearance.BorderSize = 0;
            this.button_MemoryStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MemoryStore.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_MemoryStore.Location = new System.Drawing.Point(116, 160);
            this.button_MemoryStore.Name = "button_MemoryStore";
            this.button_MemoryStore.Size = new System.Drawing.Size(47, 30);
            this.button_MemoryStore.TabIndex = 15;
            this.button_MemoryStore.TabStop = false;
            this.button_MemoryStore.Text = "MS";
            this.button_MemoryStore.UseVisualStyleBackColor = false;
            this.button_MemoryStore.Click += new System.EventHandler(this.button_MemoryStore_Click);
            this.button_MemoryStore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_MemoryRecall
            // 
            this.button_MemoryRecall.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_MemoryRecall.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_MemoryRecall.FlatAppearance.BorderSize = 0;
            this.button_MemoryRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MemoryRecall.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_MemoryRecall.Location = new System.Drawing.Point(63, 160);
            this.button_MemoryRecall.Name = "button_MemoryRecall";
            this.button_MemoryRecall.Size = new System.Drawing.Size(47, 30);
            this.button_MemoryRecall.TabIndex = 14;
            this.button_MemoryRecall.TabStop = false;
            this.button_MemoryRecall.Text = "MR";
            this.button_MemoryRecall.UseVisualStyleBackColor = false;
            this.button_MemoryRecall.Click += new System.EventHandler(this.button_MemoryRecall_Click);
            this.button_MemoryRecall.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // buttonMemoryClear
            // 
            this.buttonMemoryClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMemoryClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMemoryClear.FlatAppearance.BorderSize = 0;
            this.buttonMemoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMemoryClear.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonMemoryClear.Location = new System.Drawing.Point(10, 160);
            this.buttonMemoryClear.Name = "buttonMemoryClear";
            this.buttonMemoryClear.Size = new System.Drawing.Size(47, 30);
            this.buttonMemoryClear.TabIndex = 13;
            this.buttonMemoryClear.TabStop = false;
            this.buttonMemoryClear.Text = "MC";
            this.buttonMemoryClear.UseVisualStyleBackColor = false;
            this.buttonMemoryClear.Click += new System.EventHandler(this.buttonMemoryClear_Click);
            this.buttonMemoryClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_PercentageC
            // 
            this.button_PercentageC.BackColor = System.Drawing.SystemColors.Control;
            this.button_PercentageC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PercentageC.FlatAppearance.BorderSize = 0;
            this.button_PercentageC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PercentageC.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_PercentageC.Location = new System.Drawing.Point(10, 196);
            this.button_PercentageC.Name = "button_PercentageC";
            this.button_PercentageC.Size = new System.Drawing.Size(60, 30);
            this.button_PercentageC.TabIndex = 12;
            this.button_PercentageC.TabStop = false;
            this.button_PercentageC.Text = "%";
            this.button_PercentageC.UseVisualStyleBackColor = false;
            this.button_PercentageC.Click += new System.EventHandler(this.button_PercentageC_Click);
            this.button_PercentageC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Number_5
            // 
            this.button_Number_5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Number_5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Number_5.FlatAppearance.BorderSize = 0;
            this.button_Number_5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_Number_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Number_5.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Number_5.Location = new System.Drawing.Point(76, 304);
            this.button_Number_5.Name = "button_Number_5";
            this.button_Number_5.Size = new System.Drawing.Size(60, 30);
            this.button_Number_5.TabIndex = 11;
            this.button_Number_5.TabStop = false;
            this.button_Number_5.Text = "5";
            this.button_Number_5.UseVisualStyleBackColor = false;
            this.button_Number_5.Click += new System.EventHandler(this.numberButton_Click);
            this.button_Number_5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_ClearEntry
            // 
            this.button_ClearEntry.BackColor = System.Drawing.SystemColors.Control;
            this.button_ClearEntry.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ClearEntry.FlatAppearance.BorderSize = 0;
            this.button_ClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClearEntry.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_ClearEntry.Location = new System.Drawing.Point(10, 232);
            this.button_ClearEntry.Name = "button_ClearEntry";
            this.button_ClearEntry.Size = new System.Drawing.Size(60, 30);
            this.button_ClearEntry.TabIndex = 10;
            this.button_ClearEntry.TabStop = false;
            this.button_ClearEntry.Text = "CE";
            this.button_ClearEntry.UseVisualStyleBackColor = false;
            this.button_ClearEntry.Click += new System.EventHandler(this.button_ClearEntry_Click);
            this.button_ClearEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Number_3
            // 
            this.button_Number_3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Number_3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Number_3.FlatAppearance.BorderSize = 0;
            this.button_Number_3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_Number_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Number_3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Number_3.Location = new System.Drawing.Point(142, 340);
            this.button_Number_3.Name = "button_Number_3";
            this.button_Number_3.Size = new System.Drawing.Size(60, 30);
            this.button_Number_3.TabIndex = 9;
            this.button_Number_3.TabStop = false;
            this.button_Number_3.Text = "3";
            this.button_Number_3.UseVisualStyleBackColor = false;
            this.button_Number_3.Click += new System.EventHandler(this.numberButton_Click);
            this.button_Number_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Number_7
            // 
            this.button_Number_7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Number_7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Number_7.FlatAppearance.BorderSize = 0;
            this.button_Number_7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_Number_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Number_7.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Number_7.Location = new System.Drawing.Point(10, 268);
            this.button_Number_7.Name = "button_Number_7";
            this.button_Number_7.Size = new System.Drawing.Size(60, 30);
            this.button_Number_7.TabIndex = 8;
            this.button_Number_7.TabStop = false;
            this.button_Number_7.Text = "7";
            this.button_Number_7.UseVisualStyleBackColor = false;
            this.button_Number_7.Click += new System.EventHandler(this.numberButton_Click);
            this.button_Number_7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Number_2
            // 
            this.button_Number_2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Number_2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Number_2.FlatAppearance.BorderSize = 0;
            this.button_Number_2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_Number_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Number_2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Number_2.Location = new System.Drawing.Point(76, 340);
            this.button_Number_2.Name = "button_Number_2";
            this.button_Number_2.Size = new System.Drawing.Size(60, 30);
            this.button_Number_2.TabIndex = 7;
            this.button_Number_2.TabStop = false;
            this.button_Number_2.Text = "2";
            this.button_Number_2.UseVisualStyleBackColor = false;
            this.button_Number_2.Click += new System.EventHandler(this.numberButton_Click);
            this.button_Number_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Number_4
            // 
            this.button_Number_4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Number_4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Number_4.FlatAppearance.BorderSize = 0;
            this.button_Number_4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_Number_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Number_4.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Number_4.Location = new System.Drawing.Point(10, 304);
            this.button_Number_4.Name = "button_Number_4";
            this.button_Number_4.Size = new System.Drawing.Size(60, 30);
            this.button_Number_4.TabIndex = 6;
            this.button_Number_4.TabStop = false;
            this.button_Number_4.Text = "4";
            this.button_Number_4.UseVisualStyleBackColor = false;
            this.button_Number_4.Click += new System.EventHandler(this.numberButton_Click);
            this.button_Number_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Point
            // 
            this.button_Point.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Point.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Point.FlatAppearance.BorderSize = 0;
            this.button_Point.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_Point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Point.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Point.Location = new System.Drawing.Point(142, 376);
            this.button_Point.Name = "button_Point";
            this.button_Point.Size = new System.Drawing.Size(60, 30);
            this.button_Point.TabIndex = 5;
            this.button_Point.TabStop = false;
            this.button_Point.Text = ".";
            this.button_Point.UseVisualStyleBackColor = false;
            this.button_Point.Click += new System.EventHandler(this.button_Point_Click);
            this.button_Point.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Number_0
            // 
            this.button_Number_0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Number_0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Number_0.FlatAppearance.BorderSize = 0;
            this.button_Number_0.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_Number_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Number_0.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Number_0.Location = new System.Drawing.Point(76, 376);
            this.button_Number_0.Name = "button_Number_0";
            this.button_Number_0.Size = new System.Drawing.Size(60, 30);
            this.button_Number_0.TabIndex = 30;
            this.button_Number_0.TabStop = false;
            this.button_Number_0.Text = "0";
            this.button_Number_0.UseVisualStyleBackColor = false;
            this.button_Number_0.Click += new System.EventHandler(this.numberButton_Click);
            this.button_Number_0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_PlusMinus
            // 
            this.button_PlusMinus.BackColor = System.Drawing.SystemColors.Control;
            this.button_PlusMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PlusMinus.FlatAppearance.BorderSize = 0;
            this.button_PlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PlusMinus.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_PlusMinus.Location = new System.Drawing.Point(10, 376);
            this.button_PlusMinus.Name = "button_PlusMinus";
            this.button_PlusMinus.Size = new System.Drawing.Size(60, 30);
            this.button_PlusMinus.TabIndex = 31;
            this.button_PlusMinus.TabStop = false;
            this.button_PlusMinus.Text = "±";
            this.button_PlusMinus.UseVisualStyleBackColor = false;
            this.button_PlusMinus.Click += new System.EventHandler(this.button_PlusMinus_Click);
            this.button_PlusMinus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // button_Number_1
            // 
            this.button_Number_1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Number_1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Number_1.FlatAppearance.BorderSize = 0;
            this.button_Number_1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_Number_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Number_1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Number_1.Location = new System.Drawing.Point(10, 340);
            this.button_Number_1.Name = "button_Number_1";
            this.button_Number_1.Size = new System.Drawing.Size(60, 30);
            this.button_Number_1.TabIndex = 32;
            this.button_Number_1.TabStop = false;
            this.button_Number_1.Text = "1";
            this.button_Number_1.UseVisualStyleBackColor = false;
            this.button_Number_1.Click += new System.EventHandler(this.numberButton_Click);
            this.button_Number_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_KeyDown);
            // 
            // operationsResult
            // 
            this.operationsResult.AutoSize = true;
            this.operationsResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.operationsResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operationsResult.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.operationsResult.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.operationsResult.Location = new System.Drawing.Point(10, 46);
            this.operationsResult.Name = "operationsResult";
            this.operationsResult.Size = new System.Drawing.Size(0, 15);
            this.operationsResult.TabIndex = 34;
            this.operationsResult.TextChanged += new System.EventHandler(this.operationsResult_TextChanged);
            // 
            // memoryIndicator_Label
            // 
            this.memoryIndicator_Label.AutoSize = true;
            this.memoryIndicator_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryIndicator_Label.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.memoryIndicator_Label.Location = new System.Drawing.Point(10, 115);
            this.memoryIndicator_Label.Name = "memoryIndicator_Label";
            this.memoryIndicator_Label.Size = new System.Drawing.Size(17, 14);
            this.memoryIndicator_Label.TabIndex = 35;
            this.memoryIndicator_Label.Text = "M";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(277, 415);
            this.Controls.Add(this.memoryIndicator_Label);
            this.Controls.Add(this.operationsResult);
            this.Controls.Add(this.button_Number_1);
            this.Controls.Add(this.button_DivideOneByX);
            this.Controls.Add(this.button_Divide);
            this.Controls.Add(this.button_Multiply);
            this.Controls.Add(this.button_Subtract);
            this.Controls.Add(this.button_Addition);
            this.Controls.Add(this.button_Equal);
            this.Controls.Add(this.button_Power);
            this.Controls.Add(this.button_SquareRoot);
            this.Controls.Add(this.button_Backspace);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_Number_9);
            this.Controls.Add(this.button_Number_8);
            this.Controls.Add(this.button_Number_6);
            this.Controls.Add(this.button_MemoryMinus);
            this.Controls.Add(this.button_MemoryPlus);
            this.Controls.Add(this.button_MemoryStore);
            this.Controls.Add(this.button_MemoryRecall);
            this.Controls.Add(this.buttonMemoryClear);
            this.Controls.Add(this.button_PercentageC);
            this.Controls.Add(this.button_Number_5);
            this.Controls.Add(this.button_ClearEntry);
            this.Controls.Add(this.button_Number_3);
            this.Controls.Add(this.button_Number_7);
            this.Controls.Add(this.button_Number_2);
            this.Controls.Add(this.button_Number_4);
            this.Controls.Add(this.button_Point);
            this.Controls.Add(this.button_Number_0);
            this.Controls.Add(this.button_PlusMinus);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Label);
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.Text = "Pocket Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button button_DivideOneByX;
        private System.Windows.Forms.Button button_Divide;
        private System.Windows.Forms.Button button_Multiply;
        private System.Windows.Forms.Button button_Subtract;
        private System.Windows.Forms.Button button_Addition;
        private System.Windows.Forms.Button button_Equal;
        private System.Windows.Forms.Button button_Power;
        private System.Windows.Forms.Button button_SquareRoot;
        private System.Windows.Forms.Button button_Backspace;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_Number_9;
        private System.Windows.Forms.Button button_Number_8;
        private System.Windows.Forms.Button button_Number_6;
        private System.Windows.Forms.Button button_MemoryMinus;
        private System.Windows.Forms.Button button_MemoryPlus;
        private System.Windows.Forms.Button button_MemoryStore;
        private System.Windows.Forms.Button button_MemoryRecall;
        private System.Windows.Forms.Button buttonMemoryClear;
        private System.Windows.Forms.Button button_PercentageC;
        private System.Windows.Forms.Button button_Number_5;
        private System.Windows.Forms.Button button_ClearEntry;
        private System.Windows.Forms.Button button_Number_3;
        private System.Windows.Forms.Button button_Number_7;
        private System.Windows.Forms.Button button_Number_2;
        private System.Windows.Forms.Button button_Number_4;
        private System.Windows.Forms.Button button_Point;
        private System.Windows.Forms.Button button_Number_0;
        private System.Windows.Forms.Button button_PlusMinus;
        private System.Windows.Forms.Button button_Number_1;
        private System.Windows.Forms.Label operationsResult;
        private System.Windows.Forms.Label memoryIndicator_Label;
    }
}

