using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;
using System.Configuration;

namespace Framework_Test
{
    class Dbconnection
    {
        public static readonly string ConnectionString = ConfigurationManager.AppSettings["DBConnectionString"];
    }
    #region 数据录入
    /// <summary>
    /// 获取订单详情的列名称
    /// </summary>
    internal class ValueGroup : Dbconnection
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Work_content { get; set; }
        public string length_of_work { get; set; }
        public string workshop { get; set; }
        public string Production_capacity { get; set; }
        public string Remarks { get; set; }
    }
    class ValueDetail : Dbconnection
    {
        private string tablename = "ContractMessage";
        public bool Create()
        {
            using (var conn = new SQLiteConnection(ConnectionString)) {
                conn.Open();
                using (var t = conn.BeginTransaction()) {//锁定db
                    try {
                        var tableExists = conn.QuerySingle<int>("SELECT COUNT(*) AS QtRecords FROM sqlite_master WHERE type = 'table' AND name = :name",
                            new { name = tablename }, t) == 1;
                        if (!tableExists) {
                            conn.Execute($"Create table {tablename}( " +
                                "ID INTEGER PRIMARY KEY NOT NULL," +
                                "Name string," +
                                "Work_content string," +
                                "length_of_work string," +
                                "workshop string," +
                                "Production_capacity string," +
                                "Remarks string" +
                                ")", transaction: t);
                        }
                        t.Commit();//执行
                        return true;
                    } catch (System.Exception ex) {
                        t.Rollback();//回滚
                        throw ex;
                    }
                }
            }
        }
        //add
        public int Insert(ValueGroup con)
        {
            using (var conn = new SQLiteConnection(ConnectionString)) {
                var Name = con.Name;
                var Work_content = con.Work_content;
                var length_of_work = con.length_of_work;
                var workshop = con.workshop;
                var Production_capacity = con.Production_capacity;
                var Remarks = con.Remarks;
                var a = conn.Execute(
                    $"insert into {tablename} (" +
                        "Name," +
                        "Work_content," +
                        "length_of_work," +
                        "workshop," +
                        "Production_capacity," +
                        "Remarks" +
                    ") values (" +
                        ":Name," +
                        ":Work_content," +
                        ":length_of_work," +
                        ":workshop," +
                        ":Production_capacity," +
                        ":Remarks" +
                    ")",
                new {
                    Name,
                    Work_content,
                    length_of_work,
                    workshop,
                    Production_capacity,
                    Remarks
                });
                return a;
            }
        }
        //delete
        public void Delete(List<int> deletelst)
        {
            var sql = $"delete from {tablename} where ID = :ID";
            using (var conn = new SQLiteConnection(ConnectionString)) {
                conn.Execute(sql);
            }
        }
        //update
        public int Update(int ID, int CarID)
        {
            using (var conn = new SQLiteConnection(ConnectionString)) {
                var a = conn.Execute($"update {tablename} set CarID = :CarID where ID = :ID",
                new { CarID, ID });
                return a;
            }
        }
        //search
        public IEnumerable<ValueGroup> GetAllValue()
        { //search all value
            using (var conn = new SQLiteConnection(ConnectionString)) {
                return conn.Query<ValueGroup>($"select * from {tablename} ");
            }
        }
    }

    #endregion
}
