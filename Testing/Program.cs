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
            IList<Student> st = sf.SearchStudent(true);
            for (int i = 2; i < st.Count; i++)
            {
                StudentRank t = new StudentRank();
                t.Stnum = st[i].Stnum;
                t.Rank = 1;
                t.Date = st[i].Joindate;
                sf.AddStudentRank(t);
            }
        }
    }
}
