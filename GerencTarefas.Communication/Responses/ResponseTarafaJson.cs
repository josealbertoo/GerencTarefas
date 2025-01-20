using GerencTarefas.Communication.Enum;

namespace GerencTarefas.Communication.Responses;
public class ResponseTarafaJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public TarefaPrioridade Prioridade { get; set; }
    public DateTime DataLimite { get; set; }
    public TarefaStatus Status { get; set; }
}
