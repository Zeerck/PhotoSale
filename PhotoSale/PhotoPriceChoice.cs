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
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            wbPhotoPriceChoice9x12 = Convert.ToInt32(_wbPhotoPrice9x12.Text);
            wbPhotoPriceChoice12x15 = Convert.ToInt32(_wbPhotoPrice12x15.Text);
            wbPhotoPriceChoice18x24 = Convert.ToInt32(_wbPhotoPrice18x24.Text);

            cPhotoPriceChoice9x12 = Convert.ToInt32(_сPhotoPrice9x12.Text);
            cPhotoPriceChoice12x15 = Convert.ToInt32(_сPhotoPrice12x15.Text);
            cPhotoPriceChoice18x24 = Convert.ToInt32(_сPhotoPrice18x24.Text);

            Close();
        }
    }
}
