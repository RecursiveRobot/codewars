open System.Numerics 

let fibonacci = Seq.unfold (fun (n0, n1) -> Some(n1, (n1, n0 + n1))) (0I,1I)

let perimeter (n: BigInteger): BigInteger =
  4I * (fibonacci |> Seq.take ((int)n+1) |> Seq.sum)

perimeter 5I