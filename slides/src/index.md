- title : Publish React Components with F#
- description : Southern Fried F# Talk - Publish React Components with Fable
- author : Eric Harding
- theme : night
- transition : default

***
<!-- theme: sky -->

## Publish React Components with Fable

> Eric Harding  
@digitalsorcery  
https://blog.digitalsorcery.net


![BTS](images/BTS.svg)
![SFF](images/sfflogo.png)

<!-- 
BTS is a local company building tools for futures and options traders
use fable in production
SFF is a local meetup, come join us.
-->

***

## First, 
### a little background...

<!-- 
I'm going to be talking about several technologies
and I want to make sure everyone has, at least, a passing familiarity
 -->

---

## What is React?
- Component based JavaScript view library
- Pioneer of the pure view function

---

## What is F#?

<!--
We're about 7 talks into an F# conference...
I hope we're all on the same page about this by now
-->

---

## What is Babel?

- Babel is a JavaScript to JavaScript compiler (Wait, what?)
- Lets you use new JavaScript syntax on older browsers

![Compiling](images/compiling.png)

<!--
Fable transforms the F# AST to the Babel AST
-->

--- 

## What is Fable?

- Fable is an F# to JavaScript compiler powered by [Babel](https://babeljs.io/)
- Fable is not **.NET** in the browser (see [Bolero](https://github.com/fsbolero/Bolero))
- Fable leverages the **JavaScript** ecosystem

<!-- 
Fable is part of the JavaScript world
Anything you can do with JavaScript you can do with F#
-->

---

## What is Elmish?
- Brings the MVU / [Elm](https://elm-lang.org/) programming model to F#
- The recommended _(but not only)_ way to build UI with Fable
  * Specifically: **Fable.Elmish.React**
- The **E** in [S.A.F.E](https://safe-stack.github.io/) stack
- Also used in [Fabulous](https://fsprojects.github.io/Fabulous/)

<!--
Why is it recommended? Because it's awesome.
-->

---

## What is NPM?
- The package manager for JavaScript
- [npmjs.com](http://npmjs.com) is the repository
- **Yarn** is an alternative front end

***

## OK, now what?

---
Oh, yea

---

Lets
## Publish React Components with Fable
- Create a React component
- Test it (hopefully?)
- Publish it on NPM

<!-- 
Fable is general purpose
Anything you can do with JavaScript you can also do with F#
-->

***

# But Why? 
- Is this a good idea?

<!-- 
I may be biased...
I think there are several reasons you might want to do this
-->

---

## Full Participation
- Fable 1.0 was released in [2017](https://fable.io/blog/Introducing-1-0-beta.html)
- Fable leverages JavaScript ecosystem to great effect
- Mostly a "read only" member of the larger JavaScript community

<!-- 
Fable is only a few years old
In those years the Fable community has built on top of high quality JavaScript packages like Babel and React
Fable packages are mostly for consumption by Fable but they don't have to be
 -->

---

## Try Before you Buy

- Elmish is amazing for green field work
- We don't always have that luxury

<!--
I wouldn't choose anything else for a green field web project
-->

---
## Low Risk
- Write a single component in F#
- Team doesn't even need Fable

  
> The secret to building large apps is never to build large apps. - *Justin Meyer*

<!--
Easy to justify
-->

---
## Spread F#
1. Publish something useful.
2. Wait for users to look at the source.
3. Some will learn enough to contribute back.

<!-- 
low key
JavaScript community may be more open to functional programming ideas than .NET
-->


***

# But How?

---

### I'm glad you asked.

---

## React in F#

    open Fable.React
    type Props = {
        name : string
    }
    type FSComponent(props : Props) as self =
        inherit PureComponent<Props,unit>(props) with
        do self.setInitState()
        override __.render() =
            div [] [str (sprintf "Hello %s" props.name)]

<!-- 
- Different namespaces in fable 2.x
- package.json, webpack.config.js
 -->

<!-- ### A Note About Webpack
- Little bit of a dark art
![witches](https://i.pinimg.com/originals/8e/d2/08/8ed208270ed9981b642c700bf2cacd57.gif) -->

***

## The End

- Slides available at [https://github.com/ericharding/SouthernFriedReact](https://github.com/ericharding/SouthernFriedReact)
