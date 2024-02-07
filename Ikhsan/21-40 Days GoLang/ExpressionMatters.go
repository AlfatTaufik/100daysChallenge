package main

import (
	"fmt"
)

func max(a, b int) int {
	if a > b {
		return a
	}
	return b
}

func expressionsMatter(a, b, c int) int {
	result1 := a * (b + c)
	result2 := a * b * c
	result3 := a + b * c
	result4 := (a + b) * c
	result5 := a + b + c

	return max(max(max(max(result1, result2), result3), result4), result5)
}

func main() {
	fmt.Println(expressionsMatter(1, 2, 3)) // Output: 9
	fmt.Println(expressionsMatter(1, 1, 1)) // Output: 3
	fmt.Println(expressionsMatter(9, 1, 1)) // Output: 18
}
