using AcademiaSpec.Abstracao;
using AcademiaSpec.Models;
using System;
using TechTalk.SpecFlow;

namespace AcademiaSpec.Steps
{
    [Binding]
    public class HomePageSteps : SuperBase
    {
        private Home_model home;
        private Product_model product;
        private BuscaCateg_model busca;
        public HomePageSteps(): base()
        {
            home = new Home_model(driver);
            product = new Product_model(driver);
            busca = new BuscaCateg_model(driver);

        }

        [Given(@"que o usuário esta na homePage")]
        public void DadoQueOUsuarioEstaNaHomePage()
        {
            home.verificaAberturaHome();
            Constantes.logInfo.Add("Home Verificada com sucesso");
        }
        
        [When(@"Clicar em um produto")]
        public void QuandoClicarEmUmProduto()
        {
            home.abreProdutoHome();
            Constantes.logInfo.Add("Produto Aberto com sucesso");
        }

        [When(@"Clicar no produto (.*)")]
        public void QuandoClicarNoProduto(int p0)
        {
            home.abreProdutoHome(p0);
            Constantes.logInfo.Add($"O Produto aberto foi o de numero {p0}");
        }

        [When(@"Realizar uma busca")]
        public void QuandoRealizarUmaBusca()
        {
            busca.BuscaProduto("Blouse");
        }

        [When(@"Realizar uma busca por ""(.*)""")]
        public void QuandoRealizarUmaBuscaPor(string p0)
        {
            busca.BuscaProduto(p0);
        }



        [Then(@"deverá ser exibido os detelhes do produto")]
        public void EntaoDeveraSerExibidoOsDetelhesDoProduto()
        {
            product.verificaTelaProduto();
        }
    }
}
