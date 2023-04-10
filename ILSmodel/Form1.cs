namespace ILSmodel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Уважаемый пользователь!{Environment.NewLine}Добро пожаловать на тренажер, моделирующий уход на 2 круг в автоматическом режиме при отказе курсового радиомаяка.{Environment.NewLine}", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                //переход на тренировочную форму
                TrainingForm form = new TrainingForm();
                this.Hide();
                form.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка открытия программы");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открытие формы с правилами
            Rules form = new Rules();
            form.ShowDialog();
        }

        private void StartButton_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.LightBlue;
        }

        private void StartButton_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.White;
        }
    }
}