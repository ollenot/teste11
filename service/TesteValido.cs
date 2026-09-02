namespace teste11.service;

/// <summary>
/// Fornece validações simples para valores de texto.
/// </summary>
public static class TesteValido
{
	/// <summary>
	/// Verifica se o valor informado contém texto válido.
	/// </summary>
	/// <param name="valor">Valor a ser validado.</param>
	/// <returns><see langword="true"/> quando o valor possui conteúdo; caso contrário, <see langword="false"/>.</returns>
	public static bool EhValido(string? valor)
	{
		return !string.IsNullOrWhiteSpace(valor);
	}
}