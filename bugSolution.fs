let mutable x = ref 10

let addOne xRef = 
  let newValue = !xRef + 1
  xRef := newValue
  newValue

let y = addOne x

printf "%d %d" !x y // prints 11 11

x := 20

printf "%d" !x //prints 20

printf "%d" y //prints 11

//Alternatively, we can use a mutable record:

type MyRecord = { mutable value: int }

let mutable xRecord = { value = 10 }

let addOneRecord xRecord = 
    xRecord.value <- xRecord.value + 1
    xRecord.value

let yRecord = addOneRecord xRecord

printf "%d %d" xRecord.value yRecord //prints 11 11

xRecord.value <- 20

printf "%d %d" xRecord.value yRecord //prints 20 11