let rotateString (s: string) = s.Substring(1) + s.Substring(0, 1)

let rotateNumber (number: int) (skipCount: int)  =
    let s = number |> string
    let s1 = s.Substring(0, skipCount)
    let s2 = s.Substring(skipCount) |> rotateString
    (s1 + s2) |> int

let maxRot (n: int) =
    List.unfold (fun (n0, i) -> 
        if i < n0.ToString().Length then 
            Some( rotateNumber n0 i, (rotateNumber n0 i, i + 1) )
        else 
            None) (n, 0)
    |> List.append [n]
    |> List.max