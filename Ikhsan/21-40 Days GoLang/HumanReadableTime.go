package main

import "fmt"

func HumanReadableTime(seconds int) string {
  if seconds < 0 || seconds > 359999 {
	return "Invalid input"
  }

  hours := seconds / 3600
  seconds %= 3600
  minutes := seconds / 60
  seconds %= 60

  return fmt.Sprintf("%02d:%02d:%02d", hours, minutes, seconds)
}

func main() {
  fmt.Println(HumanReadableTime(5)) // 00:00:05
  fmt.Println(HumanReadableTime(60)) // 00:01:00
}
