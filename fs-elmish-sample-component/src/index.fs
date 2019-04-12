module ElmishComponent

open Fable.React

type Props = {
    src : string option
}

type ManualImgSpinner(props : Props) as self=
    inherit Component<Props,Counter.Model>(props) with
    do self.setInitState (Counter.init props.src)
    member __.update msg =
        let state' = Counter.update msg self.state
        self.setState (fun _ _ -> state')
    override __.render() =
        Counter.view self.state self.update

let ImgSpinner props = Adapter.toComponent (fun p -> Counter.init p.src) Counter.update Counter.view props