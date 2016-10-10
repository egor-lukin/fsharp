//8. Для данного текстового файла проверить следующую гипотезу: «Самые часто встречающиеся согласные – это К, В, П»

open System
open System.IO

[<EntryPoint>]
let main argv =

  let cons = ['Б'; 'В'; 'Г'; 'Д'; 'Ж'; 'З'; 'Й'; 'К'; 'Л'; 'М'; 'Н'; 'П'; 'Р'; 'С'; 'Т'; 'Ф'; 'Х'; 'Ц'; 'Ч'; 'Ш';'Щ']

  let symbols =
    "file.txt"
      |> File.ReadLines
      |> String.Concat
      |> List.ofSeq
      |> List.map (fun ch -> Char.ToUpper ch)

  let compareChars x y =
    match compare x y with
    | 0 -> true
    | _ -> false

  cons
    |> List.map (fun x -> (x, 0))
    |> List.map (fun tuple ->
      let counter = List.fold (fun acc ch -> if compareChars (fst tuple) ch then acc + 1 else acc) 0 symbols
      (fst tuple, counter))
    |> List.sortBy (fun t -> - snd t)
    |> List.filter (fun t -> snd t <> 0)
    |> List.iter (fun x -> Console.WriteLine(x))

  0;;
