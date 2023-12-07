using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TransitoRD.Core.Application.Dtos.Agentes;
using TransitoRD.Core.Application.Dtos.Licencia;
using TransitoRD.Core.Application.Interfaces.Services;
using TransitoRD.Core.Domain.Entities;

namespace TransitoRD.Controllers.v1
{
    public class LicenciaController : BaseApi<Licencia, RequestlicenciaDto, ResponselicenciaDto, ILicenciaService>
    {
        private ILicenciaService _service;
        
        public LicenciaController(ILicenciaService service, IMapper mapper) : base(service, mapper)
        {
            _service = service;
        }

        [HttpGet("[Controller]/cedula/{lice}")]
        public virtual async Task<IActionResult> GetByPlacaAsync(string lice)
        {
            var entityresult = await _service.GetByLicenciaRequest(lice);

            if (entityresult is null)
            {
                return NotFound();
            }

            return Ok(entityresult);
        }
    }
}
