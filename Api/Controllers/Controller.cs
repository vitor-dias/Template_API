using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        private readonly IRepositoryService _clubService;

        public ClubController(IRepositoryService clubService) =>
            _clubService = clubService;

        [HttpGet]
        public async Task<IActionResult> RecoverAll()
        {
            var clubs = await _clubService.RecoverAll();
            
            return Ok(clubs);
        }

        [HttpPost]
        public async Task<IActionResult> Register(Repository club)
        {
            var id = await _clubService.Register(club);

            return Ok(id);
        }
    }
}
