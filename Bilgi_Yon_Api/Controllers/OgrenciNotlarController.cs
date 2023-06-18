using BusinessLayer.Abstract;
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
    public class OgrenciNotlarController : ControllerBase
    {
        private readonly IOGRENCI_NOTService _ogrencinotService;

        private readonly ILogger<OgrenciBilgiController> _logger;

        public OgrenciNotlarController(IOGRENCI_NOTService ogrencinotService, ILogger<OgrenciBilgiController> logger)
        {
            _ogrencinotService = ogrencinotService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult ogrencinot_list()
        {
            var values = _ogrencinotService.TGetList();

            _logger.LogInformation("Listeleme Yapıldı.");

            return Ok(values);


        }

        [HttpPost]
        public IActionResult ogrencinot_add(OGRENCI_NOT ogrencinot)
        {
            _ogrencinotService.TInsert(ogrencinot);

            _logger.LogInformation("Ekleme Yapıldı.");
            return Ok();
        }

        [HttpDelete("{ID}")]
        public IActionResult ogrencinot_delete(int ID)
        {
            var values = _ogrencinotService.TGetByID(ID);
            _logger.LogInformation("Silme Yapıldı.");
            _ogrencinotService.TDelete(values);

            return Ok();


        }

        [HttpPut]
        public IActionResult ogrencinot_update(OGRENCI_NOT ogrencinot)
        {
            _ogrencinotService.TUpdate(ogrencinot);

            _logger.LogInformation("Güncelleme Yapıldı.");
            return Ok();
        }

        [HttpGet("{ID}")]
        public IActionResult ogrencinot_Get(int ID)
        {
            var values = _ogrencinotService.TGetByID(ID);
            _logger.LogInformation("Bilgi Getirildi.");
            return Ok(values);


        }


    }
}
