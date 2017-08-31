using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTest
{
    class DataClass
    {
        private struct CsvData
        {
            public int index;
            public string horseName;
            public string jokeyName;
        }

        Log log = new Log();
        List<CsvData> dataList = new List<CsvData>();

        // CSVの読み込み
        public void ReadData()
        {
            try
            {
                string filePath = @"../../../data.csv";
                using (System.IO.StreamReader sr = new System.IO.StreamReader(filePath))
                {
                    while (sr.Peek() >= 0)
                    {
                        CsvData csv = new CsvData();

                        string[] record = sr.ReadLine().Split(',');

                        csv.index = int.Parse(record[0]);
                        csv.horseName = record[1];
                        csv.jokeyName = record[2];

                        dataList.Add(csv);
                    }
                }
            }
            catch (Exception e)
            {
                log.ErrorLog(e.Message);
            }
        }

        [Conditional("DEBUG")]
        public void WriteAllData()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("[全てのデータを表示します]");
            for (int i = 0; i < dataList.Count; i++)
            {
                Console.WriteLine("{0,2}\t{1,-12}\t{2}", dataList[i].index, dataList[i].horseName, dataList[i].jokeyName);
            }
            Console.WriteLine("----------------------------------------");
        }

        // 指定された番号のデータ表示する
        public void GetListData(int num)
        {
            CsvData csv = new CsvData();
            csv = dataList.Find(x => x.index == num);

            if(csv.index == 0)
            {
                Console.WriteLine("データが見つかりませんでした");
                return;
            }

            Console.WriteLine("{0}\t{1,-12}\t{2}", csv.index, csv.horseName, csv.jokeyName);
        }
    }
}
