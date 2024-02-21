package main

import "fmt"

func CountOnes(left, right uint64) uint64 {
  result := uint64(0)
	bit := uint64(1)

	for bit <= right {
		onesBefore := (right / (bit * 2)) * bit
		mod := right % (bit * 2)
		onesInCurrent := uint64(0)

		if mod >= bit {
			onesInCurrent = mod - bit + 1
		}

		result += onesBefore + onesInCurrent

		bit *= 2
	}

	if left > 1 {
		result -= CountOnes(1, left-1)
	}

	return result
}

func main() {
    fmt.Println(CountOnes(5, 7)) // uint64(7)
    fmt.Println(CountOnes(12, 29)) // uint64(51)
}
