using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using JewelryStore.Business;
using JewelryStore.Business.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelectPdf;

namespace JewelryStore.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private readonly ILogger<FileController> _logger;

        public FileController(ILogger<FileController> logger, IAuthService authService)
        {
        }


        [HttpPost("ExportPdf")]
        public IActionResult ExportToPdf(ExportDto exportDto)
        {
            if(exportDto == null)
            {
                return BadRequest();
            }
            HtmlToPdf converter = new HtmlToPdf();

            //TODO move this hard coded html string to some configuration
            exportDto.FileContent = "<h2>JEWELRY STORE</><table _ngcontent-ng-cli-universal-c0=\"\" border=\"1\" style=\"border-collapse: collapse; width: 100%; height: 14px;\"><tbody _ngcontent-ng-cli-universal-c0=\"\"><tr _ngcontent-ng-cli-universal-c0=\"\" style=\"height: 14px;\"><td _ngcontent-ng-cli-universal-c0=\"\" style=\"width: 25%; height: 14px;\">Sl No</td><td _ngcontent-ng-cli-universal-c0=\"\" style=\"width: 25%; height: 14px;\">Price</td><td _ngcontent-ng-cli-universal-c0=\"\" style=\"width: 25%; height: 14px;\">Weight</td><td _ngcontent-ng-cli-universal-c0=\"\" style=\"width: 12.5%; height: 14px;\">Discount(%)</td><td _ngcontent-ng-cli-universal-c0=\"\" style=\"width: 12.5%; height: 14px;\">Total</td></tr><tr _ngcontent-ng-cli-universal-c0=\"\"><td _ngcontent-ng-cli-universal-c0=\"\" style=\"width: 25%;\">&nbsp;" + "1" + "</td><td _ngcontent-ng-cli-universal-c0=\"\" style=\"width: 25%;\">&nbsp;" + exportDto.Price + "</td><td _ngcontent-ng-cli-universal-c0=\"\" style=\"width: 25%;\">&nbsp;" + exportDto.Weight + "</td><td _ngcontent-ng-cli-universal-c0=\"\" style=\"width: 12.5%;\">&nbsp;" + exportDto.Discount + "</td><td _ngcontent-ng-cli-universal-c0=\"\" style=\"width: 12.5%;\">&nbsp;" + exportDto.Total + "</td></tr></tbody></table>";
            PdfDocument doc = converter.ConvertHtmlString(exportDto.FileContent);
            var content = doc.Save();
            return File(content, "application/pdf");
        }

        [HttpGet("Print")]
        public IActionResult Print()
        {
            throw new NotImplementedException();
        }
    }
}
