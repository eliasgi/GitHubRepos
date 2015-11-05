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
        [Required]
        [Display(Name ="Branch Code")]
        public string BranchCode { get; set; }
        [Required]
        [Display(Name = "Branch Name")]
        public string BranchName { get; set; }
    }
}