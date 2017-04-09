using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ttxy.Model;
using ttxy.Funcs;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlFuns sf = new SqlFuns();
            for (int i = 4; i <= 30; i++)
            {
                StuParent sp0 = new StuParent();
                StuParent sp1 = new StuParent();
                sp0.Stnum = uint.Parse(i + "");
                sp1.Stnum = uint.Parse(i + "");
                sp0.Mord = true;
                sp1.Mord = false;
                Random r = new Random();
                double seed = r.NextDouble();
                if (seed > 0.5)
                {
                    sp0.Stpar = true;
                    double stmp = r.NextDouble() * 30;
                    sp0.Spnum = (uint)(stmp % 30);
                }
                else
                {
                    sp0.Stpar = false;
                    double stmp = r.NextDouble() * 10;
                    sp0.Spnum = (uint)(stmp % 10);
                }
                sf.AddStuParent(sp0);

                double sed = r.NextDouble();
                if (sed > 0.5)
                {
                    sp0.Stpar = true;
                    double stmp = r.NextDouble() * 30;
                    sp0.Spnum = (uint)(stmp % 30);
                }
                else
                {
                    sp0.Stpar = false;
                    double stmp = r.NextDouble() * 10;
                    sp0.Spnum = (uint)(stmp % 10);
                }
                sf.AddStuParent(sp1);
            }
        }
    }
}
