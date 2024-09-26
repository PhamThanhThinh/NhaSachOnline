using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaSachOnline.Models
{
  [Table("Genre")]
  public class Genre
  {
    public int Id { get; set; }
    //Required chỉ ra rằng thuộc tính không được để trống
    // NULL khác rỗng
    [Required]
    [MaxLength(50)]
    public string GenreName { get; set; }
    public List<Book> Books { get; set; }
  }
}
