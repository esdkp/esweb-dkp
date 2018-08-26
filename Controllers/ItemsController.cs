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
    public class ItemsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public ItemsController(ApplicationDbContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/items
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _context.Items.ToList();
        }

        // GET api/items/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return _context.Items.Find(id);
        }

        // POST api/items
        [HttpPost]
        public void Post([FromBody]ItemDto itemDto)
        {
            Item item = _mapper.Map<Item>(itemDto);
            _context.Items.Add(item);
            _context.SaveChanges();
        }

        // PUT api/items/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]ItemDto itemDto)
        {
            Item itemToUpdate = _mapper.Map<Item>(itemDto);
            itemToUpdate.Id = id;
            _context.Items.Update(itemToUpdate);
            _context.SaveChanges();

        }

        // DELETE api/items/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Item itemToDelete = _context.Items.Find(id);
            if (itemToDelete != null) {
                _context.Items.Remove(itemToDelete);
                _context.SaveChanges();
            }
        }
    }
}
