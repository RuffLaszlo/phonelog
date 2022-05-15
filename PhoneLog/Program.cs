// See https://aka.ms/new-console-template for more information
using System.Text;
using PhoneLog;

Dictionary<CallDestination, int> inMemoryLog = new Dictionary<CallDestination, int>();

StreamReader sr = new StreamReader("..\\..\\..\\data\\input.txt");
while (sr.Peek() != -1)
{
    string[] line = sr.ReadLine().Split('\t');
    CallDestination cd = ReadData.FindCountryAndRegion(line[3].Substring(1), "..\\..\\..\\data\\country.txt", "..\\..\\..\\data\\area.txt");
    if (inMemoryLog.ContainsKey(cd))
    {
        inMemoryLog[cd] += Int32.Parse(line[4]);
    }
    else
    {
        inMemoryLog.Add(cd, Int32.Parse(line[4]));
    }
}

using (StreamWriter sw = new StreamWriter(File.Create("..\\..\\..\\data\\test.txt"), Encoding.Latin1))
{
    foreach (CallDestination cd in inMemoryLog.Keys)
    {
        sw.Write($"{cd.Country}\t{cd.Region}\t{cd.CountryCode}\t{cd.RegionCode}");
        sw.WriteLine("\t" + inMemoryLog[cd].ToString());
    }
}

Console.WriteLine("Done writing.");