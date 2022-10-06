using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacientesController : ControllerBase
    {
        private readonly DataContext _context;


        public PacientesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
      public IEnumerable<Paciente> GetAll()
      {
        
        return _context.Pacientes;
        
      }
    }
}