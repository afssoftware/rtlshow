using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using TVMaze.DataAccess;
using TVMaze.Models;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace TVMaze.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RTLshowController : ControllerBase
    {
        private readonly RTLContext _context;
        private readonly ILogger<RTLshowController> _logger;
        private const string Format = "yyyy-MM-dd";

        public RTLshowController(
            RTLContext context,
            ILogger<RTLshowController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task <List<RTLshow>> Get()
        {
            try
            {
                var query = await _context.RTLshows
                         .Include(c => c.Casts)
                         .ToList();
                //User JsonConvert 
                //return Content(JsonConvert.SerializeObject(query));
                return query;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error occurrend.", ex);
            }
            return null;
        }

        // Post: api/rtlshow
        [HttpPost]
        public void Post(RTLshow rtlshow)
        {
            try
            {
                _context.RTLshows.Add(rtlshow);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError("Error occurrend.", ex);
            }
        }
    }
}
