using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PageCreator.Models
{
    public class Pages
    {

        public Pages(string Title, string Access, int CreatedBy, string Content)
        {
            this.Title = Title;
            this.Access = Access;
            this.CreatedBy = CreatedBy;
            CreatedAt = DateTime.UtcNow;
            this.Content = Content;
        }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("access")]
        public string Access { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public Users Users { get; set; }

        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column("content")]
        public string Content { get; set; }
    }
}