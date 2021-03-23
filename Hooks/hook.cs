using AcademiaSpec.Abstracao;
using AcademiaSpec.ExtensionMethods;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using TechTalk.SpecFlow;

namespace AcademiaSpec.Hooks
{
    [Binding]
    public class hook
    {
        [BeforeTestRun]
        public static void configuraReport()
        {
            ExtentHtmlReporter reporter = new ExtentHtmlReporter(Constantes.sREPORTPATH);
            Constantes._extent = new ExtentReports();
            Constantes._extent.AttachReporter(reporter);
        }

        [BeforeFeature]
        public static void CriaFeature()
        {
            Constantes._feature = Constantes._extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }

        [BeforeScenario]
        public static void CriaScenario()
        {
            Constantes._scenario = Constantes._feature.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterStep]
        public static void InsereReportNoPasso()
        {
            switch (ScenarioStepContext.Current.StepInfo.StepDefinitionType)
            {
                case TechTalk.SpecFlow.Bindings.StepDefinitionType.Given:
                    Constantes._scenario.StepDefinitionGiven();
                    break;

                case TechTalk.SpecFlow.Bindings.StepDefinitionType.Then:
                    Constantes._scenario.StepDefinitionThen();
                    break;

                case TechTalk.SpecFlow.Bindings.StepDefinitionType.When:
                    Constantes._scenario.StepDefinitionWhen();
                    break;
            }

            Constantes.logImage.Clear();
            Constantes.logInfo.Clear();
        }

        [AfterTestRun]
        public static void FlushExtent()
        {
            Constantes._extent.Flush();
            System.Diagnostics.Process.Start(Constantes.sREPORTPATH);
        }
    }
}
