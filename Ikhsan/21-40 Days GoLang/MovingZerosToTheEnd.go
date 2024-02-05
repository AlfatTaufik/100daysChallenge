package main

import "fmt"

func MoveZeros(arr []int) []int {
    nonZeroIndex := 0

    for _, num := range arr {
        if num != 0 {
            arr[nonZeroIndex] = num
            nonZeroIndex++
        }
    }

    for i := nonZeroIndex; i < len(arr); i++ {
        arr[i] = 0
    }

    return arr
}

func main() {
    input := []int{1, 2, 0, 1, 0, 1, 0, 3, 0, 1}
    result := MoveZeros(input)

    fmt.Println(result) // [1 2 1 1 3 1 0 0 0 0]
}
