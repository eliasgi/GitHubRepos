using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelephoneDirectory.Models
{
    [Table("PhoneDirectory")]
    public class PhoneDirectoryModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Title { get; set; }
        [Display(Name = "Direct Telephone")]
        public string DirectTelephone { get; set; }
        [Display(Name = "Mobile No")]
        public string MobileNo { get; set; }
        [Display(Name = "Extenstion No")]
        public string ExtentionNo { get; set; }
        public virtual int BranchID { get; set; }

    }
}