using System;
using TechTalk.SpecFlow;
using TTTclassLib;

namespace SpecFlowTTT.StepDefinitions
{
    [Binding]
    public class SpecFlowTTTStepDefinitions
    {
        Class1 _methods = new Class1();

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
            _methods.WinCondition();
        }

        [Then(@"the winner is x")]
        public void ThenTheWinnerIs()
        {
            Convert.ToString(_methods.WinCondition()).Should().Be("x has won");
        }

        [Then(@"the winner is unknown")]
        public void ThenTheWinnerIsUnknown()
        {
            _methods.WinCondition().Should().Be("No winner yet");
        }

        [When(@"asking who's turn")]
        public void WhenAskingWhosTurn()
        {
            throw new PendingStepException();
        }

        [Then(@"player o's turn")]
        public void ThenPlayerOsTurn()
        {
            Convert.ToString(_methods.turn).Should().Be("o");
        }
    }
}
