using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Test.ConnectDB
{
    class DB_DBName
    {
        private static readonly string ConnectionString = Dbconnection.ConnectionString;
        public class DBName : Dbconnection
        {
            public string USID { get; set; }
            public string dbpa1_DBName { get; set; }
            public string dbpa2_DBName { get; set; }

        }
        private static readonly string TableName = "ContractMessage";
        private string Create_SQL = $"Create table {TableName}( " +
                                "USID INTEGER PRIMARY KEY NOT NULL," +
                                "dbpa1_DBName string," +
                                "dbpa2_DBName string" +
                                ")";
        private string Insert_SQL = $"insert into  {TableName} (" +
                                "dbpa1_DBName," +
                                "dbpa2_DBName" +
                            ") values (" +
                                ":dbpa1_DBName," +
                                ":dbpa2_DBName" +
                            ")";
        private string Search_SQL = $"select * from {TableName}";
        private string Update_SQL = "";
        private string Delete_SQL = "";

        public bool Create()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                using (var t = conn.BeginTransaction())
                {//锁定db
                    try
                    {
                        var tableExists = conn.QuerySingle<int>("SELECT COUNT(*) AS QtRecords FROM sqlite_master WHERE type = 'table' AND name = :name",
                            new { name = TableName }, t) == 1;
                        if (!tableExists) { conn.Execute(Create_SQL, transaction: t); }
                        t.Commit();//执行
                        return true;
                    }
                    catch (System.Exception ex)
                    {
                        t.Rollback();//回滚
                        throw ex;
                    }
                }
            }
        }
        public int Insert_DB(List<DBName> ValueList)
        {
            int a = 0;
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                foreach (var item in ValueList)
                {
                    var dbpa1_DBName = item.dbpa1_DBName;
                    var dbpa2_DBName = item.dbpa2_DBName;
                    var pa = new {
                        dbpa1_DBName,
                        dbpa2_DBName,
                    };
                    a = conn.Execute(Insert_SQL, pa);
                }
                return a;
            }
        }
        public IEnumerable<DBName> Search_DB()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                return conn.Query<DBName>(Search_SQL);
            }
        }
    }
}
