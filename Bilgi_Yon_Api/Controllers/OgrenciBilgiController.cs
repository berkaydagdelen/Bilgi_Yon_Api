using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data;

namespace Bilgi_Yon_Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OgrenciBilgiController : ControllerBase
    {


        private readonly IOGRENCI_BILGIService _ogrencibilgiService;
        private readonly ILogger<OgrenciBilgiController> _logger;

        public OgrenciBilgiController(IOGRENCI_BILGIService ogrencibilgiService, ILogger<OgrenciBilgiController> logger)
        {
            _ogrencibilgiService = ogrencibilgiService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult ogrencibilgi_list()
        {
            var values = _ogrencibilgiService.TGetList();
            _logger.LogInformation("Listeleme Yapıldı.");
            return Ok(values);

        }
        [HttpPost]
        public IActionResult ogrencibilgi_add(OGRENCI_BILGI ogrencibilgi)
        {
            _ogrencibilgiService.TInsert(ogrencibilgi);
            _logger.LogInformation("Ekleme Yapıldı.");
            return Ok();
        }
        [HttpDelete("{OGRENCI_NO}")]
        public IActionResult ogrencibilgi_delete(int OGRENCI_NO)
        {
            var values = _ogrencibilgiService.TGetByID(OGRENCI_NO);

            _ogrencibilgiService.TDelete(values);
            _logger.LogInformation("Silme Yapıldı.");
            return Ok();


        }
        [HttpPut]
        public IActionResult ogrencibilgi_update(OGRENCI_BILGI ogrencibilgi)
        {
            _ogrencibilgiService.TUpdate(ogrencibilgi);
            _logger.LogInformation("Güncelleme Yapıldı.");
            return Ok();
        }

        [HttpGet("{OGRENCI_NO}")]
        public IActionResult ogrencibilgi_Get(int OGRENCI_NO)
        {
            var values = _ogrencibilgiService.TGetByID(OGRENCI_NO);
            _logger.LogInformation("Bilgi Getirildi.");
            return Ok(values);


        }


    }
}
