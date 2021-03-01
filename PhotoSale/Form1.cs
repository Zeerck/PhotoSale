using System;
using System.Windows.Forms;

namespace PhotoSale
{
    public partial class Form1 : Form
    {
        private static float PhotoPrice9x12 = 8.5f, PhotoPrice12x15 = 11.0f, PhotoPrice18x24 = 32.0f;
        private static int Discount = 10;
        private static string PhotoText9x12 = $"Фото 9х12", PhotoText12x15 = $"Фото 12х15", PhotoText18x24 = $"Фото 18х24";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserInputPhotoFormat.Items.Add(PhotoText9x12);
            UserInputPhotoFormat.Items.Add(PhotoText12x15);
            UserInputPhotoFormat.Items.Add(PhotoText18x24);
        }

        private void Main()
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int UserPhotoNumber = Convert.ToInt32(UserInputPhotoNumber.Text);

            //Рассчёт суммы взависимости от выбора формата фото
            if (UserInputPhotoFormat.SelectedIndex == 0) //1 элемент, фото 9 на 12
            {
                TotalPrice.Text = Convert.ToString(UserPhotoNumber * PhotoPrice9x12) + " руб.";
            }

            if (UserInputPhotoFormat.SelectedIndex == 1) //2 элемент, фото 12 на 15
            {
                TotalPrice.Text = Convert.ToString(UserPhotoNumber * PhotoPrice12x15) + " руб.";
            }

            if (UserInputPhotoFormat.SelectedIndex == 2) //3 элемент, фото 18 на 24
            {
                TotalPrice.Text = Convert.ToString(UserPhotoNumber * PhotoPrice18x24) + " руб.";
            }
        }
    }
}
