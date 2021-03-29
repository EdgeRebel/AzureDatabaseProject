using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureDatabaseProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AzureDatabaseProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private ShowContext _context;

        public MovieController(ShowContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Movie>> Get()
        {
            var result = await _context.Movies.ToListAsync();
            return result;
        }
    }
}