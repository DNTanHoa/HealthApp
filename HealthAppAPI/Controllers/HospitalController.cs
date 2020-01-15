using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthAppAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

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

        [HttpGet]
        public async Task<ActionResult<Hospitals>> GetByOid(JObject param)
        {
            var Oid = param["Oid"].ToString();
            return await _context.Hospitals.Where(item => item.Oid.Equals(Oid)).FirstOrDefaultAsync();
        }
    }
}