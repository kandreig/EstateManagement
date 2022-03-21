using EstateManagement.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.SqlClient;
using System.IO;

namespace EstateManagement.Repository.SqlRepository
{
    internal class PictureRepository : IRepository<Picture>
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public void Create(Picture value)
        {

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                string queryString = "insert into tPictures(name, createDate, size, idEstate)" +
                                  " values(@name, @createDate, @size, @idEstate)";

                using (SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@name", value.Name);
                    sqlCommand.Parameters.AddWithValue("@createDate", value.CreateDate);
                    sqlCommand.Parameters.AddWithValue("@size", value.Size);
                    sqlCommand.Parameters.AddWithValue("@idEstate", value.EstateId);

                    var rowsAffected = sqlCommand.ExecuteNonQuery();

                }
            }
        }


        


        public void Delete(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                string queryString = "delete from tPictures" +
                                     " where idPicture = @id";

                using (SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", id);

                    var rowsAffected = sqlCommand.ExecuteNonQuery();

                }

            }
        }

        public List<Picture> GetAll()
        {
            var pictures = new List<Picture>();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                string queryString = "select * from tPictures";

                using (SqlCommand reader = new SqlCommand(queryString, sqlConnection))
                {
                    var queryResult = reader.ExecuteReader();
                    if (queryResult.HasRows == false) throw new Exception("There is no data");

                    while (queryResult.Read())
                    {
                        pictures.Add(GetPictureFrom(queryResult));
                    }

                }
            }

            return pictures;
        }

        public Picture GetById(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                string queryString = "select * from tPictures" +
                                     " where idPicture = @id";



                using (SqlCommand reader = new SqlCommand(queryString, sqlConnection))
                {
                    reader.Parameters.AddWithValue("@id", id);

                    var queryResult = reader.ExecuteReader();
                    if (queryResult.HasRows == false) throw new Exception("There is no data");

                    queryResult.Read();
                    return GetPictureFrom(queryResult);
                }
            }
        }


        private Picture GetPictureFrom(SqlDataReader row)
        {
            var picture = new Picture();

            picture.Id = (int)row["idPicture"];
            picture.Name = (string)row["name"];
            picture.CreateDate = (DateTime)row["createDate"];
            picture.Size = (long)row["size"];
            picture.EstateId = (int)row["idEstate"];


            return picture;
        }


        internal List<Picture> GetPicturesForEstate(int idEstate)
        {
            var pictures = new List<Picture>();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                string queryString = "select * from tPictures" +
                                    " where idEstate = @idEstate";

                using (SqlCommand reader = new SqlCommand(queryString, sqlConnection))
                {
                    reader.Parameters.AddWithValue("@idEstate", idEstate);

                    var queryResult = reader.ExecuteReader();
                   // if (queryResult.HasRows == false) throw new Exception("There is no data");

                    while (queryResult.Read())
                    {
                        pictures.Add(GetPictureFrom(queryResult));
                    }
                }
            }

            return pictures;
        }

       
        public void Update(Picture value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {

                sqlConnection.Open();

                string queryString = "update tPictures" +
                                     " set name = @name, size = @size, idEstate = @idEstate" +
                                     " where idPicture = @id";

                using (SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@name", value.Name);
                    sqlCommand.Parameters.AddWithValue("@size", value.Size);
                    sqlCommand.Parameters.AddWithValue("@idEstate", value.EstateId);


                    var rowsAffected = sqlCommand.ExecuteNonQuery();
                }

            }
        }
    }
}
