using GerencTarefas.Communication.Enum;

namespace GerencTarefas.Communication.Responses;
public class ResponseShortTarafaJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public TarefaPrioridade Prioridade { get; set; }

    public TarefaStatus Status { get; set; }
}
