using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poliklinika.Model;
using PoliklinikaAPI.Interfaces;
using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatObavezaController : ControllerBase
    {
        private BaseInterface<ChatObaveza, ChatObavezaVM> _baseInterface;
        public ChatObavezaController(BaseInterface<ChatObaveza, ChatObavezaVM> baseInterface)
        {
            _baseInterface = baseInterface;
        }

        [HttpGet("{id}")]
        public ChatObavezaVM Get(int id)
        {
            return _baseInterface.GetById(id);
        }

        [HttpPost]
        public ChatObavezaVM Insert(ChatObavezaVM model)
        {
            return _baseInterface.Insert(model);
        }
    }
}
