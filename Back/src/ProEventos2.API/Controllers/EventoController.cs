using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos2.API.Models;
using ProEventos2.API.Data;


namespace ProEventos2.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        
        private readonly DataContext _context;
        
        public EventoController(DataContext context)
        {  
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;    
        }

        [HttpGet("{id}")]

        public Evento GetById(int id)
        { 
            return _context.Eventos.FirstOrDefault(
                evento => evento.EventoId == id
            );    
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de delete com id = {id}";
        }
    }
}
