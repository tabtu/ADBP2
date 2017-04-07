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
            IList<Student> s = sf.SearchStudent(true);
            IList<PayFor> pf = sf.SearchPayFor();
            Console.WriteLine(s.Count + "," + pf.Count);
        }
    }
}
