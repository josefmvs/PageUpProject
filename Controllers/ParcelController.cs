using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PageUpProject.Business.Interfaces;
using PageUpProject.Models;
using PageUpProject.Models.Dto;

namespace PageUpProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParcelController : ControllerBase
    {
        private IParcelService _parcelService;
        public ParcelController(IParcelService parcelService)
        {
            _parcelService = parcelService;
        }

        [HttpPost]
        public ActionResult<AddParcelResponse> PostParcel([FromBody]Parcel parcel)
        {
            AddParcelResponse response = new AddParcelResponse();
            if (parcel == null)
            {
                return BadRequest("Parcel is Null");
            }

            response = _parcelService.ComputeCost(parcel);

            return Ok(response);

        }
    }
}