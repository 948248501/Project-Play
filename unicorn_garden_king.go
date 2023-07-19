package main

import (
	"fmt"
	"strings"
)

// Variables
var board [9][9]string

// Main
func main() {
	// Initialize board
	initBoard()

	// Draw the board
	drawBoard()

	// Start playing
	fmt.Println("Let's play!")
	playGame()
}

// Initialize board
func initBoard() {
	// Reset board
	for i := 0; i < 9; i++ {
		for j := 0; j < 9; j++ {
			board[i][j] = "-"
		}
	}
}

// Draw board
func drawBoard() {
	// Loop over board and draw it
	for i := 0; i < 9; i++ {
		// Create a new line
		var line []string
		for j := 0; j < 9; j++ {
			// Add each position to line
			line = append(line, board[i][j])
		}
		// Print out the line
		fmt.Println(strings.Join(line, " "))
	}
}

// Play the game
func playGame() {
	// Loop until we find a winner
	for {
		// Get the user input
		var row, column int
		fmt.Print("Enter row and column: ")
		fmt.Scan(&row, &column)

		// Update the board
		board[row][column] = "X"

		// Draw the board
		drawBoard()

		// Check for a winner
		if checkForWin() {
			fmt.Println("You win!")
			break
		}
	}
}

// Check for a winner
func checkForWin() bool {
	// Initialize variables
	var row, column, diagonal1, diagonal2 int

	// Loop over the board to check for three in a row
	for i := 0; i < 9; i++ {
		for j := 0; j < 9; j++ {
			// Check for three in a row
			if board[i][j] == "X" {
				row++
			}
			if board[j][i] == "X" {
				column++
			}
			if board[i][i] == "X" {
				diagonal1++
			}
			if board[i][8-i] == "X" {
				diagonal2++
			}

			// Check for a win
			if row == 3 || column == 3 || diagonal1 == 3 || diagonal2 == 3 {
				return true
			}
		}
		// Reset variables
		row, column, diagonal1, diagonal2 = 0, 0, 0, 0
	}
	return false
}