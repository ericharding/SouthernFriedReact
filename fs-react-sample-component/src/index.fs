module FancyComponent


open Fable.Import.React
open Fable.Helpers.React
// For Fable.React version 5
// open Fable.React

type JSComponentProps = {
    name : string
}
type FSComponent(props : JSComponentProps) as self=
    inherit PureComponent<JSComponentProps,obj>(props) with
    do self.setInitState()
    override __.render() =
        div [] [str (sprintf "Hello %s" props.name)]

