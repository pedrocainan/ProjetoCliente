namespace ProjetoClienteDaPe.Models
{
	public class Cliente
	{
		//CRIANDO O ENCAPSULAMENTO DO OBJETO COM GET E SET	
		public int Id { get; set; }
		public string? Nome { get; set; }

		public string? Telefone { get; set; }
		public string? Email { get; set; }

		public List<Cliente>? ListaCliente { get; set; }


	}
}
