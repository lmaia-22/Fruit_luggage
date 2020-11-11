using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ApplicationContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;

            _context.Database.Migrate();
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("/testeAdd")]
        public void Test()
        {
            var box = new BoxType()
            {
                Name = "Pandora",
                Cost = 999999999
            };

            _context.BoxTypes.Add(box);

            _context.SaveChanges();
        }

        [HttpGet("/testeGet")]
        public IEnumerable<BoxType> GetTest()
        {
            return _context.BoxTypes;
        }
    }
}
