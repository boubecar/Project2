
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
    public class FiLocalController : ControllerBase
    {



        public readonly IMediator _mediator;
        public readonly IMapper _mapper;

        public FiLocalController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        #region Standard CRUD methods
        [HttpGet("GetAllFiLocal")]
        public async Task<IEnumerable<FilLocalDTO>> GetAllFiLocal()
        {
            return _mediator.Send(new GetListQuery<FilLocal>(condition: null, includes: i => i.Include(n => n.Filiale)))
                 .Result.Select(FilLocal => _mapper.Map<FilLocalDTO>(FilLocal));


        }
        [HttpGet("GetLocalByfilialeId")]
        public async Task<IEnumerable<FilLocalDTO>> GetLocalByfilialeId(Guid id)
        {
            return _mediator.Send(new GetListQuery<FilLocal>(condition: c => c.Filialeid == id, includes: i => i.Include(n => n.Filiale)))
                 .Result.Select(FilLocal => _mapper.Map<FilLocalDTO>(FilLocal));


        }


        [HttpGet("{id}")]
        public async Task<FilLocal> GetCoastsTypeByID(Guid id)
        {
            return await _mediator.Send(new GetByIdQuery<FilLocal>(condition: c => c.LocallId == id, includes: null));
        }


        [HttpPost("PostFilLocal")]
        public async Task<string> PostCoasts(FilLocal SaisieComment)
        {
            return await _mediator.Send(new PostCommand<FilLocal>(SaisieComment));




        }


        [HttpPut("PutFilLocal")]
        public async Task<string> PutCoasts(FilLocal SaisieComment)
        {
            return await _mediator.Send(new PutCommand<FilLocal>(SaisieComment));
        }

        [HttpDelete("DeleteFilLocal")]
        public async Task<string> DeleteCoasts(Guid SaisieCommentId)
        {
            return await _mediator.Send(new DeleteCommand<FilLocal>(SaisieCommentId));

        }
        #endregion

    }


}
