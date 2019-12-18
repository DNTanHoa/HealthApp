using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthAppAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HealthAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly HealthAppDatabaseContext _context;

        public HospitalController(HealthAppDatabaseContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Hospitals>>> GetAlls()
        {
            return await _context.Hospitals.ToListAsync();
        }

    }
}