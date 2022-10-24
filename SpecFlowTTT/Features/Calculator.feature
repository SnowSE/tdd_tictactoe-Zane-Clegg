Feature: SpecFlowTTT
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowTTT/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: pieces played
Given x plays in (0,1)
Then x is found in cell (0,1)

Scenario: x wins
Given x plays in (0,0)
And o plays in (1,0)
And x plays in (0,1)
And o plays in (1,2)
And x plays in (0,2)
And o plays in (2,1)
And x plays in (1,1)
And o plays in (2,2)
And x plays in (2,0)
When checking for a winner
Then the winner is x

Scenario: normal game loop
Given x plays in (0,1)
And o plays in (1,1)
And x plays in (0,0)
When checking for a winner
Then the winner is unknown
When asking who's turn
Then player o's turn