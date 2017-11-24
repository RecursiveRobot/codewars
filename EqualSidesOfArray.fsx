open System

let indexIsEven (items: int array) (index: int) =
    let left = items |> Array.take index |> Array.append [|0|]
    let right = items |> Array.skip (Math.Min(index + 1, items.Length)) |> Array.append [|0|]
    Array.sum left = Array.sum right

let findEvenIndex (items : int array) = 
    let evenIndices = 
        [|0..items.Length|]
        |> Array.filter (indexIsEven items)
    
    if evenIndices.Length = 0 then -1 else Seq.min evenIndices

findEvenIndex [|1; 2; 3; 4; 3; 2; 1|]