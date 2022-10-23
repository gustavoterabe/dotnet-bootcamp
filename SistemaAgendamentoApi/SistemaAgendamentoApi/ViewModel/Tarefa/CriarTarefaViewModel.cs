using SistemaAgendamentoApi.Models;

namespace SistemaAgendamentoApi.ViewModel.Tarefa;

public class CriarTarefaViewModel
{
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime? Data { get; set; }
    public EnumStatusTarefa Status { get; set; }
}