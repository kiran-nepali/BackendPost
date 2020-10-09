using Microsoft.AspNetCore.Mvc;
using Post.Data;

namespace Post.Controllers{
    
    [Route("api/[controller]")]
    public class UserController:Controller{

        private UserService _userService;
        
        public UserController(UserService userService){
            this._userService = userService;
        }

        [HttpGet("[action]")]
        public IActionResult GetUsers(){
            var allUsers = _userService.GetAllUsers;
            return Ok(allUsers);
        }

        [HttpGet("SingleUser/{id}")]
        public IActionResult GetUserById(int id){
            var user = _userService.GetUserById(id);
            return Ok(user);
        }
        
    }
}