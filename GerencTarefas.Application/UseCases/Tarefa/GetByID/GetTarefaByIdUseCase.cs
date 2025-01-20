using GerencTarefas.Communication.Enum;
using GerencTarefas.Communication.Responses;

namespace GerencTarefas.Application.UseCases.Tarefa.GetByID;
public class GetTarefaByIdUseCase
{
    public ResponseTarafaJson Execute(int id)
    {
        return new ResponseTarafaJson 
        {   
            Id = id,
            Name = "Tarefa 1",
            Descricao = "Descrição da tarefa 1",
            Prioridade = TarefaPrioridade.Alta,
            DataLimite = new DateTime(year: 2023,month: 01, day: 01),
            Status = TarefaStatus.Aguardando
        };
    }
}
