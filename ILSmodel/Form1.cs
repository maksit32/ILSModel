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

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"��������� ������������!{Environment.NewLine}����� ���������� �� ��������, ������������ ���� �� 2 ���� � �������������� ������ ��� ������ ��������� ����������.{Environment.NewLine}", "� ���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                //������� �� ������������� �����
                TrainingForm form = new TrainingForm();
                this.Hide();
                form.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("������ �������� ���������");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //�������� ����� � ���������
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