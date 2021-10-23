using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_KravetsMaksym
{
    public partial class Form1 : Form
    {
        Point lastPoint;
        bool binaryEnter, hexEnter, decimalEnter;
        public Form1()
        {
            InitializeComponent();
            binaryEnter = true;
            BinaryEnter.Checked = true;
            textBox_Value.Text = "Введите значение";
            textBox_Value.ForeColor = Color.Gray; //Делает текст  серым
            textBox_Key.Text = "Введите ключ";
            textBox_Key.ForeColor = Color.Gray; //Делает текст  серым
            textBox_Value1.Text = "Введите значение";
            textBox_Value1.ForeColor = Color.Gray; //Делает текст  серым
            textBox_Key1.Text = "Введите ключ";
            textBox_Key1.ForeColor = Color.Gray; //Делает текст  серым

            DecViewP.Visible = false; HexViewP.Visible = false; BinViewP.Visible = false; DecViewKey.Visible = false; HexViewKey.Visible = false; BinViewKey.Visible = false; DecViewC.Visible = false; HexViewC.Visible = false; BinViewC.Visible = false;
            DecViewP1.Visible = false; HexViewP1.Visible = false; BinViewP1.Visible = false; DecViewKey1.Visible = false; HexViewKey1.Visible = false; BinViewKey1.Visible = false; DecViewC1.Visible = false; HexViewC1.Visible = false; BinViewC1.Visible = false;
        }

        private void label_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Функция которая позволяет двигать окно при зажатой левой клавише мыши
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X; //Добавляет к координатам положения окна значения на которое мышь (с зажатой левой кнопкой) была перемещена по Оси Х
                this.Top += e.Y - lastPoint.Y; //Добавляет к координатам положения окна значения на которое мышь (с зажатой левой кнопкой) была перемещена по Оси Y
            }
        }

        //Функция записывающая последние координаты окна в переменную lastPoint
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //При наведении на кнопку (CloseButton) меняет фон кнопки
        private void label_Close_MouseEnter(object sender, EventArgs e)
        {
            label_Close.BackColor = Color.Red;
        }

        //При выводе мишки за предел кнопки (CloseButton) меняет фон кнопки
        private void label_Close_MouseLeave(object sender, EventArgs e)
        {
            label_Close.BackColor = Color.White;
        }

        private void label_Hide_Click(object sender, EventArgs e)
        {
            // свернуть
            this.WindowState = FormWindowState.Minimized;
            // Развернуть
            //this.WindowState = FormWindowState.Maximized;
        }

        //При наведении на кнопку (CloseButton) меняет фон кнопки
        private void label_Hide_MouseEnter(object sender, EventArgs e)
        {
            label_Hide.BackColor = Color.FromArgb(206, 210, 217);
        }

        //При выводе мишки за предел кнопки (CloseButton) меняет фон кнопки
        private void label_Hide_MouseLeave(object sender, EventArgs e)
        {
            label_Hide.BackColor = Color.White;
        }

        private void button_XOR_Click(object sender, EventArgs e)
        {
            try
            {
                if(binaryEnter == true)
                {
                    if (textBox_Value.Text != "" && textBox_Key.Text != "")
                    {
                        string strP = textBox_Value.Text;
                        int intP = Convert.ToInt32(strP, 2);
                        string strKey = textBox_Key.Text;
                        int intKey = Convert.ToInt32(strKey, 2);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 2);
                        textBox_Result.Text = strC;

                        //DecViewP.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 2), 10);
                        //HexViewP.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 2), 16);
                        //BinViewP.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 2), 2);

                        //DecViewKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 2), 10);
                        //HexViewKey.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 2), 16);
                        //BinViewKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 2), 2);

                        DecViewC.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 2), 10);
                        HexViewC.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 2), 16);
                        BinViewC.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 2), 2);

                        DecViewP.Visible = true; HexViewP.Visible = true; BinViewP.Visible = true; DecViewKey.Visible = true; HexViewKey.Visible = true; BinViewKey.Visible = true; DecViewC.Visible = true; HexViewC.Visible = true; BinViewC.Visible = true;

                        MessageBox.Show("Шифрування виконано");
                    }
                    else if (textBox_Value.Text == "" || textBox_Value.Text == "Введите значение")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key.Text == "" || textBox_Key.Text == "Введите ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_Value.Text = "";
                        textBox_Key.Text = "";
                    }
                }
                if (hexEnter == true)
                {
                    if (textBox_Value.Text != "" && textBox_Key.Text != "")
                    {
                        string strP = textBox_Value.Text;
                        int intP = Convert.ToInt32(strP, 16);
                        string strKey = textBox_Key.Text;
                        int intKey = Convert.ToInt32(strKey, 16);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 16);
                        textBox_Result.Text = strC;

                        //DecViewP.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 16), 10);
                        //HexViewP.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 16), 16);
                        //BinViewP.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 16), 2);

                        //DecViewKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 16), 10);
                        //HexViewKey.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 16), 16);
                        //BinViewKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 16), 2);

                        DecViewC.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 16), 10);
                        HexViewC.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 16), 16);
                        BinViewC.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 16), 2);

                        DecViewP.Visible = true; HexViewP.Visible = true; BinViewP.Visible = true; DecViewKey.Visible = true; HexViewKey.Visible = true; BinViewKey.Visible = true; DecViewC.Visible = true; HexViewC.Visible = true; BinViewC.Visible = true;

                        MessageBox.Show("Шифрування виконано");
                    }
                    else if (textBox_Value.Text == "" || textBox_Value.Text == "Введите значение")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key.Text == "" || textBox_Key.Text == "Введите ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_Value.Text = "";
                        textBox_Key.Text = "";
                    }
                }
                if (decimalEnter == true)
                {
                    if (textBox_Value.Text != "" && textBox_Key.Text != "")
                    {
                        string strP = textBox_Value.Text;
                        int intP = Convert.ToInt32(strP, 10);
                        string strKey = textBox_Key.Text;
                        int intKey = Convert.ToInt32(strKey, 10);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 10);
                        textBox_Result.Text = strC;

                        //DecViewP.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 10), 10);
                        //HexViewP.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 10), 16);
                        //BinViewP.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 10), 2);

                        //DecViewKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 10), 10);
                        //HexViewKey.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 10), 16);
                        //BinViewKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 10), 2);

                        DecViewC.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 10), 10);
                        HexViewC.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 10), 16);
                        BinViewC.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Result.Text, 10), 2);

                        DecViewP.Visible = true; HexViewP.Visible = true; BinViewP.Visible = true; DecViewKey.Visible = true; HexViewKey.Visible = true; BinViewKey.Visible = true; DecViewC.Visible = true; HexViewC.Visible = true; BinViewC.Visible = true;

                        MessageBox.Show("Шифрування виконано");
                    }
                    else if (textBox_Value.Text == "" || textBox_Value.Text == "Введите значение")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key.Text == "" || textBox_Key.Text == "Введите ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_Value.Text = "";
                        textBox_Key.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Clean_Click(object sender, EventArgs e)
        {
            textBox_Value.Text = "Введите значение";
            textBox_Key.Text = "Введите ключ";
            textBox_Result.Text = "";
            textBox_Value.ForeColor = Color.Gray; //Делает текст  серым
            textBox_Key.ForeColor = Color.Gray; //Делает текст  серым
            DecViewP.Visible = false; HexViewP.Visible = false; BinViewP.Visible = false; DecViewKey.Visible = false; HexViewKey.Visible = false; BinViewKey.Visible = false; DecViewC.Visible = false; HexViewC.Visible = false; BinViewC.Visible = false;
        }

        //Если значение в поле ввода числа равно начальному значению ("Введите значение") то оно становиться пустым при нажатии на него ЛКМ
        private void textBox_Value_Enter(object sender, EventArgs e)
        {
            //Если значение в поле ввода числа пользователя равно начальному значению ("Введите значения") то оно становиться пустым при нажатии на него ЛКМ
            if (textBox_Value.Text == "Введите значение")
            {
                textBox_Value.Text = ""; //Делает поле для ввода числа пользователя пустым
                textBox_Value.ForeColor = Color.Black; //Делает цвет текста который будет введён черным
            }
        }

        //Функция которая описывает поведения поля для ввода числа, когда курсор миши в нём не установлен
        private void textBox_Value_Leave(object sender, EventArgs e)
        {
            //Если значение в поле ввода числа равно пустоте (Пользователь не ввёл значения) то оно становиться равным ("Введите число") при нажатии ЛКМ на другое активное поле
            if (textBox_Value.Text == "")
            {
                textBox_Value.Text = "Введите значение"; //Делает поле для ввода числа равным начальному значению ("Введите число")
                textBox_Value.ForeColor = Color.Gray; //Делает цвет текста серым
                DecViewP.Visible = false; HexViewP.Visible = false; BinViewP.Visible = false;
            }
            else
            {
                DecViewP.Visible = true; HexViewP.Visible = true; BinViewP.Visible = true;
                
                try 
                { 
                    if (binaryEnter == true)
                    {
                        DecViewP.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 2), 10);
                        HexViewP.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 2), 16);
                        BinViewP.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 2), 2);
                    }
                    if (hexEnter == true)
                    {
                        DecViewP.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 16), 10);
                        HexViewP.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 16), 16);
                        BinViewP.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 16), 2);
                    }
                    if (decimalEnter == true)
                    {
                        DecViewP.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 10), 10);
                        HexViewP.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 10), 16);
                        BinViewP.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value.Text, 10), 2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        //Функция которая описывает поведения поля для ввода ключа, когда курсор миши в нём установлен
        private void textBox_Key_Enter(object sender, EventArgs e)
        {
            //Если значение в поле ввода ключа равно начальному значению ("Введите ключ") то оно становиться пустым при нажатии на него ЛКМ
            if (textBox_Key.Text == "Введите ключ")
            {
                textBox_Key.Text = ""; //Делает поле для ввода ключа пустым
                textBox_Key.ForeColor = Color.Black; //Делает цвет текста который будет введён черным
            }
        }

        //Функция которая описывает поведения поля для ввода ключа, когда курсор миши в нём не установлен
        private void textBox_Key_Leave(object sender, EventArgs e)
        {
            //Если значение в поле ввода ключа равно пустоте (Пользователь не ввёл значения) то оно становиться равным ("Введите ключ") при нажатии ЛКМ на другое активное поле
            if (textBox_Key.Text == "")
            {
                textBox_Key.Text = "Введите ключ"; //Делает поле для ввода ключа равным начальному значению ("Введите пароль")
                textBox_Key.ForeColor = Color.Gray; //Делает цвет текста серым
                DecViewKey.Visible = false; HexViewKey.Visible = false; BinViewKey.Visible = false;
            }
            else
            {
                DecViewKey.Visible = true; HexViewKey.Visible = true; BinViewKey.Visible = true;
                try
                {
                    if (binaryEnter == true)
                    {
                        DecViewKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 2), 10);
                        HexViewKey.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 2), 16);
                        BinViewKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 2), 2);
                    }
                    if (hexEnter == true)
                    {
                        DecViewKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 16), 10);
                        HexViewKey.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 16), 16);
                        BinViewKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 16), 2);
                    }
                    if (decimalEnter == true)
                    {
                        DecViewKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 10), 10);
                        HexViewKey.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 10), 16);
                        BinViewKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 10), 2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Функция которая позволяет двигать окно при зажатой левой клавише мыши
        private void label_Programs_Name_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X; //Добавляет к координатам положения окна значения на которое мышь (с зажатой левой кнопкой) была перемещена по Оси Х
                this.Top += e.Y - lastPoint.Y; //Добавляет к координатам положения окна значения на которое мышь (с зажатой левой кнопкой) была перемещена по Оси Y
            }
        }

        //Функция записывающая последние координаты окна в переменную lastPoint
        private void label_Programs_Name_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Функция которая позволяет двигать окно при зажатой левой клавише мыши
        private void pictureBox_Programs_Icon_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X; //Добавляет к координатам положения окна значения на которое мышь (с зажатой левой кнопкой) была перемещена по Оси Х
                this.Top += e.Y - lastPoint.Y; //Добавляет к координатам положения окна значения на которое мышь (с зажатой левой кнопкой) была перемещена по Оси Y
            }
        }

        //Функция записывающая последние координаты окна в переменную lastPoint
        private void pictureBox_Programs_Icon_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BinaryEnter_CheckedChanged(object sender, EventArgs e)
        {
            binaryEnter = true;
            hexEnter = false;
            decimalEnter = false;
        }

        private void button_XOR1_Click(object sender, EventArgs e)
        {
            try
            {
                if (binaryEnter == true)
                {
                    if (textBox_Value1.Text != "" && textBox_Key1.Text != "")
                    {
                        string strP = textBox_Value1.Text;
                        int intP = Convert.ToInt32(strP, 2);
                        string strKey = textBox_Key1.Text;
                        int intKey = Convert.ToInt32(strKey, 2);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 2);
                        textBox_Result1.Text = strC;

                        //DecViewP1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 2), 10);
                        //HexViewP1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 2), 16);
                        //BinViewP1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 2), 2);

                        //DecViewKey1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 10);
                        //HexViewKey1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 16);
                        //BinViewKey1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 2);

                        DecViewC1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 2), 10);
                        HexViewC1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 2), 16);
                        BinViewC1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 2), 2);

                        DecViewP1.Visible = true; HexViewP1.Visible = true; BinViewP1.Visible = true; DecViewKey1.Visible = true; HexViewKey1.Visible = true; BinViewKey1.Visible = true; DecViewC1.Visible = true; HexViewC1.Visible = true; BinViewC1.Visible = true;

                        MessageBox.Show("Дешифрування виконано");
                    }
                    else if (textBox_Value1.Text == "" || textBox_Value1.Text == "Введите значение")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key1.Text == "" || textBox_Key1.Text == "Введите ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_Value1.Text = "";
                        textBox_Key1.Text = "";
                    }
                }
                if (hexEnter == true)
                {
                    if (textBox_Value1.Text != "" && textBox_Key1.Text != "")
                    {
                        string strP = textBox_Value1.Text;
                        int intP = Convert.ToInt32(strP, 16);
                        string strKey = textBox_Key1.Text;
                        int intKey = Convert.ToInt32(strKey, 16);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 16);
                        textBox_Result1.Text = strC;

                        //DecViewP1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 16), 10);
                        //HexViewP1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 16), 16);
                        //BinViewP1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 16), 2);

                        //DecViewKey1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 16), 10);
                        //HexViewKey1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 16), 16);
                        //BinViewKey1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 16), 2);

                        DecViewC1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 16), 10);
                        HexViewC1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 16), 16);
                        BinViewC1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 16), 2);

                        DecViewP1.Visible = true; HexViewP1.Visible = true; BinViewP1.Visible = true; DecViewKey1.Visible = true; HexViewKey1.Visible = true; BinViewKey1.Visible = true; DecViewC1.Visible = true; HexViewC1.Visible = true; BinViewC1.Visible = true;

                        MessageBox.Show("Дешифрування виконано");
                    }
                    else if (textBox_Value1.Text == "" || textBox_Value1.Text == "Введите значение")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key1.Text == "" || textBox_Key1.Text == "Введите ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_Value1.Text = "";
                        textBox_Key1.Text = "";
                    }
                }
                if (decimalEnter == true)
                {
                    if (textBox_Value1.Text != "" && textBox_Key1.Text != "")
                    {
                        string strP = textBox_Value1.Text;
                        int intP = Convert.ToInt32(strP, 10);
                        string strKey = textBox_Key1.Text;
                        int intKey = Convert.ToInt32(strKey, 10);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 10);
                        textBox_Result1.Text = strC;

                        //DecViewP1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 10), 10);
                        //HexViewP1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 10), 16);
                        //BinViewP1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 10), 2);

                        //DecViewKey1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 10), 10);
                        //HexViewKey1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 10), 16);
                        //BinViewKey1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 10), 2);

                        DecViewC1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 10), 10);
                        HexViewC1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 10), 16);
                        BinViewC1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Result1.Text, 10), 2);

                        DecViewP1.Visible = true; HexViewP1.Visible = true; BinViewP1.Visible = true; DecViewKey1.Visible = true; HexViewKey1.Visible = true; BinViewKey1.Visible = true; DecViewC1.Visible = true; HexViewC1.Visible = true; BinViewC1.Visible = true;

                        MessageBox.Show("Дешифрування виконано");
                    }
                    else if (textBox_Value1.Text == "" || textBox_Value1.Text == "Введите значение")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key1.Text == "" || textBox_Key1.Text == "Введите ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_Value1.Text = "";
                        textBox_Key1.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Если значение в поле ввода значения1 пользователя равно начальному значению ("Введите значение") то оно становиться пустым при нажатии на него ЛКМ
        private void textBox_Value1_Enter(object sender, EventArgs e)
        {
            //Если значение в поле ввода значение равно начальному значению ("Введите значение") то оно становиться пустым при нажатии на него ЛКМ
            if (textBox_Value1.Text == "Введите значение")
            {
                textBox_Value1.Text = ""; //Делает поле для ввода значения пустым
                textBox_Value1.ForeColor = Color.Black; //Делает цвет текста который будет введён черным
            }
        }

        //Функция которая описывает поведения поля для ввода значения, когда курсор миши в нём не установлен
        private void textBox_Value1_Leave(object sender, EventArgs e)
        {
            //Если значение в поле ввода значения1 равно пустоте (Пользователь не ввёл значения) то оно становиться равным ("Введите значение") при нажатии ЛКМ на другое активное поле
            if (textBox_Value1.Text == "")
            {
                textBox_Value1.Text = "Введите значение"; //Делает поле для ввода значения равным начальному значению ("Введите логин")
                textBox_Value1.ForeColor = Color.Gray; //Делает цвет текста серым
                DecViewP1.Visible = false; HexViewP1.Visible = false; BinViewP1.Visible = false;
            }
            else
            {
                DecViewP1.Visible = true; HexViewP1.Visible = true; BinViewP1.Visible = true;

                try 
                { 
                    if (binaryEnter == true)
                    {
                        DecViewP1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 2), 10);
                        HexViewP1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 2), 16);
                        BinViewP1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 2), 2);
                    }
                    if (hexEnter == true)
                    {
                        DecViewP1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 16), 10);
                        HexViewP1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 16), 16);
                        BinViewP1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 16), 2);
                    }
                    if (decimalEnter == true)
                    {
                        DecViewP1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 10), 10);
                        HexViewP1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 10), 16);
                        BinViewP1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Value1.Text, 10), 2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Функция которая описывает поведения поля для ввода ключа, когда курсор миши в нём установлен
        private void textBox_Key1_Enter(object sender, EventArgs e)
        {
            //Если значение в поле ввода ключа равно начальному значению ("Введите ключ") то оно становиться пустым при нажатии на него ЛКМ
            if (textBox_Key1.Text == "Введите ключ")
            {
                textBox_Key1.Text = ""; //Делает поле для ввода ключа пустым
                textBox_Key1.ForeColor = Color.Black; //Делает цвет текста который будет введён черным
            }
        }

        //Функция которая описывает поведения поля для ввода ключа1, когда курсор миши в нём не установлен
        private void textBox_Key1_Leave(object sender, EventArgs e)
        {
            //Если значение в поле ввода ключа равно пустоте (Пользователь не ввёл значения) то оно становиться равным ("Введите ключ") при нажатии ЛКМ на другое активное поле
            if (textBox_Key1.Text == "")
            {
                textBox_Key1.Text = "Введите ключ"; //Делает поле для ввода ключа равным начальному значению ("Введите ключа")
                textBox_Key1.ForeColor = Color.Gray; //Делает цвет текста серым
                DecViewKey1.Visible = false; HexViewKey1.Visible = false; BinViewKey1.Visible = false;
            }
            else
            {
                DecViewKey1.Visible = true; HexViewKey1.Visible = true; BinViewKey1.Visible = true;
                
                try 
                { 
                    if (binaryEnter == true)
                    {
                        DecViewKey1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 10);
                        HexViewKey1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 16);
                        BinViewKey1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 2);
                    }
                    if (hexEnter == true)
                    {
                        DecViewKey1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 16), 10);
                        HexViewKey1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 16), 16);
                        BinViewKey1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 16), 2);
                    }
                    if (decimalEnter == true)
                    {
                        DecViewKey1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 10), 10);
                        HexViewKey1.Text = "Hex = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 10), 16);
                        BinViewKey1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 10), 2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_Clean1_Click(object sender, EventArgs e)
        {
            textBox_Value1.Text = "Введите значение";
            textBox_Key1.Text = "Введите ключ";
            textBox_Result1.Text = "";
            textBox_Value1.ForeColor = Color.Gray; //Делает текст  серым
            textBox_Key1.ForeColor = Color.Gray; //Делает текст  серым
            DecViewP1.Visible = false; HexViewP1.Visible = false; BinViewP1.Visible = false; DecViewKey1.Visible = false; HexViewKey1.Visible = false; BinViewKey1.Visible = false; DecViewC1.Visible = false; HexViewC1.Visible = false; BinViewC1.Visible = false;
        }

        private void DecimalEnter_CheckedChanged(object sender, EventArgs e)
        {
            decimalEnter = true;
            binaryEnter = false;
            hexEnter = false;
        }

        private void HEXEnter_CheckedChanged(object sender, EventArgs e)
        {
            hexEnter = true;
            binaryEnter = false;
            decimalEnter = false;
        }
    }
}
