namespace KcMWh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = "C:\\Users\\jakub.jaros\\Desktop\\kcmwh.txt";
            var OutputPath = "C:\\Users\\jakub.jaros\\Desktop\\outputDeml.txt";

            var content = File.ReadAllText(path);
            string[] line = content.Split("\r\n");
            var lenght = line.Length;
            Console.WriteLine(lenght);

            for (int i = 0;i < lenght; i++) 
            {
                using (StreamWriter outputFile = new StreamWriter(OutputPath, true))
                {
                    outputFile.WriteLine(line[i]);
                    outputFile.WriteLine(line[i]);
                    outputFile.WriteLine(line[i]);
                    outputFile.WriteLine(line[i]);

                    //outputFile.WriteLine(i + "\t" + line[i]);
                    //outputFile.WriteLine(i + "\t" + line[i]);
                    //outputFile.WriteLine(i + "\t" + line[i]);
                    //outputFile.WriteLine(i + "\t" + line[i]);
                }
            }
        }
    }
}