using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Zedcrest_Task.DTO;
using Zedcrest_Task.Models;
using Zedcrest_Task.Repository.Interface;

namespace Zedcrest_Task.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AccountController:ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILogger<AccountController> _logger;
        private readonly IUserRepository _userRepository;
        private readonly SignInManager<User> _signinManager;
        private readonly UserManager<User> _userManager;

        public AccountController(IMapper mapper,
                                 ILogger<AccountController> logger,
                                 IUserRepository userRepository,
                                 SignInManager<User> signInManager,
                                 UserManager<User> userManager)
        {
            _mapper = mapper;
            _logger = logger;
            _userRepository = userRepository;
            _userManager = userManager;
            _signinManager = signInManager; 

        }
        [HttpPost]
        [Route("Register")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDTO userRegistrationDTO)
        {
            _logger.LogInformation($"Registration Attempt From {userRegistrationDTO.Email}");
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            try
            {
                var user = _mapper.Map<User>(userRegistrationDTO);
                var result = await _userManager.CreateAsync(user);
                if (user == null)
                {
                    throw new InvalidOperationException();
                    _logger.LogError($"Empty Details {userRegistrationDTO}");
                    return NotFound("user Information Empty");

                }
                if (!result.Succeeded)
                {
                    return BadRequest("User Registration Failure");
                }
                return Accepted();

            }catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }

        }
        
        [HttpGet]
        [Route("Login")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Login([FromBody] UserLoginDTO userLoginDTO)
        {
            _logger.LogInformation($"Login Attempt From {userLoginDTO.Email}");
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            try
            {
                var user = _mapper.Map<User>(userLoginDTO);
                var result = await _signinManager.PasswordSignInAsync(userLoginDTO.Email, userLoginDTO.Password, false, false);
                if (user == null)
                {
                    throw new ArgumentNullException(nameof(userLoginDTO));
                    _logger.LogError($"Empty Details {userLoginDTO}");
                    return NotFound("user Information Empty");

                }
                if (!result.Succeeded)
                {
                    return Unauthorized(userLoginDTO);
                }
                return Accepted();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();

            }

        }
    }
}
