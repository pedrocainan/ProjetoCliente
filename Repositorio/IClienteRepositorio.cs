using ProjetoClienteDaPe.Models;

namespace ProjetoClienteDaPe.Repositorio
{
	public interface IClienteRepositorio 
	{
        //Crud
        IEnumerable<Cliente> TodosClientes();
    }
}
