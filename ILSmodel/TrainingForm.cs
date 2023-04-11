﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ILSmodel
{
    public partial class TrainingForm : Form
    {
        //bool
        private bool IsLoc = false;
        private bool IsApp = false;
        private bool IsLanded = false;


        //ВСЕ данные о ВС, кроме его местоположения
        private Plane plane = new Plane { Course = 90, Heading = 270, Heingt = 3000, Minimum = 100, Speed = 200 };
        //положения точек(ВС) для разных координатных плоскостей
        //глиссада
        private int XHorizontal;
        private int YHorizontal;
        //курс
        private int XVertical;
        private int YVertical;



        public TrainingForm()
        {
            InitializeComponent();
            this.MinimumLabel.Text = $"Minimum {plane.Minimum}ft";
            //заполнение координат
            this.XHorizontal = this.PlaneHorizontal.Location.X;
            this.YHorizontal = this.PlaneHorizontal.Location.Y;

            this.XVertical = this.PlaneVertical.Location.X;
            this.YVertical = this.PlaneVertical.Location.Y;
            //курсы
            this.HeadingLabel.Text = $"Курс {plane.Heading}";
            this.HeadingLabelNav.Text = $"{plane.Heading}";

            //PFD
            this.SpeedLabelPFD.Text = this.plane.Speed.ToString();
            this.HeightPFD.Text = this.plane.Heingt.ToString();
        }

        private void TrainingForm_Load(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы ознакомились с правилами?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res != DialogResult.Yes)
            {
                this.Close();   //закрываем форму и переходим на старт ( где правила )
            }
            //если правила изучены
            //полет начат
            this.timer.Start();
        }

        //проверка координат (габаритов) в полете
        private void checkCoordinates()
        {
            //проверка по x,y вертикальной точки
            if (XVertical < 0 || YVertical < 20 || YVertical > 470 || XVertical > 460)
            {
                Random rand = new Random();
                //разворот ВС на рандомный курс поворот
                this.plane.Heading += rand.Next(90, 180);
                checkHeading();
            }



            //проверка по x,y горизонтальной точки (высота)
            if (XHorizontal < 0) //лево
            {
                XHorizontal = 0;
            }
            if (XHorizontal > 460) //право
            {
                XHorizontal = 460;
            }
            if (YHorizontal < 20) //верх
            {
                YHorizontal = 20;
            }
            if (YHorizontal > 270) //низ (ниже ВПП высота быть не может!)
            {
                YHorizontal = 270; //проверяем посадка ли?
                if (checkRunway() && plane.Speed == 0 && plane.Heingt == 0)
                {
                    timer.Stop();
                    MessageBox.Show("Самолет успешно приземлился!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void fly()
        {
            //от курса забиваем движение по координатам
            //функция БЕЗ сдвига самого самолета (лишь изменяет XVertical и YVertical)
            //для vertical
            if (this.plane.Heading == 360)
            {
                YVertical += -5;
            }
            else if (this.plane.Heading == 90)
            {
                XVertical += 5;
                XHorizontal += 5;
            }
            else if (this.plane.Heading == 180)
            {
                YVertical += 5;
            }
            else if (this.plane.Heading == 270)
            {
                XVertical -= 5;
                XHorizontal -= 5;
            }
            else if (this.plane.Heading >= 1 && this.plane.Heading < 22)
            {
                XVertical += 1;
                YVertical -= 3;
                XHorizontal += 1;
            }
            else if (this.plane.Heading >= 22 && this.plane.Heading < 45)
            {
                XVertical += 2;
                YVertical -= 2;
                XHorizontal += 2;
            }
            else if (this.plane.Heading >= 45 && this.plane.Heading < 67)
            {
                XVertical += 3;
                YVertical -= 1;
                XHorizontal += 3;
            }
            else if (this.plane.Heading >= 67 && this.plane.Heading < 90)
            {
                XVertical += 4;
                YVertical -= 1;
                XHorizontal += 4;
            }
            else if (this.plane.Heading >= 91 && this.plane.Heading < 112)
            {
                XVertical += 3;
                YVertical += 1;
                XHorizontal += 3;
            }
            else if (this.plane.Heading >= 112 && this.plane.Heading < 135)
            {
                XVertical += 2;
                YVertical += 2;
                XHorizontal += 2;
            }
            else if (this.plane.Heading >= 135 && this.plane.Heading < 157)
            {
                XVertical += 1;
                YVertical += 3;
                XHorizontal += 1;
            }
            else if (this.plane.Heading >= 157 && this.plane.Heading < 180)
            {
                XVertical += 1;
                YVertical += 4;
                XHorizontal += 1;
            }
            else if (this.plane.Heading >= 181 && this.plane.Heading < 202)
            {
                XVertical -= 1;
                YVertical += 3;
                XHorizontal -= 1;
            }
            else if (this.plane.Heading >= 202 && this.plane.Heading < 225)
            {
                XVertical -= 2;
                YVertical += 2;
                XHorizontal -= 2;
            }
            else if (this.plane.Heading >= 225 && this.plane.Heading < 247)
            {
                XVertical -= 3;
                YVertical += 1;
                XHorizontal -= 3;
            }
            else if (this.plane.Heading >= 247 && this.plane.Heading < 270)
            {
                XVertical -= 4;
                YVertical += 1;
                XHorizontal -= 4;
            }
            else if (this.plane.Heading >= 271 && this.plane.Heading < 292)
            {
                XVertical -= 3;
                YVertical -= 1;
                XHorizontal -= 3;
            }
            else if (this.plane.Heading >= 292 && this.plane.Heading < 315)
            {
                XVertical -= 2;
                YVertical -= 2;
                XHorizontal -= 2;
            }
            else if (this.plane.Heading >= 315 && this.plane.Heading < 337)
            {
                XVertical -= 1;
                YVertical -= 3;
                XHorizontal -= 1;
            }
            else if (this.plane.Heading >= 337 && this.plane.Heading < 360)
            {
                XVertical -= 1;
                YVertical -= 4;
                XHorizontal -= 1;
            }
        }

        //корректное определение heading ВС
        private void checkHeading()
        {
            if (this.plane.Heading > 360)
            {
                this.plane.Heading = this.plane.Heading - 360;
            }
            else if (this.plane.Heading < 0)
            {
                this.plane.Heading = this.plane.Heading + 360;
            }
        }

        //полет ВС
        private void timer_Tick(object sender, EventArgs e)
        {
            //проверка высоты
            if (this.plane.Heingt == 0)
            {
                heightZero();
            }
            //не приземлился
            if (!IsLanded)
            {
                //захвачен глиссадный и курсовой
                if (IsApp && IsLoc)
                {
                    //натяжка на курсовой (алгоритм) + на глиссадный (алгоритм)
                    this.pictureBox1.Image = Image.FromFile("..\\..\\..\\images\\PFD_descent.png");


                }
                //захвачен курсовой без глиссады
                else if (IsLoc)
                {
                    //натяжка на курсовой (алгоритм)
                    //спокойно сдвигаемся на точку 1(сверху)
                    if ((XVertical > 22 && XVertical < 47) && (YVertical > 133 && YVertical <= 216))
                    {
                        //двигаем x
                        XVertical += 3;
                        //двигаем y
                        YVertical += 4;
                        //меняем курс
                        plane.Heading = 120;
                        //меняем текст
                        this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                        this.HeadingLabelNav.Text = $"{plane.Heading}";
                        //двигаем самолет
                        PlaneVertical.Location = new Point(XVertical, YVertical);
                    }
                    //резко сдвигаемся на точку 2 (сверху)
                    else if ((XVertical >= 47 && XVertical <= 95) && (YVertical > 133 && YVertical <= 216))
                    {
                        //двигаем x
                        XVertical += 2;
                        //двигаем y
                        YVertical += 5;
                        //меняем курс
                        plane.Heading = 150;
                        //меняем текст
                        this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                        this.HeadingLabelNav.Text = $"{plane.Heading}";
                        //двигаем самолет
                        PlaneVertical.Location = new Point(XVertical, YVertical);
                    }
                    //спокойно сдвигаемся на точку 1(снизу)
                    else if ((XVertical > 22 && XVertical < 47) && (YVertical >= 216 && YVertical < 340))
                    {
                        //двигаем x
                        XVertical += 3;
                        //двигаем y
                        YVertical -= 4;
                        //меняем курс
                        plane.Heading = 40;
                        //меняем текст
                        this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                        this.HeadingLabelNav.Text = $"{plane.Heading}";
                        //двигаем самолет
                        PlaneVertical.Location = new Point(XVertical, YVertical);
                    }
                    //резко сдвигаемся на точку 2 (снизу)
                    else if ((XVertical >= 47 && XVertical <= 95) && (YVertical >= 216 && YVertical < 340))
                    {
                        //двигаем x
                        XVertical += 2;
                        //двигаем y
                        YVertical -= 5;
                        //меняем курс
                        plane.Heading = 30;
                        //меняем текст
                        this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                        this.HeadingLabelNav.Text = $"{plane.Heading}";
                        //двигаем самолет
                        PlaneVertical.Location = new Point(XVertical, YVertical);
                    }
                    //на курсовом, просто двигаемся по x + снижение скорости
                    else if ((XVertical >= 47 && XVertical < 150) && (YVertical == 216 || YVertical == 215 || YVertical == 214))
                    {
                        //снижение скорости
                        if (plane.Speed != 140)
                        {
                            plane.Speed -= 10;
                            this.SpeedLabelPFD.Text = plane.Speed.ToString();
                        }
                        //двигаем x
                        XVertical += 5;
                        //меняем курс
                        plane.Heading = 90;
                        //меняем текст
                        this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                        this.HeadingLabelNav.Text = $"{plane.Heading}";
                        //двигаем самолет
                        PlaneVertical.Location = new Point(XVertical, YVertical);
                    }
                    //протягивание
                    else if(XVertical < 390)
                    {
                        //снижение скорости
                        if (plane.Speed != 140)
                        {
                            plane.Speed -= 10;
                            this.SpeedLabelPFD.Text = plane.Speed.ToString();
                        }
                        //двигаем x
                        XVertical += 5;
                        //меняем курс
                        plane.Heading = 90;
                        //меняем текст
                        this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                        this.HeadingLabelNav.Text = $"{plane.Heading}";
                        //двигаем самолет
                        PlaneVertical.Location = new Point(XVertical, YVertical);
                    }
                }
                //обычный полет
                else
                {
                    //выравниваем PFD
                    Thread.Sleep(100);
                    this.pictureBox1.Image = Image.FromFile("..\\..\\..\\images\\PFD_center.png");
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    checkCoordinates();
                    //меняем текст
                    this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                    this.HeadingLabelNav.Text = $"{plane.Heading}";
                    //сдвиг ВС
                    this.PlaneVertical.Location = new Point(XVertical, YVertical);

                    //передвижение координат
                    fly();

                    //горизонталь
                    //сдвиг ВС
                    this.PlaneHorizontal.Location = new Point(XHorizontal, YHorizontal);
                }
            }
            else
            {
                //если приземлился
                timer.Stop();
                MessageBox.Show("Самолет успешно приземлился", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TrainingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //открыть главную форму при закрытии
                var form = Application.OpenForms[0];
                form.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка закрытия приложения");
            }
        }

        //отказ КРМ (ручной)
        private void FailureButton_Click(object sender, EventArgs e)
        {
            //отказ кнопок (заход будет ручной)
            (sender as Button).BackColor = Color.Red;
            (sender as Button).Enabled = false;
            this.LocButton.BackColor = Color.Black;
            this.LocButton.Enabled = false;
            this.APPButton.BackColor = Color.Black;
            this.APPButton.Enabled = false;

            //bool
            IsApp = false;
            IsLoc = false;
            IsLanded = false;
        }

        //курсы управление ручное!
        private void HeadingLeftButton_Click(object sender, EventArgs e)
        {
            this.plane.Heading -= 1;
            checkHeading();
        }

        private void HeadingRightButton_Click(object sender, EventArgs e)
        {
            this.plane.Heading += 1;
            checkHeading();
        }
        //высота управление ручное!
        private void HeightUP_Click(object sender, EventArgs e)
        {
            //изменение высоты ВС
            this.plane.Heingt += 100;
            this.pictureBox1.Image = Image.FromFile("..\\..\\..\\images\\PFD_climb.png");
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (this.plane.Heingt > 3000)
            {
                this.plane.Heingt = 3000;
            }
            this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
            this.HeightPFD.Text = $"{plane.Heingt}";
            this.YHorizontal -= 8;
        }

        private void HeightDown_Click(object sender, EventArgs e)
        {
            //изменение высоты ВС
            if (plane.Heingt > 250)
            {
                this.pictureBox1.Image = Image.FromFile("..\\..\\..\\images\\PFD_descent.png");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.plane.Heingt -= 100;
                this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
                this.HeightPFD.Text = $"{plane.Heingt}";
                this.YHorizontal += 8;
            }
            else if (plane.Heingt > 0 && plane.Heingt <= 250)
            {
                this.pictureBox1.Image = Image.FromFile("..\\..\\..\\images\\PFD_descent.png");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.plane.Heingt -= 50;
                //защита за габариты
                if (this.plane.Heingt < 0)
                {
                    this.plane.Heingt = 0;
                }
                this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
                this.HeightPFD.Text = $"{plane.Heingt}";
                this.YHorizontal += 6;
            }
            //height == 0
            else
            {
                this.pictureBox1.Image = Image.FromFile("..\\..\\..\\images\\PFD_descent.png");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                heightZero();
            }
        }
        //если height == 0 проверка
        private void heightZero()
        {
            //если на полосе, то сел
            if (checkRunway())
            {
                IsLanded = true;
            }
            //если не на полосе -- разбился
            else
            {
                //отключение таймера
                timer.Stop();
                this.PlaneHorizontal.Location = new Point(XHorizontal, 270);
                var res = MessageBox.Show($"Самолет разбился!{Environment.NewLine}Начать заново?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (res == DialogResult.Yes)
                {
                    //закрыть форму
                    this.Close();
                }
                else
                {
                    //выход из программы
                    Application.Exit();
                }
            }
        }

        //проверка полосы (при посадке ВС)
        //учитываем координаты ВПП
        private bool checkRunway()
        {
            //торец ВПП (Vertical)
            const int XRnw = 140; //+246 - конец ВПП
            const int YRnw = 214;

            //150 - все что дальше выезд за полосу
            if ((XVertical >= XRnw && XVertical <= XRnw + 190) && (YVertical > YRnw - 6 && YVertical < YRnw + 6))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //захват курсового!
        private void LocButton_Click(object sender, EventArgs e)
        {
            //отключение
            if (IsLoc)
            {
                //изменяем цвет кнопки
                (sender as Button).BackColor = Color.Red;
                IsLoc = false;
                APPButton.BackColor = Color.Red;
                IsApp = false;


                //разрешение нормального полета
                this.KeyPreview = true;
                HeadingLeftButton.Enabled = true;
                HeadingRightButton.Enabled = true;

            }
            //включение
            else
            {
                //если вошел в координаты курсового радиомаяка
                //сверяю диаграммы и ВС
                if (OnLock())
                {
                    IsLoc = true;
                    (sender as Button).BackColor = Color.Green;
                    //запретить ручное управление
                    this.KeyPreview = false;
                    //запрет изменения курса
                    HeadingLeftButton.Enabled = false;
                    HeadingRightButton.Enabled = false;
                }
            }
        }
        private bool OnLock()
        {
            //сверяю координаты ВС и курсового маяка
            if ((XVertical > 22 && XVertical < 95) && (YVertical > 133 && YVertical < 340))
            {
                return true;
            }
            return false;
        }
        //захват глиссадного + курсового
        private void APPButton_Click(object sender, EventArgs e)
        {
            //отключение
            if (IsApp)
            {
                LocButton.BackColor = Color.Red;
                IsLoc = false;
                (sender as Button).BackColor = Color.Red;
                IsApp = false;
            }
            else
            {
                LocButton.BackColor = Color.Green;
                IsLoc = true;

                (sender as Button).BackColor = Color.Green;
                IsApp = true;
            }
        }
        //быстрое движение
        private void TrainingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                this.plane.Heading -= 5;
                checkHeading();
            }
            else if (e.KeyCode == Keys.E)
            {
                this.plane.Heading += 5;
                checkHeading();
            }
            //набор высоты
            else if (e.KeyCode == Keys.W)
            {
                this.pictureBox1.Image = Image.FromFile("..\\..\\..\\images\\PFD_climb.png");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.plane.Heingt += 100;
                if (this.plane.Heingt > 3000)
                {
                    this.plane.Heingt = 3000;
                }
                this.YHorizontal -= 8;
                //обновление высоты
                this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
                this.HeightPFD.Text = $"{plane.Heingt}";
            }
            //снижение
            else if (e.KeyCode == Keys.S)
            {
                this.pictureBox1.Image = Image.FromFile("..\\..\\..\\images\\PFD_descent.png");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.plane.Heingt -= 100;
                if (plane.Heingt < 0)
                {
                    heightZero();
                }
                this.YHorizontal += 8;
                this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
                this.HeightPFD.Text = $"{plane.Heingt}";

            }
            //скорость увеличение и уменьшение
            else if (e.KeyCode == Keys.A)
            {
                this.plane.Speed -= 10;
                if (plane.Speed < 0)
                {
                    plane.Speed = 0;
                }
                this.SpeedLabelPFD.Text = $"{plane.Speed}";
                if (plane.Speed < 130 && !checkRunway())
                {
                    timer.Stop();
                    MessageBox.Show("Сваливание! Самолет разбился", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                this.plane.Speed += 10;
                if (plane.Speed >= 200)
                {
                    plane.Speed = 200;
                }
                this.SpeedLabelPFD.Text = $"{plane.Speed}";
            }
        }
    }
}
