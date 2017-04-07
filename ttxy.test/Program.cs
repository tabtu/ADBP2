using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

using ttxy.Model;
using ttxy.Funcs;

namespace ttxy
{
    class Program
    {
        static void Main(string[] args)
        {
            UsFuns uf = new UsFuns();
            //IList<Services> se = uf.GetServicesList(1);
            ////IList<Pet> mypets = uf.GetPetList("tom");

            //Console.WriteLine(se.Count);
        }



        //static void test2()
        //{
        //    string a1 = "000000";
        //    Console.WriteLine(md5.Md5Encode(a1));
        //}

        ////static void test1()
        ////{
        ////    DLanData dd = new DLanData();
        ////    IList<LanData> tmp = dd.SELECT_ALL();
        ////    for (int i = 0; i < tmp.Count; i++)
        ////    {
        ////        string[] gpstmp = tmp[i].GpsPoint.Split('|');
        ////        tmp[i].Lng = gpstmp[0];
        ////        tmp[i].Lat = gpstmp[1];

        ////        dd.UPDATE(tmp[i]);
        ////    }
        ////    Console.WriteLine(tmp.Count);
        ////    return;
        ////}

        static void test0()
        {
            StreamReader sr = new StreamReader("D://1.txt");
            string content = sr.ReadToEnd();
            string[] str = content.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("第 {0} 行: {1}", i + 1, str[i]);
            }
        }

        static void test()
        {
            string tt = "106.647805,26.67679";

            tt = tt.Replace(",", "|");
            Console.WriteLine(tt);
        }
    }
}
