import java.util.Scanner; 

public class ProjectPlay { 

  public static void main(String[] args) { 
  
    Scanner scan = new Scanner(System.in); 

    String gameName; 
    int score; 

    System.out.println("Welcome to Project Play!"); 
    System.out.println("Please enter the game you would like to play: "); 
    gameName = scan.nextLine(); 

    if (gameName.equals("Rock, Paper, Scissors")) { 
    
      System.out.println("You have selected Rock, Paper, Scissors. Please enter your score to start the game: "); 
      score = scan.nextInt(); 

      int cpuScore = 0; 
      int userScore = 0; 

      while (userScore < 5 && cpuScore < 5) { 
      
        if (score > cpuScore) { 
          System.out.println("You won this round!"); 
          userScore++; 
        } 
        else if (score < cpuScore) { 
          System.out.println("You lost this round. Try again!"); 
          cpuScore++; 
        } 
        else { 
          System.out.println("It's a tie! Play again to break the tie!"); 
        }
        
        System.out.println("Please enter your score to start the next round: "); 
        score = scan.nextInt(); 
      } 

      if (userScore == 5) { 
        System.out.println("Congratulations! You beat the computer!"); 
      } 
      else { 
        System.out.println("Sorry, the computer won this time. Better luck next time!"); 
      } 
    }

    else if (gameName.equals("Tic-Tac-Toe")) { 
    
      System.out.println("You have selected Tic-Tac-Toe. Please enter your score to start the game: "); 
      score = scan.nextInt(); 

      int cpuScore = 0; 
      int userScore = 0; 

      while (userScore < 5 && cpuScore < 5) { 
      
        if (score > cpuScore) { 
          System.out.println("You won this round!"); 
          userScore++; 
        } 
        else if (score < cpuScore) { 
          System.out.println("You lost this round. Try again!"); 
          cpuScore++; 
        } 
        else { 
          System.out.println("It's a tie! Play again to break the tie!"); 
        }
        
        System.out.println("Please enter your score to start the next round: "); 
        score = scan.nextInt(); 
      } 

      if (userScore == 5) { 
        System.out.println("Congratulations! You beat the computer!"); 
      } 
      else { 
        System.out.println("Sorry, the computer won this time. Better luck next time!"); 
      } 
    }

    else if (gameName.equals("Connect Four")) { 
    
      System.out.println("You have selected Connect Four. Please enter your score to start the game: "); 
      score = scan.nextInt(); 

      int cpuScore = 0; 
      int userScore = 0; 

      while (userScore < 5 && cpuScore < 5) { 
      
        if (score > cpuScore) { 
          System.out.println("You won this round!"); 
          userScore++; 
        } 
        else if (score < cpuScore) { 
          System.out.println("You lost this round. Try again!"); 
          cpuScore++; 
        } 
        else { 
          System.out.println("It's a tie! Play again to break the tie!"); 
        }
        
        System.out.println("Please enter your score to start the next round: "); 
        score = scan.nextInt(); 
      } 

      if (userScore == 5) { 
        System.out.println("Congratulations! You beat the computer!"); 
      } 
      else { 
        System.out.println("Sorry, the computer won this time. Better luck next time!"); 
      } 
    }

    else { 
      System.out.println("Sorry, that game is not available."); 
    } 
  } 
}