
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
    public class    PoleController : ControllerBase
    {



        public readonly IMediator _mediator;
        public readonly IMapper _mapper;

        public PoleController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

       
        #region Standard CRUD methods
           
       [HttpGet("GetAllPole")]
        public async Task<IEnumerable<PoleDTO>> GetAllPole()
        {
            return _mediator.Send(new GetListQuery<Pole>(condition: null, includes: null))
                 .Result.Select(Pole => _mapper.Map<PoleDTO>(Pole));
        }

        

        [HttpGet("{id}")]
        public async Task<Pole> GetCoastsTypeByID(Guid id)
        {
            return await _mediator.Send(new GetByIdQuery<Pole>(condition: c => c.PoleId == id, includes: null));
        }
       

        [HttpPost("PostPole")]
        public async Task<string> PostCoasts(Pole SaisieComment)
        {
            return await _mediator.Send(new PostCommand<Pole>(SaisieComment));




        }


        [HttpPut("PutPole")]
        public async Task<string> PutCoasts(Pole SaisieComment)
        {
            return await _mediator.Send(new PutCommand<Pole>(SaisieComment));
        }

        [HttpDelete("DeletePole")]
        public async Task<string> DeleteCoasts(Guid SaisieCommentId)
        {
            return await _mediator.Send(new DeleteCommand<Pole>(SaisieCommentId));

        }
        #endregion

    }


}
