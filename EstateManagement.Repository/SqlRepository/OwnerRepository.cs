using EstateManagement.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateManagement.Repository.SqlRepository
{
    internal class OwnerRepository : IRepository<Owner>
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;




        public void Create(Owner value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = "insert into tOwners(name,email,phone,cnp)" +
                                  " values(@name,@email,@phone,@cnp)";
                using(SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@name",value.Name);
                    sqlCommand.Parameters.AddWithValue("@email",value.Email);
                    sqlCommand.Parameters.AddWithValue("@phone",value.Phone);
                    sqlCommand.Parameters.AddWithValue("@cnp",value.CNP);
                    
                    sqlConnection.Open();
                    
                    var rowsAffected = sqlCommand.ExecuteNonQuery();

                }
                
            }

        }

        public void Delete(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = "delete from tOwners" +
                                     " where idOwner = @id";

                using (SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", id);

                    sqlConnection.Open();

                    var rowsAffected = sqlCommand.ExecuteNonQuery();

                }

            }
        }

        public List<Owner> GetAll()
        {
            var owners = new List<Owner>();

            using(SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                string queryString = "select * from tOwners";

                using (SqlCommand reader = new SqlCommand(queryString, sqlConnection))
                {
                    var queryResult = reader.ExecuteReader();
                   // if (queryResult.HasRows == false) throw new Exception("There is no data");

                    while (queryResult.Read())
                    {
                        owners.Add(GetOwnerFrom(queryResult));
                    }

                }
            }

            return owners;
        }

        public Owner GetById(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                string queryString = "select * from tOwners" +
                                     " where idOwner = @id";

                

                using (SqlCommand reader = new SqlCommand(queryString, sqlConnection))
                {
                    reader.Parameters.AddWithValue("@id", id);

                    var queryResult = reader.ExecuteReader();
                    if (queryResult.HasRows == false) throw new Exception("There is no data");
                    
                    queryResult.Read();
                    return GetOwnerFrom(queryResult);
                }
            }
        }

        private Owner GetOwnerFrom(SqlDataReader row)
        {

            var estateRepo = new EstateRepository();

            var owner = new Owner();

            owner.Id = (int)row["idOwner"];
            owner.Name = (string)row["name"];
            owner.Email = (string)row["email"];
            owner.Phone = (string)row["phone"];
            owner.CNP = (string)row["cnp"];

            List<Estate> rowEstates = estateRepo.GetEstatesForOwner(owner.Id);

            owner.Estates = rowEstates;


            //if(!owner.Estates.Any())
            //{
            //    throw new Exception("list null");
            //}

            return owner;
        }


        public void Update(Owner value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = "update tOwners" +
                                     " set name = @name, email = @email, phone = @phone, cnp = @cnp" +
                                     " where idOwner = @id";

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", value.Id);
                    sqlCommand.Parameters.AddWithValue("@name", value.Name);
                    sqlCommand.Parameters.AddWithValue("@email", value.Email);
                    sqlCommand.Parameters.AddWithValue("@phone", value.Phone);
                    sqlCommand.Parameters.AddWithValue("@cnp", value.CNP);

                    
                    var rowsAffected = sqlCommand.ExecuteNonQuery();
                }

            }
        }
        

        

    }
}
