
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
    public class NormesController : ControllerBase
    {



        public readonly IMediator _mediator;
        public readonly IMapper _mapper;

        public NormesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        #region Standard CRUD methods
        [HttpGet("GetAllNormes")]
        public async Task<IEnumerable<NormesDTO>> GetAllNormes()
        {
            return _mediator.Send(new GetListQuery<Normes>(condition: null, includes: null))
                 .Result.Select(Normes => _mapper.Map<NormesDTO>(Normes));


        }



        [HttpGet("{id}")]
        public async Task<Normes> GetCoastsTypeByID(Guid id)
        {
            return await _mediator.Send(new GetByIdQuery<Normes>(condition: c => c.normeId == id, includes: null));
        }


        [HttpPost("PostNormes")]
        public async Task<string> PostCoasts(Normes SaisieComment)
        {
            return await _mediator.Send(new PostCommand<Normes>(SaisieComment));




        }


        [HttpPut("PutNormes")]
        public async Task<string> PutCoasts(Normes SaisieComment)
        {
            return await _mediator.Send(new PutCommand<Normes>(SaisieComment));
        }

        [HttpDelete("DeleteNormes")]
        public async Task<string> DeleteCoasts(Guid SaisieCommentId)
        {
            return await _mediator.Send(new DeleteCommand<Normes>(SaisieCommentId));

        }
        #endregion

    }


}
