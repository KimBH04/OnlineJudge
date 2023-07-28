package main

import "fmt"

func main() {
	var n int
	fmt.Scanln(&n)
	for i := 1; i < n; i++ {
		fmt.Print(i, " ")
		if i%6 == 0 {
			fmt.Print("Go! ")
		}
	}
	fmt.Println(n, "Go!")
}
