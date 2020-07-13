using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectAdvance2.Global
{
    class Base
    {
        public static string excelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\TestData\\TestData.xlsx");
        public static string uploadFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\TestData\\TestWorkSample.txt");
        public static string reportsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\TestReports\\");
       
    }
}
