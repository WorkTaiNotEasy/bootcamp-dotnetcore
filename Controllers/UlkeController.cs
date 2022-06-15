using bootcamp_dotnetcore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace bootcamp_dotnetcore.Controllers
{
    public class UlkeController : ControllerBase
    {
        private static List<UlkeModel> models = new List<UlkeModel>();

        [HttpGet("UlkeGetir")]
        public List<UlkeModel> UlkeGetir()
        {
            return models;
        }


        [HttpGet("UlkeGetirByPlakaKod/{ulkekod}")]
        public List<UlkeModel> UlkeGetirByPlakaKod(int ulkekod)
        {
            List<UlkeModel> sonuclar = models.Where(x => x.ulkeKod == ulkekod).ToList();
            return sonuclar;
        }



        [HttpPost("UlkeKaydet")]
        public string UlkeKaydet(UlkeModel model)
        {
            models.Add(model);

            return "OK";
        }

        [HttpPut("UlkeGuncelle")]
        public bool UlkeGuncelle(UlkeModel model, int ulkekod)
        {
            int index = models.FindIndex(x => x.ulkeKod == ulkekod);
            models[index] = model;
            return true;
        }

        [HttpDelete("UlkeSil")]
        public bool UlkeSil(int ulkekod)
        {
            int index = models.FindIndex(x => x.ulkeKod == ulkekod);
            models.RemoveAt(index);
            return true;

        }







    }
}
