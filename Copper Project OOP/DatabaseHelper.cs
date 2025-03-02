using System;
using System.Data;
using System.Data.SQLite;

namespace Copper_Project_OOP
{
    public static class DatabaseHelper
    {
        private static string connectionString = @"Data Source=C:\Users\Keynoosh\source\repos\Copper Project OOP\Copper Project OOP\CopperDb.db;Version=3;Pooling=True;Max Pool Size=100;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }



        public static void InitializeDatabase()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS ProcessDurations (
                ProcessName TEXT PRIMARY KEY,
                Duration INTEGER
            );";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                string createPurityRecordsTable = @"
        CREATE TABLE IF NOT EXISTS Copper (
            Identifier INTEGER UNIQUE,
            PurityPercentage REAL
        );";

                using (var command = new SQLiteCommand(createPurityRecordsTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                string createStoneTableQuery = @"
        CREATE TABLE IF NOT EXISTS Stones (
            Weight INTEGER NOT NULL,
            Size REAL NOT NULL,
            State TEXT NOT NULL
        );";
                using (var command = new SQLiteCommand(createStoneTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                string createCustomerTableQuery = @"
        CREATE TABLE IF NOT EXISTS Costumers (
            Name TEXT PRIMARY KEY,
            Password TEXT,
            OrderAmount INTEGER
        );";
                using (var command = new SQLiteCommand(createStoneTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                string createUsersTableQuery = @"
        CREATE TABLE IF NOT EXISTS Users (
            Username TEXT PRIMARY KEY,
            Password TEXT,
            User_Role TEXT
        );";

                using (var command = new SQLiteCommand(createUsersTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }


                string insertSampleDataQuery = @"
        INSERT OR IGNORE INTO Users (Username, Password, User_Role)
        VALUES
            ('سیما مجتبوی', 'password', 'StoreKeeper'),
            ('علی آشنا', 'password', 'ProductManager'),
            ('زامیاد ذاکری', 'password', 'SalesManager'),
            ('بابک معین', 'password', 'ProductOperator'),
            ('مهران رحمانیان', 'password', 'QualityChecker');";

                using (var command = new SQLiteCommand(insertSampleDataQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

            }
        }


        private static readonly object dbLock = new object();

        public static void InsertOrUpdateProcess(string processName, int duration)
        {
            lock (dbLock)
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string query = @"
                        INSERT INTO ProcessDurations (ProcessName, Duration)
                        VALUES (@ProcessName, @Duration)
                        ON CONFLICT(ProcessName) DO UPDATE SET
                        Duration = Duration + @Duration;";
                            using (var command = new SQLiteCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ProcessName", processName);
                                command.Parameters.AddWithValue("@Duration", duration);
                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
        }


        public static int GetProcessDuration(string processName)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Duration FROM ProcessDurations WHERE ProcessName = @ProcessName;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProcessName", processName);
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public static DataTable GetProcessDurations()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT ProcessName, Duration FROM ProcessDurations;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable); 
                        return dataTable;
                    }
                }
            }
        }


        public static void InsertCopper(int identifier, double purityPercentage)
        {
            using (var connection = GetConnection())
            {
                 connection.Open();
                 string query = @"
            INSERT INTO Copper (Identifier, PurityPercentage)
            VALUES (@Identifier, @PurityPercentage);";

                 using (var command = new SQLiteCommand(query, connection))
                 {
                     command.Parameters.AddWithValue("@Identifier", identifier);
                     command.Parameters.AddWithValue("@PurityPercentage", purityPercentage);
                     command.ExecuteNonQuery();
                 }
            }      
        }


        public static bool d(string username, string password,string User_role)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = @"
                    select 1 from Users
                        where user_role = '@UserRole'
                        and username = '@UserName' 
                        and password = '@PassWord'  ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserRole", User_role.ToLower());
                    command.Parameters.AddWithValue("@UserName", username.ToLower());
                    command.Parameters.AddWithValue("@PassWord", password.ToLower());

                    var result = command.ExecuteScalar();
                    return result != null;
                }
        }
            }


        public static void InsertCustomer(string name, string password, int orderAmount)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string insertQuery = @"
        INSERT INTO Customers (Name, Password, OrderAmount)
        VALUES (@Name, @Password, @OrderAmount);";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Password", password);  
                    command.Parameters.AddWithValue("@OrderAmount", orderAmount);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool AuthenticateCustomer(string name, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Password FROM Customers WHERE Name = @Name;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    var result = command.ExecuteScalar();
                    return result != null && result.ToString() == password;  
                }
            }
        }


        public static DataTable GetAllCoppers()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Identifier, PurityPercentage FROM Copper;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }


        public static DataTable GetAllStones()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Weight, Size, State FROM Stones;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }


        public static DataTable GetAllOrders()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Name, OrderAmount FROM Customers;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }



        public static void EnableWALMode()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SQLiteCommand("PRAGMA journal_mode=WAL;", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
