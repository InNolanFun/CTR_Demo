using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;
using System.Configuration;
using Framework_Test.ConnectDB;

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

    internal class UserGroup : Dbconnection
    {
        public string USID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string USName { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string USNumber { get; set; }
        /// <summary>
        /// 厂区
        /// </summary>
        public string USworkshop { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string USRemarks { get; set; }
    }
    class ValueDetail : Dbconnection
    {
        private string tablename = "ContractMessage";
        public bool Create(string intablename, string sql)
        {
            tablename = intablename;
            using (var conn = new SQLiteConnection(ConnectionString)) {
                conn.Open();
                using (var t = conn.BeginTransaction()) {//锁定db
                    try {
                        var tableExists = conn.QuerySingle<int>("SELECT COUNT(*) AS QtRecords FROM sqlite_master WHERE type = 'table' AND name = :name",
                            new { name = tablename }, t) == 1;
                        if (!tableExists) { conn.Execute(sql, transaction: t); }
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
        public int Insert(string sql, object parami)
        {
            using (var conn = new SQLiteConnection(ConnectionString)) {
                var a = conn.Execute(sql, parami);
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

        public IEnumerable<dynamic> GetDBMessage(makeConnect.dbvalue dbvalue)
        {
            using (var conn = new SQLiteConnection(ConnectionString)) {
                if (dbvalue.name_db == "UserGroup") {
                    return conn.Query<UserGroup>(dbvalue.search_sql);
                } else if (dbvalue.name_db == "ContractMessage") {
                    return conn.Query<ValueGroup>(dbvalue.search_sql);
                } else {
                    return null;
                }
            }
        }
    }

    #endregion
}
