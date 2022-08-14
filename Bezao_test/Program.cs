using System;

namespace Bezao_test
{
    
    public class NumberToWords
    {

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a Number to convert to words");

                string numberEnter = Console.ReadLine();
                numberEnter = ConvertAmount(double.Parse(numberEnter));

                Console.WriteLine("Number in words is \n{0}", numberEnter);
                Console.ReadKey();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private static String[] units = { "Zero", "One", "Two", "Three","Four", "Five", "Six", "Seven", 
            "Eight", "Nine", "Ten", "Eleven","Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
            "Seventeen", "Eighteen", "Nineteen" };


        private static String[] tens = { "", "", "Twenty", "Thirty", "Forty","Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };


        public static String ConvertAmount(double amount)
        {
            try
            {
                Int64 amount_int = (Int64)amount;
                Int64 amount_dec = (Int64)Math.Round((amount - (double)(amount_int)) * 100);

                if (amount_dec == 0)
                {
                    return Convert(amount_int) + " Only.";
                }
                else
                {
                    return Convert(amount_int) + " Point " + Convert(amount_dec) + " Only.";
                }
            }
            catch (Exception ex)
            {
                
            }
            return "";
        }


        public static String Convert(Int64 number)
        {
            if (number < 20)
            {
                return units[number];
            }

            if (number < 100)
            {
                return tens[number / 10] + ((number % 10 > 0) ? " " + Convert(number % 10) : "");
            }

            if (number < 1000)
            {
                return units[number / 100] + " Hundred"
                        + ((number % 100 > 0) ? " And " + Convert(number % 100) : "");
            }

            if (number < 100000)
            {
                return Convert(number / 1000) + " Thousand "
                + ((number % 1000 > 0) ? " " + Convert(number % 1000) : "");
            }

            if (number < 10000000)
            {
                return Convert(number / 100000) + " Lakh "
                        + ((number % 100000 > 0) ? " " + Convert(number % 100000) : "");
            }

            if (number < 1000000000)
            {
                return Convert(number / 10000000) + " Crore "
                        + ((number % 10000000 > 0) ? " " + Convert(number % 10000000) : "");
            }

            return Convert(number / 1000000000) + " Arab "
                    + ((number % 1000000000 > 0) ? " " + Convert(number % 1000000000) : "");
        }
    }
}
