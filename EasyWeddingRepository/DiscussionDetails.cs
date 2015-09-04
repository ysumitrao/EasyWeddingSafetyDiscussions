using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EasyWeddingRepository
{
    public class DiscussionDetails
    {
        [Key]        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DiscussionId { get; set; }

        [Required]
        [StringLength(50)]
        public string Observer { get; set; }

        [Required]
        public DateTime DateOfDiscussion { get; set; }

        public string FormattedDateOfDiscussion
        {
            get
            {
                return string.Format("{0:dd/MM/yyyy}", DateOfDiscussion);
            }
        }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        [Required]
        [StringLength(50)]
        public string ColleagueName { get; set; }

        [Required]
        [StringLength(100)]
        public string SubjectOfDiscussion { get; set; }

        [Required]
        [StringLength(1000)]
        public string Outcome { get; set; }
    }
}