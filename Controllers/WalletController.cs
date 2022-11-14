using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Zedcrest_Task.DTO;
using Zedcrest_Task.Repository.Interface;

namespace Zedcrest_Task.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class WalletController: ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILogger<WalletController> _logger;
        private readonly IWalletRepository _walletRepository;
       

        public WalletController(IMapper mapper,
                                 ILogger<WalletController> logger,
                                 IWalletRepository walletRepository
                                )
        {
            _mapper = mapper;
            _logger = logger;
           
            _walletRepository = walletRepository;
           

        }
        [HttpPost]
        [Route("CreateWallet")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> createWallet([FromBody] WalletDTO walletDTO)
        {
            var result = await _walletRepository.createWallet(walletDTO);
            return Ok(result);


        }

       
}
}
