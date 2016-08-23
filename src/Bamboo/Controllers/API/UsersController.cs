using Bamboo.Models;
using Bamboo.ViewModels;
using Bamboo.ViewModels.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Bamboo.Controllers.API
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private BambooContext dbContext;
        public UsersController(BambooContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost, Route("")]
        public async Task<IActionResult> CreateUserAction([FromBody] CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Sanitize data before saving
                    var user = new User
                    {
                        Id = Guid.NewGuid(),
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        PasswordHash = model.Password // TODO: hash password
                    };

                    this.dbContext.Users.Add(user);

                    await this.dbContext.SaveChangesAsync();

                    return Ok(user.ToViewModel());
                }
                catch (Exception ex)
                {
                    // Do not use ex.Message in production
                    return BadRequest(new ErrorViewModel { Error = Error.InternalError, ErrorDescription = ex.InnerException.Message });
                }
            }
            else
            {
                return BadRequest(new ErrorViewModel { Error = Error.ModelError, ErrorDescription = ModelState.GetFirstError() });
            }
        }
    }
}
