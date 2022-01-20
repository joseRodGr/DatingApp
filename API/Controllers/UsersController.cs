using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [Authorize]
    public class UsersController: BaseApiController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]  //api/Users
        public async Task<ActionResult<IEnumerable<AppUser>>> getUsers(){

            return Ok(await _context.Users.ToListAsync());
            
        }

        [HttpGet("{id}")] //api/Users/id
        public async Task<ActionResult<AppUser>> getUser(int id){

            var user = await _context.Users.FindAsync(id);

            if (user ==null){
                return NotFound("User doesn't exist");
            }

            return Ok(user);

        }
    }
}