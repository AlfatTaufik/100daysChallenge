package main

import "fmt"

func FoldArray(arr []int, runs int) []int {
	result := make([]int, len(arr))

	for i := 0; i < len(arr); i++ {
		result[i] = arr[i]
	}

	for run := 0; run < runs; run++ {
		newLength := (len(result) + 1) / 2
		folded := make([]int, newLength)

		for i := 0; i < newLength; i++ {
			if i == len(result)-1-i {
				folded[i] = result[i]
			} else {
				folded[i] = result[i] + result[len(result)-1-i]
			}
		}

		result = folded
	}

	return result
}

func main() {
	arr := []int{1, 2, 3, 4, 5}
	runs := 1
	fmt.Println(FoldArray(arr, runs)) // Output: [6 6 3]

	runs = 2
	fmt.Println(FoldArray(arr, runs)) // Output: [9 6]
}

