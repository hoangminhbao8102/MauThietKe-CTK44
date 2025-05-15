// Template Method pattern -- Real World example

using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DoFactory.GangOfFour.Template.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World
    /// Template Design Pattern.
    /// </summary
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    abstract class DataAccessObject
    {
        protected string connectionString = string.Empty;
        protected DataSet dataSet = new DataSet();

        public virtual void Connect()
        {
            // Set up connection string to connect to SQL Server database
            connectionString = "Data Source=LAPTOP-N4TOHTRH\\SQLEXPRESS;Initial Catalog=Template_RealWorld;User ID=sa;Password=minhbao8102;TrustServerCertificate=True;";
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            connectionString = "";
        }

        // The 'Template Method'
        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    class Categories : DataAccessObject
    {
        public override void Select()
        {
            string sql = "SELECT CategoryName FROM Categories";
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            dataSet = new DataSet();
            adapter.Fill(dataSet, "Categories");
        }

        public override void Process()
        {
            Console.WriteLine("Categories ---- ");

            DataTable? dataTable = dataSet.Tables["Categories"];
            if (dataTable == null)
            {
                Console.WriteLine("No data available for 'Categories'.");
                return;
            }

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["CategoryName"]);
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    class Products : DataAccessObject
    {
        public override void Select()
        {
            string sql = "SELECT ProductName FROM Products;";
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            dataSet = new DataSet();
            adapter.Fill(dataSet, "Products");
        }

        public override void Process()
        {
            Console.WriteLine("Products ---- ");
            DataTable? dataTable = dataSet.Tables["Products"];
            if (dataTable == null)
            {
                Console.WriteLine("No data available for 'Products'.");
                return;
            }

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["ProductName"]);
            }
            Console.WriteLine();
        }
    }
}