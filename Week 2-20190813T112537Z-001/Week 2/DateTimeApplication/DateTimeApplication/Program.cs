using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int DD, MM, YY, hh, mm, ss;
            long ticks;

            Console.WriteLine("Enter the date and time: ");
            string n1 = Console.ReadLine();
            string[] time = n1.Split(':');
            int.TryParse(time[0], out DD);
            int.TryParse(time[1], out MM);
            int.TryParse(time[2], out YY);
            int.TryParse(time[3], out hh);
            int.TryParse(time[4], out mm);
            int.TryParse(time[5], out ss);

            if(DD > 30 || MM > 12 || hh > 12 || mm > 59 || ss > 59)
            {
                Console.WriteLine("Invalid Time!!");
                Console.Read();
                System.Environment.Exit(0);
            }

            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", DD, MM, YY, hh, mm, ss);

            Console.WriteLine("Enter ticks: ");
            string n2 = Console.ReadLine();
            long.TryParse(n2, out ticks);

            int addSec = (int)(ticks / 10000000);

            int addHours = addSec / (3600);

            int addMinutes = (addSec / 60) - (addHours * 60);

            int newSec = (addSec) - (addHours * 3600 + addMinutes * 60);

            ss += newSec;

            string sec = "", min = "", hour = "", date = "", month = "", year = "";
            
            if (ss >= 60)
            {
               // Console.WriteLine(ss);
                mm++;
                ss = ss % 60;
                //Console.WriteLine(ss);
                if (ss < 10)
                {
                    sec = "0" + ss;
                }
                else
                {
                    sec = "" + sec;
                }
            }
            else
            {
                sec = ""+ss;
            }

            mm += addMinutes;
            if(mm >= 60)
            {
                hh++;
                mm = mm % 60;
                if (mm < 10)
                {
                    min = "0" + mm;
                }
                else
                {
                    min = "" + mm;
                }
            }
            else
            {
                min = "" + mm;
            }

            hh += addHours;
            if(hh > 23)
            {
                DD++;
                hh = hh % 24;
                if (hh < 10)
                {
                    hour = "0" + hh;
                }
                else
                {
                    hour = "" + hh;
                }
            }
            else
            {
                hour = "" + hh;
            }

            if(DD > 30)
            {
                MM++;
                DD = DD % 30;
                if (DD < 10)
                {
                    date = "0" + DD;
                }
                else
                {
                    date = "" + DD;
                }
            }
            else
            {
                date = "" + DD;
            }

            if(MM > 12)
            {
                YY++;
                MM = MM % 12;
                if (MM < 10)
                {
                    month = "0" + MM;
                }
                else
                {
                    month = "" + MM;
                }
            }
            else
            {
                month = "" + MM;
            }

            if (YY > 99)
            {
                YY = YY % 100;
                if (YY < 10)
                {
                    year = "0" + YY;
                }
                else
                {
                    year = "" + YY;
                }
            }
            else
            {
                year = "" + YY;
            }

            Console.WriteLine("\nTIME : {0}:{1}:{2}:{3}:{4}:{5}", DD, MM, YY, hh, mm, sec);

            Console.Read();
        }
    }
}
