using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DKP.Data;
using DKP.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace DKP.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {

        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public PersonController(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        // GET: api/persons
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<Person> Get()
        {
            return _context.Persons.ToList();
        }

        // GET api/persons/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public Person Get(int id)
        {
            return _context.Persons.Find(id);
        }

        // POST api/persons
        [HttpPost]
        public void Post([FromBody]PersonDto personDto)
        {
            Person person = _mapper.Map<Person>(personDto);
            _context.Persons.Add(person);
            _context.SaveChanges();
        }

        // PUT api/persons/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]PersonDto personDto)
        {
            Person personToUpdate = _mapper.Map<Person>(personDto);
            personToUpdate.Id = id;
            _context.Persons.Update(personToUpdate);
            _context.SaveChanges();
        }

        // DELETE api/persons/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Person personToDelete = _context.Persons.Find(id);
            if (personToDelete != null)
            {
                _context.Persons.Remove(personToDelete);
                _context.SaveChanges();
            }
        }
    }
}
