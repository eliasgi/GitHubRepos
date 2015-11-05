using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TelephoneDirectory.Models
{


    [Table("Branch")]
    public class BranchModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int BranchId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
    }
}