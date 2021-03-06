using System;
using System.Windows.Forms;

namespace PhotoSale
{
    public partial class MainForm : Form
    {
        //Приписка c — Цена для цветного фото. Приписка wb — Цена для Чёрно-Белого фото
        public static float cPhotoPrice9x12,
                            cPhotoPrice12x15,
                            cPhotoPrice18x24,
                            wbPhotoPrice9x12,
                            wbPhotoPrice12x15,
                            wbPhotoPrice18x24;

        private static string PhotoText9x12 = "Фото на 9х12",
                              PhotoText12x15 = "Фото 12 на 15",
                              PhotoText18x24 = "Фото 18 на 24",
                              _wbPrintMode = "ЧБ",
                              _cPrintMode = "Цветной";

        private static int DiscountPercent = 10;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Добавление форматов фото в соответсвующий список
            UserInputPhotoFormat.Items.Add(PhotoText9x12);
            UserInputPhotoFormat.Items.Add(PhotoText12x15);
            UserInputPhotoFormat.Items.Add(PhotoText18x24);

            //Добавление режимов печати (Цветоной или ЧБ)
            UserInputPrintMode.Items.Add(_cPrintMode);
            UserInputPrintMode.Items.Add(_wbPrintMode);

            //Выбор по умолчанию режим печати "Цветной", чтобы не делать обработку исключений по типу поле пустое
            UserInputPrintMode.SelectedIndex = 0;
            //Выбор по умолчанию "фото 9 на 12", чтобы не делать обработку исключений по типу поле пустое
            UserInputPhotoFormat.SelectedIndex = 0;

            //Поле с ценами
            Prices.Text = $"Цены:\n\n" +
                          $"Цветные:\n" +
                          $"Фото 9 на 12 — {cPhotoPrice9x12} руб.\n" +
                          $"Фото 12 на 15 — {cPhotoPrice12x15} руб\n" +
                          $"Фото 18 на 24 — {cPhotoPrice18x24} руб\n\n" +
                          $"ЧБ:\n" +
                          $"Фото 9 на 12 — {wbPhotoPrice9x12} руб. \n" +
                          $"Фото 12 на 15 — {wbPhotoPrice12x15} руб. \n" +
                          $"Фото 18 на 24 — {wbPhotoPrice18x24} руб. \n";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int UserPhotoNumber = Convert.ToInt32(UserInputPhotoNumber.Text);

            if (UserInputPrintMode.SelectedIndex == 0)
            {
                _cTotalPriceCalculate(UserPhotoNumber);
            }

            if (UserInputPrintMode.SelectedIndex == 1)
            {
                _wbTotalPriceCalculate(UserPhotoNumber);
            }
        }

        private void ChangePricesButton_Click(object sender, EventArgs e)
        {
            PhotoPriceChoice photoPriceChoice = new PhotoPriceChoice();

            DialogResult Result = photoPriceChoice.ShowDialog();

            if (Result == DialogResult.OK)
            {
                //Получаем цены, указанные в форме "Выбор цены для фото"
                cPhotoPrice9x12 = Convert.ToInt32(PhotoPriceChoice.cPhotoPriceChoice9x12);
                cPhotoPrice12x15 = Convert.ToInt32(PhotoPriceChoice.cPhotoPriceChoice12x15);
                cPhotoPrice18x24 = Convert.ToInt32(PhotoPriceChoice.cPhotoPriceChoice18x24);
                wbPhotoPrice9x12 = Convert.ToInt32(PhotoPriceChoice.wbPhotoPriceChoice9x12);
                wbPhotoPrice12x15 = Convert.ToInt32(PhotoPriceChoice.wbPhotoPriceChoice12x15);
                wbPhotoPrice18x24 = Convert.ToInt32(PhotoPriceChoice.wbPhotoPriceChoice18x24);

                //Записываем полученные цены в поле
                Prices.Text = $"Цены:\n\n" +
                              $"Цветные:\n" +
                              $"Фото 9 на 12 — {cPhotoPrice9x12} руб.\n" +
                              $"Фото 12 на 15 — {cPhotoPrice12x15} руб\n" +
                              $"Фото 18 на 24 — {cPhotoPrice18x24} руб\n\n" +
                              $"ЧБ:\n" +
                              $"Фото 9 на 12 — {wbPhotoPrice9x12} руб. \n" +
                              $"Фото 12 на 15 — {wbPhotoPrice12x15} руб. \n" +
                              $"Фото 18 на 24 — {wbPhotoPrice18x24} руб. \n";
            }
        }

