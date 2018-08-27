using System;
using EFCoreDemo.Data;
using EFCoreDemo.IRepository;
using EFCoreDemo.Models;

namespace EFCoreDemo.Repository
{
    public class NoteRepository:BaseRepository<Note>,INoteRepository
    {
        public NoteRepository(NoteContext context):base(context)
        {
            
        }
    }
}
