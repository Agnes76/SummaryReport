using System;
using System.Collections.Generic;
using System.IO;

namespace SummaryReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            string textFilePath = @"C:\Users\hp\Documents\Project\Payment\CodingChallenge\SummaryReport\testFile.txt";

            string[] numArr = File.ReadAllLines(textFilePath);

            string[] MTN =
            {
             "0703","0706","0803","0806","0810","0813","0814","0816","0903","0906","0913","0916","07025","07026","0704"
            };

            string[] Airtel =
            {
             "0701","0708","0802","0808","0812","0901","0902","0904","0907","0912"
             };

            string[] Globacom =
            {
             "0705","0805","0807","0811","0815","0905","0915"
            };

            string[] Mobile =
            {
             "0809","0817","0818","0909","0908"
            };

            string[] MTEL =
            {
             "0804"
            };

            List<string> newMTN = new List<string>();

            List<string> newAirtel = new List<string>();

            List<string> newGlobacom = new List<string>();

            List<string> newMobile = new List<string>();

            List<string> newMTEL = new List<string>();


            foreach (var num in numArr)
            {
                foreach (var item in MTN)
                {
                    if (num.StartsWith(item))
                    {
                        newMTN.Add(num);
                        break;
                    }
                }

                foreach (var item in Airtel)
                {
                    if (num.StartsWith(item))
                    {
                        newAirtel.Add(num);
                        break;
                    }
                }

                foreach (var item in Globacom)
                {
                    if (num.StartsWith(item))
                    {
                        newGlobacom.Add(num);
                        break;
                    }
                }

                foreach (var item in Mobile)
                {
                    if (num.StartsWith(item))
                    {
                        newMobile.Add(num);
                        break;
                    }
                }

                foreach (var item in MTEL)
                {
                    if (num.StartsWith(item))
                    {
                        newMTEL.Add(num);
                        break;
                    }
                }
            }

            Console.WriteLine($"Total Phone Numbers for MTN : {newMTN.Count}");

            Console.WriteLine($"Total Phone Numbers for Airtel : {newAirtel.Count}");

            Console.WriteLine($"Total Phone Numbers for Globacom : {newGlobacom.Count}");

            Console.WriteLine($"Total Phone Numbers for 9Mobile : {newMobile.Count}");

            Console.WriteLine($"Total Phone Numbers for MTEL : {newMTEL.Count}");


        }

    }
}
