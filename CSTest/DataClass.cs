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
        Log log = new Log();
        List<string[]> dataList = new List<string[]>();

        public void ReadData()
        {
            try
            {
                string filePath = @"../../../data.csv";
                using (System.IO.StreamReader sr = new System.IO.StreamReader(filePath))
                {
                    while (sr.Peek() >= 0)
                    {
                        dataList.Add(sr.ReadLine().Split(','));
                    }
                }
            }
            catch (System.Exception e)
            {
                log.ErrorLog(e.Message);
            }
        }

        public int GetListCnt()
        {
            return dataList.Count;
        }

        [Conditional("DEBUG")]
        public void WriteAllData()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("[全てのデータを表示します]");
            for (int i = 0; i < dataList.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(dataList[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------");
        }
    }
}
