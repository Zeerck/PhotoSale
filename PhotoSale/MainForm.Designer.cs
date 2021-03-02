
namespace PhotoSale
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LabelUserInput = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.TotalPriceText = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.UserInputPhotoFormat = new System.Windows.Forms.ComboBox();
            this.UserInputPhotoFormatText = new System.Windows.Forms.Label();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.UserHintNumberPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Prices = new System.Windows.Forms.Label();
            this.UserInputPrintMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserInputPhotoNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.UserHintNumberPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInputPhotoNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelUserInput
            // 
            this.LabelUserInput.AutoSize = true;
            this.LabelUserInput.Location = new System.Drawing.Point(12, 57);
            this.LabelUserInput.Name = "LabelUserInput";
            this.LabelUserInput.Size = new System.Drawing.Size(236, 13);
            this.LabelUserInput.TabIndex = 1;
            this.LabelUserInput.Text = "Введите количество фотографий для печати:";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(12, 156);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // TotalPriceText
            // 
            this.TotalPriceText.AutoSize = true;
            this.TotalPriceText.Location = new System.Drawing.Point(12, 182);
            this.TotalPriceText.Name = "TotalPriceText";
            this.TotalPriceText.Size = new System.Drawing.Size(40, 13);
            this.TotalPriceText.TabIndex = 3;
            this.TotalPriceText.Text = "Итого:";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(51, 182);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(36, 13);
            this.TotalPrice.TabIndex = 4;
            this.TotalPrice.Text = "0 руб.";
            // 
            // UserInputPhotoFormat
            // 
            this.UserInputPhotoFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserInputPhotoFormat.FormattingEnabled = true;
            this.UserInputPhotoFormat.Location = new System.Drawing.Point(12, 118);
            this.UserInputPhotoFormat.Name = "UserInputPhotoFormat";
            this.UserInputPhotoFormat.Size = new System.Drawing.Size(99, 21);
            this.UserInputPhotoFormat.TabIndex = 5;
            // 
            // UserInputPhotoFormatText
            // 
            this.UserInputPhotoFormatText.AutoSize = true;
            this.UserInputPhotoFormatText.Location = new System.Drawing.Point(12, 102);
            this.UserInputPhotoFormatText.Name = "UserInputPhotoFormatText";
            this.UserInputPhotoFormatText.Size = new System.Drawing.Size(130, 13);
            this.UserInputPhotoFormatText.TabIndex = 6;
            this.UserInputPhotoFormatText.Text = "Выберите формат фото:";
            // 
            // UserHintNumberPhoto
            // 
            this.UserHintNumberPhoto.Image = global::PhotoSale.Properties.Resources.Info;
            this.UserHintNumberPhoto.Location = new System.Drawing.Point(61, 74);
            this.UserHintNumberPhoto.Name = "UserHintNumberPhoto";
            this.UserHintNumberPhoto.Size = new System.Drawing.Size(10, 19);
            this.UserHintNumberPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserHintNumberPhoto.TabIndex = 7;
            this.UserHintNumberPhoto.TabStop = false;
            this.Hint.SetToolTip(this.UserHintNumberPhoto, "Не более 99 фото");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Акция!\r\nПри печати более 20 фото скидка 10%";
            // 
            // Prices
            // 
            this.Prices.AutoSize = true;
            this.Prices.Location = new System.Drawing.Point(317, 9);
            this.Prices.Name = "Prices";
            this.Prices.Size = new System.Drawing.Size(0, 13);
            this.Prices.TabIndex = 9;
            // 
            // UserInputPrintMode
            // 
            this.UserInputPrintMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserInputPrintMode.FormattingEnabled = true;
            this.UserInputPrintMode.Location = new System.Drawing.Point(12, 25);
            this.UserInputPrintMode.Name = "UserInputPrintMode";
            this.UserInputPrintMode.Size = new System.Drawing.Size(99, 21);
            this.UserInputPrintMode.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Выберите режим печати:";
            // 
            // UserInputPhotoNumber
            // 
            this.UserInputPhotoNumber.Location = new System.Drawing.Point(12, 74);
            this.UserInputPhotoNumber.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.UserInputPhotoNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UserInputPhotoNumber.Name = "UserInputPhotoNumber";
            this.UserInputPhotoNumber.Size = new System.Drawing.Size(43, 20);
            this.UserInputPhotoNumber.TabIndex = 12;
            this.UserInputPhotoNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 204);
            this.Controls.Add(this.UserInputPhotoNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserInputPrintMode);
            this.Controls.Add(this.Prices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserHintNumberPhoto);
            this.Controls.Add(this.UserInputPhotoFormatText);
            this.Controls.Add(this.UserInputPhotoFormat);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.TotalPriceText);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.LabelUserInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Печать фото";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserHintNumberPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInputPhotoNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelUserInput;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label TotalPriceText;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.ComboBox UserInputPhotoFormat;
        private System.Windows.Forms.Label UserInputPhotoFormatText;
        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.PictureBox UserHintNumberPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Prices;
        private System.Windows.Forms.ComboBox UserInputPrintMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown UserInputPhotoNumber;
    }
}

