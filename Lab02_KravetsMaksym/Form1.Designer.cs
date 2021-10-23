
namespace Lab02_KravetsMaksym
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_Value = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_XOR = new System.Windows.Forms.Button();
            this.button_Clean = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Programs_Name = new System.Windows.Forms.Label();
            this.pictureBox_Programs_Icon = new System.Windows.Forms.PictureBox();
            this.label_Hide = new System.Windows.Forms.Label();
            this.label_Roll = new System.Windows.Forms.Label();
            this.label_Close = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Result1 = new System.Windows.Forms.TextBox();
            this.textBox_Key1 = new System.Windows.Forms.TextBox();
            this.textBox_Value1 = new System.Windows.Forms.TextBox();
            this.DecViewC = new System.Windows.Forms.Label();
            this.BinViewC = new System.Windows.Forms.Label();
            this.HexViewC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DecimalEnter = new System.Windows.Forms.RadioButton();
            this.HEXEnter = new System.Windows.Forms.RadioButton();
            this.BinaryEnter = new System.Windows.Forms.RadioButton();
            this.button_XOR1 = new System.Windows.Forms.Button();
            this.button_Clean1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HexViewP = new System.Windows.Forms.Label();
            this.BinViewP = new System.Windows.Forms.Label();
            this.DecViewP = new System.Windows.Forms.Label();
            this.HexViewKey = new System.Windows.Forms.Label();
            this.BinViewKey = new System.Windows.Forms.Label();
            this.DecViewKey = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HexViewC1 = new System.Windows.Forms.Label();
            this.BinViewC1 = new System.Windows.Forms.Label();
            this.DecViewC1 = new System.Windows.Forms.Label();
            this.HexViewKey1 = new System.Windows.Forms.Label();
            this.BinViewKey1 = new System.Windows.Forms.Label();
            this.DecViewKey1 = new System.Windows.Forms.Label();
            this.HexViewP1 = new System.Windows.Forms.Label();
            this.BinViewP1 = new System.Windows.Forms.Label();
            this.DecViewP1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Programs_Icon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Value
            // 
            this.textBox_Value.Location = new System.Drawing.Point(76, 41);
            this.textBox_Value.Name = "textBox_Value";
            this.textBox_Value.Size = new System.Drawing.Size(171, 22);
            this.textBox_Value.TabIndex = 0;
            this.textBox_Value.Enter += new System.EventHandler(this.textBox_Value_Enter);
            this.textBox_Value.Leave += new System.EventHandler(this.textBox_Value_Leave);
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(76, 102);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(171, 22);
            this.textBox_Key.TabIndex = 1;
            this.textBox_Key.Enter += new System.EventHandler(this.textBox_Key_Enter);
            this.textBox_Key.Leave += new System.EventHandler(this.textBox_Key_Leave);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(76, 166);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(171, 22);
            this.textBox_Result.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "P = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "C = ";
            // 
            // button_XOR
            // 
            this.button_XOR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_XOR.Location = new System.Drawing.Point(48, 221);
            this.button_XOR.Name = "button_XOR";
            this.button_XOR.Size = new System.Drawing.Size(78, 36);
            this.button_XOR.TabIndex = 6;
            this.button_XOR.Text = "XOR";
            this.button_XOR.UseVisualStyleBackColor = true;
            this.button_XOR.Click += new System.EventHandler(this.button_XOR_Click);
            // 
            // button_Clean
            // 
            this.button_Clean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Clean.Location = new System.Drawing.Point(175, 221);
            this.button_Clean.Name = "button_Clean";
            this.button_Clean.Size = new System.Drawing.Size(96, 36);
            this.button_Clean.TabIndex = 7;
            this.button_Clean.Text = "Прибрати";
            this.button_Clean.UseVisualStyleBackColor = true;
            this.button_Clean.Click += new System.EventHandler(this.button_Clean_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label_Programs_Name);
            this.panel1.Controls.Add(this.pictureBox_Programs_Icon);
            this.panel1.Controls.Add(this.label_Hide);
            this.panel1.Controls.Add(this.label_Roll);
            this.panel1.Controls.Add(this.label_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 29);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label_Programs_Name
            // 
            this.label_Programs_Name.AutoSize = true;
            this.label_Programs_Name.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Programs_Name.Location = new System.Drawing.Point(41, 7);
            this.label_Programs_Name.Name = "label_Programs_Name";
            this.label_Programs_Name.Size = new System.Drawing.Size(96, 15);
            this.label_Programs_Name.TabIndex = 4;
            this.label_Programs_Name.Text = "XOR Шифратор";
            this.label_Programs_Name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Programs_Name_MouseDown);
            this.label_Programs_Name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_Programs_Name_MouseMove);
            // 
            // pictureBox_Programs_Icon
            // 
            this.pictureBox_Programs_Icon.Image = global::Lab02_KravetsMaksym.Properties.Resources.icons8_щит_100;
            this.pictureBox_Programs_Icon.Location = new System.Drawing.Point(4, 3);
            this.pictureBox_Programs_Icon.Name = "pictureBox_Programs_Icon";
            this.pictureBox_Programs_Icon.Size = new System.Drawing.Size(31, 22);
            this.pictureBox_Programs_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Programs_Icon.TabIndex = 3;
            this.pictureBox_Programs_Icon.TabStop = false;
            this.pictureBox_Programs_Icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Programs_Icon_MouseDown);
            this.pictureBox_Programs_Icon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Programs_Icon_MouseMove);
            // 
            // label_Hide
            // 
            this.label_Hide.AutoSize = true;
            this.label_Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Hide.Location = new System.Drawing.Point(674, 7);
            this.label_Hide.Name = "label_Hide";
            this.label_Hide.Size = new System.Drawing.Size(17, 16);
            this.label_Hide.TabIndex = 2;
            this.label_Hide.Text = "—";
            this.label_Hide.Click += new System.EventHandler(this.label_Hide_Click);
            this.label_Hide.MouseEnter += new System.EventHandler(this.label_Hide_MouseEnter);
            this.label_Hide.MouseLeave += new System.EventHandler(this.label_Hide_MouseLeave);
            // 
            // label_Roll
            // 
            this.label_Roll.AutoSize = true;
            this.label_Roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Roll.Image = global::Lab02_KravetsMaksym.Properties.Resources.развернут;
            this.label_Roll.Location = new System.Drawing.Point(696, 7);
            this.label_Roll.Name = "label_Roll";
            this.label_Roll.Size = new System.Drawing.Size(14, 16);
            this.label_Roll.TabIndex = 1;
            this.label_Roll.Text = "  ";
            // 
            // label_Close
            // 
            this.label_Close.AutoSize = true;
            this.label_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Close.Location = new System.Drawing.Point(718, 7);
            this.label_Close.Name = "label_Close";
            this.label_Close.Size = new System.Drawing.Size(16, 16);
            this.label_Close.TabIndex = 0;
            this.label_Close.Text = "X";
            this.label_Close.Click += new System.EventHandler(this.label_Close_Click);
            this.label_Close.MouseEnter += new System.EventHandler(this.label_Close_MouseEnter);
            this.label_Close.MouseLeave += new System.EventHandler(this.label_Close_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "C =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Key =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(28, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "P =";
            // 
            // textBox_Result1
            // 
            this.textBox_Result1.Location = new System.Drawing.Point(70, 161);
            this.textBox_Result1.Name = "textBox_Result1";
            this.textBox_Result1.ReadOnly = true;
            this.textBox_Result1.Size = new System.Drawing.Size(171, 22);
            this.textBox_Result1.TabIndex = 13;
            // 
            // textBox_Key1
            // 
            this.textBox_Key1.Location = new System.Drawing.Point(70, 96);
            this.textBox_Key1.Name = "textBox_Key1";
            this.textBox_Key1.Size = new System.Drawing.Size(171, 22);
            this.textBox_Key1.TabIndex = 12;
            this.textBox_Key1.Enter += new System.EventHandler(this.textBox_Key1_Enter);
            this.textBox_Key1.Leave += new System.EventHandler(this.textBox_Key1_Leave);
            // 
            // textBox_Value1
            // 
            this.textBox_Value1.Location = new System.Drawing.Point(70, 36);
            this.textBox_Value1.Name = "textBox_Value1";
            this.textBox_Value1.Size = new System.Drawing.Size(171, 22);
            this.textBox_Value1.TabIndex = 11;
            this.textBox_Value1.Enter += new System.EventHandler(this.textBox_Value1_Enter);
            this.textBox_Value1.Leave += new System.EventHandler(this.textBox_Value1_Leave);
            // 
            // DecViewC
            // 
            this.DecViewC.AutoSize = true;
            this.DecViewC.Location = new System.Drawing.Point(40, 191);
            this.DecViewC.Name = "DecViewC";
            this.DecViewC.Size = new System.Drawing.Size(49, 15);
            this.DecViewC.TabIndex = 17;
            this.DecViewC.Text = "Decimal";
            // 
            // BinViewC
            // 
            this.BinViewC.AutoSize = true;
            this.BinViewC.Location = new System.Drawing.Point(200, 191);
            this.BinViewC.Name = "BinViewC";
            this.BinViewC.Size = new System.Drawing.Size(42, 15);
            this.BinViewC.TabIndex = 18;
            this.BinViewC.Text = "Binary";
            // 
            // HexViewC
            // 
            this.HexViewC.AutoSize = true;
            this.HexViewC.Location = new System.Drawing.Point(134, 191);
            this.HexViewC.Name = "HexViewC";
            this.HexViewC.Size = new System.Drawing.Size(27, 15);
            this.HexViewC.TabIndex = 19;
            this.HexViewC.Text = "Hex";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DecimalEnter);
            this.groupBox1.Controls.Add(this.HEXEnter);
            this.groupBox1.Controls.Add(this.BinaryEnter);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 113);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Система вводу";
            // 
            // DecimalEnter
            // 
            this.DecimalEnter.AutoSize = true;
            this.DecimalEnter.Location = new System.Drawing.Point(7, 86);
            this.DecimalEnter.Name = "DecimalEnter";
            this.DecimalEnter.Size = new System.Drawing.Size(67, 19);
            this.DecimalEnter.TabIndex = 2;
            this.DecimalEnter.TabStop = true;
            this.DecimalEnter.Text = "Decimal";
            this.DecimalEnter.UseVisualStyleBackColor = true;
            this.DecimalEnter.CheckedChanged += new System.EventHandler(this.DecimalEnter_CheckedChanged);
            // 
            // HEXEnter
            // 
            this.HEXEnter.AutoSize = true;
            this.HEXEnter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HEXEnter.Location = new System.Drawing.Point(7, 60);
            this.HEXEnter.Name = "HEXEnter";
            this.HEXEnter.Size = new System.Drawing.Size(50, 19);
            this.HEXEnter.TabIndex = 1;
            this.HEXEnter.TabStop = true;
            this.HEXEnter.Text = "HEX";
            this.HEXEnter.UseVisualStyleBackColor = true;
            this.HEXEnter.CheckedChanged += new System.EventHandler(this.HEXEnter_CheckedChanged);
            // 
            // BinaryEnter
            // 
            this.BinaryEnter.AutoSize = true;
            this.BinaryEnter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BinaryEnter.Location = new System.Drawing.Point(7, 37);
            this.BinaryEnter.Name = "BinaryEnter";
            this.BinaryEnter.Size = new System.Drawing.Size(60, 19);
            this.BinaryEnter.TabIndex = 0;
            this.BinaryEnter.TabStop = true;
            this.BinaryEnter.Text = "Binary";
            this.BinaryEnter.UseVisualStyleBackColor = true;
            this.BinaryEnter.CheckedChanged += new System.EventHandler(this.BinaryEnter_CheckedChanged);
            // 
            // button_XOR1
            // 
            this.button_XOR1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_XOR1.Location = new System.Drawing.Point(52, 221);
            this.button_XOR1.Name = "button_XOR1";
            this.button_XOR1.Size = new System.Drawing.Size(78, 36);
            this.button_XOR1.TabIndex = 22;
            this.button_XOR1.Text = "XOR";
            this.button_XOR1.UseVisualStyleBackColor = true;
            this.button_XOR1.Click += new System.EventHandler(this.button_XOR1_Click);
            // 
            // button_Clean1
            // 
            this.button_Clean1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Clean1.Location = new System.Drawing.Point(173, 221);
            this.button_Clean1.Name = "button_Clean1";
            this.button_Clean1.Size = new System.Drawing.Size(96, 36);
            this.button_Clean1.TabIndex = 23;
            this.button_Clean1.Text = "Прибрати";
            this.button_Clean1.UseVisualStyleBackColor = true;
            this.button_Clean1.Click += new System.EventHandler(this.button_Clean1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.HexViewP);
            this.groupBox2.Controls.Add(this.BinViewP);
            this.groupBox2.Controls.Add(this.DecViewP);
            this.groupBox2.Controls.Add(this.HexViewKey);
            this.groupBox2.Controls.Add(this.BinViewKey);
            this.groupBox2.Controls.Add(this.DecViewKey);
            this.groupBox2.Controls.Add(this.button_Clean);
            this.groupBox2.Controls.Add(this.textBox_Value);
            this.groupBox2.Controls.Add(this.textBox_Key);
            this.groupBox2.Controls.Add(this.textBox_Result);
            this.groupBox2.Controls.Add(this.HexViewC);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BinViewC);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DecViewC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button_XOR);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(107, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 268);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Зашифрувати";
            // 
            // HexViewP
            // 
            this.HexViewP.AutoSize = true;
            this.HexViewP.Location = new System.Drawing.Point(134, 66);
            this.HexViewP.Name = "HexViewP";
            this.HexViewP.Size = new System.Drawing.Size(27, 15);
            this.HexViewP.TabIndex = 25;
            this.HexViewP.Text = "Hex";
            // 
            // BinViewP
            // 
            this.BinViewP.AutoSize = true;
            this.BinViewP.Location = new System.Drawing.Point(200, 66);
            this.BinViewP.Name = "BinViewP";
            this.BinViewP.Size = new System.Drawing.Size(42, 15);
            this.BinViewP.TabIndex = 24;
            this.BinViewP.Text = "Binary";
            // 
            // DecViewP
            // 
            this.DecViewP.AutoSize = true;
            this.DecViewP.Location = new System.Drawing.Point(40, 66);
            this.DecViewP.Name = "DecViewP";
            this.DecViewP.Size = new System.Drawing.Size(49, 15);
            this.DecViewP.TabIndex = 23;
            this.DecViewP.Text = "Decimal";
            // 
            // HexViewKey
            // 
            this.HexViewKey.AutoSize = true;
            this.HexViewKey.Location = new System.Drawing.Point(134, 128);
            this.HexViewKey.Name = "HexViewKey";
            this.HexViewKey.Size = new System.Drawing.Size(27, 15);
            this.HexViewKey.TabIndex = 22;
            this.HexViewKey.Text = "Hex";
            // 
            // BinViewKey
            // 
            this.BinViewKey.AutoSize = true;
            this.BinViewKey.Location = new System.Drawing.Point(200, 130);
            this.BinViewKey.Name = "BinViewKey";
            this.BinViewKey.Size = new System.Drawing.Size(42, 15);
            this.BinViewKey.TabIndex = 21;
            this.BinViewKey.Text = "Binary";
            // 
            // DecViewKey
            // 
            this.DecViewKey.AutoSize = true;
            this.DecViewKey.Location = new System.Drawing.Point(40, 127);
            this.DecViewKey.Name = "DecViewKey";
            this.DecViewKey.Size = new System.Drawing.Size(49, 15);
            this.DecViewKey.TabIndex = 20;
            this.DecViewKey.Text = "Decimal";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HexViewC1);
            this.groupBox3.Controls.Add(this.BinViewC1);
            this.groupBox3.Controls.Add(this.DecViewC1);
            this.groupBox3.Controls.Add(this.HexViewKey1);
            this.groupBox3.Controls.Add(this.BinViewKey1);
            this.groupBox3.Controls.Add(this.DecViewKey1);
            this.groupBox3.Controls.Add(this.HexViewP1);
            this.groupBox3.Controls.Add(this.BinViewP1);
            this.groupBox3.Controls.Add(this.DecViewP1);
            this.groupBox3.Controls.Add(this.button_XOR1);
            this.groupBox3.Controls.Add(this.textBox_Value1);
            this.groupBox3.Controls.Add(this.button_Clean1);
            this.groupBox3.Controls.Add(this.textBox_Key1);
            this.groupBox3.Controls.Add(this.textBox_Result1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(422, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 268);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Розшифрувати";
            // 
            // HexViewC1
            // 
            this.HexViewC1.AutoSize = true;
            this.HexViewC1.Location = new System.Drawing.Point(142, 186);
            this.HexViewC1.Name = "HexViewC1";
            this.HexViewC1.Size = new System.Drawing.Size(27, 15);
            this.HexViewC1.TabIndex = 32;
            this.HexViewC1.Text = "Hex";
            // 
            // BinViewC1
            // 
            this.BinViewC1.AutoSize = true;
            this.BinViewC1.Location = new System.Drawing.Point(199, 186);
            this.BinViewC1.Name = "BinViewC1";
            this.BinViewC1.Size = new System.Drawing.Size(42, 15);
            this.BinViewC1.TabIndex = 31;
            this.BinViewC1.Text = "Binary";
            // 
            // DecViewC1
            // 
            this.DecViewC1.AutoSize = true;
            this.DecViewC1.Location = new System.Drawing.Point(40, 186);
            this.DecViewC1.Name = "DecViewC1";
            this.DecViewC1.Size = new System.Drawing.Size(49, 15);
            this.DecViewC1.TabIndex = 30;
            this.DecViewC1.Text = "Decimal";
            // 
            // HexViewKey1
            // 
            this.HexViewKey1.AutoSize = true;
            this.HexViewKey1.Location = new System.Drawing.Point(142, 121);
            this.HexViewKey1.Name = "HexViewKey1";
            this.HexViewKey1.Size = new System.Drawing.Size(27, 15);
            this.HexViewKey1.TabIndex = 29;
            this.HexViewKey1.Text = "Hex";
            // 
            // BinViewKey1
            // 
            this.BinViewKey1.AutoSize = true;
            this.BinViewKey1.Location = new System.Drawing.Point(199, 121);
            this.BinViewKey1.Name = "BinViewKey1";
            this.BinViewKey1.Size = new System.Drawing.Size(42, 15);
            this.BinViewKey1.TabIndex = 28;
            this.BinViewKey1.Text = "Binary";
            // 
            // DecViewKey1
            // 
            this.DecViewKey1.AutoSize = true;
            this.DecViewKey1.Location = new System.Drawing.Point(40, 121);
            this.DecViewKey1.Name = "DecViewKey1";
            this.DecViewKey1.Size = new System.Drawing.Size(49, 15);
            this.DecViewKey1.TabIndex = 27;
            this.DecViewKey1.Text = "Decimal";
            // 
            // HexViewP1
            // 
            this.HexViewP1.AutoSize = true;
            this.HexViewP1.Location = new System.Drawing.Point(142, 61);
            this.HexViewP1.Name = "HexViewP1";
            this.HexViewP1.Size = new System.Drawing.Size(27, 15);
            this.HexViewP1.TabIndex = 26;
            this.HexViewP1.Text = "Hex";
            // 
            // BinViewP1
            // 
            this.BinViewP1.AutoSize = true;
            this.BinViewP1.Location = new System.Drawing.Point(199, 61);
            this.BinViewP1.Name = "BinViewP1";
            this.BinViewP1.Size = new System.Drawing.Size(42, 15);
            this.BinViewP1.TabIndex = 25;
            this.BinViewP1.Text = "Binary";
            // 
            // DecViewP1
            // 
            this.DecViewP1.AutoSize = true;
            this.DecViewP1.Location = new System.Drawing.Point(40, 61);
            this.DecViewP1.Name = "DecViewP1";
            this.DecViewP1.Size = new System.Drawing.Size(49, 15);
            this.DecViewP1.TabIndex = 24;
            this.DecViewP1.Text = "Decimal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 310);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XOR шифратор";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Programs_Icon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Value;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_XOR;
        private System.Windows.Forms.Button button_Clean;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Hide;
        private System.Windows.Forms.Label label_Roll;
        private System.Windows.Forms.Label label_Close;
        private System.Windows.Forms.Label label_Programs_Name;
        private System.Windows.Forms.PictureBox pictureBox_Programs_Icon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Result1;
        private System.Windows.Forms.TextBox textBox_Key1;
        private System.Windows.Forms.TextBox textBox_Value1;
        private System.Windows.Forms.Label DecViewC;
        private System.Windows.Forms.Label BinViewC;
        private System.Windows.Forms.Label HexViewC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton HEXEnter;
        private System.Windows.Forms.RadioButton BinaryEnter;
        private System.Windows.Forms.Button button_XOR1;
        private System.Windows.Forms.Button button_Clean1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton DecimalEnter;
        private System.Windows.Forms.Label HexViewP;
        private System.Windows.Forms.Label BinViewP;
        private System.Windows.Forms.Label DecViewP;
        private System.Windows.Forms.Label HexViewKey;
        private System.Windows.Forms.Label BinViewKey;
        private System.Windows.Forms.Label DecViewKey;
        private System.Windows.Forms.Label HexViewC1;
        private System.Windows.Forms.Label BinViewC1;
        private System.Windows.Forms.Label DecViewC1;
        private System.Windows.Forms.Label HexViewKey1;
        private System.Windows.Forms.Label BinViewKey1;
        private System.Windows.Forms.Label DecViewKey1;
        private System.Windows.Forms.Label HexViewP1;
        private System.Windows.Forms.Label BinViewP1;
        private System.Windows.Forms.Label DecViewP1;
    }
}

