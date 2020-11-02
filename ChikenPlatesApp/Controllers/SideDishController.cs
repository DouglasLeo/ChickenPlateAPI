using ChikenPlatesApp.Dtos;
using ChikenPlatesApp.Models;
using ChikenPlatesApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChikenPlatesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SideDishController : ControllerBase
    {
        private readonly ISideDishService _sideDishService;

        public SideDishController(ISideDishService sideDishService)
        {
            _sideDishService = sideDishService;
        }

        // GET: api/<SIdeDishController>
        [HttpGet("GetAll")]
        public ActionResult<List<SideDish>> GetAll()
        {
            try
            {
                return Ok(_sideDishService.GetAll());
            }

            catch (Exception ex)
            {
                return BadRequest("An error occurred: " + ex.Message);
            }
        }

        // GET api/<SIdeDishController>/5
        [HttpGet("Get/{id}")]
        public ActionResult<SideDish> Get(long id)
        {
            try
            {
                return Ok(_sideDishService.Get(id));
            }

            catch (Exception ex)
            {
                return BadRequest("An error occurred: " + ex.Message);
            }
        }

        // POST api/<SIdeDishController>
        [HttpPost("Create")]
        public ActionResult<SideDish> Create([FromBody] SideDishDtos sideDishObject)
        {
            try
            {
                var sideDish = new SideDish { DishName = sideDishObject.DishName };

                var result = _sideDishService.Create(sideDish);
                _sideDishService.SaveChanges();

                return Ok(result);
            }

            catch (Exception ex)
            {
                return BadRequest("An error occurred: " + ex.Message);
            }
        }
    }
}
