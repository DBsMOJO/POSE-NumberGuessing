# POSE-NumberGuessing

## Task 

Write a program NumberQuiz that generates a random number between 1 and 100.
The player then has to guess this number. The program counts the guessing
attempts and the player's guessing strategy is assessed depending on the
number of attempts. After each failed attempt, the player receives a message
as to whether the number they are looking for is larger or smaller than the
number entered.

Rate strategy rating table:

| Guessing attempts   | Output    |
|--------------- | --------------- |
| 1-5   | Tolle Leistung!   |
| 6-10   | Schon ganz gut!   |
|  >10   | Endlich geschafft!   |

### Example of user dialog

``` csharp
Random random = new.Random(); // Generates a random number generator
guessNumber = random.Next(1, 101); // Generate random number from 1 to 100
```

