namespace SB_test_win_form
{
    partial class AddDataToDBForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddDataToDBButton = new System.Windows.Forms.Button();
            this.AddDataToDBCancelButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.FaserNameLabel = new System.Windows.Forms.Label();
            this.NameTexBox = new System.Windows.Forms.TextBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.FaserNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddDataToDBButton
            // 
            this.AddDataToDBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDataToDBButton.Location = new System.Drawing.Point(93, 447);
            this.AddDataToDBButton.Name = "AddDataToDBButton";
            this.AddDataToDBButton.Size = new System.Drawing.Size(91, 35);
            this.AddDataToDBButton.TabIndex = 0;
            this.AddDataToDBButton.Text = "Добавить";
            this.AddDataToDBButton.UseVisualStyleBackColor = true;
            // 
            // AddDataToDBCancelButton
            // 
            this.AddDataToDBCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDataToDBCancelButton.Location = new System.Drawing.Point(400, 447);
            this.AddDataToDBCancelButton.Name = "AddDataToDBCancelButton";
            this.AddDataToDBCancelButton.Size = new System.Drawing.Size(97, 35);
            this.AddDataToDBCancelButton.TabIndex = 1;
            this.AddDataToDBCancelButton.Text = "Cancel";
            this.AddDataToDBCancelButton.UseVisualStyleBackColor = true;
            this.AddDataToDBCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(60, 97);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 17);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Имя";
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Location = new System.Drawing.Point(60, 30);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(70, 17);
            this.SecondNameLabel.TabIndex = 3;
            this.SecondNameLabel.Text = "Фамилия";
            // 
            // FaserNameLabel
            // 
            this.FaserNameLabel.AutoSize = true;
            this.FaserNameLabel.Location = new System.Drawing.Point(61, 156);
            this.FaserNameLabel.Name = "FaserNameLabel";
            this.FaserNameLabel.Size = new System.Drawing.Size(71, 17);
            this.FaserNameLabel.TabIndex = 4;
            this.FaserNameLabel.Text = "Отчество";
            // 
            // NameTexBox
            // 
            this.NameTexBox.Location = new System.Drawing.Point(63, 117);
            this.NameTexBox.Name = "NameTexBox";
            this.NameTexBox.Size = new System.Drawing.Size(213, 23);
            this.NameTexBox.TabIndex = 5;
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.Location = new System.Drawing.Point(64, 50);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(213, 23);
            this.SecondNameTextBox.TabIndex = 6;
            // 
            // FaserNameTextBox
            // 
            this.FaserNameTextBox.Location = new System.Drawing.Point(64, 177);
            this.FaserNameTextBox.Name = "FaserNameTextBox";
            this.FaserNameTextBox.Size = new System.Drawing.Size(213, 23);
            this.FaserNameTextBox.TabIndex = 7;
            // 
            // AddDataToDBForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 494);
            this.Controls.Add(this.FaserNameTextBox);
            this.Controls.Add(this.SecondNameTextBox);
            this.Controls.Add(this.NameTexBox);
            this.Controls.Add(this.FaserNameLabel);
            this.Controls.Add(this.SecondNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AddDataToDBCancelButton);
            this.Controls.Add(this.AddDataToDBButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDataToDBForms";
            this.Text = "Добавить даные в базу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDataToDBButton;
        private System.Windows.Forms.Button AddDataToDBCancelButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.Label FaserNameLabel;
        private System.Windows.Forms.TextBox NameTexBox;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.TextBox FaserNameTextBox;
    }
}