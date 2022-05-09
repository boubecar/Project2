
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_5S.Domain.Commands;

using Project_5S.Domain.Queries;
using Project_5S.Domain.DTOs;
using Project_5S.Domain.Models;
using AutoMapper;
//[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(HousingTenureTypesController), "AutoMapperStart")]
namespace Project_5S.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class notationController : ControllerBase
    {



        public readonly IMediator _mediator;
        public readonly IMapper _mapper;

        public notationController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        #region Standard CRUD methods
        [HttpGet("GetAllnotation")]
        public async Task<IEnumerable<notationDTO>> GetAllnotation()
        {
            return _mediator.Send(new GetListQuery<notation>(condition: null, includes: null))
                 .Result.Select(notation => _mapper.Map<notationDTO>(notation));


        }



        [HttpGet("{id}")]
        public async Task<notation> GetCoastsTypeByID(Guid id)
        {
            return await _mediator.Send(new GetByIdQuery<notation>(condition: c => c.Id == id, includes: null));
        }


        [HttpPost("Postnotation")]
        public async Task<string> PostCoasts(notation SaisieComment)
        {
            return await _mediator.Send(new PostCommand<notation>(SaisieComment));




        }


        [HttpPut("Putnotation")]
        public async Task<string> PutCoasts(notation SaisieComment)
        {
            return await _mediator.Send(new PutCommand<notation>(SaisieComment));
        }

        [HttpDelete("Deletenotation")]
        public async Task<string> DeleteCoasts(Guid SaisieCommentId)
        {
            return await _mediator.Send(new DeleteCommand<notation>(SaisieCommentId));

        }
        #endregion

    }


}
