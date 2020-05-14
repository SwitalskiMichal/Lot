using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Lot.Controllers.Modele;
using Lot.Encje;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lot.Controllers
{
    [Route("api/lot")]
    [ApiController]
    public class LotyController : ControllerBase
    {
        private LotContext _lot;
        private IMapper mapper;

        public LotyController(LotContext _lot, IMapper mapper)
        {
            this._lot = _lot;
            this.mapper = mapper;
        }

        public ActionResult<List<LotyDetailsDto>> Get()
        {
            var loty = _lot.Loty.Include(c => c.CelLotu).ToList();
            var lotyDto = mapper.Map<List<LotyDetailsDto>>(loty);

            return Ok(lotyDto);
        }

        [HttpGet("{name}")]
        public ActionResult<List<LotyDetailsDto>> Get(string name)
        {
            var lot = _lot.Loty
                .Include(c => c.CelLotu)
                .FirstOrDefault(lot => lot.nazwaLiniLotniczej.Replace(" ", "-").ToLower() == name.ToLower());

            if(lot == null)
            {
                return NotFound();
            }else
            {
                var lotDto = mapper.Map<LotyDetailsDto>(lot);
                return Ok(lotDto);
            }
        }
    }
}