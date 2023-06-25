import java.util.*;


public class ProjectPlay {

public static void main(String[] args) {

// Create a Scanner object
Scanner input = new Scanner(System.in);

// Declare two variables
int choice;
int score = 0;

// Print out a welcome message to the user
System.out.println("Welcome to Project Play");

// Create a while loop that will continue running until the user selects 0
while(choice != 0) {

// Print out the menu for the user
System.out.println("\nPlease select an option:");
System.out.println("1. Math game");
System.out.println("2. Hangman");
System.out.println("3. Trivia");
System.out.println("0. Exit");

// Ask the user to make a selection
System.out.print("\nEnter your choice: ");

// Store the selection in a variable
choice = input.nextInt();

// If the user selects the math game option
if(choice == 1) 
{

// Create a new instance of the math game
MathGame mg = new MathGame();

// Run the run method of the game
mg.run();

// Update the score of the user
score += mg.getScore();

System.out.println("\nYour score is now " + score);

}

// If the user selects the hangman option
else if (choice == 2) 
{

// Create a new instance of the hangman game
Hangman hm = new Hangman();

// Run the run method of the game
hm.run();

// Update the score
score += hm.getScore();

System.out.println("\nYour score is now " + score);

}

// If the user selects the trivia option
else if(choice == 3) 
{

// Create a new instance of the trivia game
Trivia tr = new Trivia();

// Run the run method of the game
tr.run();

// Update the score
score += tr.getScore();

System.out.println("\nYour score is now " + score);

}

// If the user selects the exit option
else if(choice == 0) 
{

// Print a goodbye message
System.out.println("\nThank you for playing Project Play. Goodbye!");

break;

}

}

}

// MathGame class
private class MathGame {

// Variables
int score;

// Method to run the game
public void run() {

// Create a Scanner object
Scanner input = new Scanner(System.in);

// Ask the user for two random numbers
System.out.print("Enter two random numbers: ");

// Store the two numbers in variables
int a = input.nextInt();
int b = input.nextInt();

// Print out the math equation
System.out.println(a + " + " + b);

// Ask the user for the answer
System.out.print("What is the answer? ");

// Store the answer in a variable
int answer = input.nextInt();

// Check if the answer is correct
if(answer == (a + b)) 
{

// Increase the score
score++;

// Print out a success message
System.out.println("Correct! Your score is now " + score);

} 

else 
{

// Print out a failure message
System.out.println("Incorrect. The correct answer was " + (a + b) +
". Your score is still " + score);

}

}

// Method to get the score
public int getScore() {

return score;

}

}

// Hangman class
private class Hangman {

// Variables
int score;

// Method to run the game
public void run() {

// Ask the user to guess a letter
System.out.print("Guess a letter: ");

// Get the user's input
Scanner input = new Scanner(System.in);
String letter = input.nextLine();

// Check if the letter is correct
if(letter.equals("a")) 
{

// Increase the score
score++;

// Print out a success message
System.out.println("Correct! Your score is now " + score);

} 

else 
{

// Print out a failure message
System.out.println("Incorrect. The correct answer was 'a'. Your score is still " + score);

}

}

// Method to get the score
public int getScore() {

return score;

}

}

// Trivia class
private class Trivia {

// Variables
int score;

// Method to run the game
public void run() {

// Ask the user a trivia question
System.out.println("What is the capital of France?");

// Get the user's input
Scanner input = new Scanner(System.in);
String answer = input.nextLine();

// Check if the answer is correct
if(answer.equalsIgnoreCase("Paris")) 
{

// Increase the score
score++;

// Print out a success message
System.out.println("Correct! Your score is now " + score);

} 

else 
{

// Print out a failure message
System.out.println("Incorrect. The correct answer was 'Paris'. Your score is still " + score);

}

}

// Method to get the score
public int getScore() {

return score;

}

}

}