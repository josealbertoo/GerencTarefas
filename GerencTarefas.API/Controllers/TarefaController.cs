using GerencTarefas.Communication.Requests;
using GerencTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;
using GerencTarefas.Application.UseCases.Tarefa.Register;
using GerencTarefas.Application.UseCases.Tarefa.Update;
using GerencTarefas.Application.UseCases.Tarefa.GetAll;
using GerencTarefas.Application.UseCases.Tarefa.GetByID;
using Microsoft.AspNetCore.Http.HttpResults;
using GerencTarefas.Application.UseCases.Tarefa.Delete;

namespace GerencTarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TarefaController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTarafaJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTarefaJson request)
    {
        var response = new RegisterTarefaUseCase().Execute(request);
        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTarefaJson request)
    {
        var useCase = new UpdateTarefaUseCase();
        useCase.Execute(id, request);
        return NoContent();
    }
    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTarefaJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var response = new GetAllTarefaUseCase().Execute();
        if (response.Tarefas.Any())
        {
            return Ok(response);
        }
        return NoContent();
    }
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTarafaJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Get([FromRoute] int id)
    {
        var useCase = new GetTarefaByIdUseCase();
        var response = useCase.Execute(id);
        return Ok(response);
    }
    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        var useCase = new DeleteTarefaByIdUseCase();
        useCase.Execute(id);
        return NoContent();
    }
}
