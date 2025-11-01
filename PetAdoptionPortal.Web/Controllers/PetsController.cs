using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetAdoptionPortal.Infrastructure.Entities;
using PetAdoptionPortal.Services.Interfaces;

namespace PetAdoptionPortal.Web.Controllers
{
    [Authorize] //entire controller requires login
    public class PetsController : Controller
    {
        private readonly IPetService _petService;
        public PetsController(IPetService petService) => _petService = petService;

        
        public async Task<IActionResult> Index()
        {
            var pets = await _petService.GetAllPetAsync();
            return View(pets);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(Pet pet)
        {
            if (!ModelState.IsValid) return View(pet);
            await _petService.AddPetAsync(pet);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var pet = await _petService.GetPetByIdAsync(id);
            if (pet == null) return NotFound();
            return View(pet);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Pet pet)
        {
            if (!ModelState.IsValid) return View(pet);

            //if status is pending, just mark the request
            if (pet.Status == "Pending")
            {
                //it could also log the request, send email, etc.
                TempData["Message"] = $"Your adoption request for {pet.Name} is being processed. Please wait or contact us.";
                pet.Status = "Available"; //keep available until approved
            }

            await _petService.UpdatePetAsync(pet);
            return RedirectToAction(nameof(Index));
        }
        [AllowAnonymous]
        public IActionResult FunFacts()
        {
            // Simple list of fun facts or tips
            var funFacts = new List<string>
    {
        "Dogs have three eyelids, including one to keep their eyes moist.",
        "Cats can rotate their ears 180 degrees and have 32 muscles in each ear.",
        "Regular checkups and proper nutrition improve your pet’s lifespan."
    };

            return View(funFacts);
        }

    }
}
