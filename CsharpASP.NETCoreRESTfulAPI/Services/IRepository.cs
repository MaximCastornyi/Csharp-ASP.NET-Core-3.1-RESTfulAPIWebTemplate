using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsharpASP.NETCoreRESTfulAPI.Entities;
using CsharpASP.NETCoreRESTfulAPI.Services;

namespace CsharpASP.NETCoreRESTfulAPI.Services
{
    public interface IRepository
    {
        void AddGenre(Genre genre);
        Task<List<Genre>> GetAllGenres();
        Genre GetGenreById(int Id);
    }
}
