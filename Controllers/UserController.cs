//using Blog.Data;
//using Blog.Models;
//using Blog.ViewModels;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace Blog.Controllers
//{
//    public class UserController
//    {
//        [HttpGet("v1/user")]
//        public async Task<IActionResult> GetAsync(
//            [FromServices]BlogDataContext context)
//        {
//            try
//            {
//                var users = await context.Users.ToListAsync();
//                return Ok(new ResultViewModel<List<User>>(users));
//            }
//            catch
//            {
//                return StatusCode(500, new ResultViewModel<List<Category>>("05X04 - Falha interna no servidor"));
//            }
//        }
//    }
//}
