using EstateManagement.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace EstateManagement.Repository.SqlRepository
{
    internal class EstateRepository : IRepository<Estate>
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public void Create(Estate value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                string queryString = "insert into tEstates(name,address,price,type,createDate,idOwner)" +
                                  " values(@name,@address,@price,@type,@createDate,@idOwner)";

                using (SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@name", value.Name);
                    sqlCommand.Parameters.AddWithValue("@address", value.Address);
                    sqlCommand.Parameters.AddWithValue("@price", value.Price);
                    sqlCommand.Parameters.AddWithValue("@type", value.Type);
                    sqlCommand.Parameters.AddWithValue("@createDate", value.CreateDate);
                    sqlCommand.Parameters.AddWithValue("@idOwner", value.OwnerId);

                    

                    var rowsAffected = sqlCommand.ExecuteNonQuery();

                }

            }
        }

        public void Delete(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                string queryString = "delete from tEstates" +
                                     " where idEstate = @id";

                using (SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", id);

                    var rowsAffected = sqlCommand.ExecuteNonQuery();

                }

                


            }
        }

       

        public List<Estate> GetAll()
        {
            var estates = new List<Estate>();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                string queryString = "select * from tEstates";

                using (SqlCommand reader = new SqlCommand(queryString, sqlConnection))
                {
                    var queryResult = reader.ExecuteReader();
                    //if (queryResult.HasRows == false) throw new Exception("There is no data");

                    while (queryResult.Read())
                    {
                        estates.Add(GetEstateFrom(queryResult));
                    }

                }
            }

            return estates;
        }

        public Estate GetById(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                string queryString = "select * from tEstates" +
                                     " where idEstate = @id";



                using (SqlCommand reader = new SqlCommand(queryString, sqlConnection))
                {
                    reader.Parameters.AddWithValue("@id", id);

                    var queryResult = reader.ExecuteReader();
                    //if (queryResult.HasRows == false) throw new Exception("There is no data");

                    queryResult.Read();
                    return GetEstateFrom(queryResult);
                }
            }
        }

        private Estate GetEstateFrom(SqlDataReader row)
        {
            var pictureRepo = new PictureRepository();
            var estate = new Estate();

            estate.Id = (int)row["idEstate"];
            estate.Name = (string)row["name"];
            estate.Address = (string)row["address"];
            estate.Price = Convert.ToDouble(row["price"]);
            estate.Type = Convert.ToInt32(row["type"]);
            estate.CreateDate = (DateTime)row["createDate"];
            estate.OwnerId = (int)row["idOwner"];

            estate.Pictures = pictureRepo.GetPicturesForEstate(estate.Id);


            return estate;
        }

        internal List<Estate> GetEstatesForOwner(int idOwner)
        {
            var estates = new List<Estate>();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                string queryString = "select * from tEstates" +
                                    " where idOwner = @idOwner";

                using (SqlCommand reader = new SqlCommand(queryString, sqlConnection))
                {
                    reader.Parameters.AddWithValue("@idOwner", idOwner);

                    var queryResult = reader.ExecuteReader();
                    //if (queryResult.HasRows == false) throw new Exception("There is no data");

                    while (queryResult.Read())
                    {
                        estates.Add(GetEstateFrom(queryResult));
                    }
                }
            }

            return estates;
        }

        

        public void Update(Estate value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {

                sqlConnection.Open();

                string queryString = "update tEstates" +
                                     " set name = @name, address = @address, price = @price, type = @type, createDate = @createDate, idOwner = @idOwner" +
                                     " where idEstate = @id";

                using (SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", value.Id);
                    sqlCommand.Parameters.AddWithValue("@name", value.Name);
                    sqlCommand.Parameters.AddWithValue("@address", value.Address);
                    sqlCommand.Parameters.AddWithValue("@price", value.Price);
                    sqlCommand.Parameters.AddWithValue("@type", value.Type);
                    sqlCommand.Parameters.AddWithValue("@createDate", value.CreateDate);
                    sqlCommand.Parameters.AddWithValue("@idOwner", value.OwnerId);


                    var rowsAffected = sqlCommand.ExecuteNonQuery();
                }

            }
        }
    }
}
