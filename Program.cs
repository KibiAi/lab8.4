using lab8._4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть вихідний формат даних (CSV, XML, JSON):");
        string sourceFormat = Console.ReadLine();
        Console.WriteLine("Введіть цільовий формат даних (CSV, XML, JSON):");
        string targetFormat = Console.ReadLine();

        DataPrototype data;
        switch (sourceFormat)
        {
            case "CSV":
                data = new CSVData();
                break;
            case "XML":
                data = new XMLData();
                break;
            case "JSON":
                data = new JSONData();
                break;
            default:
                Console.WriteLine("Невідомий формат даних");
                return;
        }

        IDataAdapter adapter;
        if (sourceFormat == "CSV" && targetFormat == "XML")
        {
            adapter = new CSVToXMLAdapter();
        }
        else if (sourceFormat == "CSV" && targetFormat == "JSON")
        {
            adapter = new CSVToJSONAdapter();
        }
        else if (sourceFormat == "XML" && targetFormat == "JSON")
        {
            adapter = new XMLToJSONAdapter();
        }
        else
        {
            Console.WriteLine("Неможливо конвертувати з вихідного формату в цільовий");
            return;
        }

        adapter.Convert(data);
    }
}