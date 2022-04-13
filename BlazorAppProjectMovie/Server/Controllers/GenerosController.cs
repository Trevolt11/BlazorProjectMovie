﻿using BlazorAppProjectMovie.Client.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlazorAppProjectMovie.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenerosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public GenerosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //[HttpGet]
        //public async Task<ActionResult<List<Genero>>> Get()
        //{

        //}

        [HttpPost]
        public async Task<ActionResult<int>> Post(Genero genero)
        {
            context.Add(genero);
            await context.SaveChangesAsync();
            return genero.Id;

        }
    }
}
