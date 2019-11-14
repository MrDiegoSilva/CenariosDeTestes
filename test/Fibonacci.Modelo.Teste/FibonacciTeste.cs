using System;
using Xunit;

namespace Fibonacci.Modelo.Teste
{
    [Binding]
    public class FibonacciTeste
    {
        private CalculoHora calculoHora;
        private double quantidade;
        private Decimal valor;

        [Given(@"que estou consumindo o método CalculaHoraExtraNormal")]
        public void DadoQueEstouConsumindoOMetodoCalculaHoraExtraNormal()
        {
            calculoHora = new CalculoHora();
        }

        [Given(@"preencho o campo '(.*)' com o valor (.*)")]
        public void DadoPreenchoOCampoComOValor(string quantidade0, int p1)
        {
            quantidade = p1;
        }

        [When(@"executo a aplicação")]
        public void QuandoExecutoAAplicacao()
        {
            valor = (Decimal)calculoHora.CalculaHoraExtraNormal(quantidade);
        }

        [Then(@"vejo '(.*)'")]
        public void EntaoVejo(Decimal p0)
        {
            Assert.Equal(p0.ToString("N2"), valor.ToString("N2"));
        }
    }
}
