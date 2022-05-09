
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 

using Project_5S.Domain.Queries;
using Project_5S.Domain.DTOs;
using Project_5S.Domain.Models;
using AutoMapper;
using Project_5S.Domain.Commands;
//[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(HousingTenureTypesController), "AutoMapperStart")]
namespace Project_5S.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {



        public readonly IMediator _mediator;
        public readonly IMapper _mapper;

        public UsersController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        #region Standard CRUD methods
        [HttpGet("GetAllFiliale")]
        public async Task<IEnumerable<UsersDTO>> GetAllFiliale()
        {
            return _mediator.Send(new GetListQuery<Users>(condition: null, includes: null))
                 .Result.Select(Users => _mapper.Map<UsersDTO>(Users));


        }



        [HttpGet("{id}")]
        public async Task<Users> GetCoastsTypeByID(Guid id)
        {
            return await _mediator.Send(new GetByIdQuery<Users>(condition: c => c.userId == id, includes: null));
        }


        [HttpPost("PostFilale")]
        public async Task<string> PostCoasts(Users SaisieComment)
        {
            return await _mediator.Send(new PostCommand<Users>(SaisieComment));




        }


        [HttpPut("PutUsers")]
        public async Task<string> PutCoasts(Users SaisieComment)
        {
            return await _mediator.Send(new PutCommand<Users>(SaisieComment));
        }

        [HttpDelete("DeleteUsers")]
        public async Task<string> DeleteCoasts(Guid SaisieCommentId)
        {
            return await _mediator.Send(new DeleteCommand<Users>(SaisieCommentId));

        }
        #endregion

    }


}
