using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zedcrest_Task.Models
{
    public class Wallet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //public int? BankId { get; set; }
        public string UserId { get; set; }
        public decimal Balance { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public Currency currency { get; set; }
        public bool Status { get; set; }
       // public ICollection<UserTransaction> Transactions { get; set; }
        /*[ForeignKey("BankId")]

        public virtual Bank Bank { get; set; }
        public string RecipientCode { get; set; }
        public string TransferCode { get; set; }*/
    }
}
