//8. Для заданного списка слов найти слова, не содержащие буквы Е

open System

[<EntryPoint>]
let main argv =

  let symbol = argv.[0]

  argv.[1..]
    |> Array.toList
    |> List.filter (fun word -> String.forall (fun c -> Convert.ToString(c) <> symbol) word)
    |> List.iter (fun word -> Console.WriteLine word)

  0;;
