using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BLL.functions
{
    public static class staticValudation
    {
        public static bool name(string name)
        {
            if (name == null) return false;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= 'א' || name[i] <= 'ת' || name[i] == ' ')
                    return true;
            }
            return false;
        }
        public static bool numberPhone(string numberPhone)
        {
            if (numberPhone == null || numberPhone.Length < 9 || numberPhone.Length > 10) return false;
            for (int i = 0; i < numberPhone.Length; i++)
            {
                if (numberPhone[i] >= '9' || numberPhone[i] <= '0')
                    return true;
            }
            return false;
        }
        public static bool ValidateTz(string tz)
        {
            if (string.IsNullOrWhiteSpace(tz) || tz.Length != 9)
            {
                return false;
            }

            int sum = 0;
            for (int i = 0; i < 8; i++)
            {
                int digit = int.Parse(tz[i].ToString());
                if (i % 2 == 0)
                {
                    sum += digit;
                }
                else
                {
                    sum += digit < 5 ? digit * 2 : digit * 2 - 9;
                }
            }

            int checksum = (10 - (sum % 10)) % 10;
            int lastDigit = int.Parse(tz[8].ToString());

            return checksum == lastDigit;
        }


    }
}
