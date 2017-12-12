using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Notowanie
    {
        public string TICKER { get; set; }
        public string DTYYYYMMDD { get; set; }
        public DateTime Date {
            get
            {
                return DateTime.ParseExact(DTYYYYMMDD, "yyyyMMdd", CultureInfo.InvariantCulture);
            }
        }
        public double OPEN { get; set; }
        public double HIGH { get; set; }
        public double LOW { get; set; }
        public double CLOSE { get; set; }
        public int VOL { get; set; }

        public static List<Notowanie> PobierzNotowanie(string plik){
            List<Notowanie> returnList = new List<Notowanie>();
            var csv = new CsvReader(File.OpenText(plik));
            csv.Configuration.CultureInfo = new System.Globalization.CultureInfo("en");
            var _not = csv.GetRecords<Notowanie>();
            foreach (Notowanie not in _not)
            {
                returnList.Add(not);
            }
            return returnList;
        }
    }
}
