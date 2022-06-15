using bootcamp_dotnetcore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace bootcamp_dotnetcore.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class CityController : ControllerBase
    {
       private static List<SehirModel> models = new List<SehirModel>();
   
        // Create, Read, Update, Delete - CRUD
        // 


        [HttpGet("SehirGetir")]
        public List<SehirModel> SehirGetir()
        {
            return models;
        }

        [HttpGet("SehirGetirByPlakaKod/{plakaKod}")]
        public List<SehirModel> SehirGetirByPlakaKod(int plakaKod)
        {
            List<SehirModel> sonuclar = models.Where(x => x.PlakaKod == plakaKod).ToList();
            return sonuclar;

   

            /* 
             * Expression
             * list.Where(x => x.PlakaKod == plakaKod) --> IEnumerable, IEnumerable<T>, IEnumerable<SehirModel>
             * IEnumerable<int>
             * 
             * 
             * 
             * x =>  --> foreach
             * foreach(var x in list){
             *   if (x.PlakaKod == plakaKod) {}
             * }
             */
        }

        [HttpPost("SehirKaydet")]
        public string SehirKaydet(SehirModel model)
        {
            models.Add(model);

            return "OK";
        }

        [HttpPut("SehirGuncelle")]
        public bool SehirGuncelle(SehirModel model, int plakaKod)
        {
            int index = models.FindIndex(x => x.PlakaKod == plakaKod);
            models[index] = model;
            return true;
        }

        [HttpDelete("SehirSil")]
        public bool SehirSil(int plakaKodu)
        {
            int index = models.FindIndex(x => x.PlakaKod == plakaKodu);
            models.RemoveAt(index);
            return true;

        }
    }
}
