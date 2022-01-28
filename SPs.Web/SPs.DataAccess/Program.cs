using SPs.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPs.DataAccess
{
    internal class Program
    {
        const string mysqlConnectionString = "server=localhost;port=3306;database=db_gymmanager;user=root;password=root;CharSet=utf8;Sslmode=none;Pooling=false;AllowPublicKeyRetrieval=True";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GetMembersOfThisWeek();

            GetInventoryById(3);

            CreateNewSale(1,3);
        }

        private static List<Member> GetMembersOfThisWeek()
        {
            List<Member> members = new List<Member>();

            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);

            connection.Open();

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("MembersOfThisWeek", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Member member = new Member
                    {
                        IdMembers = (int)reader["idmembers"],
                        RegisterDate = (DateTime)reader["registerdate"],
                        Type = reader["type"] as string,
                    };

                    members.Add(member);
                }
            }
            finally
            {
                connection.Close();
            }

            return members;
        }

        private static Inventory GetInventoryById(int productTypeId)
        {
            Inventory inventory = null;

            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);

            connection.Open();

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("CheckInventory", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_idproductstype", productTypeId);

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    inventory = new Inventory
                    {
                        Product = reader["product"] as string,
                        Amount = (int)reader["amount"]
                    };
                }
            }
            finally
            {
                connection.Close();
            }

            return inventory;
        }

        private static Sale CreateNewSale(int idproductstype, int idusers)
        {
            Sale result = null;

            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);

            connection.Open();

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("CreateNewSale", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_idproductstype", idproductstype);
                command.Parameters.AddWithValue("_idusers", idusers);


                command.ExecuteNonQuery();

                result = new Sale
                {
                    IdProductsType = idproductstype,
                    IdUsers = idusers
                };
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}
