using System;
using System.Windows.Forms;

namespace SB_test_win_form
{
    public partial class LoginsForm : Form
    {
        public LoginsForm()
        {
            
            InitializeComponent();
            this.AcceptButton = UserLogInButton;
            this.CancelButton = CancelButton;
        }

        public String userName;
        public String password;
        
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserLogInButton_Click(object sender, EventArgs e)
        {

            if (!VerifiUserName() | !VerifiUserPassword()) {

                SB_test_win_form.Messages.MessagesForm MessageUserName = new SB_test_win_form.Messages.MessagesForm();
                MessageUserName.SetMessageText(" Введіть коректне ім я користувача\n та пароль...");

            }
            if(VerifiUserName() & VerifiUserPassword())
            {

                 if (GetUserCredentials())
                    {

                     LoginBL LogBL = new LoginBL();
                     if (LogBL.ValidateUserNameAndPass(userName, password))
                     {
                         MainWindow MW = new MainWindow();
                         MW.Show();
                         SB_test_win_form.Messages.MessagesForm MessageUserName = new SB_test_win_form.Messages.MessagesForm();
                         MessageUserName.SetMessageText("You enter user name: " + userName + " and pass: " + password);

                         Hide();
                     }

                 }

            }

           
        }

        public void CloseLoginsForm() {

            this.Close();

        }

        private bool GetUserCredentials()
        {
            //Get UserName and pass
            //Sent data to DB
            //If true
            return true;
            //else False
        }

        private void UserNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private bool VerifiUserName() {

            try
            {
                userName = UserNameComboBox.SelectedItem.ToString();
                return true;
            }
            catch (System.NullReferenceException)
            {
               
                return false;

            }
            
        }

        private bool VerifiUserPassword() {

            try
            {
                password = PasswordTextBox.ToString().Remove(0, 42);
                if (password.Length >= 1)
                {
                    return true;
                }
                else
                {
                    
                    return false;
                }
                
            }
            catch (System.NullReferenceException nullRefExcept)
            {

                SB_test_win_form.Messages.MessagesForm MessageUserName = new SB_test_win_form.Messages.MessagesForm();
                MessageUserName.SetMessageText("Поле для вводу пароля пусте!\nБудь ласка  введіть Ваш пароль\n і продожіть роботу.\n\n\n " + nullRefExcept);
                return false;
            }
        }

        private void PasswordTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }
    }
}
