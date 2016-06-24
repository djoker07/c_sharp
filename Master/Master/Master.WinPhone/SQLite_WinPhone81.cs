﻿using System;
using System.IO;
using Master;
using Master.UWP;
using Xamarin.Forms;
using Windows.Storage;

[assembly: Dependency(typeof(SQLite_WinPhone81))]

namespace Master.UWP
{
    public class SQLite_WinPhone81 : ISQLite
    {
        public SQLite_WinPhone81()
        {
        }
        #region ISQLite implementation
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "TodoSQLite.db3";
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);

            var conn = new SQLite.SQLiteConnection(path);

            // Return the database connection 
            return conn;
        }
        #endregion
    }
}