using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Commander.Controllers
{
  [ApiController]
  [Route("commands")]
  public class CommandsController : ControllerBase
  {
    private readonly ICommanderRepo _repository;
    private readonly IMapper _mapper;

    public CommandsController(ICommanderRepo repository, IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    //GET commands/
    [HttpGet]
    public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
    {
      var commandItems = _repository.GetAllCommands();

      return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
    }

    //GET commands/{id}
    [HttpGet("{id}")]
    public ActionResult<CommandReadDto> GetCommandById(int id)
    {
      var commandItem = _repository.GetCommandById(id);

      if (commandItem != null)
      {
        return Ok(_mapper.Map<CommandReadDto>(commandItem));
      }

      return NotFound();
    }
  }
}
