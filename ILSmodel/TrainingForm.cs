using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private Plane plane = new Plane { Course = 90, Heading = 90, Heingt = 4000, Minimum = 200, Speed = 220 };
        //положения точек(ВС) для разных координатных плоскостей
        //глиссада
        private int XHorizontal;
        private int YHorizontal;
        //курс
        private int XVertical;
        private int YVertical;
        //задача полета (ЛИБО ТАЙМЕР)
        private Task task;

        public TrainingForm()
        {
            InitializeComponent();
        }

        private void TrainingForm_Load(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы ознакомились с правилами?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res != DialogResult.Yes)
            {
                this.Close();   //закрываем форму и переходим на старт ( где правила )
            }
            //если правила изучены

            //полет начат
            task = new Task(Fly);
            task.Start();
        }

        private void Fly()
        {
            //пока не сел
            while (!IsLanded)
            {
                //захвачен глиссадный и курсовой
                if(IsApp && IsLoc)
                {

                }
                //захвачен курсовой без глиссады
                else if(IsLoc)
                {

                }
                else
                {

                }
            }
            //если приземлился
            //do something

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
    }
}
