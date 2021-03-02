using System;
using System.Windows.Forms;

namespace PhotoSale
{
    public partial class MainForm : Form
    {
        //Приписка _c — Цена для цветного фото. Приписка _wb — Цена для Чёрно-Белого фото
        private static float _cPhotoPrice9x12 = 8.5f,
                             _cPhotoPrice12x15 = 11.0f,
                             _cPhotoPrice18x24 = 32.0f,
                             _wbPhotoPrice9x12 = 5.0f,
                             _wbPhotoPrice12x15 = 7.0f,
                             _wbPhotoPrice18x24 = 24.0f;

        private static string PhotoText9x12 = "Фото 9х12",
                              PhotoText12x15 = "Фото 12х15",
                              PhotoText18x24 = "Фото 18х24",
                              _wbPrintMode = "ЧБ",
                              _cPrintMode = "Цветной";

        private static int Discount = 10;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserInputPhotoFormat.Items.Add(PhotoText9x12);
            UserInputPhotoFormat.Items.Add(PhotoText12x15);
            UserInputPhotoFormat.Items.Add(PhotoText18x24);

            UserInputPrintMode.Items.Add(_cPrintMode);
            UserInputPrintMode.Items.Add(_wbPrintMode);

            UserInputPrintMode.SelectedIndex = 0;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int UserPhotoNumber = Convert.ToInt32(UserInputPhotoNumber.Text);
            if (UserInputPrintMode.SelectedIndex == 0)
            {
                _wbTotalPriceCalculate(UserPhotoNumber);
            }

            if (UserInputPrintMode.SelectedIndex == 1)
            {
                _cTotalPriceCalculate(UserPhotoNumber);
            }
        }

        private void _wbTotalPriceCalculate(int UserPhotoNumber)
        {
            //Итоговая цена
            float TotalPricePhoto9x12 = UserPhotoNumber * _wbPhotoPrice9x12;
            float TotalPricePhoto12x15 = UserPhotoNumber * _wbPhotoPrice12x15;
            float TotalPricePhoto18x24 = UserPhotoNumber * _wbPhotoPrice18x24;

            //Итоговая скидка
            float TotalDiscount9x12 = TotalPricePhoto9x12 * Discount / 100;
            float TotalDiscount12x15 = TotalPricePhoto12x15 * Discount / 100;
            float TotalDiscount18x24 = TotalPricePhoto18x24 * Discount / 100;

            //Итоговая цена со скидкой
            float UserPriceWithDiscount9x12 = TotalPricePhoto9x12 - TotalDiscount9x12;
            float UserPriceWithDiscount12x15 = TotalPricePhoto12x15 - TotalDiscount12x15;
            float UserPriceWithDiscount18x24 = TotalPricePhoto18x24 - TotalDiscount18x24;

            //Рассчёт суммы взависимости от выбора формата фото
            if (UserInputPhotoFormat.SelectedIndex == 0 && UserPhotoNumber < 20) //1 элемент, фото 9 на 12
            {
                TotalPrice.Text = Convert.ToString(UserPhotoNumber * _wbPhotoPrice9x12) + " руб.";
                return;
            }
            if (UserInputPhotoFormat.SelectedIndex == 0 && UserPhotoNumber > 20)
            {
                TotalPrice.Text = Convert.ToString(UserPriceWithDiscount9x12) + $" руб. Со скидкой {Discount}%!";
                return;
            }
            
            if (UserInputPhotoFormat.SelectedIndex == 1 && UserPhotoNumber < 20) //2 элемент, фото 12 на 15
            {
                TotalPrice.Text = Convert.ToString(UserPhotoNumber * _wbPhotoPrice12x15) + " руб.";
                return;
            }
            if (UserInputPhotoFormat.SelectedIndex == 1 && UserPhotoNumber > 20)
            {
                TotalPrice.Text = Convert.ToString(UserPriceWithDiscount12x15) + $" руб. Со скидкой {Discount}%!";
                return;
            }
            
            if (UserInputPhotoFormat.SelectedIndex == 2 && UserPhotoNumber < 20) //3 элемент, фото 18 на 24
            {
                TotalPrice.Text = Convert.ToString(UserPhotoNumber * _wbPhotoPrice18x24) + " руб.";
                return;
            }
            if (UserInputPhotoFormat.SelectedIndex == 2 && UserPhotoNumber > 20)
            {
                TotalPrice.Text = Convert.ToString(UserPriceWithDiscount18x24) + $" руб. Со скидкой {Discount}%!";
                return;
            }
        }
        private void _cTotalPriceCalculate(int UserPhotoNumber)
        {
            //Итоговая цена
            float TotalPricePhoto9x12 = UserPhotoNumber * _cPhotoPrice9x12;
            float TotalPricePhoto12x15 = UserPhotoNumber * _cPhotoPrice12x15;
            float TotalPricePhoto18x24 = UserPhotoNumber * _cPhotoPrice18x24;

            //Итоговая скидка
            float TotalDiscount9x12 = TotalPricePhoto9x12 * Discount / 100;
            float TotalDiscount12x15 = TotalPricePhoto12x15 * Discount / 100;
            float TotalDiscount18x24 = TotalPricePhoto18x24 * Discount / 100;

            //Итоговая цена со скидкой
            float UserPriceWithDiscount9x12 = TotalPricePhoto9x12 - TotalDiscount9x12;
            float UserPriceWithDiscount12x15 = TotalPricePhoto12x15 - TotalDiscount12x15;
            float UserPriceWithDiscount18x24 = TotalPricePhoto18x24 - TotalDiscount18x24;

            //Рассчёт суммы взависимости от выбора формата фото
            if (UserInputPhotoFormat.SelectedIndex == 0 && UserPhotoNumber < 20) //1 элемент, фото 9 на 12
            {
                TotalPrice.Text = Convert.ToString(UserPhotoNumber * _cPhotoPrice9x12) + " руб.";
                return;
            }
            if (UserInputPhotoFormat.SelectedIndex == 0 && UserPhotoNumber > 20)
            {
                TotalPrice.Text = Convert.ToString(UserPriceWithDiscount9x12) + $" руб. Со скидкой {Discount}%!";
                return;
            }
            
            if (UserInputPhotoFormat.SelectedIndex == 1 && UserPhotoNumber < 20) //2 элемент, фото 12 на 15
            {
                TotalPrice.Text = Convert.ToString(UserPhotoNumber * _cPhotoPrice12x15) + " руб.";
                return;
            }
            if (UserInputPhotoFormat.SelectedIndex == 1 && UserPhotoNumber > 20)
            {
                TotalPrice.Text = Convert.ToString(UserPriceWithDiscount12x15) + $" руб. Со скидкой {Discount}%!";
                return;
            }
            
            if (UserInputPhotoFormat.SelectedIndex == 2 && UserPhotoNumber < 20) //3 элемент, фото 18 на 24
            {
                TotalPrice.Text = Convert.ToString(UserPhotoNumber * _cPhotoPrice18x24) + " руб.";
                return;
            }
            if (UserInputPhotoFormat.SelectedIndex == 2 && UserPhotoNumber > 20)
            {
                TotalPrice.Text = Convert.ToString(UserPriceWithDiscount18x24) + $" руб. Со скидкой {Discount}%!";
                return;
            }
        }
    }
}
