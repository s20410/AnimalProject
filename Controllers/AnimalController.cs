using AnimalsProject.Models;
using AnimalsProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace AnimalsProject.Controllers
{

    [ApiController]
    [Route("api/animals")]

    public class AnimalController : ControllerBase
    {
        private IAnimalService _animalService;

        public AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [HttpGet]
        public IActionResult GetAnimals(string orderBy)
        {
            var result = _animalService.GetAnimals( orderBy );

            return Ok( result );
        } 
        [HttpPost]
        public Task<IActionResult> AddAnimal ( Animal animal )
        {
            var result = _animalService.AddAnimal( animal );

            if ( result == 1 )
            {
                return Task.FromResult<IActionResult>(Ok( $"The animal has been added to db, added values name: {animal.Name}, description {animal.Description}, category {animal.Category}, area: {animal.Area}" ));

            }

            return Task.FromResult<IActionResult>(NotFound( $"The animal has not been added {animal.IdAnimal} to db" ));
        }
        [HttpPut( "{idAnimal}" )]
        public async Task<IActionResult> UpdateAnimal ( Animal animal, int idAnimal )
        {
            var result = _animalService.UpdateAnimal( animal, idAnimal );
            if ( result == 1 )
            {
                return Ok( "Animal updated" );
            }
            return NotFound("The animal has not been updated");
        }
        [HttpDelete("{idAnimal}")]
        public async Task<IActionResult> DeleteAnimal ( int idAnimal )
        {
            var result = _animalService.DeleteAnimal(idAnimal);

            if ( result == 1 )
            {
                return Ok("Animal was deleted");
            }
            return NotFound("Animal was not deleted");
        }
    }
}