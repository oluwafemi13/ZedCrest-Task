using System.ComponentModel.DataAnnotations.Schema;
using Zedcrest_Task.Models;

namespace Zedcrest_Task.DTO
{
    public class WalletDTO
    {
        public int Id { get; set; }
        //public int? BankId { get; set; }
       
        public double Balance { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Currency Currency { get; set; }
        public bool Status { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }
    }
}
