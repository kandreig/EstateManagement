using System;


namespace EstateManagement.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string Name { get; set; } // GUID
        public DateTime CreateDate { get; set; }
        public long Size { get; set; }
        public int EstateId { get; set; } // select name from tPictures where idEstate = @idEstate
    }                                      // File.PathCombine(name, PicturesFolderPath);
}                                          //toate pozele vor fi intr un folder si eu doar le caut dupa nume care este guid si unic