module ElmishComponent

// For Fable 3
open Fable.React

open Counter

type Props = {
    src : string option
}
type CounterComponent(props : Props) as self=
    inherit Component<Props,Counter.Model>(props) with
    do self.setInitState (Counter.init props.src)
    override __.render() =
        Counter.view self.state ignore

