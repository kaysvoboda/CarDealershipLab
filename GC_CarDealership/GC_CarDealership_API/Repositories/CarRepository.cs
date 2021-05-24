using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GC_CarDealership_API.Data;
using GC_CarDealership_API.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace GC_CarDealership_API.Repositories
{
    public class CarRepository:ICarRepository
    {
        private readonly CarDbContext _context;

        public CarRepository(CarDbContext context)
        {
            _context = context;
        }


        public async Task Create(Data.Model.Car model)
        {
            _context.Car.Add(model);
            await _context.SaveChangesAsync();
        }


        public async Task Delete(int id)
        {
            var car = await _context.Car.FindAsync(id);
            _context.Car.Remove(car);
            await _context.SaveChangesAsync();
        }


        public async Task<Car> Get(int id)
        {
            return await _context.Car.FindAsync(id);
        }

        public async Task<List<Data.Model.Car>> GetAll()
        {
            return await _context.Car.ToListAsync();
        }

        public async Task Update(int id, Car car)
        {
            _context.Update(car);
            await _context.SaveChangesAsync();
        }
    }
}
