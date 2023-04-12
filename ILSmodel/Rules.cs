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
    public partial class Rules : Form
    {
        //bool
        private bool IsLoc = false;
        private bool IsApp = false;


        public Rules()
        {
            InitializeComponent();
            this.textBox1.Enabled = false;
            this.textBox1.Text = $"Q - курс влево, E - курс вправо{Environment.NewLine}A - снизить скорость,{Environment.NewLine}D - увеличить скорость{Environment.NewLine}W - набрать высоту, S - снизиться";
        }

        private void Rules_Load(object sender, EventArgs e)
        {
            
        }

        private void LocButton_Click(object sender, EventArgs e)
        {
            //отключение
            if(IsLoc) 
            {
                (sender as Button).BackColor = Color.Red;
                IsLoc = false;
                AppButton.BackColor = Color.Red;
                IsApp = false;
            }
            else
            {
                (sender as Button).BackColor = Color.Green;
                IsLoc = true;
            }
        }

        private void AppButton_Click(object sender, EventArgs e)
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
    }
}
