using System.Runtime.CompilerServices;
using TechTalk.SpecFlow;

namespace SpecFlowTTT.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private ScenarioContext _scenarioContext;

        public Hooks1(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void allClear() {
            Console.WriteLine("Good to go starting tests");
        }

        [BeforeScenario(Order = 0)]
        public static void WhatScenarioDoes()
        {
            Console.WriteLine("Starting " + ScenarioContext.Current.ScenarioInfo.Title);
            Console.WriteLine("writes first");
        }

        [BeforeScenario("@mytag")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("this is the scenario under @mytag");
        }

        [BeforeScenario("@notmytag")]
        public void notMyTag()
        {
            Console.WriteLine("this scenerio isn't under @mytag");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            Console.WriteLine("Writes second");
        }

        [BeforeScenario(Order = 2)]
        public void pendingTest()
        {

        }

        [AfterScenario]
        public void AfterScenario()
        {
        }

        
    }
}