        private void _wbTotalPriceCalculate(int UserPhotoNumber) //Цена Чёрно-Белых фото
        {
            //Итоговая цена
            float TotalPricePhoto9x12 = UserPhotoNumber * wbPhotoPrice9x12;
            float TotalPricePhoto12x15 = UserPhotoNumber * wbPhotoPrice12x15;
            float TotalPricePhoto18x24 = UserPhotoNumber * wbPhotoPrice18x24;

            //Итоговая скидка
            float TotalDiscount9x12 = TotalPricePhoto9x12 * DiscountPercent / 100;
            float TotalDiscount12x15 = TotalPricePhoto12x15 * DiscountPercent / 100;
            float TotalDiscount18x24 = TotalPricePhoto18x24 * DiscountPercent / 100;

            //Итоговая цена со скидкой
            float UserPriceWithDiscount9x12 = TotalPricePhoto9x12 - TotalDiscount9x12;
            float UserPriceWithDiscount12x15 = TotalPricePhoto12x15 - TotalDiscount12x15;
            float UserPriceWithDiscount18x24 = TotalPricePhoto18x24 - TotalDiscount18x24;

            //Рассчёт суммы взависимости от выбора формата фото
            if (UserInputPhotoFormat.SelectedIndex == 0 && UserPhotoNumber <= 20) //1 элемент, фото 9 на 12
            {
                TotalPrice.Text = Convert.ToString(UserPhotoNumber * wbPhotoPrice9x12) + " руб.";
                return;
            }
            if (UserInputPhotoFormat.SelectedIndex == 0 && UserPhotoNumber > 20)
            {
                TotalPrice.Text = Convert.ToString(UserPriceWithDiscount9x12) + $" руб. Ваша скидка: {TotalDiscount9x12} руб.";
                return;
            }
            
            if (UserInputPhotoFormat.SelectedIndex == 1 && UserPhotoNumber <= 20) //2 элемент, фото 12 на 15
            {
                TotalPrice.Text = Convert.ToString(UserPhotoNumber * wbPhotoPrice12x15) + " руб.";
                return;
            }
            if (UserInputPhotoFormat.SelectedIndex == 1 && UserPhotoNumber > 20)
            {
                TotalPrice.Text = Convert.ToString(UserPriceWithDiscount12x15) + $" руб. Ваша скидка: {TotalDiscount12x15} руб.";
                return;
            }
            
            if (UserInputPhotoFormat.SelectedIndex == 2 && UserPhotoNumber <= 20) //3 элемент, фото 18 на 24
            {
                TotalPrice.Text = Convert.ToString(UserPhotoNumber * wbPhotoPrice18x24) + " руб.";
                return;
            }
            if (UserInputPhotoFormat.SelectedIndex == 2 && UserPhotoNumber > 20)
            {
                TotalPrice.Text = Convert.ToString(UserPriceWithDiscount18x24) + $" руб. Ваша скидка: {TotalDiscount18x24} руб.";
                return;
            }
        }
        private void _cTotalPriceCalculate(int UserPhotoNumber) //Цена цветных фото
        {
            //Итоговая цена
            float TotalPricePhoto9x12 = UserPhotoNumber * cPhotoPrice9x12;
            float TotalPricePhoto12x15 = UserPhotoNumber * cPhotoPrice12x15;
            float TotalPricePhoto18x24 = UserPhotoNumber * cPhotoPrice18x24;

            //Итоговая скидка
            float TotalDiscount9x12 = TotalPricePhoto9x12 * DiscountPercent / 100;
            float TotalDiscount12x15 = TotalPricePhoto12x15 * DiscountPercent / 100;
            float TotalDiscount18x24 = TotalPricePhoto18x24 * DiscountPercent / 100;

            //Итоговая цена со скидкой
            float UserPriceWithDiscount9x12 = TotalPricePhoto9x12 - TotalDiscount9x12;
            float UserPriceWithDiscount12x15 = TotalPricePhoto12x15 - TotalDiscount12x15;
            float UserPriceWithDiscount18x24 = TotalPricePhoto18x24 - TotalDiscount18x24;

            //Рассчёт суммы взависимости от выбора формата фото
            if (UserInputPhotoFormat.SelectedIndex == 0 && UserPhotoNumber <= 20) //1 элемент, фото 9 на 12
            {
                TotalPrice.Text = Convert.ToString(UserPhotoNumber * cPhotoPrice9x12) + " руб.";
                return;
            }
            if (UserInputPhotoFormat.SelectedIndex == 0 && UserPhotoNumber > 20)
            {
                TotalPrice.Text = Convert.ToString(UserPriceWithDiscount9x12) + $" руб. Ваша скидка: {TotalDiscount9x12} руб.";
                return;
            }
            
            if (UserInputPhotoFormat.SelectedIndex == 1 && UserPhotoNumber <= 20) //2 элемент, фото 12 на 15
            {
                TotalPrice.Text = Convert.ToString(UserPhotoNumber * cPhotoPrice12x15) + " руб.";
                return;
            }
            if (UserInputPhotoFormat.SelectedIndex == 1 && UserPhotoNumber > 20)
            {
                TotalPrice.Text = Convert.ToString(UserPriceWithDiscount12x15) + $" руб. Ваша скидка: {TotalDiscount12x15} руб.";
                return;
            }
            
            if (UserInputPhotoFormat.SelectedIndex == 2 && UserPhotoNumber <= 20) //3 элемент, фото 18 на 24
            {
                TotalPrice.Text = Convert.ToString(UserPhotoNumber * cPhotoPrice18x24) + " руб.";
                return;
            }
            if (UserInputPhotoFormat.SelectedIndex == 2 && UserPhotoNumber > 20)
            {
                TotalPrice.Text = Convert.ToString(UserPriceWithDiscount18x24) + $" руб. Ваша скидка: {TotalDiscount18x24} руб.";
                return;
            }
        }
    }
}
