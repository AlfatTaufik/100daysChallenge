package main

import "fmt"

func processStringWithBackspace(s string) string {
	stack := make([]rune, 0)

	for _, char := range s {
		if char == '#' {
			if len(stack) > 0 {
				stack = stack[:len(stack)-1]
			}
		} else {
			stack = append(stack, char)
		}
	}

	return string(stack)
}

func main() {
	fmt.Println(processStringWithBackspace("abc#d##c")) // Output: "ac"
	fmt.Println(processStringWithBackspace("abc##d######")) // Output: ""
	fmt.Println(processStringWithBackspace("#######")) // Output: ""
	fmt.Println(processStringWithBackspace("")) // Output: ""
}
