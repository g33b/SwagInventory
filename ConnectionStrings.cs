using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Dapper;

namespace SwagInventory
{
    public static class ConnectionStrings
    {
        public static string DbFile
        {
            get { return Environment.CurrentDirectory + "\\inventory.sqlite"; }
        }
        
        public static SqliteConnection DBConnection()
        {
            return new SqliteConnection("Data Source=" + DbFile);
        }




        private static void CreateDatabase()
        {
            using (var cnn = DBConnection())
            {
                cnn.Open();
                cnn.Execute(
                    @"create table Items
              (
                 ID             integer identity primary key AUTOINCREMENT,
                 GUID           varchar(100) not null,
                 Description    varchar(100) not null
              )");
            }
        }
    }
}
