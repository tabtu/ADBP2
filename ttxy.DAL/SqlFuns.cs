using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ttxy.Model;

namespace ttxy.Funcs
{
    /// <summary>
    /// Powered by Tab Tu
    /// Last Edition Apr.4 2017
    /// 32 Functions, based on SQL operations
    /// </summary>
    public class SqlFuns
    {
        /*--------------------------------------attendance------------------------------------------*/
        public int AddAttendance(Attendance ld)
        {
            string sqlstr = "INSERT INTO db_p2_attendance (STU_NUM, COS_ID, ATD_DT)VALUES('" +
                ld.Student + "', '" +
                ld.Course + "', '" +
                ld.Date.ToShortDateString() + "');";
            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public Attendance SearchAttendanceSNUM(string snum)
        {
            string sqlstr = "SELECT STU_NUM, COS_ID, ATD_DT FROM db_p2_attendance WHERE STU_NUM='";

            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + snum + "'");
            DataTable dt = ds.Tables[0];

            Attendance temp = new Attendance();

            temp.Student = uint.Parse(dt.Rows[0][0].ToString());
            temp.Course = uint.Parse(dt.Rows[0][1].ToString());
            temp.Date = DateTime.Parse(dt.Rows[0][2].ToString());

            return temp;
        }

        public Attendance SearchAttendanceCNUM(string cnum)
        {
            string sqlstr = "SELECT STU_NUM, COS_ID, ATD_DT FROM db_p2_attendance WHERE COS_ID='";

            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + cnum + "'");
            DataTable dt = ds.Tables[0];

            Attendance temp = new Attendance();

            temp.Student = uint.Parse(dt.Rows[0][0].ToString());
            temp.Course = uint.Parse(dt.Rows[0][1].ToString());
            temp.Date = DateTime.Parse(dt.Rows[0][2].ToString());

            return temp;
        }

        public IList<Attendance> SearchAttendanceCNUM(DateTime sd, DateTime ed)
        {
            string sqlstr = "SELECT STU_NUM, COS_ID, ATD_DT FROM db_p2_attendance WHERE ATD_DT>'" + sd.ToShortDateString();
            string sqlend = "' and ATD_DT<'" + ed.ToShortDateString() + "';";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + sqlend);
            DataTable dt = ds.Tables[0];

            IList<Attendance> result = new List<Attendance>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Attendance temp = new Attendance();

                temp.Student = uint.Parse(dt.Rows[i][0].ToString());
                temp.Course = uint.Parse(dt.Rows[i][1].ToString());
                temp.Date = DateTime.Parse(dt.Rows[i][2].ToString());

