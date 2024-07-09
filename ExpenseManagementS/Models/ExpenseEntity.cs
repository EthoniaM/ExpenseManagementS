using System.ComponentModel.DataAnnotations;

namespace ExpenseManagementS.Models
{
    public class ExpenseEntity
    {
        [Key]
        public int ExpenseId { get; set; }
        [Required]
        public DateTime Expensedate { get; set; }
        [Required]
        public string GivenTo { get; set;}
        [Required]
        public double ExpenseAmount { get; set; }
    }
}
