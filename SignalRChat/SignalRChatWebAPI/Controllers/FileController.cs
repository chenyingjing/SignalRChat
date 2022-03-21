using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRChatWebAPI.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SignalRChatWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        //// GET: api/<FileController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<FileController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        private readonly IHubContext<ChatHub> _hubContext;

        public FileController(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        // POST api/<FileController>
        [HttpPost]
        public async void Post([FromBody] MyData value)
        //public void Post([FromBody] string value)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", "user1", "Hello,abc");
        }


    }
}