                result.Add(temp);
            }
            return result;
        }
        
        /*--------------------------------------Course------------------------------------------*/
        public int AddCourse(Course ld)
        {
            string sqlstr = "INSERT INTO db_p2_course (COS_ID, COS_NAME, COL_ID, COS_ACTIVE)VALUES(" +
                ld.Cosid + ", '" +
                ld.Name + "', '" +
                ld.Level + "', " +
                ld.Active + ");";
            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public int EditCourse(Course ld)
        {
            string sqlstr = "UPDATE db_p2_course SET COS_NAME='" + ld.Name +
                "', COL_ID='" + ld.Level +
                "', COS_ACTIVE=" + ld.Active + 
                " WHERE COS_ID=" + ld.Cosid;

            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public int DropCourse(uint cosid)
        {
            string sqlstr = "UPDATE db_p2_course SET COS_ACTIVE=0 WHERE COS_ID=" + cosid;

            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
            //string sqlstr = "DELETE FROM u_pet " +
            //    "WHERE id=" + ld.ID;
            //int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            //return result;
        }

        public Course SearchCourseID(uint cosid)
        {
            string sqlstr = "SELECT COS_ID, COS_NAME, COL_ID, COS_ACTIVE FROM db_p2_course WHERE COS_ID=";
            string sqlend = " and COS_ACTIVE=1";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + cosid + sqlend);
            DataTable dt = ds.Tables[0];

            Course temp = new Course();

            temp.Cosid = uint.Parse(dt.Rows[0][0].ToString());
            temp.Name = dt.Rows[0][1].ToString();
            temp.Level = ushort.Parse(dt.Rows[0][2].ToString());
            temp.Active = dt.Rows[0][3].Equals("1");

            return temp;
        }

        public IList<Course> SearchCourseLEVEL(ushort level)
        {
            string sqlstr = "SELECT COS_ID, COS_NAME, COL_ID, COS_ACTIVE FROM db_p2_course WHERE COL_ID=";
            string sqlend = " and COS_ACTIVE=1";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + level + sqlend);
            DataTable dt = ds.Tables[0];

            IList<Course> result = new List<Course>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Course temp = new Course();

                temp.Cosid = uint.Parse(dt.Rows[i][0].ToString());
                temp.Name = dt.Rows[i][1].ToString();
                temp.Level = ushort.Parse(dt.Rows[i][2].ToString());
                temp.Active = dt.Rows[i][3].Equals("1");

                result.Add(temp);
            }
            return result;
        }

        public IList<Course> SearchCourseNAME(string name)
        {
            string sqlstr = "SELECT COS_ID, COS_NAME, COL_ID, COS_ACTIVE FROM db_p2_course WHERE COS_NAME LIKE '%";
            string sqlend = "%' and COS_ACTIVE=1";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + name + sqlend);
            DataTable dt = ds.Tables[0];

            IList<Course> result = new List<Course>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Course temp = new Course();

                temp.Cosid = uint.Parse(dt.Rows[i][0].ToString());
                temp.Name = dt.Rows[i][1].ToString();
                temp.Level = ushort.Parse(dt.Rows[i][2].ToString());
                temp.Active = dt.Rows[i][3].Equals("1");

                result.Add(temp);
            }
            return result;
        }
        
        /*--------------------------------------Level------------------------------------------*/
        public int AddLevel(Level ld)
        {
            string sqlstr = "INSERT INTO db_p2_courselevel (COL_ID, COL_NAME)VALUES(" +
                ld.Levid + ", '" +
                ld.Name + "');";
            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public int EditLevel(Level ld)
        {
            string sqlstr = "UPDATE db_p2_courselevel SET COL_ID=" + ld.Levid +
                ", COL_NAME='" + ld.Name +
                "' WHERE COL_ID=" + ld.Levid;

            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public int DropLevel(ushort ld)
        {
            string sqlstr = "DELETE FROM db_p2_courselevel " +
                "WHERE COL_ID=" + ld;

            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public Level SearchLevel(ushort id)
        {
            string sqlstr = "SELECT COL_ID, COL_NAME FROM db_p2_courselevel WHERE COL_ID=";

            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + id);
            DataTable dt = ds.Tables[0];

            Level temp = new Level();

            temp.Levid = ushort.Parse(dt.Rows[0][0].ToString());
            temp.Name = dt.Rows[0][1].ToString();

            return temp;
        }

        public IList<Level> SearchLevel()
        {
            string sqlstr = "SELECT COL_ID, COL_NAME FROM db_p2_courselevel;";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr);
            DataTable dt = ds.Tables[0];

            IList<Level> result = new List<Level>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Level temp = new Level();

                temp.Levid = ushort.Parse(dt.Rows[i][0].ToString());
                temp.Name = dt.Rows[i][1].ToString();

                result.Add(temp);
            }
            return result;
        }
        
        /*--------------------------------------Member------------------------------------------*/
        public int AddMember(Member ld)
        {
            string sqlstr = "INSERT INTO db_p2_member (MEM_USR, MEM_PWD, MEM_STU, STU_NUM)VALUES('" +
                ld.Usrname + "', '" +
                ld.Pwd + "', " +
                ld.Is_stu + ", '" +
                ld.Stnum + ");";
            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public int EditMember(Member ld)
        {
            string sqlstr = "UPDATE db_p2_member SET MEM_USR='" + ld.Usrname +
                "', MEM_PWD='" + ld.Pwd +
                "', MEM_STU=" + ld.Is_stu +
                ", STU_NUM=" + ld.Stnum +
                " WHERE MEM_USR='" + ld.Usrname + "';";

            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public int DropMember(string usr)
        {
            string sqlstr = "DELETE FROM db_p2_member " +
                "WHERE MEM_USR='" + usr + "';";

            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public Member SearchMemberUSR(string usr)
        {
            string sqlstr = "SELECT MEM_USR, MEM_PWD, MEM_STU, STU_NUM FROM db_p2_member WHERE MEM_USR='";

            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + usr + "';");
            DataTable dt = ds.Tables[0];

            Member temp = new Member();

            temp.Usrname = dt.Rows[0][0].ToString();
            temp.Pwd = dt.Rows[0][1].ToString();
            temp.Is_stu = dt.Rows[0][2].Equals("1");
            temp.Stnum = uint.Parse(dt.Rows[0][3].ToString());

            return temp;
        }
        
        /*--------------------------------------Parent------------------------------------------*/
        public int AddParent(Parent ld)
        {
            string sqlstr = "INSERT INTO db_p2_parent (PAR_NUM, PAR_NAME, PAR_MOBILE, PAR_EMAIL)VALUES(" +
                ld.Pnum + ", '" +
                ld.Name + "', '" +
                ld.Mobile + "', '" +
                ld.Email + "');";
            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public int EditParent(Parent ld)
        {
            string sqlstr = "UPDATE db_p2_parent SET PAR_NUM=" + ld.Pnum +
                ", PAR_NAME='" + ld.Name +
                "', PAR_MOBILE='" + ld.Mobile +
                "', PAR_EMAIL='" + ld.Email +
                " WHERE PAR_NUM=" + ld.Pnum;

            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }
        
        public Parent SearchParent(uint id)
        {
            string sqlstr = "SELECT PAR_NUM, PAR_NAME, PAR_MOBILE, PAR_EMAIL FROM db_p2_parent WHERE PAR_NUM=";

            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + id);
            DataTable dt = ds.Tables[0];

            Parent temp = new Parent();

            temp.Pnum = uint.Parse(dt.Rows[0][0].ToString());
            temp.Name = dt.Rows[0][1].ToString();
            temp.Mobile = dt.Rows[0][2].ToString();
            temp.Email = dt.Rows[0][3].ToString();

            return temp;
        }

        /*--------------------------------------PayFor------------------------------------------*/
        public int AddPayFor(PayFor ld)
        {
            string sqlstr = "INSERT INTO db_p2_payfor (PAF_ID, PAF_DES)VALUES(" + 
                ld.Id + ", '" +
                ld.Description + "');";
            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public PayFor SearchPayFor(ushort id)
        {
            string sqlstr = "SELECT PAF_ID, PAF_DES FROM db_p2_payfor WHERE PAF_ID=";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + id);
            DataTable dt = ds.Tables[0];

            PayFor temp = new PayFor();

            temp.Id = ushort.Parse(dt.Rows[0][0].ToString());
            temp.Description = dt.Rows[0][1].ToString();

            return temp;
        }

        public IList<PayFor> SearchPayFor()
        {
            string sqlstr = "SELECT PAF_ID, PAF_DES FROM db_p2_payfor";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr);
            DataTable dt = ds.Tables[0];

            IList<PayFor> result = new List<PayFor>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PayFor temp = new PayFor();

                temp.Id = ushort.Parse(dt.Rows[i][0].ToString());
                temp.Description = dt.Rows[i][1].ToString();

                result.Add(temp);
            }
            return result;
        }

        /*--------------------------------------Payment------------------------------------------*/
        public int AddPayment(Payment ld)
        {
            string sqlstr = "INSERT INTO db_p2_payment (PAY_ID, STU_NUM, PAY_FEE, PAF_ID, PAY_DT)VALUES(" +
                ld.Id + ", " +
                ld.Stnum + ", " +
                ld.Fee + ", " +
                ld.Payfor + ", '" +
                ld.Paydt + "');";
            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public IList<Payment> SearchPayment(uint snum)
        {
            string sqlstr = "SELECT PAY_ID, STU_NUM, PAY_FEE, PAF_ID, PAY_DT FROM db_p2_payment WHERE STU_NUM=";
            string sqlend = " ORDER BY PAY_DT";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + snum + sqlend);
            DataTable dt = ds.Tables[0];

            IList<Payment> result = new List<Payment>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Payment temp = new Payment();

                temp.Id = uint.Parse(dt.Rows[i][0].ToString());
                temp.Stnum = uint.Parse(dt.Rows[i][1].ToString());
                temp.Fee = double.Parse(dt.Rows[i][2].ToString());
                temp.Payfor = ushort.Parse(dt.Rows[i][3].ToString());
                temp.Paydt = DateTime.Parse(dt.Rows[i][4].ToString());

                result.Add(temp);
            }
            return result;
        }

        public IList<Payment> SearchPayment(ushort payf)
        {
            string sqlstr = "SELECT PAY_ID, STU_NUM, PAY_FEE, PAF_ID, PAY_DT FROM db_p2_payment WHERE PAF_ID=";
            string sqlend = " ORDER BY PAY_DT";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + payf + sqlend);
            DataTable dt = ds.Tables[0];

            IList<Payment> result = new List<Payment>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Payment temp = new Payment();

                temp.Id = uint.Parse(dt.Rows[i][0].ToString());
                temp.Stnum = uint.Parse(dt.Rows[i][1].ToString());
                temp.Fee = double.Parse(dt.Rows[i][2].ToString());
                temp.Payfor = ushort.Parse(dt.Rows[i][3].ToString());
                temp.Paydt = DateTime.Parse(dt.Rows[i][4].ToString());

                result.Add(temp);
            }
            return result;
        }

        public IList<Payment> SearchPayment(DateTime sd, DateTime ed)
        {
            string sqlstr = "SELECT PAY_ID, STU_NUM, PAY_FEE, PAF_ID, PAY_DT FROM db_p2_payment WHERE PAY_DT>'";
            string sqlmid = "' AND PAY_DT<'";
            string sqlend = "' ORDER BY PAY_DT";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + sd + sqlmid + ed + sqlend);
            DataTable dt = ds.Tables[0];

            IList<Payment> result = new List<Payment>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Payment temp = new Payment();

                temp.Id = uint.Parse(dt.Rows[i][0].ToString());
                temp.Stnum = uint.Parse(dt.Rows[i][1].ToString());
                temp.Fee = double.Parse(dt.Rows[i][2].ToString());
                temp.Payfor = ushort.Parse(dt.Rows[i][3].ToString());
                temp.Paydt = DateTime.Parse(dt.Rows[i][4].ToString());

                result.Add(temp);
            }
            return result;
        }

        public IList<Payment> SearchPayment(uint snum, ushort pf, DateTime sd, DateTime ed)
        {
            string sqlstr = "SELECT PAY_ID, STU_NUM, PAY_FEE, PAF_ID, PAY_DT FROM db_p2_payment WHERE PAY_DT>'";
            string sqlmid0 = "' AND PAY_DT<'";
            string sqlmid1 = "' AND STU_NUM=";
            string sqlmid2 = " AND PAF_ID=";
            string sqlend = " ORDER BY PAY_DT";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + sd + sqlmid0 + ed + sqlmid1 + snum + sqlmid2 + pf + sqlend);
            DataTable dt = ds.Tables[0];

            IList<Payment> result = new List<Payment>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Payment temp = new Payment();

                temp.Id = uint.Parse(dt.Rows[i][0].ToString());
                temp.Stnum = uint.Parse(dt.Rows[i][1].ToString());
                temp.Fee = double.Parse(dt.Rows[i][2].ToString());
                temp.Payfor = ushort.Parse(dt.Rows[i][3].ToString());
                temp.Paydt = DateTime.Parse(dt.Rows[i][4].ToString());

                result.Add(temp);
            }
            return result;
        }


        /*--------------------------------------Rank------------------------------------------*/
        public Rank SearchRank(uint rkid)
        {
            string sqlstr = "SELECT RAK_ID, RAK_NAME, RAK_COLOR FROM db_p2_rank WHERE RAK_ID=";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + rkid);
            DataTable dt = ds.Tables[0];

            Rank temp = new Rank();
            temp.Id = uint.Parse(dt.Rows[0][0].ToString());
            temp.Name = dt.Rows[0][1].ToString();
            temp.Color = dt.Rows[0][2].ToString();

            return temp;
        }

        public IList<Rank> SearchRank()
        {
            string sqlstr = "SELECT RAK_ID, RAK_NAME, RAK_COLOR FROM db_p2_rank ORDER BY RAK_ID";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr);
            DataTable dt = ds.Tables[0];

            IList<Rank> result = new List<Rank>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Rank temp = new Rank();

                temp.Id = uint.Parse(dt.Rows[i][0].ToString());
                temp.Name = dt.Rows[i][1].ToString();
                temp.Color = dt.Rows[i][2].ToString();

                result.Add(temp);
            }
            return result;
        }

        /*--------------------------------------Requirement------------------------------------------*/
        public int AddRequirement(Requirement ld)
        {
            string sqlstr = "INSERT INTO db_p2_requirement (RAK_ID, COS_ID, REQ_DES)VALUES(" +
                ld.Rank + ", " +
                ld.Course + ", '" +
                ld.Description + "');";
            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public int DropRequirement(uint rkid, uint cosid)
        {
            string sqlstr = "DELETE FROM db_p2_requirement WHERE RAK_ID =" + rkid + " AND COS_ID=" + cosid;
            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public IList<Requirement> SearchRequirement(uint rkid)
        {
            string sqlstr = "SELECT RAK_ID, COS_ID, REQ_DES FROM db_p2_requirement WHERE RAK_ID=";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + rkid);
            DataTable dt = ds.Tables[0];

            IList<Requirement> result = new List<Requirement>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Requirement temp = new Requirement();

                temp.Rank = uint.Parse(dt.Rows[i][0].ToString());
                temp.Course = ushort.Parse(dt.Rows[i][1].ToString());
                temp.Description = dt.Rows[i][2].ToString();

                result.Add(temp);
            }
            return result;
        }

        /*--------------------------------------Student------------------------------------------*/
        public int AddStudent(Student ld)
        {
            string sqlstr = "INSERT INTO db_p2_student (STU_NAME, STU_BIRTH, STU_JODATE, STU_MOBILE, STU_EMAIL, STU_ADDR, STU_ACTIVE)VALUES('" +
                ld.Name + "', '" +
                ld.Birth + "', '" +
                ld.Joindate + "', '" +
                ld.Mobile + "', '" +
                ld.Email + "', '" +
                ld.Address + "', " +
                ld.Active + ");";
            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        /// <summary>
        /// to be tested
        /// </summary>
        /// <param name="ld"></param>
        /// <returns></returns>
        public int EditStudent(Student ld)
        {
            string sqlstr = "UPDATE db_p2_student SET STU_NAME='" + ld.Name +
                "', STU_BIRTH='" + ld.Birth +
                "', STU_JODATE=" + ld.Joindate +
                "', STU_MOBILE=" + ld.Mobile +
                "', STU_EMAIL=" + ld.Email +
                "', STU_ADDR=" + ld.Address +
                "', STU_ACTIVE=" + ld.Active +
                " WHERE STU_NUM=" + ld.Stnum;

            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public int DropStudent(uint snum)
        {
            string sqlstr = "UPDATE db_p2_student SET STU_ACTIVE=0 WHERE STU_NUM=" + snum;

            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
            //string sqlstr = "DELETE FROM u_pet " +
            //    "WHERE id=" + ld.ID;
            //int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            //return result;
        }

        public Student SearchStudent(uint snum)
        {
            string sqlstr = "SELECT STU_NUM, STU_NAME, STU_BIRTH, STU_JODATE, STU_MOBILE, STU_EMAIL, STU_ADDR, STU_ACTIVE FROM db_p2_student WHERE STU_NUM=";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + snum);
            DataTable dt = ds.Tables[0];

            Student temp = new Student();

            temp.Stnum = uint.Parse(dt.Rows[0][0].ToString());
            temp.Name = dt.Rows[0][1].ToString();
            temp.Birth = DateTime.Parse(dt.Rows[0][2].ToString());
            temp.Joindate = DateTime.Parse(dt.Rows[0][3].ToString());
            temp.Mobile = dt.Rows[0][4].ToString();
            temp.Email = dt.Rows[0][5].ToString();
            temp.Address = dt.Rows[0][6].ToString();
            temp.Active = dt.Rows[0][7].Equals("1");

            return temp;
        }


        public IList<Student> SearchStudent(string name)
        {
            string sqlstr = "SELECT STU_NUM, STU_NAME, STU_BIRTH, STU_JODATE, STU_MOBILE, STU_EMAIL, STU_ADDR, STU_ACTIVE FROM db_p2_student WHERE STU_NAME LIKE '%";
            string sqlend = "%';";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + name + sqlend);
            DataTable dt = ds.Tables[0];

            IList<Student> result = new List<Student>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Student temp = new Student();

                temp.Stnum = uint.Parse(dt.Rows[i][0].ToString());
                temp.Name = dt.Rows[i][1].ToString();
                temp.Birth = DateTime.Parse(dt.Rows[i][2].ToString());
                temp.Joindate = DateTime.Parse(dt.Rows[i][3].ToString());
                temp.Mobile = dt.Rows[i][4].ToString();
                temp.Email = dt.Rows[i][5].ToString();
                temp.Address = dt.Rows[i][6].ToString();
                temp.Active = dt.Rows[i][7].Equals("1");

                result.Add(temp);
            }
            return result;
        }

        public IList<Student> SearchStudent(bool active)
        {
            string sqlstr = "SELECT STU_NUM, STU_NAME, STU_BIRTH, STU_JODATE, STU_MOBILE, STU_EMAIL, STU_ADDR, STU_ACTIVE FROM db_p2_student WHERE STU_ACTIVE=";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + active);
            DataTable dt = ds.Tables[0];

            IList<Student> result = new List<Student>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Student temp = new Student();

                temp.Stnum = uint.Parse(dt.Rows[i][0].ToString());
                temp.Name = dt.Rows[i][1].ToString();
                temp.Birth = DateTime.Parse(dt.Rows[i][2].ToString());
                temp.Joindate = DateTime.Parse(dt.Rows[i][3].ToString());
                temp.Mobile = dt.Rows[i][4].ToString();
                temp.Email = dt.Rows[i][5].ToString();
                temp.Address = dt.Rows[i][6].ToString();
                temp.Active = dt.Rows[i][7].Equals("1");

                result.Add(temp);
            }
            return result;
        }

        /*--------------------------------------StudentRank--------------------------------*/
        public int AddStudentRank(StudentRank ld)
        {
            string sqlstr = "INSERT INTO db_p2_sturank (STU_NUM, RAK_ID, STR_DT)VALUES(" +
                ld.Stnum + ", " +
                ld.Rank + ", '" +
                ld.Date + "');";
            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public StudentRank SearchStudentRank(uint snum, uint rkid)
        {
            string sqlstr = "SELECT STU_NUM, RAK_ID, STR_DT FROM db_p2_sturank WHERE STU_NUM=";
            string sqlend = " AND RAK_ID=";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + snum + sqlend + rkid);
            DataTable dt = ds.Tables[0];

            StudentRank temp = new StudentRank();

            temp.Stnum = uint.Parse(dt.Rows[0][0].ToString());
            temp.Rank = uint.Parse(dt.Rows[0][1].ToString());
            temp.Date = DateTime.Parse(dt.Rows[0][2].ToString());

            return temp;
        }

        public IList<StudentRank> SearchStudentRank(uint snum)
        {
            string sqlstr = "SELECT STU_NUM, RAK_ID, STR_DT FROM db_p2_sturank WHERE STU_NUM=";
            string sqlend = " ORDER BY RAK_ID";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + snum + sqlend);
            DataTable dt = ds.Tables[0];

            IList<StudentRank> result = new List<StudentRank>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                StudentRank temp = new StudentRank();

                temp.Stnum = uint.Parse(dt.Rows[i][0].ToString());
                temp.Rank = uint.Parse(dt.Rows[i][1].ToString());
                temp.Date = DateTime.Parse(dt.Rows[i][2].ToString());

                result.Add(temp);
            }
            return result;
        }

        /*--------------------------------------StuParent------------------------------------------*/
        public int AddStuParent(StuParent ld)
        {
            string sqlstr = "INSERT INTO db_p2_stupar (STU_NUM, STP_MORD, STP_STUPAR, SP_ID)VALUES(" +
                ld.Stnum + ", " +
                ld.Mord + ", " +
                ld.Stpar + ", " +
                ld.Spnum + ");";
            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public int DropStuParent(uint cosid)
        {
            string sqlstr = "UPDATE db_p2_stupar SET COS_ACTIVE=0 WHERE COS_ID=" + cosid;

            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
            //string sqlstr = "DELETE FROM u_pet " +
            //    "WHERE id=" + ld.ID;
            //int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            //return result;
        }

        public StuParent SearchStuParent(uint stnum, bool mod)
        {
            string sqlstr = "SELECT STU_NUM, STP_MORD, STP_STUPAR, SP_ID FROM db_p2_stupar WHERE STU_NUM=";
            string sqlend = " and STP_MORD=";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + stnum + sqlend + mod);
            DataTable dt = ds.Tables[0];

            StuParent temp = new StuParent();

            temp.Stnum = uint.Parse(dt.Rows[0][0].ToString());
            temp.Mord = dt.Rows[0][1].Equals("1");
            temp.Stpar = dt.Rows[0][2].Equals("1");
            temp.Spnum = uint.Parse(dt.Rows[0][3].ToString());

            return temp;
        }

        public IList<StuParent> SearchStuParent(uint stnum)
        {
            string sqlstr = "SELECT STU_NUM, STP_MORD, STP_STUPAR, SP_ID FROM db_p2_stupar WHERE STU_NUM=";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + stnum);
            DataTable dt = ds.Tables[0];

            IList<StuParent> result = new List<StuParent>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                StuParent temp = new StuParent();

                temp.Stnum = uint.Parse(dt.Rows[i][0].ToString());
                temp.Mord = dt.Rows[i][1].Equals("1");
                temp.Stpar = dt.Rows[i][2].Equals("1");
                temp.Spnum = uint.Parse(dt.Rows[i][3].ToString());

                result.Add(temp);
            }
            return result;
        }

        /*--------------------------------------Timetable------------------------------------------*/
        public int AddTimetable(Timetable ld)
        {
            string sqlstr = "INSERT INTO db_p2_timetable (COS_ID, TIT_DOW, TIT_DTS, TIT_DTE)VALUES('" +
                ld.Course + "', '" +
                ld.Dayofweek + "', '" +
                ld.Starttime + "', " +
                ld.Endtime + ");";
            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public int DropTimetable(Timetable tm)
        {
            string sqlstr = "DELETE FROM db_p2_timetable WHERE COS_ID=" + tm.Course + 
                " AND TIT_DOW=" + tm.Dayofweek + 
                " AND TIT_DTS=" + tm.Starttime + 
                " AND TIT_DTE=" + tm.Endtime;
            int result = MySqlHelper.ExecuteNonQuery(sqlstr);
            return result;
        }

        public IList<Timetable> SearchTimetable(uint cosid)
        {
            string sqlstr = "SELECT COS_ID, TIT_DOW, TIT_DTS, TIT_DTE FROM db_p2_timetable WHERE COS_ID=";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + cosid);
            DataTable dt = ds.Tables[0];

            IList<Timetable> result = new List<Timetable>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Timetable temp = new Timetable();

                temp.Course = uint.Parse(dt.Rows[i][0].ToString());
                temp.Dayofweek = short.Parse(dt.Rows[i][1].ToString());
                temp.Starttime = short.Parse(dt.Rows[i][2].ToString());
                temp.Endtime = short.Parse(dt.Rows[i][3].ToString());

                result.Add(temp);
            }
            return result;
        }

        public IList<Timetable> SearchTimetable(short dow)
        {
            string sqlstr = "SELECT COS_ID, TIT_DOW, TIT_DTS, TIT_DTE FROM db_p2_timetable WHERE TIT_DOW=";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlstr + dow);
            DataTable dt = ds.Tables[0];

            IList<Timetable> result = new List<Timetable>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Timetable temp = new Timetable();

                temp.Course = uint.Parse(dt.Rows[i][0].ToString());
                temp.Dayofweek = short.Parse(dt.Rows[i][1].ToString());
                temp.Starttime = short.Parse(dt.Rows[i][2].ToString());
                temp.Endtime = short.Parse(dt.Rows[i][3].ToString());

                result.Add(temp);
            }
            return result;
        }
    }
}
