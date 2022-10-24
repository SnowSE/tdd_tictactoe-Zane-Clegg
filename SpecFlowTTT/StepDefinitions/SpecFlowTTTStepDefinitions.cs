using System;
using TechTalk.SpecFlow;
using TTTclassLib;

namespace SpecFlowTTT.StepDefinitions
{
    [Binding]
    public class SpecFlowTTTStepDefinitions
    {
        Class1 _methods = new Class1();

        private ScenarioContext _scenarioContext;
        public SpecFlowTTTStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"grid is initialized")]
        public void GivenGridIsInitialized()
        {
            _methods.InitializeGrid();
        }


        [Given(@"x plays in \((.*),(.*)\)")]
        public void GivenXPlaysIn(int x, int y)
        {
            _methods.SetPlay(x,y);
        }

        [Then(@"x is found in cell \((.*),(.*)\)")]
        public void ThenXIsFoundInCell(int x, int y)
        {
            _methods.CheckCell(x, y);
        }

        [Given(@"o plays in \((.*),(.*)\)")]
        public void GivenOPlaysIn(int x, int y)
        {
            _methods.SetPlay(x,y);
        }

        [When(@"checking for a winner")]
        public void WhenCheckingForAWinner()
        {
           _scenarioContext.Add("xWinner", _methods.WinCondition());
        }

        [Then(@"the winner is x")]
        public void ThenTheWinnerIs()
        {
            _scenarioContext.Get<string>("xWinner").Should().Be("x has won");
        }

        [Then(@"the winner is unknown")]
        public void ThenTheWinnerIsUnknown()
        {
            _methods.WinCondition().Should().Be("No winner yet");
        }

        [When(@"asking who's turn")]
        public void WhenAskingWhosTurn()
        {
            _scenarioContext.Add("oTurn", _methods.Turn());
        }

        [Then(@"player o's turn")]
        public void ThenPlayerOsTurn()
        {
            Convert.ToString(_scenarioContext.Get<char>("oTurn")).Should().Be("o");
        }
    }
}
