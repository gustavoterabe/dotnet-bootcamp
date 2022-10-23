using AutoMapper;
using SistemaAgendamentoApi.Models;
using SistemaAgendamentoApi.ViewModel.Tarefa;

namespace SistemaAgendamentoApi;

public class AutoMapperProfile: Profile
{
    public AutoMapperProfile()  
    {  
        CreateMap<CriarTarefaViewModel, Tarefa>(); 
    }  
}