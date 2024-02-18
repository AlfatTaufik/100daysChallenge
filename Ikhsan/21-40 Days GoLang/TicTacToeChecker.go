package main

import "fmt"

func checkTicTacToe(board [][]int) int {
	// Check rows & columns
	for i := 0; i < 3; i++ {
		if board[i][0] == board[i][1] && board[i][1] == board[i][2] {
			if board[i][0] != 0 {
				return board[i][0]
			}
		}
		if board[0][i] == board[1][i] && board[1][i] == board[2][i] {
			if board[0][i] != 0 {
				return board[0][i]
			}
		}
	}

	// Check diagonals
	if board[0][0] == board[1][1] && board[1][1] == board[2][2] {
		if board[0][0] != 0 {
			return board[0][0]
		}
	}
	if board[0][2] == board[1][1] && board[1][1] == board[2][0] {
		if board[0][2] != 0 {
			return board[0][2]
		}
	}

	// check unfinished
	for i := 0; i < 3; i++ {
		for j := 0; j < 3; j++ {
			if board[i][j] == 0 {
				return -1
			}
		}
	}

	// draw
	return 0
}

func main() {
	board1 := [][]int{
		{0, 0, 1},
		{0, 1, 2},
		{2, 1, 0},
	}
	fmt.Println(checkTicTacToe(board1)) // Output: -1

	board2 := [][]int{
		{1, 1, 1},
		{0, 2, 0},
		{2, 0, 2},
	}
	fmt.Println(checkTicTacToe(board2)) // Output: 1

	board3 := [][]int{
		{1, 1, 2},
		{0, 2, 0},
		{2, 1, 1},
	}
	fmt.Println(checkTicTacToe(board3)) // Output: 2

	board4 := [][]int{
		{1, 2, 1},
		{2, 1, 2},
		{2, 1, 2},
	}
	fmt.Println(checkTicTacToe(board4)) // Output: 0
}

