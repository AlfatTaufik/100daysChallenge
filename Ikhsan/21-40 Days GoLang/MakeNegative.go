package main

import (
	"fmt"
)

func MakeNegative(number int) int {
	if number > 0 {
		return -number
	}
	return number
}

func main() {
	fmt.Println(MakeNegative(1))  // Output: -1
	fmt.Println(MakeNegative(-5)) // Output: -5
	fmt.Println(MakeNegative(0))  // Output: 0
}
