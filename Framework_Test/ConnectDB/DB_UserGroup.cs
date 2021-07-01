using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Test.ConnectDB
{
    class DB_UserGroup
    {
        private static readonly string ConnectionString = Dbconnection.ConnectionString;
        public class UserGroup : Dbconnection
        {
            public string USID { get; set; }
            /// <summary>
            /// 姓名
            /// </summary>
            public string USName { get; set; }
            /// <summary>
            /// 密码
            /// </summary>
            public string USPsw { get; set; } = "123456";
            /// <summary>
            /// 工号
            /// </summary>
            public string USNumber { get; set; }
            /// <summary>
            /// 厂区
            /// </summary>
            public string USworkshop { get; set; }
            /// <summary>
            /// 权限
            /// 默认取值null = 不显示功能模块. 1 2 分别对应两个功能模块
            /// </summary>
            public string USPower { get; set; } = "null";
            /// <summary>
            /// 备注
            /// </summary>
            public string USRemarks { get; set; }
        }
        private static readonly string TableName = "UserGroup";
        private string Create_SQL = $"Create table {TableName}( " +
                                "USID INTEGER PRIMARY KEY NOT NULL," +
                                "USName string," +
                                "USNumber string," +
                                "USworkshop string," +
                                "USPsw string," +
                                "USPower string," +
                                "USRemarks string" +
                                ")";
        private string Insert_SQL = $"insert into  {TableName} (" +
                                "USName," +
                                "USPsw," +
                                "USNumber," +
                                "USworkshop," +
                                "USPower," +
                                "USRemarks" +
                            ") values (" +
                                ":USName," +
                                ":USPsw," +
                                ":USNumber," +
                                ":USworkshop," +
                                ":USPower," +
                                ":USRemarks" +
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
        public int Insert_DB(List<UserGroup> ValueList)
        {
            int a = 0;
            using (var conn = new SQLiteConnection(ConnectionString)) {
                foreach (var item in ValueList) {
                    var USName = item.USName;
                    var USPsw = item.USPsw;
                    var USNumber = item.USNumber;
                    var USworkshop = item.USworkshop;
                    var USPower = item.USPower;
                    var USRemarks = item.USRemarks;
                    var USpa = new {
                        USName,
                        USPsw,
                        USNumber,
                        USworkshop,
                        USPower,
                        USRemarks,
                    };
                    a += conn.Execute(Insert_SQL, USpa
                    );
                }
                return a;
            }
        }
        public IEnumerable<UserGroup> Search_DB()
        {
            using (var conn = new SQLiteConnection(ConnectionString)) {
                return conn.Query<UserGroup>(Search_SQL);
            }
        }
    }
}
