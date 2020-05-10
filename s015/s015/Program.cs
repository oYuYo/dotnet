using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s015
{
    class Hello
    {
        static string ABC(int k)
        {
            // 末尾最適化してみた
            string temp = "ABC";
            while (k > 1)
            {
                temp = "A" + temp + "B" + temp + "C";
                k--;
            }
            return temp;
            /* 再起処理
             if (k == 1){
                        return "ABC";
                    }else{
                        return "A" + ABC(k-1) + "B" + ABC(k-1) + "C";
                    }
            */
        }
        static void Main(string[] args)
        {
            string[] stArrayData = System.Console.ReadLine().Trim().Split(' ');
            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine("hello = {0}", stArrayData[i]);
            }
            int N = int.Parse(stArrayData[0]);
            int start = int.Parse(stArrayData[1]);
            int end = int.Parse(stArrayData[2]);
            if (N > 0 && N < 51 && start > 0 && end > 0)    // 入力値チェック しかしN>27でタイムエラー...
            {
                string strABC = ABC(N);
                for (int i = start - 1; i < end; i++)
                {
                    System.Diagnostics.Debug.Write(strABC[i]);
                }
            }
            System.Diagnostics.Debug.WriteLine("");

        }
    }
}
