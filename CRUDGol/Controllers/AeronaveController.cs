using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDGol.Data;
using CRUDGol.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDGol.Controllers
{
    [ApiController]
    [Route("aeronave")]
    public class AeronaveController : ControllerBase
    {
        protected IAeronaveRepository _aeronaveRepository;
        protected AeronaveContext _context;

        public AeronaveController(IAeronaveRepository repository)
        {
            _aeronaveRepository = repository;

        }

        [HttpGet]
        public IEnumerable<Aeronave> Get()
        {
            return _aeronaveRepository.GetAll().ToList();
        }

        [HttpGet("selecionar/{id}")]
        public Aeronave SelecionarPorId(int id)
        {
            var aeronave = new Aeronave();

            if (aeronave == null)
                return null;

            return aeronave;
        }

        [HttpPost]
        [Route("inserir")]
        public Task<Aeronave> Inserir(Aeronave aeronave)
        {

            if (!ModelState.IsValid)
                return null;

            _aeronaveRepository.Add(aeronave);

            return null;
        }

        [HttpPut("alterar/{id}")]
        public Aeronave Alter(int id)
        {
            var aeronave = new Aeronave();


            if (aeronave != null)
                return null;

            _aeronaveRepository.Update(aeronave);

            return aeronave;
        }

        [HttpGet("delete/{id}")]
        public Aeronave Delete(int id)
        {
            var aeronave = new Aeronave();
            //aeronave = _context.Artistas.FirstOrDefault(a => a.Id == id);

            if (aeronave == null)
                return null;


            return null;
        }
    }
}