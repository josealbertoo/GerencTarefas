using GerencTarefas.Communication.Requests;
using GerencTarefas.Communication.Responses;

namespace GerencTarefas.Application.UseCases.Tarefa.Register;
public class RegisterTarefaUseCase
{
    public ResponseRegisterTarafaJson Execute(RequestTarefaJson request)
    {
        return new ResponseRegisterTarafaJson()
        {
            Id = 7,
            Name = request.Name,
            Descricao = request.Descricao,
            Prioridade = request.Prioridade,
            DataLimite = request.DataLimite,
            Status = request.Status
        };
    }
}
