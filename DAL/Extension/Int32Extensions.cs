//using DocumentFormat.OpenXml.Vml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DAL.Extension
{
    public static class Int32Extensions
    {
        public static int ToInt32(this string number)
        {
            return Convert.ToInt32(number);
        }
        public static int ToInt32(this object number)
        {
            if (number == null)
            {
                throw new ArgumentNullException(nameof(number));
            }

            //if (number is TextBox textBox)
            //{
            //    // Extract the text from the TextBox and then convert it to an integer
            //    return Convert.ToInt32(textBox.Text);
            //}
            else
            {
                // If it's not a TextBox, try converting it directly
                return Convert.ToInt32(number);
            }
        }
    }
}
