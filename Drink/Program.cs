using System;

namespace Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string NMSL;
            Glass tmsl = new Glass();
            while(true)
            {
                Console.Write(">");
                NMSL=Console.ReadLine();
                if(NMSL.Contains("drink"))
                {
                    string[] haosheng = NMSL.Split("k");
                    int liters;
                    if(int.TryParse(haosheng[1], out liters))
                    {
                        liters = Int32.Parse(haosheng[1]);
                    }
                    if(liters<0)
                    {
                        liters = liters * -1;
                    }
                    tmsl.drink(liters);
                } else if(NMSL.Equals("print"))
                {
                    Console.WriteLine("This glass contains {0}ml of liquid", tmsl.LiquidLevel);
                }
                else if(NMSL.Equals("stop"))
                {
                    break;
                }
            }
        }
    }
    class Glass
    {
        public int LiquidLevel=200;
        public void drink(int mililiters)
        {
            LiquidLevel = LiquidLevel - mililiters;
            refill();
        }
        public void refill()
        {
            if(LiquidLevel < 100)
            {
                LiquidLevel = 200;
            } 
        }
    }
}
