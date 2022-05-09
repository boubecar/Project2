
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
using Project_5S1.Domain.DTOs;
//[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(HousingTenureTypesController), "AutoMapperStart")]
namespace Project_5S.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class criteresController : ControllerBase
    {



        public readonly IMediator _mediator;
        public readonly IMapper _mapper;

        public criteresController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        #region Standard CRUD methods
        [HttpGet("GetAllcriters")]
        public async Task<IEnumerable<CriteresDTO>> GetAllcriters()
        {
            return _mediator.Send(new GetListQuery<criteres>(condition:null, includes: i => i.Include(n => n.Normes)))
                 .Result.Select(criteres => _mapper.Map<CriteresDTO>(criteres));


        }
        [HttpGet("getGroupedCriterion")]
        public async Task<IEnumerable<groupedCriteresDTO>> GetGroupedCriteres()
        {

            int ctr = 0;

            var criterion = _mediator.Send(new GetListQuery<criteres>(null, includes: i => i.Include(p => p.Normes))).Result
                .GroupBy(g => g.Normes.designation).Select(s => new groupedCriteresDTO
                {
                    NormeId = s.Select(c => c.NormeId).FirstOrDefault(),
                    normename = s.Key,
                    criterionDTOs = s.Select((c, i) => new CriteresDTO(c, ctr++)).ToList()
                }).ToList();
            return criterion;
        }
        [HttpGet("GetAllcritersByNormes")]
        public async Task<IEnumerable<CriteresDTO>> GetAllcritersByNormes(Guid id)
        {
            return _mediator.Send(new GetListQuery<criteres>(condition: c => c.NormeId == id, includes: i => i.Include(n => n.Normes)))
                 .Result.Select(criteres => _mapper.Map<CriteresDTO>(criteres));


        }



        [HttpGet("{id}")]
        public async Task<criteres> GetCoastsTypeByID(Guid id)
        {
            return await _mediator.Send(new GetByIdQuery<criteres>(condition: c => c.critereId == id, includes: null));
        }
 


        [HttpPost("PostFilale")]
        public async Task<string> PostCoasts(criteres SaisieComment)
        {
            return await _mediator.Send(new PostCommand<criteres>(SaisieComment));




        }


        [HttpPut("Putcriteres")]
        public async Task<string> PutCoasts(criteres SaisieComment)
        {
            return await _mediator.Send(new PutCommand<criteres>(SaisieComment));
        }

        [HttpDelete("Deletecriteres")]
        public async Task<string> DeleteCoasts(Guid SaisieCommentId)
        {
            return await _mediator.Send(new DeleteCommand<criteres>(SaisieCommentId));

        }
        #endregion

    }


}
