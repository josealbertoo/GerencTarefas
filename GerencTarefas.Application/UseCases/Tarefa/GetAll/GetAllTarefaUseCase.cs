using GerencTarefas.Communication.Enum;
using GerencTarefas.Communication.Responses;

namespace GerencTarefas.Application.UseCases.Tarefa.GetAll;
public class GetAllTarefaUseCase
{
    public ResponseAllTarefaJson Execute()
    {
        return new ResponseAllTarefaJson()
        {
            Tarefas = new List<ResponseShortTarafaJson>()
            {
                new ResponseShortTarafaJson()
                {
                    Id = 1,
                    Name = "Tarefa 1",
                    Prioridade = TarefaPrioridade.Alta,
                    Status = TarefaStatus.Aguardando
                },
                new ResponseShortTarafaJson()
                {
                    Id = 2,
                    Name = "Tarefa 2",
                    Prioridade = TarefaPrioridade.Baixa,
                    Status = TarefaStatus.Concluída
                }
            }
        };
    }
}
