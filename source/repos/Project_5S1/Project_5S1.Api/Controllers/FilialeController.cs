
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
    public class FilialeController : ControllerBase
    {



        public readonly IMediator _mediator;
        public readonly IMapper _mapper;

        public FilialeController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        #region Standard CRUD methods
       [HttpGet("GetAllFiliale")]
        public async Task<IEnumerable<SaisieFilialeDTO>> GetAllFiliale()
        {
            return _mediator.Send(new GetListQuery<Filiale>(condition: null, includes: i => i.Include(n => n.pole)))
                 .Result.Select(Filiale => _mapper.Map<SaisieFilialeDTO>(Filiale));
 
             
        }

        [HttpGet("GetAllfilialeByPole")]
        public async Task<IEnumerable<SaisieFilialeDTO>> GetAllfilialeByPole(Guid id)
        {
            return _mediator.Send(new GetListQuery<Filiale>(condition: c => c.poleId == id, includes: i => i.Include(n => n.pole)))
                 .Result.Select(Filiale => _mapper.Map<SaisieFilialeDTO>(Filiale));


        }

        [HttpGet("{id}")]
        public async Task<Filiale> GetCoastsTypeByID(Guid id)
        {
            return await _mediator.Send(new GetByIdQuery<Filiale>(condition: c => c.FilialId == id, includes: null));
        }
       

        [HttpPost("PostFilale")]
        public async Task<string> PostCoasts(Filiale SaisieComment)
        {
            return await _mediator.Send(new PostCommand<Filiale>(SaisieComment));




        }


        [HttpPut("PutFiliale")]
        public async Task<string> PutCoasts(Filiale SaisieComment)
        {
            return await _mediator.Send(new PutCommand<Filiale>(SaisieComment));
        }

        [HttpDelete("DeleteFiliale")]
        public async Task<string> DeleteCoasts(Guid SaisieCommentId)
        {
            return await _mediator.Send(new DeleteCommand<Filiale>(SaisieCommentId));

        }
        #endregion

    }


}
