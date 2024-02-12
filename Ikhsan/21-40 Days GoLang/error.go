package main

import (
	"errors"
	"fmt"
)

func Pembagian(nilai, pembagi int) (int, error) {
	if pembagi == 0 {
		return 0, errors.New("Pembagian Dengan NOL")
	} else {
		return nilai / pembagi, nil
	}
}

func main() {
	hasil, err := Pembagian(100, 10)
	if err == nil {
		fmt.Println("Hasil", hasil)
	} else {
		fmt.Println("Errors",  err.Error())
	}
}
