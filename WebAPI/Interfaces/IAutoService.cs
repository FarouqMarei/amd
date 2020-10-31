using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTOs;
using WebAPI.Models;
using WebAPI.Utilities;

namespace WebAPI.Interfaces
{
    public interface IAutoService
    {
        Task<ResponseResult<List<Auto>>> GetAllByUser(int id);
    }
}
