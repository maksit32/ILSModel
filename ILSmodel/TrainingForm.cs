using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
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
        private bool GoAroud = false;


        //ВСЕ данные о ВС, кроме его местоположения
        private Plane plane = new Plane { Course = 90, Heading = 270, Heingt = 3000, Minimum = 100, Speed = 200 };
        //положения точек(ВС) для разных координатных плоскостей
        //глиссада
        private int XHorizontal;
        private int YHorizontal;
        //курс
        private int XVertical;
        private int YVertical;
        //counter
        private int counter = 0;



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

            //убрать flight directors
            this.FlightDirector.Visible = false;
            //убрать кнопку продолжения полета
            ContinueButton.Enabled = false;
            ContinueButton.Visible = false;
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
            if (this.plane.Heingt <= 0)
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
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    //как и курсовой, только дополнительно сдвиг по глиссадному (XHoriz, YHoriz)
                    if ((XVertical > 22 && XVertical < 47) && (YVertical > 133 && YVertical <= 212))
                    {
                        this.FlightDirector.Location = new Point(47, 223);
                        //двигаем x
                        XVertical += 3;
                        XHorizontal += 3;
                        //двигаем y
                        YVertical += 4;
                        YHorizontal++;
                        //уменьшаем высоту ВС + обновляем данные
                        this.plane.Heingt -= 15;
                        if (checkRunway())   //если на полосе
                        {
                            if (plane.Heingt <= 30)
                            {
                                this.plane.Heingt = 0;
                            }
                            else
                            {
                                this.plane.Heingt -= 15;
                            }
                        }
                        this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
                        this.HeightPFD.Text = $"{plane.Heingt}";
                        //снижение скорости
                        if (plane.Speed != 140)
                        {
                            plane.Speed -= 10;
                            this.SpeedLabelPFD.Text = plane.Speed.ToString();
                        }
                        //меняем курс
                        plane.Heading = 120;
                        //меняем текст
                        this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                        this.HeadingLabelNav.Text = $"{plane.Heading}";
                        //двигаем самолет
                        PlaneVertical.Location = new Point(XVertical, YVertical);
                        PlaneHorizontal.Location = new Point(XHorizontal, YHorizontal);
                    }
                    //резко сдвигаемся на точку 2 (сверху)
                    else if ((XVertical >= 47 && XVertical <= 95) && (YVertical > 133 && YVertical <= 211))
                    {
                        this.FlightDirector.Location = new Point(75, 223);
                        //двигаем x
                        XVertical += 2;
                        XHorizontal += 2;
                        //двигаем y
                        YVertical += 5;
                        YHorizontal++;
                        //уменьшаем высоту ВС + обновляем данные
                        this.plane.Heingt -= 15;
                        if (checkRunway())   //если на полосе
                        {
                            if (plane.Heingt <= 30)
                            {
                                this.plane.Heingt = 0;
                            }
                            else
                            {
                                this.plane.Heingt -= 15;
                            }
                        }
                        this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
                        this.HeightPFD.Text = $"{plane.Heingt}";
                        //снижение скорости
                        if (plane.Speed != 140)
                        {
                            plane.Speed -= 10;
                            this.SpeedLabelPFD.Text = plane.Speed.ToString();
                        }
                        //меняем курс
                        plane.Heading = 150;
                        //меняем текст
                        this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                        this.HeadingLabelNav.Text = $"{plane.Heading}";
                        //двигаем самолет
                        PlaneVertical.Location = new Point(XVertical, YVertical);
                        PlaneHorizontal.Location = new Point(XHorizontal, YHorizontal);
                    }
                    //спокойно сдвигаемся на точку 1(снизу)
                    else if ((XVertical > 22 && XVertical < 47) && (YVertical >= 220 && YVertical < 340))
                    {
                        this.FlightDirector.Location = new Point(160, 223);
                        //двигаем x
                        XVertical += 3;
                        XHorizontal += 3;
                        //двигаем y
                        YVertical -= 4;
                        YHorizontal++;
                        //уменьшаем высоту ВС + обновляем данные
                        this.plane.Heingt -= 15;
                        if (checkRunway())   //если на полосе
                        {
                            if (plane.Heingt <= 30)
                            {
                                this.plane.Heingt = 0;
                            }
                            else
                            {
                                this.plane.Heingt -= 15;
                            }
                        }
                        this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
                        this.HeightPFD.Text = $"{plane.Heingt}";
                        //снижение скорости
                        if (plane.Speed != 140)
                        {
                            plane.Speed -= 10;
                            this.SpeedLabelPFD.Text = plane.Speed.ToString();
                        }
                        //меняем курс
                        plane.Heading = 40;
                        //меняем текст
                        this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                        this.HeadingLabelNav.Text = $"{plane.Heading}";
                        //двигаем самолет
                        PlaneVertical.Location = new Point(XVertical, YVertical);
                        PlaneHorizontal.Location = new Point(XHorizontal, YHorizontal);
                    }
                    //резко сдвигаемся на точку 2 (снизу)
                    else if ((XVertical >= 47 && XVertical <= 95) && (YVertical >= 221 && YVertical < 340))
                    {
                        this.FlightDirector.Location = new Point(186, 223);
                        //двигаем x
                        XVertical += 2;
                        XHorizontal += 2;
                        //двигаем y
                        YVertical -= 5;
                        YHorizontal++;
                        //уменьшаем высоту ВС + обновляем данные
                        this.plane.Heingt -= 15;
                        if (checkRunway())   //если на полосе
                        {
                            if (plane.Heingt <= 30)
                            {
                                this.plane.Heingt = 0;
                            }
                            else
                            {
                                this.plane.Heingt -= 15;
                            }
                        }
                        this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
                        this.HeightPFD.Text = $"{plane.Heingt}";
                        //снижение скорости
                        if (plane.Speed != 140)
                        {
                            plane.Speed -= 10;
                            this.SpeedLabelPFD.Text = plane.Speed.ToString();
                        }
                        //меняем курс
                        plane.Heading = 30;
                        //меняем текст
                        this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                        this.HeadingLabelNav.Text = $"{plane.Heading}";
                        //двигаем самолет
                        PlaneVertical.Location = new Point(XVertical, YVertical);
                        PlaneHorizontal.Location = new Point(XHorizontal, YHorizontal);
                    }
                    //на курсовом, просто двигаемся по x + снижение скорости
                    else if ((XVertical >= 47 && XVertical < 150) && (YVertical == 216))
                    {
                        this.FlightDirector.Location = new Point(117, 223);
                        //снижение скорости
                        if (plane.Speed != 140)
                        {
                            plane.Speed -= 10;
                            this.SpeedLabelPFD.Text = plane.Speed.ToString();
                        }
                        if (YVertical >= 214 && YVertical <= 217)
                        {
                            YVertical = 215;
                        }
                        //двигаем x
                        XVertical += 5;
                        XHorizontal += 5;
                        //снижаюсь по X
                        YHorizontal++;
                        //уменьшаем высоту ВС + обновляем данные
                        this.plane.Heingt -= 15;
                        if (checkRunway())   //если на полосе
                        {
                            if (plane.Heingt <= 30)
                            {
                                this.plane.Heingt = 0;
                            }
                            else
                            {
                                this.plane.Heingt -= 15;
                            }
                        }
                        this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
                        this.HeightPFD.Text = $"{plane.Heingt}";
                        //меняем курс
                        plane.Heading = 90;
                        //меняем текст
                        this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                        this.HeadingLabelNav.Text = $"{plane.Heading}";
                        //двигаем самолет
                        PlaneVertical.Location = new Point(XVertical, YVertical);
                        PlaneHorizontal.Location = new Point(XHorizontal, YHorizontal);
                    }
                    //протягивание (не захватил)
                    else if (XVertical < 390)
                    {
                        this.FlightDirector.Location = new Point(117, 223);
                        //снижение скорости
                        if (plane.Speed != 140)
                        {
                            plane.Speed -= 10;
                            this.SpeedLabelPFD.Text = plane.Speed.ToString();
                        }
                        if (YVertical >= 214 && YVertical <= 217)
                        {
                            YVertical = 215;
                        }
                        //двигаем x
                        XVertical += 5;
                        XHorizontal += 5;
                        //уменьшаем высоту ВС + обновляем данные
                        this.plane.Heingt -= 15;
                        if (checkRunway())   //если на полосе
                        {
                            if (plane.Heingt <= 30)
                            {
                                this.plane.Heingt = 0;
                            }
                            else
                            {
                                this.plane.Heingt -= 15;
                            }
                        }
                        this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
                        this.HeightPFD.Text = $"{plane.Heingt}";
                        //двигаю y
                        YHorizontal++;
                        //меняем курс
                        plane.Heading = 90;
                        //меняем текст
                        this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                        this.HeadingLabelNav.Text = $"{plane.Heading}";
                        //двигаем самолет
                        PlaneVertical.Location = new Point(XVertical, YVertical);
                        PlaneHorizontal.Location = new Point(XHorizontal, YHorizontal);
                    }
                    //захватил но пилот не приземлился
                    else
                    {
                        LocButton_Click(sender, e);
                    }

                }
                //захвачен курсовой без глиссады
                else if (IsLoc)
                {
                    //натяжка на курсовой (алгоритм)
                    //чтобы после lock менялась высота
                    //спокойно сдвигаемся на точку 1(сверху)
                    this.PlaneHorizontal.Location = new Point(XHorizontal, YHorizontal);
                    //PFD -- выравнивание
                    this.pictureBox1.Image = Image.FromFile("..\\..\\..\\images\\PFD_center.png");
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    if ((XVertical > 22 && XVertical < 47) && (YVertical > 133 && YVertical <= 212))
                    {
                        this.FlightDirector.Location = new Point(75, 223);
                        //двигаем x
                        XVertical += 3;
                        XHorizontal += 3;
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
                    else if ((XVertical >= 47 && XVertical <= 95) && (YVertical > 133 && YVertical <= 211))
                    {
                        this.FlightDirector.Location = new Point(47, 223);
                        //двигаем x
                        XVertical += 2;
                        XHorizontal += 2;
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
                    else if ((XVertical > 22 && XVertical < 47) && (YVertical >= 220 && YVertical < 340))
                    {
                        this.FlightDirector.Location = new Point(160, 223);
                        //двигаем x
                        XVertical += 3;
                        XHorizontal += 3;
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
                    else if ((XVertical >= 47 && XVertical <= 95) && (YVertical >= 221 && YVertical < 340))
                    {
                        this.FlightDirector.Location = new Point(186, 223);
                        //двигаем x
                        XVertical += 2;
                        XHorizontal += 2;
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
                    else if ((XVertical >= 47 && XVertical < 150) && (YVertical == 216))
                    {
                        this.FlightDirector.Location = new Point(117, 223);
                        //снижение скорости
                        if (plane.Speed != 140)
                        {
                            plane.Speed -= 10;
                            this.SpeedLabelPFD.Text = plane.Speed.ToString();
                        }
                        if (YVertical >= 214 && YVertical <= 217)
                        {
                            YVertical = 215;
                        }
                        //двигаем x
                        XVertical += 5;
                        XHorizontal += 5;
                        //меняем курс
                        plane.Heading = 90;
                        //меняем текст
                        this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                        this.HeadingLabelNav.Text = $"{plane.Heading}";
                        //двигаем самолет
                        PlaneVertical.Location = new Point(XVertical, YVertical);
                    }
                    //протягивание (не захватил)
                    else if (XVertical < 390)
                    {
                        this.FlightDirector.Location = new Point(117, 223);
                        //снижение скорости
                        if (plane.Speed != 140)
                        {
                            plane.Speed -= 10;
                            this.SpeedLabelPFD.Text = plane.Speed.ToString();
                        }
                        if (YVertical >= 214 && YVertical <= 217)
                        {
                            YVertical = 215;
                        }
                        //двигаем x
                        XVertical += 5;
                        XHorizontal += 5;
                        //меняем курс
                        plane.Heading = 90;
                        //меняем текст
                        this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                        this.HeadingLabelNav.Text = $"{plane.Heading}";
                        //двигаем самолет
                        PlaneVertical.Location = new Point(XVertical, YVertical);
                    }
                    //захватил но пилот не приземлился
                    else
                    {
                        LocButton_Click(sender, e);
                    }
                }
                //goAround
                else if(GoAroud)
                {
                    //выравниваем PFD
                    //Thread.Sleep(100);
                    this.pictureBox1.Image = Image.FromFile("..\\..\\..\\images\\PFD_climb.png");
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    checkCoordinates();
                    //меняем текст
                    this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                    this.HeadingLabelNav.Text = $"{plane.Heading}";
                    //сдвиг ВС
                    this.PlaneVertical.Location = new Point(XVertical, YVertical);

                    //передвижение координат
                    goAroundFly();

                    //горизонталь
                    //сдвиг ВС
                    this.PlaneHorizontal.Location = new Point(XHorizontal, YHorizontal);
                }
                //обычный полет
                else
                {
                    //выравниваем PFD
                    //Thread.Sleep(100);
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
                plane.Heingt = 0;
                this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
                this.HeightPFD.Text = $"{plane.Heingt}";
                //на полосу (мало ли ошибка)
                this.PlaneHorizontal.Location = new Point(XHorizontal, 260);
                MessageBox.Show("Самолет успешно приземлился", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void goAroundFly()
        {
            //просто набор высоты  и движение вдроль ВПП
            XHorizontal += 7;  
            XVertical += 7;
            if(plane.Heingt < 3000)
            {
                YHorizontal -= 2;
                plane.Heingt += 120;
                this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
                this.HeightPFD.Text = $"{plane.Heingt}";
            }
            else
            {
                plane.Heingt = 3000;
                this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
                this.HeightPFD.Text = $"{plane.Heingt}";
            }
            if (XHorizontal >= 432)
            {
                timer.Stop();
                MessageBox.Show("Самолет ушел на 2 круг", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //отказ кнопок (заход будет ручной либо уход на 2 круг)
            (sender as Button).BackColor = Color.Red;
            this.LocButton.BackColor = Color.Black;
            this.LocButton.Enabled = false;
            this.APPButton.BackColor = Color.Black;
            this.APPButton.Enabled = false;
           


            //запуск таймера на уход (если было что-то захвачено)
            if (IsLoc || IsApp)
            {
                //показываем кнопку продолжить снижение
                ContinueButton.Enabled = true;
                ContinueButton.Visible = true;
                GoAroud = true; //по умолчанию уход на 2 круг
                timeNotToGoAround.Start();
            }

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
            if ((XVertical >= XRnw && XVertical <= XRnw + 215) && (YVertical > YRnw - 6 && YVertical < YRnw + 6))
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

                    //появился маркер
                    this.FlightDirector.Visible = true;
                }
            }
        }
        //на курсе
        private bool OnLock()
        {
            //сверяю координаты ВС и курсового маяка
            if ((XVertical > 22 && XVertical < 95) && (YVertical > 133 && YVertical < 340))
            {
                return true;
            }
            return false;
        }
        //на глиссаде
        private bool OnGlide()
        {
            const int XGlideBegin = 92;
            //const int XGlideEnd = 363;
            const int YGlideBegin = 226;
            //const int YGlideEnd = 265;


            //вошел ровно в глиссаду
            if ((XHorizontal >= XGlideBegin - 6 && XHorizontal <= XGlideBegin + 6) && (YHorizontal >= YGlideBegin - 6 && YHorizontal <= YGlideBegin + 6))
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

                //разрешение нормального полета
                this.KeyPreview = true;
                HeadingLeftButton.Enabled = true;
                HeadingRightButton.Enabled = true;
                HeightUP.Enabled = true;
                HeightDown.Enabled = true;
            }
            else
            {
                //если захватил курс и глиссаду
                if (OnLock() && OnGlide())
                {
                    //маркеры
                    LocButton.BackColor = Color.Green;
                    IsLoc = true;

                    (sender as Button).BackColor = Color.Green;
                    IsApp = true;

                    //запретить ручное управление
                    this.KeyPreview = false;
                    //запрет изменения курса
                    HeadingLeftButton.Enabled = false;
                    HeadingRightButton.Enabled = false;
                    //запрет набора высоты
                    HeightUP.Enabled = false;
                    HeightDown.Enabled = false;

                    //появился маркер
                    this.FlightDirector.Visible = true;
                }
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
        //пользователь решает продолжить снижение при отказе, либо будет goAround автоматически
        private void timeNotToGoAround_Tick(object sender, EventArgs e)
        {
            //мигаем
            if (counter % 2 == 0)
            {
                this.FailureButton.ForeColor = Color.Yellow;
            }
            else
            {
                this.FailureButton.ForeColor = Color.Black;
            }

            //есть 2 цикла на нажатие кнопки продолжения посадки в авторежиме
            //ручная посадка
            if (counter == 2 && !GoAroud)
            {
                //bool
                IsApp = false;
                IsLoc = false;
                IsLanded = false;
                this.timeNotToGoAround.Stop();
            }
            //уход на 2 круг
            else if (counter == 2 && GoAroud)
            {
                this.timeNotToGoAround.Stop();
                goAround();
            }
            counter++;
        }
        //алгоритм ухода на 2 круг
        private void goAround()
        {
            //отключить все!
            IsApp = false;
            IsLoc = false;
            IsLanded = false;
            GoAroud = true;

            MessageBox.Show("Go Around!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            GoAroud = false;
            this.KeyPreview = true;
        }
    }
}
