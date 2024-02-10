package main

import (
	"fmt"
	"strings"
)

func modifyString(input string) string {
	words := strings.Fields(input)
	var result string

	for _, word := range words {
		modifiedWord := ""
		for i, char := range word {
			if i%2 == 0 {
				modifiedWord += strings.ToUpper(string(char))
			} else {
				modifiedWord += strings.ToLower(string(char))
			}
		}
		result += modifiedWord + " "
	}

	return strings.TrimSpace(result)
}

func main() {
	fmt.Println(modifyString("String"))            // Output: "StRiNg"
	fmt.Println(modifyString("Weird string case")) // Output: "WeIrD StRiNg CaSe"
}
