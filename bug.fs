let mutable x = 10

let addOne x = x + 1

let y = addOne x

printf "%d %d" x y // prints 10 11

x <- 20 // changed value of x

printf "%d" x //prints 20

//But the value of y is not updated.  Immutability of y is not immediately apparent when using mutable variables.