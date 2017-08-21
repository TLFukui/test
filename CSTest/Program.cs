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

            Console.WriteLine("{0}までの数字で確認したい番号を入力してください(終了するには0を入力してください)", data.GetListCnt());

            while (true)
            {
                var num = int.Parse(Console.ReadLine());

                if(num > data.GetListCnt() || num < 0)
                {
                    Console.WriteLine("入力範囲外です。");
                }

                if(num == 0)
                {
                    break;
                }
                else
                {
                    // リストから対応する番号の文字列を取得
                }
            }
        }
    }
}