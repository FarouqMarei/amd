using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Interfaces;
using WebAPI.Models;
using WebAPI.Utilities;
using static WebAPI.Utilities.Enum;

namespace WebAPI.Services
{
    public class AutoService : IAutoService
    {
        public readonly AmdDBContext _dbContext;
        public AutoService(AmdDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ResponseResult<List<Auto>>> GetAllByUser(int id)
        {
            ResponseResult<List<Auto>> result = new ResponseResult<List<Auto>>();
            List<Auto> autos = _dbContext.Autos.Where(c => c.CreationUserId == id).ToList();
            List<LookupValue> lookupValues = _dbContext.LookupValues.ToList();

            List<Auto> models = autos.Select(c => new Auto
            {
                Id = c.Id,
                Description = c.Description,
                CarStatus = c.CarStatus,
                Type = c.Type,
                BrandId = c.BrandId,
                AuctionId = c.AuctionId,
                ArrivalDate = c.ArrivalDate,
                BuyDate = c.BuyDate,
                BuyingAccountId = c.BuyingAccountId,
                CityId = c.CityId,
                Color = c.Color,
                ContainerId = c.ContainerId,
                CreationDate = c.CreationDate,
                CreationUserId = c.CreationUserId,
                DestinationId = c.DestinationId,
                BuyerId = c.BuyerId,
                Engine = c.Engine,
                LoadPortId = c.LoadPortId,
                VinNo = c.VinNo,
                DisplayStatus = c.DisplayStatus,
                Lot = c.Lot,
                Model = c.Model,
                RemainingPayment = c.RemainingPayment,
                PaperStatus = c.PaperStatus,
                ModificationUserId = c.ModificationUserId,
                ModificationDate = c.ModificationDate,
                Name = c.Name,
                AuctionName = lookupValues.Where(l => l.Id == c.AuctionId).FirstOrDefault().Name,
                BrandName = lookupValues.Where(l => l.Id == c.BrandId).FirstOrDefault().Name,
                BuyerName = _dbContext.Users.Where(u => u.Id == c.BuyerId).FirstOrDefault().Name,
                CityName = lookupValues.Where(l => l.Id == c.CityId).FirstOrDefault().Name,
                DestinationName = lookupValues.Where(l => l.Id == c.DestinationId).FirstOrDefault().Name,
                LoadPortName = lookupValues.Where(l => l.Id == c.LoadPortId).FirstOrDefault().Name,
                ContainerSerial = _dbContext.Containers.Where(cn => cn.Id == c.ContainerId).FirstOrDefault().SerialNumber,
                DisplayStatusStr = System.Enum.GetName(typeof(DisplayStatus), c.DisplayStatus),
                PaperStatusStr = System.Enum.GetName(typeof(PaperStatus), c.PaperStatus),
                CarStatusStr = System.Enum.GetName(typeof(CarStatus), c.CarStatus)
            }).ToList();

            result.Data = models;
            result.Errors = null;
            result.Status = StatusType.Success;

            return result;
        }
    }
}
