using System;
using System.IO;

namespace File
{
    class Program
    {
        public static void Main()
        {
            InfoDatatest myObj = new InfoDatatest();
            myObj.ReadData("Dwellings.csv");
        }
    }
    class InfoDatatest
    {
        public string[,] dataList = new string[12,16];
        public void ReadData(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            int j = 0;
            while(!reader.EndOfStream){
                var line = reader.ReadLine();
                var values = line.Split(',');
                string[] arrayVar = new string[16];
                for(int i = 0;i < values.Length;i++){
                    dataList[j,i] = values[i];
                }
                j++;
            }
            for(int m = 0; m < 12;m++){
                Console.WriteLine();
                Console.WriteLine("Row {0}", m);
                for(int n = 0; n < 16;n++){
                    Console.Write(dataList[m,n] + ", ");
                }
            }
        }
    }
}
