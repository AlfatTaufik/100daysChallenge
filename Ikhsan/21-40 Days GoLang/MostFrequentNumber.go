package main

import "fmt"

func mostFrequent(arr []int) int {
	counts := make(map[int]int)
	for _, num := range arr {
		counts[num]++
	}

	var maxFreq, mostFrequentNumber int
	for num, freq := range counts {
		if freq > maxFreq || (freq == maxFreq && num > mostFrequentNumber) {
			maxFreq = freq
			mostFrequentNumber = num
		}
	}

	return mostFrequentNumber
}

func main() {
	arr1 := []int{12, 10, 8, 12, 7, 6, 4, 10, 12}
	arr2 := []int{12, 10, 8, 12, 7, 6, 4, 10, 12, 10}
	arr3 := []int{12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10}

	result1 := mostFrequent(arr1)
	result2 := mostFrequent(arr2)
	result3 := mostFrequent(arr3)

	fmt.Println(result1) // Output: 12
	fmt.Println(result2) // Output: 12
	fmt.Println(result3) // Output: 3
}


