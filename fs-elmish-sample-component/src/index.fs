module ElmishComponent

open Fable.React

type Props = {
    src : string option
}
type CounterComponent(props : Props) as self=
    inherit Component<Props,Counter.Model>(props) with
    do self.setInitState (Counter.init props.src)
    member __.update msg =
        let state' = Counter.update msg self.state
        self.setState (fun _ _ -> state')
    override __.render() =
        Counter.view self.state self.update
