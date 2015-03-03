namespace FizzBuzz

module PatternMatching =
    let numbers = [1..100]
    
    let buzzer number = 
        match number with
        | _ when number % 15 = 0 -> printf "FizzBuzz\n"
        | _ when number % 5 = 0 -> printf "Buzz\n"
        | _ when number % 3 = 0 -> printf "Fizz\n"
        | _ -> printf "%i\n" number

    numbers |> List.iter buzzer