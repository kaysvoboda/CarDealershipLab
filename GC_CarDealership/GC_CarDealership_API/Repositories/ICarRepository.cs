using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GC_CarDealership_API.Data;
using GC_CarDealership_API.Data.Model;

namespace GC_CarDealership_API.Repositories
{
    public interface ICarRepository
    {

        Task Create(Data.Model.Car model);
        Task Delete(int id);
        Task<List<Car>> GetAll();
        Task<Car> Get(int id);
        Task Update(int id, Car model);
    }
}
