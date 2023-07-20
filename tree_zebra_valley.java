// Main file
public class ProjectPlay {
	public static void main(String[] args) {
		System.out.println("Welcome to Project Play!");
		
		GameEngine engine = new GameEngine();
		engine.startGame();
	}
}

//GameEngine.java
public class GameEngine { 
	public void startGame() {
		System.out.println("Game starting...");
		
		// Create players
		Player p1 = new Player("John");
		Player p2 = new Player("Sarah");
		
		// Start game loop
		while (!p1.isGameOver() && !p2.isGameOver()) {
			// Player 1 turn
			System.out.println("It is " + p1.getName() + "'s turn");
			p1.makeMove();
			if (p1.isGameOver()) {
				break;
			}
			
			// Player 2 turn
			System.out.println("It is " + p2.getName() + "'s turn");
			p2.makeMove();
			if (p2.isGameOver()) {
				break;
			}
		}
		
		// Determine winner
		if (p1.isGameOver()) {
			System.out.println(p2.getName() + " wins!");
		} else if (p2.isGameOver()) {
			System.out.println(p1.getName() + " wins!");
		}
		
		System.out.println("Game over!");
	}
}

//Player.java
public class Player {
    private String name;
    private int score;
    private boolean gameOver;
    
    public Player(String name) {
        this.name = name;
        this.score = 0;
        this.gameOver = false;
    }
    
    public String getName() {
        return this.name;
    }
    
    public int getScore() {
        return this.score;
    }
    
    public void makeMove() {
        // Player logic for move goes here
        this.score += 10;
        
        // Check if game is over
        if (this.score >= 100) {
            this.gameOver = true;
        }
    }
    
    public boolean isGameOver() {
        return this.gameOver;
    }
}