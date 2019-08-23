using FluentAssertions;
using Sample.Test.E2E.Core.Entities;
using Sample.Test.E2E.Core.Models;
using Sample.Test.E2E.Core.Repositories;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Sample.Test.E2E.Run.Steps
{
    [Binding]
    public class LimiteSteps
    {
        public LimitModel newLimit;

        public InvestmentModel investmentModel;

        [Given(@"que possua um limite inicial de ""(.*)"" reais")]
        public async Task DadoQuePossuaUmLimiteInicialDeReaisAsync(string initialLimit)
        {
            Limit limit = new Limit()
            {
                User = "Frederico",
                UserLimit = initialLimit
            };

            this.newLimit = await LimitRepository.UpdateLimit(limit);
        }

        [When(@"realizo uma operacao financeira de ""(.*)"" reais")]
        public async Task QuandoRealizoUmaOeracaoFinanceiraDeReais(string value)
        {
            Investment investment = new Investment()
            {
                User = "Frederico",
                InvestimentValue = value
            };

            this.investmentModel = await InvestmentRepository.MakeInvestment(investment);
        }

        [Then(@"o meu novo limite deve ser ""(.*)"" reais")]
        public async Task EntaoOMeuNovoLimiteDeveSerReais(string value)
        {
            LimitModel limit = await LimitRepository.FindByUser("Frederico");

            limit.UserLimit.Should().Be(value);

        }
    }
}
