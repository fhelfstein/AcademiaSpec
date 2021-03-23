using AcademiaSpec.Abstracao;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Bindings;

namespace AcademiaSpec.ExtensionMethods
{
    public static class ScenarioExtensionMethod
    {
        private static ExtentTest CreateScenario(ExtentTest extent, StepDefinitionType stepDefinitionType)
        {
            string scenarioStepContext = ScenarioStepContext.Current.StepInfo.Text;

            switch (stepDefinitionType)
            {
                case StepDefinitionType.Given:
                    return extent.CreateNode<Given>(scenarioStepContext);
                case StepDefinitionType.Then:
                    return extent.CreateNode<Then>(scenarioStepContext);
                case StepDefinitionType.When:
                    return extent.CreateNode<When>(scenarioStepContext);
                default:
                    throw new ArgumentOutOfRangeException(nameof(stepDefinitionType), stepDefinitionType, null);
            }

        }

        private static void CreateScenarioFailOrError(ExtentTest extent, StepDefinitionType stepDefinitionType)
        {
            Exception error = ScenarioContext.Current.TestError;

            if (error.InnerException == null)
            {
                CreateScenario(extent, stepDefinitionType).Error(error.Message);
            }
            else
            {
                CreateScenario(extent, stepDefinitionType).Fail(error.InnerException);

            }
        }

        public static void StepDefinitionGiven(this ExtentTest extent)
        {
            if (ScenarioContext.Current.TestError == null)
            {
                var teste = CreateScenario(extent, StepDefinitionType.Given);
                foreach (string sAux in Constantes.logInfo)
                {
                    teste.Info(sAux);
                }
                foreach (string sAux in Constantes.logImage)
                {
                    teste.AddScreenCaptureFromPath(sAux, null);
                }

                Constantes.logImage.Clear();
                Constantes.logInfo.Clear();
            }
            else
            {
                CreateScenarioFailOrError(extent, StepDefinitionType.Given);
            }
        }

        public static void StepDefinitionWhen(this ExtentTest extent)
        {
            if (ScenarioContext.Current.TestError == null)
            {
                var teste = CreateScenario(extent, StepDefinitionType.When);
                foreach (string sAux in Constantes.logInfo)
                {
                    teste.Info(sAux);
                }
                foreach (string sAux in Constantes.logImage)
                {
                    teste.AddScreenCaptureFromPath(sAux, null);
                }

                Constantes.logImage.Clear();
                Constantes.logInfo.Clear();
            }
            else
            {
                CreateScenarioFailOrError(extent, StepDefinitionType.When);
            }
        }

        public static void StepDefinitionThen(this ExtentTest extent)
        {
            if (ScenarioContext.Current.TestError == null)
            {
                var teste = CreateScenario(extent, StepDefinitionType.Then);
                foreach (string sAux in Constantes.logInfo)
                {
                    teste.Info(sAux);
                }
                foreach (string sAux in Constantes.logImage)
                {
                    teste.AddScreenCaptureFromPath(sAux, null);
                }

                Constantes.logImage.Clear();
                Constantes.logInfo.Clear();
            }
            else
            {
                CreateScenarioFailOrError(extent, StepDefinitionType.Then);
            }
        }
    }
}