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
    public class UserController : ControllerBase
    {
        private readonly HealthAppDatabaseContext _context;

        public UserController(HealthAppDatabaseContext context)
        {
            this._context = context;
        }

        //[HttpPost]
        //public async Task<ActionResult<bool>> IsValidUser(string username, string password)
        //{
        //    var user = await _context.SystemUsers.Where(item => item.Username == username &&
        //                                          item.password == password).FirstOrDefaultAsync();
        //    return user != null ? true : false;
        //}

        [HttpPost]
        public async Task<ActionResult<bool>> RegisterUser(SystemUsers user)
        {
            this._context.SystemUsers.Add(user);
            return await this._context.SaveChangesAsync() != 0 ? true : false;
        }
    }
}