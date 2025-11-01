using PetAdoptionPortal.Infrastructure.Entities;

namespace PetAdoptionPortal.Services.Interfaces
{
    public  interface IPetService
    {
        Task<List<Pet>> GetAllPetAsync();
        Task<Pet?> GetPetByIdAsync(int id);
        Task AddPetAsync(Pet pet);
        Task UpdatePetAsync (Pet pet);
        Task DeletePetAsync (int id);
    }
}
