using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace ttxy.Funcs
{
    public class MySqlHelper
    {

        private MySqlHelper()
        {

        }

        //Excute a single insert, return primary key; using ExceuteNonQuery if return void
        public static int ExecuteInsert(string sql, MySqlParameter[] parameters)
        {
            //Debug.WriteLine(sql);
            using (MySqlConnection connection = new MySqlConnection(MyDataContext.connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                try
                {
                    connection.Open();
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = @"select LAST_INSERT_ID()";
                    int value = Int32.Parse(cmd.ExecuteScalar().ToString());
                    return value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public static int ExecuteInsert(string sql)
        {
            return ExecuteInsert(sql, null);
        }

        //Excute SQL with parameters (insert,update,delete)
        public static int ExecuteNonQuery(string sql, MySqlParameter[] parameters)
        {
            //Debug.WriteLine(sql);
            using (MySqlConnection connection = new MySqlConnection(MyDataContext.connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                try
                {
                    connection.Open();
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        //Excute SQL without parameters, return count of the result list
        public static int ExecuteNonQuery(string sql)
        {
            return ExecuteNonQuery(sql, null);
        }

        //Excute the first of a single SQL; also use to return count(*)
        public static int ExecuteScalar(string sql, MySqlParameter[] parameters)
        {
            //Debug.WriteLine(sql);
            using (MySqlConnection connection = new MySqlConnection(MyDataContext.connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                try
                {
                    connection.Open();
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    int value = Int32.Parse(cmd.ExecuteScalar().ToString());
                    return value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public static int ExecuteScalar(string sql)
        {
            return ExecuteScalar(sql, null);
        }

        //Excute Mission
        public static void ExecuteTrans(List<string> sqlList, List<MySqlParameter[]> paraList)
        {
            //Debug.WriteLine(sql);
            using (MySqlConnection connection = new MySqlConnection(MyDataContext.connectionString))
            {
                MySqlCommand cmd = new MySqlCommand();
                MySqlTransaction transaction = null;
                cmd.Connection = connection;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();
                    cmd.Transaction = transaction;

                    for (int i = 0; i < sqlList.Count; i++)
                    {
                        cmd.CommandText = sqlList[i];
                        if (paraList != null && paraList[i] != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddRange(paraList[i]);
                        }
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();

                }
                catch (Exception e)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch
                    {

                    }
                    throw e;
                }

            }
        }
        public static void ExecuteTrans(List<string> sqlList)
        {
            ExecuteTrans(sqlList, null);
        }

        //Excute Select SQL, return dataset
        public static DataSet ExecuteQuery(string sql, MySqlParameter[] parameters)
        {
            //Debug.WriteLine(sql);
            using (MySqlConnection connection = new MySqlConnection(MyDataContext.connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, connection);
                    if (parameters != null) da.SelectCommand.Parameters.AddRange(parameters);
                    da.Fill(ds, "ds");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return ds;
            }
        }
        public static DataSet ExecuteQuery(string sql)
        {
            return ExecuteQuery(sql, null);
        }

        //Excute Proceedue, return string; paraList[0] is the returns
        public static string ExecuteProcedure(string procedureName, List<MySqlParameter> paraList)
        {
            MySqlConnection mysqlcon;
            MySqlDataAdapter mysqldata = new MySqlDataAdapter();
            DataSet dataset = new DataSet();
            mysqlcon = new MySqlConnection(MyDataContext.connectionString);
            mysqldata.SelectCommand = new MySqlCommand();
            mysqldata.SelectCommand.Connection = mysqlcon;
            mysqldata.SelectCommand.CommandText = procedureName;
            mysqldata.SelectCommand.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < paraList.Count; i++)
            {
                mysqldata.SelectCommand.Parameters.Add(paraList[i]);
            }

            try
            {
                mysqldata.Fill(dataset, procedureName);

                return paraList[0].Value.ToString();
            }
            catch (MySqlException ex)
            {
                return ex.ToString();
            }
        }
    }
}
