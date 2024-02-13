package main

import (
	"fmt"
	"strconv"
	"strings"
)

func isValidIPv4Address(ip string) bool {
	octets := strings.Split(ip, ".")

	if len(octets) != 4 {
		return false
	}

	for _, octetStr := range octets {
		octet, err := strconv.Atoi(octetStr)
		if err != nil {
			return false
		}

		if octet < 0 || octet > 255 {
			return false
		}

		if len(octetStr) > 1 && octetStr[0] == '0' {
			return false
		}
	}

	return true
}

func main() {
	validIP := "192.168.1.1"
	invalidIP := "256.0.0.1"

	fmt.Printf("%s is valid: %t\n", validIP, isValidIPv4Address(validIP))
	fmt.Printf("%s is valid: %t\n", invalidIP, isValidIPv4Address(invalidIP))
}

