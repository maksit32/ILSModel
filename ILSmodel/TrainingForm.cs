using System;
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
        private bool OnRnW = false; //при посадке (чтоб не разбиться)


        //ВСЕ данные о ВС, кроме его местоположения
        private Plane plane = new Plane { Course = 90, Heading = 270, Heingt = 4000, Minimum = 200, Speed = 220 };
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

        //проверка координат (габаритов) в полете + сам полет
        private void checkCoordinates()
        {
            //проверка по x,y вертикальной точки
            if (XVertical < 0 || YVertical < 16 || YVertical > 469 || XVertical > 467)
            {
                Random rand = new Random();
                //разворот ВС на рандомный курс поворот
                this.plane.Heading += rand.Next(1, 180);
                checkHeading();
                fly();
            }
            else
            {
                fly();
            }


            //проверка по x,y горизонтальной точки (высота)
            if (XHorizontal < 6) //лево
            {
                XHorizontal = 6;
            }
            if (XHorizontal > 459) //право
            {
                XHorizontal = 459;
            }
            if (YHorizontal < 16) //верх
            {
                YHorizontal = 16;
            }
            if (YHorizontal > 263) //низ (ниже ВПП высота быть не может!)
            {
                YHorizontal = 263;
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
            }
            else if (this.plane.Heading == 180)
            {
                YVertical += 5;
            }
            else if (this.plane.Heading == 270)
            {
                XVertical -= 5;
            }
            else if (this.plane.Heading >= 1 && this.plane.Heading < 22)
            {
                XVertical += 1;
                YVertical -= 3;
            }
            else if (this.plane.Heading >= 22 && this.plane.Heading < 45)
            {
                XVertical += 2;
                YVertical -= 2;
            }
            else if (this.plane.Heading >= 45 && this.plane.Heading < 67)
            {
                XVertical += 3;
                YVertical -= 1;
            }
            else if (this.plane.Heading >= 67 && this.plane.Heading < 90)
            {
                XVertical += 4;
                YVertical -= 1;
            }
            else if (this.plane.Heading >= 91 && this.plane.Heading < 112)
            {
                XVertical += 3;
                YVertical += 1;
            }
            else if (this.plane.Heading >= 112 && this.plane.Heading < 135)
            {
                XVertical += 2;
                YVertical += 2;
            }
            else if (this.plane.Heading >= 135 && this.plane.Heading < 157)
            {
                XVertical += 1;
                YVertical += 3;
            }
            else if (this.plane.Heading >= 157 && this.plane.Heading < 180)
            {
                XVertical += 1;
                YVertical += 4;
            }
            else if (this.plane.Heading >= 181 && this.plane.Heading < 202)
            {
                XVertical -= 1;
                YVertical += 3;
            }
            else if (this.plane.Heading >= 202 && this.plane.Heading < 225)
            {
                XVertical -= 2;
                YVertical += 2;
            }
            else if (this.plane.Heading >= 225 && this.plane.Heading < 247)
            {
                XVertical -= 3;
                YVertical += 1;
            }
            else if (this.plane.Heading >= 247 && this.plane.Heading < 270)
            {
                XVertical -= 4;
                YVertical += 1;
            }
            else if (this.plane.Heading >= 271 && this.plane.Heading < 292)
            {
                XVertical -= 3;
                YVertical -= 1;
            }
            else if (this.plane.Heading >= 292 && this.plane.Heading < 315)
            {
                XVertical -= 2;
                YVertical -= 2;
            }
            else if (this.plane.Heading >= 315 && this.plane.Heading < 337)
            {
                XVertical -= 1;
                YVertical -= 3;
            }
            else if (this.plane.Heading >= 337 && this.plane.Heading < 360)
            {
                XVertical -= 1;
                YVertical -= 4;
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

                }
                //захвачен курсовой без глиссады
                else if (IsLoc)
                {

                }
                //обычный полет
                else
                {
                    //сдвиг координат + самолетов
                    //курс
                    //движение ВС
                    //XVertical += 5;
                    //YVertical += 5;
                    checkCoordinates(); //+fly сам полет
                    //this.plane.Heading += 5;
                    //меняем текст
                    this.HeadingLabel.Text = $"Курс ВС: {plane.Heading}";
                    this.HeadingLabelNav.Text = $"{plane.Heading}";
                    //сдвиг ВС
                    this.PlaneVertical.Location = new Point(XVertical, YVertical);


                    //высота
                    //движение
                    //XHorizontal += 5;
                    //YHorizontal += 5;
                    checkCoordinates();
                    //сдвиг ВС
                    this.PlaneHorizontal.Location = new Point(XHorizontal, YHorizontal);


                    /*
                     * 1) присвоить координаты X,Y
                     * 2) проверить координаты на габариты
                     * 3) передвинуть вс
                     */
                }
            }
            else
            {
                //если приземлился
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
            if (this.plane.Heingt > 4500)
            {
                this.plane.Heingt = 4500;
            }
            this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
            this.HeightPFD.Text = $"{plane.Heingt}";
        }

        private void HeightDown_Click(object sender, EventArgs e)
        {
            //изменение высоты ВС
            if (plane.Heingt > 250)
            {
                this.plane.Heingt -= 100;
                this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
                this.HeightPFD.Text = $"{plane.Heingt}";
            }
            else if (plane.Heingt > 0 && plane.Heingt <= 250)
            {
                this.plane.Heingt -= 50;
                //защита за габариты
                if (this.plane.Heingt < 0)
                {
                    this.plane.Heingt = 0;
                }
                this.HeightLabel.Text = $"Высота ВС:  {plane.Heingt}ft";
                this.HeightPFD.Text = $"{plane.Heingt}";
            }
            //height == 0
            else
            {
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
            if ((XVertical >= XRnw && XVertical <= XRnw + 150) && (YVertical > YRnw - 4 && YVertical < YRnw + 4))
            {
                OnRnW = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        //закрылки! (test)
        private void FlapsUpButton_Click(object sender, EventArgs e)
        {

        }

        private void FlapsDownButton_Click(object sender, EventArgs e)
        {

        }
        //захват курсового!
        private void LocButton_Click(object sender, EventArgs e)
        {

        }
        //захват глиссадного + курсового
        private void APPButton_Click(object sender, EventArgs e)
        {

        }
    }
}
