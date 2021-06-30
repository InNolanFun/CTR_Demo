using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Test.ConnectDB
{
    class DB_ContractMessage
    {
        private static readonly string ConnectionString = Dbconnection.ConnectionString;
        public class ValueGroup : Dbconnection
        {
            public string ID { get; set; }
            public string UName { get; set; }
            public string Work_content { get; set; }
            public string length_of_work { get; set; }
            public string workshop { get; set; }
            public string Production_capacity { get; set; }
            public string Remarks { get; set; }
        }
        private static readonly string TableName = "ContractMessage";
        private string Create_SQL = $"Create table {TableName}( " +
                                "ID INTEGER PRIMARY KEY NOT NULL," +
                                "UName string," +
                                "Work_content string," +
                                "length_of_work string," +
                                "workshop string," +
                                "Production_capacity string," +
                                "Remarks string" +
                                ")";
        private string Insert_SQL = $"insert into  {TableName} (" +
                                "UName," +
                                "Work_content," +
                                "length_of_work," +
                                "workshop," +
                                "Production_capacity," +
                                "Remarks" +
                            ") values (" +
                                ":UName," +
                                ":Work_content," +
                                ":length_of_work," +
                                ":workshop," +
                                ":Production_capacity," +
                                ":Remarks" +
                            ")";
        private string Search_SQL = $"select * from {TableName}";
        private string Update_SQL = "";
        private string Delete_SQL = "";

        public bool Create()
        {
            using (var conn = new SQLiteConnection(ConnectionString)) {
                conn.Open();
                using (var t = conn.BeginTransaction()) {//锁定db
                    try {
                        var tableExists = conn.QuerySingle<int>("SELECT COUNT(*) AS QtRecords FROM sqlite_master WHERE type = 'table' AND name = :name",
                            new { name = TableName }, t) == 1;
                        if (!tableExists) { conn.Execute(Create_SQL, transaction: t); }
                        t.Commit();//执行
                        return true;
                    } catch (System.Exception ex) {
                        t.Rollback();//回滚
                        throw ex;
                    }
                }
            }
        }
        public int Insert_DB(List<ValueGroup> ValueList)
        {
            int a = 0;
            using (var conn = new SQLiteConnection(ConnectionString)) {
                foreach (var item in ValueList) {
                    var UName = item.UName;
                    var Work_content = item.Work_content;
                    var length_of_work = item.length_of_work;
                    var workshop = item.workshop;
                    var Production_capacity = item.Production_capacity;
                    var Remarks = item.Remarks;
                    var pa = new
                    {
                        UName,
                        Work_content,
                        length_of_work,
                        workshop,
                        Production_capacity,
                        Remarks,
                    };
                    a += conn.Execute(Insert_SQL, pa);
                }
                return a;
            }
        }
        public IEnumerable<ValueGroup> Search_DB()
        {
            using (var conn = new SQLiteConnection(ConnectionString)) {
                return conn.Query<ValueGroup>(Search_SQL);
            }
        }

    }
}
