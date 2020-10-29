using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnesApp
{
    public class Extension
    {
        public static bool CheckAllField(string[] UserInfo, string Empty)
        {
            foreach (var field in UserInfo)
            {
                if(field == Empty)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckHash(string UserPassword, string Password)
        {
            return UserPassword == GetHash(Password);
        }

        public static string GetHash(string Password)
        {
            byte[] GetByte = new ASCIIEncoding().GetBytes(Password);
            byte[] GetHashByte = new SHA256Managed().ComputeHash(GetByte);
            return new ASCIIEncoding().GetString(GetHashByte);
        }

        public static void ShowMessage(string content, string title)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK, title.ToLower() == "error" ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }
    }
}
