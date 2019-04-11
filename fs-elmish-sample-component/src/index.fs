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


type GenericComponent<'a>(init,update,view,props) as self =
    inherit Component<Props,'a>(props) with
    do self.setInitState (init props.src)
    member __.update msg =
        let state' = update msg self.state
        self.setState (fun _ _ -> state')
    override __.render() =
        view self.state self.update

let private toComponent init update view props =
    GenericComponent(init,update,view,props)

let CounterComponent2 props = toComponent Counter.init Counter.update Counter.view props