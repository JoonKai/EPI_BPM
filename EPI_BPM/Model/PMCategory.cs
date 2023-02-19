using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPI_BPM.Model
{
    public class PMCategory
    {
        public string Site { get; set; } = "";
        public string MOCVDNumber { get; set; } = "";
        public string ManufacturingStatus { get; set; } = "";
        public string MOCVDModel { get; set; } = "";
        public string MOCVDCode { get; set; } = "";
        public int ChamberGage { get; set; }
        public int FilterGage { get; set; }
        public int ChamberCount { get; set; }
        public int FilterCount { get; set; }
        public int PMCycle { get; set; }
        public int FilterCycle { get; set; }
        public DateTime PMDate { get; set; }
        public DateTime FilterDate { get; set; }
        public string ETC { get; set; }

        public override string ToString()
        {
            return $"Site:{Site}, " +
                $"MOCVDNumber:{MOCVDNumber}, " +
                $"ManufacturingStatus:{ManufacturingStatus}, " +
                $"MOCVDModel:{MOCVDModel}, " +
                $"MOCVDCode:{MOCVDCode}, " +
                $"FilterCount:{FilterCount}," +
                $"PMCycle:{PMCycle}," +
                $"PMDate:{PMDate}," +
                $"FilterDate:{FilterDate}," +
                $"ETC:{ETC}";
        }
        public static List<PMCategory> PMCategories => new List<PMCategory>()
        {
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=80,FilterGage=10, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
            new PMCategory {Site="B/1F", MOCVDNumber="123",ManufacturingStatus="양산", MOCVDModel="K465I", MOCVDCode="B1GMO128",ChamberGage=30,FilterGage=20, ChamberCount=123,FilterCount= 112, PMCycle=300, FilterCycle=125, PMDate=DateTime.Now, FilterDate=DateTime.Now, ETC="손준석"},
        };
    }
}
