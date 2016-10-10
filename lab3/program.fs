//8. В массиве все элементы, стоящие после максимального, уменьшить на 1.
//Пример: из массива A[5]: 3 2 1 5 4 должен получиться массив 3 2 1 5 3.

open System

[<EntryPoint>]
let main argv =

  let mas =
    argv
      |> Array.map (fun x -> Int32.Parse x)

  let max =
    mas
      |> Array.max

  let index =
    mas
      |> Array.findIndex(fun x -> x = max)

  mas.[index + 1..]
    |> Array.map (fun x -> x - 1)
    |> Array.append mas.[0..index]
    |> Array.iter (fun x -> Console.WriteLine(x))

  0;




