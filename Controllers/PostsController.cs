using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using scene_it.Services;
using scene_it.Models;

namespace scene_it.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class PostsController : ControllerBase
  {
    private readonly PostsService _ps;
    public PostsController(PostsService ps)
    {
      _ps = ps;
    }





  }
}
