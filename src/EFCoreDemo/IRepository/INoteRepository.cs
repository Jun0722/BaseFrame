using System;
using System.Collections.Generic;
using EFCoreDemo.Models;

namespace EFCoreDemo.IRepository
{
    public interface INoteRepository:IBaseRepository<Note>
    {
        //Tuple<List<Note>, int> PageList(int pageIndex, int pageSize);
    }
}
