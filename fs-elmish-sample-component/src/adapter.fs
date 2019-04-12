module Adapter
open Fable.React

type GenericComponent<'p,'s,'m>(init:'p->'s,update:'m->'s->'s,view,props) as self =
    inherit Component<'p,'s>(props) with
    do self.setInitState (init props)
    member __.update msg =
        let state' = update msg self.state
        self.setState (fun _ _ -> state')
    override __.render() =
        view self.state self.update

let toComponent init update view props =
    GenericComponent(init,update,view,props)