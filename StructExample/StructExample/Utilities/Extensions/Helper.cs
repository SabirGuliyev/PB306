using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample.Utilities.Extensions
{
    internal static class Helper
    {
        public static bool CheckPassword(this string password)
        {
            if (password.Length < 8) return false;
            bool isDigit = false;
            bool isUpper = false;
            bool isLower = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    isDigit = true;
                }
                else if (char.IsUpper(password[i]))
                {
                    isUpper= true;
                }
                else if (char.IsLower(password[i]))
                {
                    isLower = true;
                }
            }

            return isDigit && isUpper && isLower;

        }
    }
}
