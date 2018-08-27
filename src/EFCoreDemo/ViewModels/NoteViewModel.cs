using System;
using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo.ViewModels
{
    public class NoteViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "标题")]
        public string Title { get; set; } = "Today1";
        [Required]
        [Display(Name = "内容")]
        public string Content { get; set; } = "Content1";
    }
}
