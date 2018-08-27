using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo.Models
{
    /// <summary>
    /// 笔记
    /// </summary>
    public class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime? Create { get; set; }
        public int TypeId { get; set; }
        public virtual NoteType Type { get; set; }
    }
}
