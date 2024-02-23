package main

import (
	"fmt"
	"sort"
)

func SortByLength(arr []string) []string {
	sort.Slice(arr, func(i, j int) bool {
		return len(arr[i]) < len(arr[j])
	})

	return arr
}

func main() {
	inputArray := []string{"Telescopes", "Glasses", "Eyes", "Monocles"}
	sortedArray := SortByLength(inputArray)

	fmt.Println(sortedArray) // [Eyes Glasses Monocles Telescopes]
}

