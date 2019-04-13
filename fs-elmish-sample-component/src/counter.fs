module Counter

open Fable.React
open Fable.React.Props

type Model = {
  image : string
  angle : float
}

type Msg =
  | Left of float
  | Right of float
  | Reset

let init img =
  let img = defaultArg img "https://southernfriedfsharp.com/sfflogo_large2.png"
  { image = img; angle = 0.0 }

let update msg model =
  match msg with
  | Left a -> { model with angle = model.angle - a }
  | Right a -> { model with angle = model.angle + a }
  | Reset -> { model with angle = 0.0 }


let view (model:Model) dispatch =
  div[] [
    button [OnClick (fun _ -> dispatch (Left 10.))] [str "Left"]

    img [
      Src model.image
      Style [ 
        Width 200
        Height 200
        Transform (sprintf "rotate(%fdeg)" model.angle) ] ]

    button [OnClick (fun _ -> dispatch (Right 10.))] [str "Right"]
    button [OnClick (fun _ -> dispatch Reset)] [str "Center"]
  ]
