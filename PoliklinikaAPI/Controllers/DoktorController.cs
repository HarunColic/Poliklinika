using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poliklinika.Model;
using PoliklinikaAPI.Interfaces;
using PoliklinikaAPI.ViewModels;

namespace PoliklinikaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoktorController : ControllerBase
    {
        protected UserBaseInterface<Doktor, DoktorVM, CreateDoktorVM> _userInterface;

        public DoktorController(UserBaseInterface<Doktor, DoktorVM, CreateDoktorVM> userInterface)
        {
            _userInterface = userInterface;
        }

        [HttpGet]
        public IList<DoktorVM> GetAll()
        {
            return _userInterface.GetAll();
        }

        [HttpGet("{id}")]
        public DoktorVM Get(int id)
        {
            return _userInterface.Get(id);
        }

        [HttpPost]
        public DoktorVM Insert(CreateDoktorVM doktor)
        {
            return _userInterface.Insert(doktor);
        }

        [HttpPut("{id}")]
        public DoktorVM Update(int id, DoktorVM doktor)
        {
            return _userInterface.Update(id, doktor);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userInterface.Delete(id);
        }
    }
}

