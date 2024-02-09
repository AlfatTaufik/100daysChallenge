package main

import (
  "fmt"
)

func splitIntoPairs(str string) []string {
  pairs := make([]string, 0, len(str)/2)
  for i := 0; i < len(str); i += 2 {
    if i+1 < len(str) {
      pairs = append(pairs, str[i:i+2])
    } else {
      pairs = append(pairs, string(str[i])+string('_'))
    }
  }
  return pairs
}

func main() {
  inputs := []string{"abc", "abcdef", "hello", "world"}
  for _, input := range inputs {
    fmt.Printf("Input: %s\n", input)
    fmt.Printf("Output: %v\n", splitIntoPairs(input))
  }
}
