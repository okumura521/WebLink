using System.ComponentModel.DataAnnotations;

namespace WebLink.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
    }
}
