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


(* Some notes:

Resetting the state (calling init) when the props change is not exactly right.
It probably makes more sense to model the props change the way Program.toNavigable handles url changes
and have a function to let you incorporate the new props into the current model.

It might make more sense to wrap a Program rather than an (init,update,view). Not sure if this would make the resulting js larger.

lazyView does a lot of what this does.  Possibility to share funtionality there?

*)