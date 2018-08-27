using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreDemo.IRepository;
using EFCoreDemo.Models;
using EFCoreDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFCoreDemo.Controllers
{
    public class NoteController : Controller
    {
        private INoteRepository _noteRepository;
        public NoteController(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public async Task<IActionResult> Index()
        {
            var notes = await _noteRepository.ListAsync();
            return View(notes);
        }

        //[HttpPost]
        public async Task<IActionResult> Add(NoteModel model)
        {

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var note = new Note
            {
                Title = model.Title,
                Content = model.Content,
                Create = DateTime.Now
            };
            await _noteRepository.AddAsync(note);

            return RedirectToAction("Index");
        }
    }
}
