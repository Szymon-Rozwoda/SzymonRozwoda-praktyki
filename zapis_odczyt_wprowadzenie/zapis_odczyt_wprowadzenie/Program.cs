using System.IO;


// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//static void Main(string[] args)
{
    StreamWriter sw = new StreamWriter(@"C:\Users\xopero\Documents\GitHub\SzymonRozwoda-praktyki\zapis_odczyt_wprowadzenie\tajny_plan.txt");
    sw.WriteLine("W jaki sposób pokonać Kapitana Wspaniałego?");
    sw.WriteLine("Kolejny genialny, tajny plan Kanciarza.");
    sw.Write("Stworzę armię klonów, ");
    sw.WriteLine("uwolnię je i wystawię przeciwko mieszkańcom Obiektowa");
    string location = "centrum handlowe.";
    for(int number = 0; number <= 6; number++)
    {
        sw.WriteLine("Klon numer {0} atakuje {1}",number,location);
        if(location == "centrum handlowe.") 
        {  
            location = "centrum miasta.";
        }
        else
        {
            location = "centrum handlowe";
        }
    }
    sw.Close();

    //druga część
    string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    StreamReader reader = new StreamReader(folder + @"\GitHub\SzymonRozwoda-praktyki\zapis_odczyt_wprowadzenie\tajny_plan.txt");
    StreamWriter writer = new StreamWriter(folder + @"\GitHub\SzymonRozwoda-praktyki\zapis_odczyt_wprowadzenie\e-mailDoKapitanaWspaniałego.txt");

    writer.WriteLine("Do: KapitanWspanialy@obiektowo.net");
    writer.WriteLine("Od: Komisarz@obiektowo.net");
    writer.WriteLine("Temat: Czy możesz ocalić świat... po raz kolejny?");
    writer.WriteLine();
    writer.WriteLine("Odkryliśmy plan Kanciarza:");
    while(!reader.EndOfStream)
    {
        string lineFromThePlan = reader.ReadLine();
        writer.WriteLine("Plan -> "+lineFromThePlan);
    }
    writer.WriteLine();
    writer.WriteLine("Czy możesz nam pomóc?");
    writer.Close();
    reader.Close();
}
