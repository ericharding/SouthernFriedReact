module FancyComponent

open Fable.React

(*
// Use these imports if you are targeting Fable 2.0.3 (stable)
open Fable.Import.React
open Fable.Helpers.React
*)

type JSComponentProps = {
    name : string
}
type FSComponent(props : JSComponentProps) as self=
    inherit PureComponent<JSComponentProps,obj>(props) with
    do self.setInitState()
    override __.render() =
        div [] [str (sprintf "Hello %s" props.name)]

