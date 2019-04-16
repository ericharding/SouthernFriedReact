module ElmishComponent

open Fable.React

type Props = {
    src : string option
}

let ImgSpinner props = Adapter.toComponent (fun p -> Counter.init p.src) Counter.update Counter.view props

//Note: see caveats on Props from the react sample index.fs
