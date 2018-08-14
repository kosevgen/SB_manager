namespace SB_test_win_form
{
    partial class LoginsForm
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
            this.UserNameComboBox = new System.Windows.Forms.ComboBox();
            this.PasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.UserLogInButton = new System.Windows.Forms.Button();
            this.LoginsCancelButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameComboBox
            // 
            this.UserNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameComboBox.FormattingEnabled = true;
            this.UserNameComboBox.Items.AddRange(new object[] {
            "kos evgen",
            "kos kateruna",
            "kos ivan"});
            this.UserNameComboBox.Location = new System.Drawing.Point(42, 180);
            this.UserNameComboBox.Name = "UserNameComboBox";
            this.UserNameComboBox.Size = new System.Drawing.Size(211, 28);
            this.UserNameComboBox.TabIndex = 0;
            this.UserNameComboBox.SelectedIndexChanged += new System.EventHandler(this.UserNameComboBox_SelectedIndexChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(42, 234);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = 'x';
            this.PasswordTextBox.Size = new System.Drawing.Size(211, 26);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PasswordTextBox_MaskInputRejected);
            // 
            // UserLogInButton
            // 
            this.UserLogInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLogInButton.Location = new System.Drawing.Point(42, 281);
            this.UserLogInButton.Name = "UserLogInButton";
            this.UserLogInButton.Size = new System.Drawing.Size(75, 34);
            this.UserLogInButton.TabIndex = 2;
            this.UserLogInButton.Text = "OK";
            this.UserLogInButton.UseVisualStyleBackColor = true;
            this.UserLogInButton.Click += new System.EventHandler(this.UserLogInButton_Click);
            // 
            // LoginsCancelButton
            // 
            this.LoginsCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginsCancelButton.Location = new System.Drawing.Point(178, 281);
            this.LoginsCancelButton.Name = "LoginsCancelButton";
            this.LoginsCancelButton.Size = new System.Drawing.Size(75, 34);
            this.LoginsCancelButton.TabIndex = 3;
            this.LoginsCancelButton.Text = "Cancel";
            this.LoginsCancelButton.UseVisualStyleBackColor = true;
            this.LoginsCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SB_test_win_form.Properties.Resources.Lighthouse;
            this.pictureBox1.Location = new System.Drawing.Point(42, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(42, 154);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(147, 17);
            this.UserNameLabel.TabIndex = 5;
            this.UserNameLabel.Text = "Имя пользователя";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(42, 215);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(63, 17);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LoginsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 327);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginsCancelButton);
            this.Controls.Add(this.UserLogInButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameComboBox);
            this.Name = "LoginsForm";
            this.Text = "Logins";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UserNameComboBox;
        private System.Windows.Forms.MaskedTextBox PasswordTextBox;
        private System.Windows.Forms.Button UserLogInButton;
        private System.Windows.Forms.Button LoginsCancelButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
    }
}

