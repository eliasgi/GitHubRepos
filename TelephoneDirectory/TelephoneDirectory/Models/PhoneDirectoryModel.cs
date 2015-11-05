using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelephoneDirectory.Models
{
    [Table("PhoneDirectory")]
    public class PhoneDirectoryModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string DirectTelephone { get; set; }
        public string MobileNo { get; set; }
        public string ExtentionNo { get; set; }
        
    }
}