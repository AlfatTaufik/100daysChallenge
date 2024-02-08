package main

import "fmt"

func FindEvenIndex(arr []int) int {
	totalSum := 0

	for _, num := range arr {
		totalSum += num
	}

	leftSum := 0
	for i, num := range arr {
		totalSum -= num
		// fmt.Println(totalSum)
		if leftSum == totalSum {
			// fmt.Println(i)
			return i
		}

		leftSum += num
	}
	// fmt.Println(-1)
	return -1
}

func main() {
	fmt.Println(FindEvenIndex([]int{8, 8}))                // -1
	fmt.Println(FindEvenIndex([]int{8, 0}))                // 0
	fmt.Println(FindEvenIndex([]int{0, 8}))                // 1
	fmt.Println(FindEvenIndex([]int{-3, 2, 1, 0}))         // 3
	fmt.Println(FindEvenIndex([]int{1, 2, 3, 4, 3, 2, 1})) // 3
}

/* Flownya gini
1. cek index ke n apakah sebelah kiri atau kanan dari index itu sama (dimulai dari index ke-0)
2. Jika sama return index ke n

ilustrasi:
1. array {-3, 2, 1, 0}
2. kiri index ke-0 itu 0, kanan index ke-0 itu {2,1,0} = 3
3. jika kedua sisi index ke-0 tidak sama, maka akan diteruskan hingga index ke-n
4. dari array itu yang menjadi kedudukannya adalah index ke-3
5. karena sisi kiri index ke-3 {-3,2,1} = 0 dan sisi kana index ke-3 {} = 0. Itu, makanya index ke-3 menjadi kedudukan kedua ruas tersebut
*/
