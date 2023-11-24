using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._4
{
    public abstract class DataPrototype
    {
        public abstract DataPrototype Clone();
    }

    public class CSVData : DataPrototype
    {
        public override DataPrototype Clone()
        {
            return (CSVData)this.MemberwiseClone();
        }
    }

    public class XMLData : DataPrototype
    {
        public override DataPrototype Clone()
        {
            return (XMLData)this.MemberwiseClone();
        }
    }

    public class JSONData : DataPrototype
    {
        public override DataPrototype Clone()
        {
            return (JSONData)this.MemberwiseClone();
        }
    }

    public interface IDataAdapter
    {
        void Convert(DataPrototype data);
    }

    public class CSVToXMLAdapter : IDataAdapter
    {
        public void Convert(DataPrototype data)
        {
            Console.WriteLine("Конвертація CSV в XML");
        }
    }

    public class CSVToJSONAdapter : IDataAdapter
    {
        public void Convert(DataPrototype data)
        {
            Console.WriteLine("Конвертація CSV в JSON");
        }
    }

    public class XMLToJSONAdapter : IDataAdapter
    {
        public void Convert(DataPrototype data)
        {
            Console.WriteLine("Конвертація XML в JSON");
        }
    }
}
