using System;
using System.Windows.Forms;

namespace PhotoSale
{
    public partial class PhotoPriceChoice : Form
    {
        public static int wbPhotoPriceChoice9x12,
                             wbPhotoPriceChoice12x15,
                             wbPhotoPriceChoice18x24,
                             cPhotoPriceChoice9x12,
                             cPhotoPriceChoice12x15,
                             cPhotoPriceChoice18x24;

        public PhotoPriceChoice()
        {
            InitializeComponent(); //Изначально эта форма вызывается как модальное диалоговое окно
        }

        private void PhotoPriceChoice_Load(object sender, EventArgs e)
        {
            OkButton.DialogResult = DialogResult.OK; //Здесь кнопка "ОК" становится результатом диалога
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //Если поля пустые, то цена ставится на 0
            if (_wbPhotoPrice9x12.Text.Length == 0)
            {
                _wbPhotoPrice9x12.Text = "0";
            }
            if (_wbPhotoPrice12x15.Text.Length == 0)
            {
                _wbPhotoPrice12x15.Text = "0";
            }
            if (_wbPhotoPrice18x24.Text.Length == 0)
            {
                _wbPhotoPrice18x24.Text = "0";
            }
            if (_cPhotoPrice9x12.Text.Length == 0)
            {
                _cPhotoPrice9x12.Text = "0";
            }
            if (_cPhotoPrice12x15.Text.Length == 0)
            {
                _cPhotoPrice12x15.Text = "0";
            }
            if (_cPhotoPrice18x24.Text.Length == 0)
            {
                _cPhotoPrice18x24.Text = "0";
            }

            try
            {
                //Конвертируем строки в числа
                wbPhotoPriceChoice9x12 = Convert.ToInt32(_wbPhotoPrice9x12.Text);
                wbPhotoPriceChoice12x15 = Convert.ToInt32(_wbPhotoPrice12x15.Text);
                wbPhotoPriceChoice18x24 = Convert.ToInt32(_wbPhotoPrice18x24.Text);

                cPhotoPriceChoice9x12 = Convert.ToInt32(_cPhotoPrice9x12.Text);
                cPhotoPriceChoice12x15 = Convert.ToInt32(_cPhotoPrice12x15.Text);
                cPhotoPriceChoice18x24 = Convert.ToInt32(_cPhotoPrice18x24.Text);
            }

            catch (FormatException)
            {
                MessageBox.Show("Поля с ценой могут содержать только цифры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
