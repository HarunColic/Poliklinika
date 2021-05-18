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
    public class OsobljeController : ControllerBase
    {
        private BaseInterface<Osoblje, OsobljeVM> _baseInterface;

        public OsobljeController(BaseInterface<Osoblje, OsobljeVM> baseInterface)
        {
            _baseInterface = baseInterface;
        }

        public List<OsobljeVM> GetAll()
        {
            return _baseInterface.GetAll();
        }
    }
}
