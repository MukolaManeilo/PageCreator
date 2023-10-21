using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PageCreator.Models
{
    public class Pages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("title")]
        public string Title { get; set; }

        [Required]
        [Column("access")]
        public string Access { get; set; }

        [Required]
        [Column("created_by")]
        public int CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public Users Users { get; set; }

        [Required]
        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Required]
        [Column("content")]
        public string Content { get; set; }
    }
}