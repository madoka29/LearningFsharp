
// Learn more about F# at http://fsharp.org

/// おみくじを引く
open System

[<EntryPoint>]
let main argv =
    
    printfn "おみくじを引きますか？ yes => 0 no => 1"
    let command = Console.ReadLine()
    
    match command with
    | "0" -> printfn "おみくじを引きます..."
             let omikujiList = ["ハッピー！"; "ちょいハッピー"; "ハッピーなような？"]
             let rand = new Random();
             let omikuji = rand.Next(0, 2);
             let result = omikujiList.[omikuji]

             printfn "あなたの今日の運勢は「%s」です！" result
             
    | "1" -> printfn "おみくじを引きません"
    | _ -> ()

    0 // return an integer exit code