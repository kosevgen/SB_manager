using System;
using System.IO;
using System.Text;

namespace SB_test_win_form.FilesManager
{

    class OpenConfigFile
    {

        static string configFilePath = "D:\\config\\";//"D:\\C#\\workspace\\Education\\SB_test_win_form\\SB_test_win_form\\bin\\Debug\\config\\";
        static string configFileName = "SBConn.cfg";
        
        bool IfExistsFolder()
        {

            return Directory.Exists(configFilePath);

        }

        bool IfExistsFile()
        {

            return File.Exists(String.Concat(configFilePath, configFileName));

        }

        bool CreateConfigFolder()
        {
            try
            {
                Directory.CreateDirectory(configFilePath);
                return true;
            }
            catch (Exception ex)
            {

                return false;

            };
        }

        bool CheckBeforeReadingConfFile()
        {

            if (IfExistsFolder())
            {

                if (IfExistsFile())
                {
                    return true;
                }
                else
                {
                    CreateConfigFile();
                }
            }
            else
            {
                CreateConfigFolder();
                CreateConfigFile();
            }

            return true;

        }

        bool CreateConfigFile()
        {

            try
            {
                FileStream file = File.Create(String.Concat(configFilePath, configFileName));
                file.Close();
                return true;
            }
            catch (Exception exCreateFile)
            {
                SB_test_win_form.Messages.MessagesForm messages = new SB_test_win_form.Messages.MessagesForm();
                messages.SetMessageText("func CreateConfigFile\n" + exCreateFile.ToString());
                return false;
            }
        }

        public string[] OpenFile(FileMode mode, FileAccess access)//зробити перезагрузку методу з різними змінними!!!
        {
            string[] stringErrorArray;
            CheckBeforeReadingConfFile();

            try
            {

                FileStream fileStream = new FileStream(String.Concat(configFilePath, configFileName), mode, access, FileShare.None);
                string[] linesConfFile = File.ReadAllLines(String.Concat(configFilePath, configFileName), Encoding.Default);
                fileStream.Close();
                return linesConfFile;

            }
            catch (ArgumentException argumentError)
            {

                SB_test_win_form.Messages.MessagesForm messages = new SB_test_win_form.Messages.MessagesForm();
                messages.SetMessageText("funk OpenFile error arg exception\n" + argumentError.ToString());          // function!!!
                stringErrorArray = new string[] { "Errors", argumentError.ToString() };
                return stringErrorArray;

            }
            catch (PathTooLongException pathTooLongErrors)
            {

                SB_test_win_form.Messages.MessagesForm messages = new SB_test_win_form.Messages.MessagesForm();
                messages.SetMessageText("func OpenFile error patch too long \n" + pathTooLongErrors.ToString());
                stringErrorArray = new string[] { "Errors", pathTooLongErrors.ToString() };
                return stringErrorArray;

            }
            catch (DirectoryNotFoundException directoryNotFoundError)
            {

                SB_test_win_form.Messages.MessagesForm messages = new SB_test_win_form.Messages.MessagesForm();
                messages.SetMessageText("func OpenFile error directori not found \n" + directoryNotFoundError.ToString());
                stringErrorArray = new string[] { "Errors", directoryNotFoundError.ToString() };
                return stringErrorArray;

            }
            catch (IOException inputOutputErrors)
            {

                SB_test_win_form.Messages.MessagesForm messages = new SB_test_win_form.Messages.MessagesForm();
                messages.SetMessageText("func OpenFile error IO errors \n" + inputOutputErrors.ToString());
                stringErrorArray = new string[] { "Errors", inputOutputErrors.ToString() };
                return stringErrorArray;

            }
            catch (UnauthorizedAccessException unauthorizedAccessError)
            {

                SB_test_win_form.Messages.MessagesForm messages = new SB_test_win_form.Messages.MessagesForm();
                messages.SetMessageText("func OpenFile error\n access error \n" + unauthorizedAccessError.ToString());
                stringErrorArray = new string[] { "Errors", unauthorizedAccessError.ToString() };
                return stringErrorArray;

            }
            catch (NotSupportedException notSupportedError)
            {

                SB_test_win_form.Messages.MessagesForm messages = new SB_test_win_form.Messages.MessagesForm();
                messages.SetMessageText("func OpenFile error\n Not supported errors \n" + notSupportedError.ToString());
                stringErrorArray = new string[] { "Errors", notSupportedError.ToString() };
                return stringErrorArray;

            }
        }
        public bool CloseFile(FileStream f)
        {
            try
            {

                f.Close();
                return true;
            }
            catch (Exception exCloseFile)
            {

                SB_test_win_form.Messages.MessagesForm messages = new SB_test_win_form.Messages.MessagesForm();
                messages.SetMessageText("func OpenFile error\n Errors close file \n" + exCloseFile.ToString());
                return false;

            }
        }
    }
}