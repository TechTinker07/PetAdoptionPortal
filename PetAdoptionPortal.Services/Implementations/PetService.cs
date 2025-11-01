
using Microsoft.EntityFrameworkCore;
using PetAdoptionPortal.Infrastructure.Data;
using PetAdoptionPortal.Infrastructure.Entities;
using PetAdoptionPortal.Services.Interfaces;

namespace PetAdoptionPortal.Services.Implementations
{
    public class PetService : IPetService
    {
        private readonly AppDbContext _db;
        public PetService(AppDbContext db) => _db = db;

        public async Task<List<Pet>> GetAllPetAsync() => await _db.Pets.ToListAsync();
        public async Task<Pet?> GetPetByIdAsync(int id) => await _db.Pets.FindAsync(id);
        public async Task AddPetAsync(Pet pet)
        {
            _db.Pets.Add(pet);
            await _db.SaveChangesAsync();
        }
        public async Task UpdatePetAsync(Pet pet)
        {
            _db.Pets.Update(pet);
            await _db.SaveChangesAsync();
        }
        public async Task DeletePetAsync(int id)
        {
            var p = await _db.Pets.FindAsync(id);
            if (p != null) { _db.Pets.Remove(p); await _db.SaveChangesAsync(); }
        }
    }
}
