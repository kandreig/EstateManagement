using System;
using System.Collections.Generic;

namespace EstateManagement.Models
{
    public class Estate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int OwnerId { get; set; }
        public double Price { get; set; }
        public int Type { get; set; }
        public DateTime CreateDate { get; set; }
        public List<Picture> Pictures { get; set; }
        public Estate()
        {
            Pictures = new List<Picture>();
        }

        public override string ToString()
        {
            return $"Estate id {Id}, name {Name}, ownerId {OwnerId}, number of pics: {Pictures.Count}";
        }
    }

}
