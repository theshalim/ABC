using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ABC.Models
{
    public class BookCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="This fields required!"), Display(Name ="Book Category"), StringLength(100)]
        public string BookCategoryName { get; set; }

        [Required(ErrorMessage = "This fields required!"), Display(Name = "Stock Type"), StringLength(30)]
        public string StockType { get; set; }

        [Required(ErrorMessage = "This fields required!"), Display(Name = "Calender Year")]
        public string CalenderYear { get; set; }



    }
}
