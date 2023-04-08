using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace FPWinery
{
    public class Database
    {
        readonly SQLiteConnection Connection;

        readonly string path = "winery.db";
        readonly string cs = @"URI=file:" + Application.StartupPath + "\\winery.db";

        readonly string logFile = "log.txt";

        public Database()
        {
            Connection = new SQLiteConnection(cs);
        }
        public void InitDB()
        {
            if(!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using var sqlite = new SQLiteConnection("@Data Source=" + path);
                sqlite.Open();
                string sqlWineTable = "CREATE TABLE \"wine\" (\r\n\t\"wineID\"\tINTEGER NOT NULL,\r\n\t\"name\"\tTEXT,\r\n\t\"price\"\tNUMERIC,\r\n\t\"stock\"\tINTEGER," +
                    "\r\n\t\"supplier_name\"\tTEXT,\r\n\tPRIMARY KEY(\"wineID\" AUTOINCREMENT)\r\n);";
                string sqlSupplierTable = "CREATE TABLE \"supplier\" (\r\n\t\"supplierID\"\tINTEGER NOT NULL,\r\n\t\"supplier_name\"\tTEXT NOT NULL,\r\n\t\"Field3\"\tINTEGER,\r\n\t" +
                    "PRIMARY KEY(\"supplierID\" AUTOINCREMENT)\r\n);";

                SQLiteCommand cmd = new SQLiteCommand(sqlWineTable, sqlite);
                cmd.ExecuteNonQuery();
                cmd = new SQLiteCommand(sqlSupplierTable, sqlite);
                cmd.ExecuteNonQuery();

                using StreamWriter writer = new(logFile,true);
                writer.WriteLine("Database.cs: Database was created!");
                
            }
            else
            {
                using (StreamWriter writer = new(logFile,true))
                {
                    writer.WriteLine("Database.cs: Database file was already created");
                }

                Console.WriteLine("File exists");
                return;
            }
        }
        public bool AddWine(Wine wine)
        {
            Connection.Open();
            string query = "insert into wine(name,price,stock,supplier) values('"+wine.WineName+"',"+wine.Price+","+wine.Stock+",'"+wine.SupplierID+"');";
            SQLiteCommand cmd = new(query,Connection);
            Console.WriteLine(Connection.FileName);
            try
            {

                int result = cmd.ExecuteNonQuery();
                if(result > 0)
                {
                    Connection.Close();

                    using (StreamWriter writer = new(logFile,true))
                    {
                        writer.WriteLine("Database.cs: Wine was created");
                    }

                    return true;
                }

            }catch(Exception ex)
            {
                using (StreamWriter writer = new(logFile,true))
                {
                    writer.WriteLine("Database.cs: Wine was not added!, Error: " + ex.Message);
                }

                Console.WriteLine(ex.Message);
            }
            Connection.Close();
            return false;

        }
        public bool AddSupplier(Supplier supplier)
        {
            Connection.Open();

            string query = "insert into supplier(name,location,email) values('" + supplier.SuppName+ "','"+
                supplier.Location+ "','"+supplier.Email+"');";

            SQLiteCommand cmd = new(query, Connection);
            try
            {

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    using (StreamWriter writer = new(logFile,true))
                    {
                        writer.WriteLine("Database.cs: Supplier added!");
                    }
                    Connection.Close();
                    return true;
                }

            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new(logFile,true))
                {
                    writer.WriteLine("Database.cs: Supplier was not added!, Error: " + ex.Message);
                }
                Console.WriteLine(ex.Message);
            }
            Connection.Close();
            return false;
        }
        public List<Wine> GetWine()
        {
            List<Wine> Wines = new();

            Connection.Open();

            string query = "select wineID,wine.name,wine.price,wine.stock,supplier.name as supname from wine, supplier where wine.supplier = supplier.supplierID";

            SQLiteCommand cmd = new(query, Connection);

            SQLiteDataAdapter da = new(cmd);

            try
            {
                DataTable dt = new();

                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    using (StreamWriter writer = new(logFile,true))
                    {
                        writer.WriteLine("Database.cs: Found all Wine Data!");
                    }

                    foreach (DataRow dr in dt.Rows)
                    {
                        Wines.Add(new Wine(Convert.ToInt32(dr["wineID"]), dr["name"].ToString(),
                            Convert.ToInt32(dr["stock"]), Convert.ToDouble(dr["price"]), Convert.ToString(dr["supname"])));
                    }
                }
                Connection.Close();
                return Wines;

            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new(logFile,true))
                {
                    writer.WriteLine("Database.cs: Could not retrieve Wine!, Error: " + ex.Message);
                }
                Console.WriteLine(ex.Message);
            }
            Connection.Close();
            return Wines;
        }
        public Supplier GetSupplierByName(string name)
        {
            Supplier supplier = new();

            try
            {
                Connection.Open();

                string query = "select * from supplier where name = '"+name+"';";
                SQLiteCommand cmd = new(query, Connection);
                SQLiteDataAdapter da = new(cmd);
                DataTable dt = new();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Connection.Close();

                    using (StreamWriter writer = new(logFile,true))
                    {
                        writer.WriteLine("Database.cs: Supplier was found!");
                    }

                    foreach (DataRow dr in dt.Rows)
                    {
                        return new Supplier(Convert.ToInt32(dr["supplierID"]), dr["name"].ToString(), dr["location"].ToString(), dr["email"].ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                using (StreamWriter writer = new(logFile,true))
                {
                    writer.WriteLine("Database.cs: Supplier was not found!, Error: " + ex.Message);
                }
                Console.WriteLine(ex.Message);
            }

            return supplier;
        }
        public List<Supplier> GetSuppliers()
        {
            List<Supplier> Suppliers = new();

            Connection.Open();

            string query = "select * from supplier;";

            SQLiteCommand cmd = new(query, Connection);

            SQLiteDataAdapter da = new(cmd);

            try
            {
                DataTable dt = new();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    using (StreamWriter writer = new(logFile,true))
                    {
                        writer.WriteLine("Database.cs: Found suppliers info!");
                    }
                    foreach (DataRow dr in dt.Rows)
                    {
                        Suppliers.Add(new Supplier(Convert.ToInt32(dr["supplierID"]), dr["name"].ToString(), dr["location"].ToString(), dr["email"].ToString()));
                    }
                }
                Connection.Close();
                return Suppliers;

            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new(logFile,true))
                {
                    writer.WriteLine("Database.cs: Suppliers were not found! Error: " + ex.Message);
                }
                Console.WriteLine(ex.Message);
            }
            Connection.Close();
            return Suppliers;
        }
    }
}
