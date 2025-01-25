using System.Globalization;

namespace KcMWh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = "C:\\Users\\jakub\\Desktop\\Deml\\kcmwh.txt";
            var OutputPath = "C:\\Users\\jakub\\Desktop\\Deml\\outputDeml6.txt";

            var content = File.ReadAllText(path);
            string[] line = content.Split("\r\n");
            var lenght = line.Length;
            Console.WriteLine(lenght);
            var j = 1;
            var d = 1;

            for (int i = 0; i < lenght; i++)
            {
                
                using (StreamWriter outputFile = new StreamWriter(OutputPath, true))
                {
                    outputFile.WriteLine(d + "\t" + j + "\t" + line[i]);
                    outputFile.WriteLine(d + "\t" + j + "\t" + line[i]);
                    outputFile.WriteLine(d + "\t" + j + "\t" + line[i]);
                    outputFile.WriteLine(d + "\t" + j + "\t" + line[i]);
                }
                if (j < 24)
                {
                    j++;
                }
                else
                {
                    j = j - 23;
                    d++;
                }
            }
        }
    }
}