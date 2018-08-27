using System;
using System.Collections.Generic;
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

        //public Tuple<List<Note>, int> PageList(int pageIndex, int pageSize)
        //{
        //    var query = _context.Set<Note>().Include(type => type.Type).AsQueryable();

        //}
    }
}
