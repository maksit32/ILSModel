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


        //ВСЕ данные о ВС, кроме его местоположения
        private Plane plane = new Plane { Course = 90, Heading = 270, Heingt = 4000, Minimum = 200, Speed = 220 };
        //положения точек(ВС) для разных координатных плоскостей
        //глиссада
        private int XHorizontal;
        private int YHorizontal;
        //курс
        private int XVertical;
        private int YVertical;
        //задача полета (ЛИБО ТАЙМЕР)
        //private Task task;



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

        //x,y,какую точку проекции проверить
        private void checkCoordinates(ref int X, ref int Y, bool IsHorizontal)
        {

        }

        //полет ВС
        private void timer_Tick(object sender, EventArgs e)
        {
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
                    XVertical += 5;
                    YVertical += 5;
                    this.PlaneVertical.Location = new Point(XVertical, YVertical);


                    //высота
                    //XHorizontal += 5;
                    //YHorizontal += 5;
                    this.PlaneHorizontal.Location = new Point(XHorizontal, YHorizontal);
                }
            }
            else
            {
                //если приземлился
                //полет остановлен
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

        }

        private void HeadingRightButton_Click(object sender, EventArgs e)
        {

        }
        //высота управление ручное!
        private void HeightUP_Click(object sender, EventArgs e)
        {

        }

        private void HeightDown_Click(object sender, EventArgs e)
        {

        }
        //закрылки!
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
