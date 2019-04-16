module ReactComponent

open Fable.Import.React
open Fable.Helpers.React
// For Fable.React version 5
// open Fable.React

type JSComponentProps = {
    name : string
}
type FSComponent(props : JSComponentProps) as self=
    inherit PureComponent<JSComponentProps,unit>(props) with
    do self.setInitState()
    override __.render() =
        div [] [str (sprintf "Hello %s" props.name)]


(* Notes

Props is a javascript object not a fable record so equality and reflection wont' work right.
It works for this purpose because it's close enough that we can pull the properties we want out and then get rid of the reference.
It probably makes more sense to declare it as an interface or specify ReferenceEquality (does that do anything in fable?)

*)