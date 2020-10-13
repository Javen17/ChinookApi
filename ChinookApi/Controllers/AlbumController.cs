using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chinook.BusinessLogic;
using Chinook.BusinessLogic.Interface;
using Chinook.BusinessModel.Models;
using ChinookDemoMVC.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ChinookApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AlbumController : BaseController<Album>
    {

        public AlbumController(IObjectFactory factory) : base()
        {
            _manager = factory.Resolve<IAlbumManager>();
        }
    }
}
