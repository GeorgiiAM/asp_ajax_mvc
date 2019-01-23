using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace jQuery_AJAX_MVC.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public string Result { get; set; }



        public void Answer(string s)
        {
            try
            {
                Regex rgx = new Regex("[-]{0,1}[0-9]{1,3}");


                if (rgx.IsMatch(s))
                {
                    if (Int32.Parse(s) <= 100 && Int32.Parse(s) >= -100)
                    {
                        int x = Int32.Parse(s);

                        if (x < 0) Result = "отрицательное значение";
                        if (x == 0) Result = "ноль";
                        if (x > 0 && x <= 11)
                        {
                            long f = 1;
                            for (int i = 2; i <= x; i++)
                            {
                                f = f * i;
                            }

                            Result = f.ToString();

                        }
                        if (x > 11) Result = "положительное значение";
                    }
                    else
                    {
                        Result = "ошибка";
                    }


                }
                else
                {
                    Result = "ошибка";
                }
            }
            catch (Exception e)
            {
                Result = e.ToString();
            }

        }
    }
}