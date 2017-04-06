using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CSDHRProject.Models
{
    [Table("jobapplication")]
    public class TalentRecruitmentModels
    {
        [Key]
        public int jobId { get; set; }

        public string applicantId { get; set; }

        public string applicantName { get; set; }

        public string jobTitle { get; set; }
    }
}