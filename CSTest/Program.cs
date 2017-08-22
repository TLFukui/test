using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Log log = new Log();
            DataClass data = new DataClass();

            log.DebugLog("デバッグモードで起動中\n");

            data.ReadData();
            data.WriteAllData();

            Console.WriteLine("数値を入力してください(終了するには0を入力してください)");

            while (true)
            {
                var intput = Console.ReadLine();

                int output;
                bool result = int.TryParse(intput, out output);
                if (!result)
                {
                    Console.WriteLine("数値を入力してください(終了するには0を入力してください)");
                    continue;
                }

                int num = int.Parse(intput);
                if(num == 0)
                {
                    break;
                }
                else
                {
                    // リストから対応する番号の文字列を表示
                    data.GetListData(num);
                }
            }
        }
    }
}