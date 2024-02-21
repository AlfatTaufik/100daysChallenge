package main

import (
  "strings"
  "sort"
  "fmt"
)

func TwoSort(arr []string) string {
  sort.Strings(arr)

  firstString := arr[0]

  result := strings.Join(strings.Split(firstString, ""), "***")

  return result
}

func main(){
  s := []string{"banana","adalah","pisang","di","bahasa","inggris"}
  fmt.Println(TwoSort(s))
}
