module FancyComponent

open Fable.React

type JSComponentProps = {
    name : string
}
type FSComponent(props : JSComponentProps) as self=
    inherit PureComponent<JSComponentProps,obj>(props) with
    do self.setInitState()
    override __.render() =
        div [] [str (sprintf "Hello %s" props.name)]

