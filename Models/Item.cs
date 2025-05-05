using System.ComponentModel.DataAnnotations;

namespace WebLink.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Display(Name = "商品名")] 
        public string Name { get; set; }
        [Display(Name = "個数")] 
        public string Number { get; set; }
        [Display(Name = "記載日")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        [Display(Name = "購入状態")] 
        public bool isPurchased { get; set; } = false; // 初期値は購入前（false）
    }
}
