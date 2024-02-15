using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Web.Api.Domain.Interfaces;
using Web.Api.Infrastructure.DBContext;
using Web.Api.Infrastructure.Models;

namespace Web.Api.Domain.Services
{
    public class DeliverServicecs : IDeliverInterface
    {
        private readonly MongoDBContext _context;
        public DeliverServicecs(MongoDBContext context)
        {
            _context = context;
        }

        public Task<IActionResult> DeliverService(string userID)
        {
            throw new NotImplementedException();
        }

        //conflicto probles, no time to resolve...
        //public Task<IActionResult> DeliverService(string userID)
        //{
        //    return _context.Pickup.DeleteOneAsync(p => p.Id == (userID));
        //}
    }
}
