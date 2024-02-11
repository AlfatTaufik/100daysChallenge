package main

import (
	"fmt"
	"strings"
)
func FirstNonRepeating(str string) string {
	s := strings.ToLower(str)

	for i := 0; i < len(s); i++ {
		st := string(s[i])
		if strings.Index(s, st) == strings.LastIndex(s, st) {
			return string(str[i])
		}
	}
	return ""
}

func main() {
	fmt.Println(FirstNonRepeating("sTreSS")) // outpu: T
}
