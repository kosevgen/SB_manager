namespace SB_test_win_form
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddDataButton = new System.Windows.Forms.Button();
            this.DeleteDataButton = new System.Windows.Forms.Button();
            this.ViewDataButton = new System.Windows.Forms.Button();
            this.DBManipulStripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ConnectToDBStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУмолчаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.особаяБазаДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работатьАвтономноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DBManipulStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddDataButton
            // 
            this.AddDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDataButton.Location = new System.Drawing.Point(13, 393);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(81, 30);
            this.AddDataButton.TabIndex = 1;
            this.AddDataButton.Text = "Добавить";
            this.AddDataButton.UseVisualStyleBackColor = true;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDataButton.Location = new System.Drawing.Point(101, 392);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(75, 31);
            this.DeleteDataButton.TabIndex = 2;
            this.DeleteDataButton.Text = "Удалить";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            // 
            // ViewDataButton
            // 
            this.ViewDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewDataButton.Location = new System.Drawing.Point(183, 393);
            this.ViewDataButton.Name = "ViewDataButton";
            this.ViewDataButton.Size = new System.Drawing.Size(85, 30);
            this.ViewDataButton.TabIndex = 3;
            this.ViewDataButton.Text = "Просмотр";
            this.ViewDataButton.UseVisualStyleBackColor = true;
            // 
            // DBManipulStripMenu
            // 
            this.DBManipulStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectToDBStripMenuItem,
            this.работатьАвтономноToolStripMenuItem});
            this.DBManipulStripMenu.Name = "DBManipulStripMenu";
            this.DBManipulStripMenu.ShowCheckMargin = true;
            this.DBManipulStripMenu.Size = new System.Drawing.Size(210, 48);
            this.DBManipulStripMenu.Text = "DataBase";
            this.DBManipulStripMenu.Opening += new System.ComponentModel.CancelEventHandler(this.СontextMenuStrip1_Opening);
            // 
            // ConnectToDBStripMenuItem
            // 
            this.ConnectToDBStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поУмолчаниюToolStripMenuItem,
            this.особаяБазаДанихToolStripMenuItem});
            this.ConnectToDBStripMenuItem.Name = "ConnectToDBStripMenuItem";
            this.ConnectToDBStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ConnectToDBStripMenuItem.Text = "Подключитса к базе";
            // 
            // поУмолчаниюToolStripMenuItem
            // 
            this.поУмолчаниюToolStripMenuItem.Name = "поУмолчаниюToolStripMenuItem";
            this.поУмолчаниюToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.поУмолчаниюToolStripMenuItem.Text = "по умолчанию";
            // 
            // особаяБазаДанихToolStripMenuItem
            // 
            this.особаяБазаДанихToolStripMenuItem.Name = "особаяБазаДанихToolStripMenuItem";
            this.особаяБазаДанихToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.особаяБазаДанихToolStripMenuItem.Text = "особая база даних";
            // 
            // работатьАвтономноToolStripMenuItem
            // 
            this.работатьАвтономноToolStripMenuItem.Name = "работатьАвтономноToolStripMenuItem";
            this.работатьАвтономноToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.работатьАвтономноToolStripMenuItem.Text = "Работать автономно";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(275, 393);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(83, 29);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 482);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ViewDataButton);
            this.Controls.Add(this.DeleteDataButton);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainWindow";
            this.Text = "Нарушения";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DBManipulStripMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddDataButton;
        private System.Windows.Forms.Button DeleteDataButton;
        private System.Windows.Forms.Button ViewDataButton;
        private System.Windows.Forms.ContextMenuStrip DBManipulStripMenu;
        private System.Windows.Forms.ToolStripMenuItem ConnectToDBStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУмолчаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem особаяБазаДанихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работатьАвтономноToolStripMenuItem;
        private System.Windows.Forms.Button ExitButton;
    }
}