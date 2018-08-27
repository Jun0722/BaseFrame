using System;
using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo.ViewModels
{
    public class NoteModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "标题")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "内容")]
        public string Content { get; set; }
        [Required]
        public int TypeId { get; set; } = 2;
    }
}
