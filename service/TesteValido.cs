namespace Teste11.Service;

/// <summary>
/// Fornece validações simples para valores de texto.
/// </summary>
public static class ValidacaoTexto
{
    /// <summary>
    /// Verifica se o valor informado contém texto válido.
    /// </summary>
    /// <param name="valor">Valor a ser validado.</param>
    /// <returns><see langword="true"/> quando o valor possui conteúdo; caso contrário, <see langword="false"/>.</returns>
    public static bool EhValido(this string? valor)
    {
        //teste
        return !string.IsNullOrWhiteSpace(valor);

    }
}