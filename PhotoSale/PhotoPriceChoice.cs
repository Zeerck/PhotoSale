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
            InitializeComponent(); //Изначально окно вызывается как модальное диалоговое окно
        }

        private void PhotoPriceChoice_Load(object sender, EventArgs e)
        {
            OkButton.DialogResult = DialogResult.OK; //Здесь кнопка "ОК" становится результатом диалога
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (_wbPhotoPrice9x12.Text.Length == 0)
            {
                wbPhotoPriceChoice9x12 = 0;
            }
            if (_wbPhotoPrice12x15.Text.Length == 0)
            {
                wbPhotoPriceChoice12x15 = 0;
            }
            if (_wbPhotoPrice18x24.Text.Length == 0)
            {
                wbPhotoPriceChoice18x24 = 0;
            }
            if (_cPhotoPrice9x12.Text.Length == 0)
            {
                cPhotoPriceChoice9x12 = 0;
            }
            if (_cPhotoPrice12x15.Text.Length == 0)
            {
                cPhotoPriceChoice12x15 = 0;
            }
            if (_cPhotoPrice18x24.Text.Length == 0)
            {
                cPhotoPriceChoice18x24 = 0;
            }
            else
            {
                wbPhotoPriceChoice9x12 = Convert.ToInt32(_wbPhotoPrice9x12.Text);
                wbPhotoPriceChoice12x15 = Convert.ToInt32(_wbPhotoPrice12x15.Text);
                wbPhotoPriceChoice18x24 = Convert.ToInt32(_wbPhotoPrice18x24.Text);

                cPhotoPriceChoice9x12 = Convert.ToInt32(_cPhotoPrice9x12.Text);
                cPhotoPriceChoice12x15 = Convert.ToInt32(_cPhotoPrice12x15.Text);
                cPhotoPriceChoice18x24 = Convert.ToInt32(_cPhotoPrice18x24.Text);
            }
        }
    }
}
