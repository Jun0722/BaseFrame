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

        [HttpPost]
        public async Task<IActionResult> Add(NoteViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _noteRepository.AddAsync(new Note
            {
                Title = viewModel.Title,
                Content = viewModel.Content,
                Create = DateTime.Now,
                TypeId=3
            });
            return RedirectToAction("Index");
        }
    }
}
