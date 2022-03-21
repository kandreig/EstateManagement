using EstateManagement.Models;
using EstateManagement.Repository;
using System;
using System.Configuration;

namespace EstateManagement.Repository
{
    public class RepositoryFactory
    {
        public static IRepository<Estate> CreateEstateRepository()
        {
            //var RepoType = Convert.ToInt32(ConfigurationManager.AppSettings["repositoryType"]);

            //switch (RepoType)
            //{
            //    case (int)RepositoryType.Sql: return new SqlRepository.EstateRepository();
            //    case (int)RepositoryType.Json: return new JsonRepository.EstateRepository();
            //}
            return new SqlRepository.EstateRepository();
        }
        public static IRepository<Owner> CreateOwnerRepository()
        {
            return new SqlRepository.OwnerRepository();
        }
        public static IRepository<Picture> CreatePictureRepository()
        {
            return new SqlRepository.PictureRepository();
        }
    }
}
