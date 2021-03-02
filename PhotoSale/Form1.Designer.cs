
namespace PhotoSale
{
    partial class Form1
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
            this.UserInputPhotoNumber = new System.Windows.Forms.TextBox();
            this.LabelUserInput = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.TotalPriceText = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.UserInputPhotoFormat = new System.Windows.Forms.ComboBox();
            this.UserInputPhotoFormatText = new System.Windows.Forms.Label();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.UserHintNumberPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserHintNumberPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInputPhotoNumber
            // 
            this.UserInputPhotoNumber.Location = new System.Drawing.Point(15, 25);
            this.UserInputPhotoNumber.MaxLength = 2;
            this.UserInputPhotoNumber.Name = "UserInputPhotoNumber";
            this.UserInputPhotoNumber.Size = new System.Drawing.Size(41, 20);
            this.UserInputPhotoNumber.TabIndex = 0;
            // 
            // LabelUserInput
            // 
            this.LabelUserInput.AutoSize = true;
            this.LabelUserInput.Location = new System.Drawing.Point(12, 9);
            this.LabelUserInput.Name = "LabelUserInput";
            this.LabelUserInput.Size = new System.Drawing.Size(236, 13);
            this.LabelUserInput.TabIndex = 1;
            this.LabelUserInput.Text = "Введите количество фотографий для печати:";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(12, 145);
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
            this.TotalPriceText.Location = new System.Drawing.Point(12, 171);
            this.TotalPriceText.Name = "TotalPriceText";
            this.TotalPriceText.Size = new System.Drawing.Size(40, 13);
            this.TotalPriceText.TabIndex = 3;
            this.TotalPriceText.Text = "Итого:";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(58, 171);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(13, 13);
            this.TotalPrice.TabIndex = 4;
            this.TotalPrice.Text = "0";
            // 
            // UserInputPhotoFormat
            // 
            this.UserInputPhotoFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserInputPhotoFormat.FormattingEnabled = true;
            this.UserInputPhotoFormat.Location = new System.Drawing.Point(15, 68);
            this.UserInputPhotoFormat.Name = "UserInputPhotoFormat";
            this.UserInputPhotoFormat.Size = new System.Drawing.Size(99, 21);
            this.UserInputPhotoFormat.TabIndex = 5;
            // 
            // UserInputPhotoFormatText
            // 
            this.UserInputPhotoFormatText.AutoSize = true;
            this.UserInputPhotoFormatText.Location = new System.Drawing.Point(15, 52);
            this.UserInputPhotoFormatText.Name = "UserInputPhotoFormatText";
            this.UserInputPhotoFormatText.Size = new System.Drawing.Size(130, 13);
            this.UserInputPhotoFormatText.TabIndex = 6;
            this.UserInputPhotoFormatText.Text = "Выберите формат фото:";
            // 
            // UserHintNumberPhoto
            // 
            this.UserHintNumberPhoto.Image = global::PhotoSale.Properties.Resources.Info;
            this.UserHintNumberPhoto.Location = new System.Drawing.Point(61, 26);
            this.UserHintNumberPhoto.Name = "UserHintNumberPhoto";
            this.UserHintNumberPhoto.Size = new System.Drawing.Size(10, 19);
            this.UserHintNumberPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserHintNumberPhoto.TabIndex = 7;
            this.UserHintNumberPhoto.TabStop = false;
            this.Hint.SetToolTip(this.UserHintNumberPhoto, "Не более 99 фото");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 204);
            this.Controls.Add(this.UserHintNumberPhoto);
            this.Controls.Add(this.UserInputPhotoFormatText);
            this.Controls.Add(this.UserInputPhotoFormat);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.TotalPriceText);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.LabelUserInput);
            this.Controls.Add(this.UserInputPhotoNumber);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Печать фото";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserHintNumberPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputPhotoNumber;
        private System.Windows.Forms.Label LabelUserInput;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label TotalPriceText;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.ComboBox UserInputPhotoFormat;
        private System.Windows.Forms.Label UserInputPhotoFormatText;
        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.PictureBox UserHintNumberPhoto;
    }
}

