using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoAPI.Interfaces;
using ToDoAPI.Models;

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoOperations _services;

        public TodoController(ITodoOperations services)
        {
            _services = services;

        }


        [HttpGet]
        public async Task<ActionResult<List<ItemModel>>> ShowEmployees()
        {
            return Ok( await _services.ShowTasks() );

        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ItemModel>> GetTaskById(int id)
        {
            return Ok( await _services.GetTaskById(id) );
        }


        [HttpPost]
        public async Task<ActionResult<List<ItemModel>>> InsertTask(ItemModel task)
        {
            return Ok( await _services.InsertTask(task) );

        }        


        [HttpPut]
        public async Task<ActionResult<List<ItemModel>>> UpdateTask(ItemModel task)
        {
            return Ok( await _services.UpdateTask(task) );

        }


        [HttpDelete]
        public async Task<ActionResult<List<ItemModel>>> DeleteTask(int id)
        {
            return Ok( await _services.DeleteTask(id) );

        }
    }
}