namespace library1

open Zanaptak.TypedCssClasses
open Giraffe.ViewEngine

type Bootstrap = CssClasses<"https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css", Naming.PascalCase>


module Something =
    let something body =
        div [ _class Bootstrap.Card ] [
            div [ _class Bootstrap.CardBody ] [
                h5 [ _class Bootstrap.CardTitle ] [ str "A clever title" ]
                p [ _class Bootstrap.CardText ] [ str "Lorem ipsum dolor sit amet." ]
                body
            ]
        ]