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
    public class TehnicarController : ControllerBase
    {
        private UserBaseInterface<Tehnicar, TehnicarVM, CreateTehnicarVM> _userInterface;
        public TehnicarController(UserBaseInterface<Tehnicar, TehnicarVM, CreateTehnicarVM> userInterface)
        {
            _userInterface = userInterface;
        }

        [HttpGet]
        public IList<TehnicarVM> GetAll()
        {
            return _userInterface.GetAll();
        }

        [HttpGet("{id}")]
        public TehnicarVM Get(int id)
        {
            return _userInterface.Get(id);
        }

        [HttpPost]
        public async Task<TehnicarVM> Insert(CreateTehnicarVM tehnicar)
        {
            return await _userInterface.Insert(tehnicar);
        }

        [HttpPut]
        public TehnicarVM Update(int id, TehnicarVM tehnicar)
        {
            return _userInterface.Update(tehnicar);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userInterface.Delete(id);
        }
    }
}
