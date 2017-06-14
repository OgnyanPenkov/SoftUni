using System;

class TradeComissions
{
    static void Main()
    {
        string town = Console.ReadLine().ToLower();
        double sales = double.Parse(Console.ReadLine());

        double comission = -1;

        bool isTownOneOfThree = town == "sofia" || town == "varna" || town == "plovdiv" && sales >= 0;

        bool isSalesZeroToFiveHundred = sales >= 0 && sales <= 500;
        bool isSalesFiveHundredToThousand = sales > 500 && sales <= 1000;
        bool isThousondToTenThousand = sales > 1000 && sales <= 10000;

        if (isTownOneOfThree)
        {
            if (town == "sofia")
            {
                if (isSalesZeroToFiveHundred)
                {
                    comission = 0.05;
                }
                else if (isSalesFiveHundredToThousand)
                {
                    comission = 0.07;
                }
                else if (isThousondToTenThousand)
                {
                    comission = 0.08;
                }
                else
                {
                    comission = 0.12;
                }
            }
            else if (town == "varna")
            {
                if (isSalesZeroToFiveHundred)
                {
                    comission = 0.045;
                }
                else if (isSalesFiveHundredToThousand)
                {
                    comission = 0.075;
                }
                else if (isThousondToTenThousand)
                {
                    comission = 0.10;
                }
                else
                {
                    comission = 0.13;
                }
            }
            else if (town == "plovdiv")
            {
                if (isSalesZeroToFiveHundred)
                {
                    comission = 0.055;
                }
                else if (isSalesFiveHundredToThousand)
                {
                    comission = 0.08;
                }
                else if (isThousondToTenThousand)
                {
                    comission = 0.12;
                }
                else
                {
                    comission = 0.145;
                }
            }
            Console.WriteLine("{0:f2}", sales * comission);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}
