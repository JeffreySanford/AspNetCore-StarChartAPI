using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int", nameof = "GetById")]
        public IActionResult GetById(int id)
        {
            var celestialObject = _context.CelestialObjects.find(id);
            if (celestialObject == null)
                return NotFound();
            celestialObject.Salellites = _context.CelestialObjects.Where(e => e.OribitObjectId == id).ToList();
            return Ok(celestialObject);
        }

        [HttpGet("{name")]
        public IActionResult GetByName(string name)
        {
            var celestialObjects = _context.CelestialObjects.Where(e => e.Name == name).toList();
            if (!celestialObjects.Any())
                return NotFound();
            foreach (var celestialObject in celestialObjects)
            {
                celestialObject.Satallites = _context.CelestialObjects.Where(e => e.OribitObjectId == id).ToList();

            }
            return OK(celestialObjects);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var celestialObjects = _context.CelestialObjects.ToList();
            foreach(var celestialObject in celestialObjects)
            {
                celestialObject.Satallites = _context.CelestialObjects.Where(e => e.OribitObjectId == id).ToList();
                return Ok(celestialObjects);

            }
}
