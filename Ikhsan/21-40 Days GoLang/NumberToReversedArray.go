package main

import "fmt"

func digitize(n int) []int {
  var result []int
  
  if n == 0 {
    return []int{0}
  }

  for n > 0 {
    digit := n % 10
    result = append(result, digit)
    n /= 10
  }
  
  return result
}


func main() {
  fmt.Println(digitize(132))
}
