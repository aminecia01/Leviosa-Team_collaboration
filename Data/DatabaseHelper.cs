using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite; //added to use the SQLite .NET provider

namespace Leviosa.Data
{
    internal class DatabaseHelper
    {
        private static string dbConnectionStr = @"Data Source=path\to\Leviosa.db"; //Adjust  in the connection string to the actual path of your SQLite database file

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(dbConnectionStr);
        }
    }
}
