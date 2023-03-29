namespace library2


open Zanaptak.TypedCssClasses

type Bootstrap = CssClasses<"https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css", Naming.PascalCase>

open Giraffe.ViewEngine

open library1

module Say =
    let hello name =
        Something.something 
            <| div [] [
                h1 [] [ str "Hello" ]
                h2 [] [ str name ]
            ]
