// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sample.Test.E2E.Run.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class LimiteCarteiraFeature : Xunit.IClassFixture<LimiteCarteiraFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "LimiteCarteira.feature"
#line hidden
        
        public LimiteCarteiraFeature(LimiteCarteiraFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-br"), "Limite Carteira", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Alteracao do limite carteira do usuario ao realizar uma operacao de venda de ativ" +
            "o")]
        [Xunit.TraitAttribute("FeatureTitle", "Limite Carteira")]
        [Xunit.TraitAttribute("Description", "Alteracao do limite carteira do usuario ao realizar uma operacao de venda de ativ" +
            "o")]
        [Xunit.TraitAttribute("Category", "cenario1")]
        public virtual void AlteracaoDoLimiteCarteiraDoUsuarioAoRealizarUmaOperacaoDeVendaDeAtivo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alteracao do limite carteira do usuario ao realizar uma operacao de venda de ativ" +
                    "o", null, new string[] {
                        "cenario1"});
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 testRunner.Given("que eu possua um limite carteira de \"50000\" reais", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 8
 testRunner.When("eu realizar uma operacao de venda do valor de \"10000\" reais", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 9
 testRunner.Then("o meu novo limite carteira deve ser \"40000\" reais", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Alteracao do limite carteira do usuario ao realizar uma operacao de venda de pass" +
            "ivos")]
        [Xunit.TraitAttribute("FeatureTitle", "Limite Carteira")]
        [Xunit.TraitAttribute("Description", "Alteracao do limite carteira do usuario ao realizar uma operacao de venda de pass" +
            "ivos")]
        [Xunit.TraitAttribute("Category", "cenario2")]
        public virtual void AlteracaoDoLimiteCarteiraDoUsuarioAoRealizarUmaOperacaoDeVendaDePassivos()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Alteracao do limite carteira do usuario ao realizar uma operacao de venda de pass" +
                    "ivos", null, new string[] {
                        "cenario2"});
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 13
 testRunner.Given("que eu possua um limite carteira de \"50000\" reais", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 14
 testRunner.When("eu realizar uma operacao de venda do valor de \"10000\" reais", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 15
 testRunner.Then("o meu novo limite carteira deve ser \"4000\" reais", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                LimiteCarteiraFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                LimiteCarteiraFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
