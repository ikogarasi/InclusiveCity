﻿using Asp.Versioning;
using InclusiveCity.Application.Dto;
using InclusiveCity.Application.Features.Commands.UploadStructureImages;
using InclusiveCity.Application.Features.Queries.GetStructureById;
using InclusiveCity.Application.Features.Queries.GetStructures;
using InclusiveCity.Application.Features.Queries.GetInclusiveInfrastructure;
using Microsoft.AspNetCore.Mvc;

namespace InclusiveCity.API.Controllers.v1
{
    [ApiVersion("1.0")]
    public class StructureController : ControllerApiBase
    {
        [HttpGet]
        public async Task<ActionResult<GetStructuresDto>> GetStructures([FromQuery] GetStructuresQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [HttpGet("structure-by-id")]
        public async Task<ActionResult<ElementDto?>> GetStructureById([FromQuery] GetStructureByIdQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [HttpPost("images")]
        public async Task<ActionResult> UploadImages([FromBody] UploadStructureImagesCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }

        [HttpGet("inclusive-infrastructure")]
        public async Task<ActionResult<GetStructuresDto>> GetInclusiveInfrastructure([FromQuery] GetInclusiveInfrastructureQuery query)
        {
            return Ok(await Mediator.Send(query));
        }
    }
}
