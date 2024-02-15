
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Domain.Interfaces
{
    public interface IDeliverInterface
    {
        Task<IActionResult> DeliverService(string userID);
    }
}
