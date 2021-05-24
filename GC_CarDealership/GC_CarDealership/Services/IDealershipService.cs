using System;
using GC_CarDealership.Services.Models;
using System.Threading.Tasks;

namespace GC_CarDealership.Services
{
    public interface IDealershipService
    {
        Task<APIResponse> QueryDealershipAsync(string name);
    }
}
