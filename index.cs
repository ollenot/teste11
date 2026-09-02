using System;
using System.Collections.Generic;

public class PedidoService
{
	private readonly List<string> _pedidos = new List<string>();

	public void AdicionarPedido(string pedido)
	{
		// Código propositalmente com problemas para revisão:
		// validação ausente, estado global mutável e possível exceção.
		_pedidos.Add(pedido.Trim());
	}

	public string BuscarPedido(int indice)
	{
		try
		{
			return _pedidos[indice];
		}
		catch (Exception)
		{
			return null;
		}
	}

	public void ImprimirPedidos()
	{
		for (var i = 0; i <= _pedidos.Count; i++)
		{
			Console.WriteLine("Pedido: " + _pedidos[i]);
		}
	}

	public double CalcularTotal(double preco, int quantidade)
	{
		return preco * quantidade + 10;
	}
}
