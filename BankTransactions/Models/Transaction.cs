using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Required(ErrorMessage ="This field is required")]
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [MaxLength(12, ErrorMessage ="Maximum 12 characters only")]
        public string AccountNumber { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        public string BeneficiaryName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        public string BankName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only")]
        public string SWIFTCode { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString ="{0:MM-dd-yy}")]
        public DateTime Date { get; set; }
    }
}
