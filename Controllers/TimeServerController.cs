using bootcamp_dotnetcore.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace bootcamp_dotnetcore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeServerController : ControllerBase
    {
        // Tarih - Saat getir
        // Tarih - Saat ayarla
        // Varsayılana Resetle


        [HttpGet("GetDateandTime")]
       public DateTimeModel GetDateandTime()
        {

            var time = new DateTimeModel();
            time.Date = DateTime.Now.Date.ToString();
            time.Time = DateTime.Now.Hour.ToString();

            return time;

        }


    }
}
