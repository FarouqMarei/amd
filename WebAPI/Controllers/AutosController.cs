using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using WebAPI.DTOs;
using WebAPI.Interfaces;
using WebAPI.Models;
using WebAPI.Utilities;
using static WebAPI.Utilities.Enum;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutosController : Controller
    {
        public readonly IAutoService _repo;
        public AutosController(IAutoService repo)
        {
            _repo = repo;
        }

        [HttpGet("GetAllByUser/{id}")]
        public async Task<ActionResult<ResponseResult<List<Auto>>>> GetAllByUser(int id)
        {
            return await _repo.GetAllByUser(id);
        }
    }
}
