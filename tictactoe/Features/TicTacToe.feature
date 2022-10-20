Feature: TicTacToe

***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Pieces Can Be Played and Checked
Given x plays in (0,1)
Then x is found in cell (0,1)

Scenario: X Wins
Given x plays in (0,0)
And x plays in (0,1)
And x plays in (0,2)
And x plays in (1,1)
And x plays in (2,0)
And O plays in (1,0)
And O plays in (1,2)
And O plays in (2,1)
And O plays in (2,2)
When checking for a winner
Then the winner of the game is


Scenario: Normal Game Loop
Given x plays in (0,1)
And O plays in (1,1)
And x plays in (0,0)
When checking for a winner
Then the winner of the game is not known yet 
When asking whos turn is next
Then player O has the next turn