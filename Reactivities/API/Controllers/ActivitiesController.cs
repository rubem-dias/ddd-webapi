using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly ILogger<ActivitiesController> _logger;
        public ActivitiesController(DataContext context, ILogger<ActivitiesController> logger)
        {
            _context = context;
            _logger = logger;
        }


        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities() 
        {
            _logger.LogInformation("Getting all activities from controller activities");
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivitiesById(Guid id) 
        {
            _logger.LogInformation($"Getting all activities from controller activities with id: {id}");
            return await _context.Activities.FindAsync(id);
        }
    }
}