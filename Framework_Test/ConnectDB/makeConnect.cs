using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Test.ConnectDB
{
    class makeConnect
    {
        public List<dbvalue> dbls = new List<dbvalue>();
        public void checkDBexisit()
        {
            foreach (var item in dbls) {
                new ValueDetail().Create(item.name_db, item.create_sql);
            }
        }
        public makeConnect()
        {
            dbls.Clear();
            dbls = MakeDBList();
        }
        private List<dbvalue> MakeDBList()
        {
            //ContractMessage
            dbls.Add(makedbvalue("ContractMessage",
                            "Create table {0}( " +
                                "ID INTEGER PRIMARY KEY NOT NULL," +
                                "Name string," +
                                "Work_content string," +
                                "length_of_work string," +
                                "workshop string," +
                                "Production_capacity string," +
                                "Remarks string" +
                                ")",
                            "insert into {0} (" +
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
                            "",
                            "select * from {0}",
                            ""));
            //UserGroup
            dbls.Add(makedbvalue("UserGroup",
                            "Create table {0}( " +
                                "USID INTEGER PRIMARY KEY NOT NULL," +
                                "USName string," +
                                "USNumber string," +
                                "USworkshop string," +
                                "USPsw string," +
                                "USPower string," +
                                "USRemarks string" +
                                ")",
                            "insert into {0} (" +
                                "USName," +
                                "USNumber," +
                                "USworkshop," +
                                "USPsw," +
                                "USPower," +
                                "USRemarks" +
                            ") values (" +
                                ":USName," +
                                ":USNumber," +
                                ":USworkshop," +
                                ":USPsw," +
                                ":USPower," +
                                ":USRemarks" +
                            ")",
                            "",
                            "select * from {0}",
                            ""));
            return dbls;
        }

        private dbvalue makedbvalue(string name, string create_sql, string Install_sql, string change_sql, string search_sql, string delete_sql)
        {
            var dbv = new dbvalue();
            dbv.name_db = name;
            dbv.create_sql = string.Format(create_sql, dbv.name_db);
            dbv.Install_sql = string.Format(Install_sql, dbv.name_db);
            dbv.change_sql = string.Format(change_sql, dbv.name_db);
            dbv.search_sql = string.Format(search_sql, dbv.name_db);
            dbv.delete_sql = string.Format(delete_sql, dbv.name_db);
            return dbv;
        }
        public class dbvalue
        {
            public string name_db { get; set; }
            public string create_sql { get; set; }
            public string Install_sql { get; set; }
            public object install_obj { get; set; }
            public string change_sql { get; set; }
            public string search_sql { get; set; }
            public string delete_sql { get; set; }

        }
        public IEnumerable<dynamic> GetMessage(string module)
        {
            switch (module) {
                case "UserGroup":
                    return new ValueDetail().GetDBMessage(dbls[1]);
                case "ContractMessage":
                    return new ValueDetail().GetDBMessage(dbls[0]);
                default:
                    return null;
            }
        }
    }
}
