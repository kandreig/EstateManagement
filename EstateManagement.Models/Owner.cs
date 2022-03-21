using System.Collections.Generic;


namespace EstateManagement.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CNP { get; set; }
        public List<Estate> Estates { get; set; }
        public Owner()
        {
            Estates = new List<Estate>();
        }
        public override string ToString()
        {
            return $"Owner id: {Id}, name : {Name}";
        }
    }
}