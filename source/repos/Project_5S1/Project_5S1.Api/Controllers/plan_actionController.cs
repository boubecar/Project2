
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
using Microsoft.EntityFrameworkCore;
//[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(HousingTenureTypesController), "AutoMapperStart")]
namespace Project_5S.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class plan_actionController : ControllerBase
    {



        public readonly IMediator _mediator;
        public readonly IMapper _mapper;

        public plan_actionController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        #region Standard CRUD methods
        [HttpGet("GetAllplan_action")]
        public async Task<IEnumerable<plan_actionDTO>> GetAllplan_action()
        {
            return _mediator.Send(new GetListQuery<plan_action>(condition: null, includes: null))
                 .Result.Select(plan_action => _mapper.Map<plan_actionDTO>(plan_action));


        }

        [HttpGet("GetAllplan_actionNote")]
        public async Task<IEnumerable<plan_actionDTO>> GetAllplan_actionNote(Guid id)
        {
            return _mediator.Send(new GetListQuery<plan_action>(condition: c => c.notationid == id, includes: i => i.Include(n => n.notation)))
                 .Result.Select(plan_action => _mapper.Map<plan_actionDTO>(plan_action));


        }

        [HttpGet("{id}")]
        public async Task<plan_action> GetCoastsTypeByID(Guid id)
        {
            return await _mediator.Send(new GetByIdQuery<plan_action>(condition: c => c.planId == id, includes: null));
        }


        [HttpPost("Postplan_action")]
        public async Task<string> PostCoasts(plan_action SaisieComment)
        {
            return await _mediator.Send(new PostCommand<plan_action>(SaisieComment));




        }


        [HttpPut("Putplan_action")]
        public async Task<string> PutCoasts(plan_action SaisieComment)
        {
            return await _mediator.Send(new PutCommand<plan_action>(SaisieComment));
        }

        [HttpDelete("Deleteplan_action")]
        public async Task<string> DeleteCoasts(Guid SaisieCommentId)
        {
            return await _mediator.Send(new DeleteCommand<plan_action>(SaisieCommentId));

        }
        #endregion

    }


}
