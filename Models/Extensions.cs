using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_7.Models
{
    internal static class Extensions
    {
        public static string ToUpperAndString(this Char value)
            => char.ToUpper(value).ToString();
    }
}
