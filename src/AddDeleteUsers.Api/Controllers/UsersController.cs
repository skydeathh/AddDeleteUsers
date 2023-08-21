using AddDeleteUsers.Application.Commands;
using AddDeleteUsers.Application.Queries;
using AddDeleteUsers.Shared.Abstractions.Commands;
using AddDeleteUsers.Shared.Abstractions.Queries;
using Microsoft.AspNetCore.Mvc;
using AddDeleteUsers.Application.DTO;

namespace AddDeleteUsers.Api.Controllers;

public class UsersController : BaseController {
    private readonly IQueryDispatcher _queryDispatcher;
    private readonly ICommandDispatcher _commandDispatcher;

    public UsersController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher) {
        _queryDispatcher = queryDispatcher;
        _commandDispatcher = commandDispatcher;
    }

    [HttpGet("{Id:guid}")]
    public async Task<ActionResult<UserDto>> Get([FromRoute] GetUser query) {
        var result = await _queryDispatcher.QueryAsync(query);

        return OkOrNotFound(result);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserDto>>> Get([FromQuery] SearchUserByName query) {
        var result = await _queryDispatcher.QueryAsync(query);

        return OkOrNotFound(result);
    }

    [HttpPut("{Id:guid}")]
    public async Task<IActionResult> Put([FromBody] AddUser command) {
        await _commandDispatcher.DispatchAsync(command);
        return Ok();
    }

    [HttpDelete("{Id:guid}")]
    public async Task<IActionResult> Delete([FromBody] RemoveUser command) {
        await _commandDispatcher.DispatchAsync(command);
        return Ok();
    }
}