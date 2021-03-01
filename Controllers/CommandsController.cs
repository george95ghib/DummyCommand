using System;
using DummyCommand.Data;
using DummyCommand.Models;
using Microsoft.AspNetCore.Mvc;

namespace DummyCommand.Controllers
{
    [Route("api/dummycommand")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult <Command> GetCommand()
        {
            var cmd =  new Command
            {
                Id = 1,
                HowTo = "remove file",
                Line = "del",
                Platform = Platform.WINDOWS,
                CreatedAt = DateTime.Now
            };

            return Ok(cmd);
        }
    }
}