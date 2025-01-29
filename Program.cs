using System.Globalization;

namespace KcMWh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "4xCena";
            try
			{
                Console.WriteLine("Zadejte cestu k datovému souboru:" + "\n");
                var path = Console.ReadLine();

                //"C:\\Users\\jakub\\Desktop\\Deml\\kcmwh.txt";
                Console.WriteLine("\n" + "Zadejte cestu k výstupu:" + "\n");
                var OutputPath = Console.ReadLine();
                //"C:\\Users\\jakub\\Desktop\\Deml\\outputDeml6.txt";
                var splitter = "\r\n";

                Console.WriteLine("\n" + "Chcete ve výstupu dignostická data? Y/N:" + "\n");
                var diag = Console.ReadLine().ToUpper();

                var content = File.ReadAllText(path);
                string[] line = content.Split(splitter);
                var lenght = line.Length;
                var j = 1;
                var d = 1;

                switch (diag)
                {
                    case "Y":
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
                        break;
                    case "N":
                        for (int i = 0; i < lenght; i++)
                        {

                            using (StreamWriter outputFile = new StreamWriter(OutputPath, true))
                            {
                                outputFile.WriteLine(line[i]);
                                outputFile.WriteLine(line[i]);
                                outputFile.WriteLine(line[i]);
                                outputFile.WriteLine(line[i]);
                            }
                            if (j < 24)
                            {
                                j++;
                            }
                            else
                            {
                                j = j - 23;
                            }
                        }
                        break;
                    default:
                        goto case "N";

                }
            }
			catch (Exception e)
			{
                Console.WriteLine("CHYBA:" + e.Message);
			}
            Console.WriteLine("\n" + "Konec, stiskněte Enter pro ukončení");
            Console.ReadLine();
        }
    }
}