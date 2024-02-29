using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreAssigner
{
    public static class FileFormatting
    {
        private static string filepath;
        public static string FilePath { get => filepath; set=> filepath=value; }//Allows me to obtain file path for subsequent saving
        public static string FileNameConverter(string name)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (name.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) != -1)//determines if valid valid file name
            {
                char[] chars = name.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (Char.IsLetterOrDigit(chars[i])) 
                    {
                        stringBuilder.Append(chars[i]);
                    }
                    else
                    {
                        stringBuilder.Append('_');
                    }
                }
                return stringBuilder.ToString();
            }
            return name;
        }
        public static string FileFormat(string title, string body, string status, string Date) 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Event Title: {title}");
            sb.AppendLine($"For Date: {Date}");
            sb.AppendLine();
            sb.AppendLine($"#####{status}##########{status}##########{status}#####");
            sb.AppendLine(body);
            sb.AppendLine();
            sb.AppendLine($"#####{status}##########{status}##########{status}#####");

            return sb.ToString();
        }
    }
}
