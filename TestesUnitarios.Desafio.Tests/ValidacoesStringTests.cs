using TestesUnitarios.Desafio.Console.Services;
using Xunit;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
         
        var texto = "a";
        var resultadoEsperado = 0;

        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

       
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

       
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        
        Assert.False(resultado);
    }

   
    public void TextoDeveTerminarComAPalavraProcurado()
    {
       
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

      
        Assert.True(resultado);
    }
}
