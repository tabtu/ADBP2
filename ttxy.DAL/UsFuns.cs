using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ttxy.Model;

namespace ttxy.Funcs
{
    public class UsFuns
    {
        /// <summary>
        /// Login the System
        /// </summary>
        /// <param name="us">User's Information, must include username and password</param>
        /// <returns>username</returns>
        public Member UserLogin(string us, string pwd)
        {
            try
            {
                SqlFuns sf = new SqlFuns();
                Member tmp = sf.SearchMemberUSR(us);
                if (tmp.Pwd == pwd)
                {
                    tmp.Pwd = "";
                    return tmp;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public Member UsrInfo(string us)
        {
            try
            {
                SqlFuns sf = new SqlFuns();
                return sf.SearchMemberUSR(us);
            }
            catch
            {
                return null;
            }
        }

        public IList<Payment> FillPayment(IList<Payment> list)
        {
            SqlFuns sf = new SqlFuns();
            foreach(Payment tmp in list)
            {
                tmp.StrStuName = sf.SearchStudent(tmp.Stnum).Name;
                tmp.StrPayFor = sf.SearchPayFor(tmp.Payfor).Description;
            }
            return list;
        }
    }
}
