using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_test_win_form
{
    class LoginBL
    {
        public LoginBL() {
            //Create connect to DB (public)
            FileStream fStream = new File.Open();
            FilesManager.OpenConfigFile openConfigFile = new FilesManager.OpenConfigFile();
            string[] readAllLineFromConfFile = openConfigFile.OpenFile(System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
            Messages.MessagesForm message = new Messages.MessagesForm();
            message.SetMessageText(readAllLineFromConfFile[0] + "\n" + readAllLineFromConfFile[1]);// + "\n" + readAllLineFromConfFile[2] + "\n" + readAllLineFromConfFile[3]);
            
        }

        private String userName;
        private String password;
        //public static SqlConnection conn;

        public bool ValidateUserNameAndPass(String uName, String pass)
        {

            
            GetUserNameFromLoginsForm();
            GetPasswordFromLoginsForm();
            if (SearchUserNameAndPass()) {
               
                return true; 

            }
            else{
                
                return true;    //Change to false!!!

            }
            
        }
        void GetUserNameFromLoginsForm()
        {
            
           
            
        }
        void GetPasswordFromLoginsForm()
        {



        }
        bool SearchUserNameAndPass() {

            return true;

        }

        void OpenConnectionToDB()
        {
            DBConnection.ConnectionOpen();
        }

        void CloseConnectionToDB()
        {
            DBConnection.ConnectionClose();
        }





    }
}
