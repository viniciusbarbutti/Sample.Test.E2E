using FluentAssertions;
using Sample.Test.E2E.Core.API.Repositories.Parameters;
using Sample.Test.E2E.Core.API.Repositories.Models;
using Sample.Test.E2E.Core.API.Repositories;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Sample.Test.E2E.Run.Steps
{
    [Binding]
    public class LimiteSteps
    {
        private LimitModel newLimit;
        
        private InvestmentModel investmentModel;

        [Given(@"que eu possua um limite carteira de ""(.*)"" reais")]
        public async Task DadoQuePossuaUmLimiteInicialDeReaisAsync(string initialLimit)
        {
            Limit limit = new Limit()
            {
                User = "Frederico",
                UserLimit = initialLimit
            };

            this.newLimit = await LimitRepository.UpdateLimit(limit);
        }

        [When(@"eu realizar uma operacao de venda do valor de ""(.*)"" reais")]
        public async Task QuandoRealizoUmaOeracaoFinanceiraDeReais(string value)
        {
            Investment investment = new Investment()
            {
                User = "Frederico",
                InvestimentValue = value
            };

            this.investmentModel = await InvestmentRepository.MakeInvestment(investment);
        }

        [Then(@"o meu novo limite carteira deve ser ""(.*)"" reais")]
        public async Task EntaoOMeuNovoLimiteDeveSerReais(string value)
        {
            LimitModel limit = await LimitRepository.FindByUser("Frederico");

            limit.UserLimit.Should().Be(value);

        }
    }
}
