namespace App

open System
open Feliz
open Feliz.Router
open Browser.Dom
open Fable.Core
open Fable.Core.JsInterop

module AppHelper =

    [<Emit("__APP_NAME__")>]
    let __APP_NAME__ = jsNative

    [<Emit("__APP_VERSION__")>]
    let __VERSION__ : string = jsNative


type App =

    static member Icon(svgpaths: string, ?size: int, ?viewBox: (int * int * int * int), ?className: string) =
        let size = defaultArg size 24
        let viewBox = defaultArg viewBox (0, 0, 24, 24)

        Svg.svg [
            svg.xmlns "http://www.w3.org/2000/svg"
            svg.viewBox viewBox
            svg.width size
            svg.height size
            if className.IsSome then
                svg.className className.Value
            svg.custom ("dangerouslySetInnerHTML", {| __html = svgpaths |})
        ]

    static member IconRobotDead(?size: int, ?className: string) =
        App.Icon(
            """<rect width="24" height="24" fill="none" />
	<g fill="none" stroke="currentColor" stroke-width="1.5">
		<path d="M14.706 4.313H9.294a4.98 4.98 0 0 0-4.982 4.981v5.412a4.98 4.98 0 0 0 4.982 4.982h5.412a4.98 4.98 0 0 0 4.982-4.982V9.294a4.98 4.98 0 0 0-4.982-4.982Z" />
		<path d="M19.606 15.588h1.619a1.025 1.025 0 0 0 1.025-1.025V9.438a1.025 1.025 0 0 0-1.025-1.025h-1.62m-15.21 7.175h-1.62a1.025 1.025 0 0 1-1.025-1.025V9.438a1.025 1.025 0 0 1 1.025-1.025h1.62" />
		<path stroke-linecap="round" stroke-linejoin="round" d="M2.765 8.413v-4.1m18.46 4.1l-.01-4.1M9.897 9.372l-2.102 2.102m0-2.102l2.102 2.102m4.206-2.102l2.102 2.102m0-2.102l-2.102 2.102M9.899 16.1h4.1" />
	</g>""",
            ?size = size,
            ?className = className
        )

    static member IconRobotWink(?size: int, ?className: string) =
        App.Icon(
            """<rect width="24" height="24" fill="none" />
	<path fill="currentColor" d="M22.078 8.347a1.4 1.4 0 0 0-.488-.325V4.647a.717.717 0 1 0-1.434 0V7.85h-.21a5.48 5.48 0 0 0-5.25-3.92H9.427a5.48 5.48 0 0 0-5.25 3.92H3.9V4.647a.717.717 0 1 0-1.434 0v3.385a1.5 1.5 0 0 0-.469.315A1.72 1.72 0 0 0 1.5 9.552v4.896a1.7 1.7 0 0 0 1.702 1.702h.956a5.48 5.48 0 0 0 5.25 3.92h5.183a5.48 5.48 0 0 0 5.25-3.92h.955a1.7 1.7 0 0 0 1.702-1.702V9.552c.02-.44-.131-.872-.42-1.205M3.996 14.716H3.24a.27.27 0 0 1-.191-.077a.3.3 0 0 1-.076-.191V9.552a.26.26 0 0 1 .248-.268h.775a.6.6 0 0 0 0 .125v5.182a.6.6 0 0 0 0 .125m4.312-2.869v-1.96a.813.813 0 1 1 1.616 0v1.96a.813.813 0 1 1-1.616 0m6.283 3.662a3.605 3.605 0 0 1-5.068 0a.813.813 0 0 1 .885-1.326a.8.8 0 0 1 .262.179a2.017 2.017 0 0 0 2.773 0a.804.804 0 0 1 1.148 0a.813.813 0 0 1 0 1.157zm1.367-3.69h-1.913a.812.812 0 0 1-.574-1.385a.8.8 0 0 1 .574-.232h1.913a.805.805 0 0 1 .754 1.117a.81.81 0 0 1-.754.509zm5.182 2.62a.3.3 0 0 1-.076.19a.27.27 0 0 1-.191.077h-.756a.6.6 0 0 0 0-.124V9.37a.6.6 0 0 0 0-.124h.765a.25.25 0 0 1 .182.077c.048.052.076.12.076.19z" />""",
            ?size = size,
            ?className = className
        )

    static member IconDwarf(?size: int, ?className: string) =
        App.Icon(
            """<rect width="512" height="512" fill="none" />
	<path fill="currentColor" d="M240.028 26v221.481L257.065 256l17.037-8.519V26zM222.99 60.074c-80.22 0-136.297 56.077-136.297 136.296h119.26l17.037 17.037zm66.018 0v153.333l17.037-17.037h119.26c0-80.219-56.077-136.296-136.297-136.296M69.657 213.407v34.074h50.047l-33.01-34.074zm41.528 0l34.074 34.074h34.074l-34.074-34.074zm58.565 0l34.074 34.074h19.167v-8.518l-25.556-25.556zm144.815 0l-25.556 25.556v8.518h19.167l34.074-34.074zm52.176 0l-34.074 34.074h34.074l34.074-34.074zm58.565 0l-33.01 34.074h50.047v-34.074zM86.694 264.52v34.074l120.325 60.694l5.68-36.497l-100.449-41.234l-8.519-17.037zm321.575 0l-8.519 17.037l-100.448 41.234l5.68 36.497l120.324-60.694V264.52zm-168.241 2.13L222.99 366.74l34.074 17.037l34.074-17.037l-17.037-100.093l-17.037 8.519l-17.037-8.519zM78.176 314.564l-46.852 41.528v59.63l61.76-93.704zm355.648 0l-14.907 7.454l61.759 93.703v-59.63zm-324.768 15.972L40.907 432.759l64.954 44.722l58.565-119.259zm293.888 0l-55.37 27.685l58.565 119.26l64.954-44.723zm-222.546 35.139L120.768 486h89.445l12.778-51.111h25.555v-36.204zm151.204 0l-68.148 33.01v36.203h25.555L301.787 486h89.444z" />""",
            ?size = size,
            ?className = className,
            viewBox = (0, 0, 512, 512)
        )

    static member IconCog(?size: int, ?className: string) =
        App.Icon(
            """<rect width="512" height="512" fill="none" />
	<path fill="currentColor" d="M234.875 18.78c-26.087 2.367-51.557 8.56-74.875 18.782c15.37 32.763 14.222 66.706-6.72 82.407c-20.835 15.617-54.055 7.965-81.124-15.69c-16.246 19.452-29.336 41.36-38.875 65.626c33.83 12.333 56.635 37.665 52.94 63.5c-3.698 25.835-32.697 43.74-68.626 46.094c2.338 25.796 8.91 50.778 18.937 73.875c17.81-8.182 35.793-11.09 51.095-8.938c13.032 1.87 23.927 7.015 31.156 16.657c15.817 21.097 7.603 54.713-16.78 81.97c19.516 16.35 42.216 29.444 66.594 39.03c12.33-33.828 37.655-56.634 63.5-52.938c25.844 3.697 43.74 32.696 46.094 68.625c26.087-2.365 51.557-8.555 74.875-18.78c-15.766-32.997-14.26-67.588 6.843-83.406c9.64-7.23 22.568-9.022 35.594-7.125c15.112 2.16 31.19 10.25 45.563 22.78c16.088-19.345 29.4-41.51 38.875-65.594c-33.83-12.332-56.635-37.653-52.938-63.5c3.697-25.846 32.665-43.772 68.594-46.125c-2.36-25.944-8.774-50.663-18.906-73.874c-32.612 15.117-66.66 13.145-82.282-7.687c-15.696-20.944-7.252-53.86 16.688-81c-19.52-16.352-42.248-29.447-66.625-39.032c-12.332 33.828-37.657 56.66-63.5 52.968c-25.846-3.693-43.744-32.696-46.095-68.625zm21.656 95.126c79.626 0 144.376 64.752 144.376 144.375c0 79.626-64.75 144.376-144.375 144.376c-79.624 0-144.374-64.75-144.374-144.375c0-79.624 64.75-144.374 144.375-144.374zm0 18.688c-69.524 0-125.686 56.162-125.686 125.687s56.162 125.69 125.687 125.69s125.69-56.164 125.69-125.69c0-69.522-56.164-125.686-125.69-125.686zm.033 15.125c61.094 0 110.625 49.53 110.625 110.624c0 61.095-49.53 110.625-110.625 110.625s-110.625-49.53-110.625-110.626c0-61.095 49.53-110.625 110.625-110.625z" />""",
            ?size = size,
            ?className = className,
            viewBox = (0, 0, 512, 512)
        )

    static member IconLightBulb(?size: int, ?className: string) =
        App.Icon(
            """<rect width="24" height="24" fill="none" />
	<path fill="currentColor" d="M12.754 2.305a.75.75 0 0 0-1.5 0v1.48a.75.75 0 0 0 1.5 0zm5.111 7.99a5.9 5.9 0 0 0-1.11-2.22a6 6 0 0 0-1.91-1.59a6.2 6.2 0 0 0-2.38-.69a6 6 0 0 0-2.46.33a6 6 0 0 0-2.13 1.29a6.2 6.2 0 0 0-1.43 2a6 6 0 0 0-.49 2.43a6.09 6.09 0 0 0 2.41 5l.35.33c.3.31.3.31.29 1v.32a1.6 1.6 0 0 0 .1.65c.07.222.194.425.36.59q.114.117.25.21v1a1.38 1.38 0 0 0 1.26 1.5h2a1.39 1.39 0 0 0 1.27-1.5v-1a1.6 1.6 0 0 0 .25-.21c.157-.166.277-.364.35-.58a1.7 1.7 0 0 0 .1-.66v-.37c0-.55 0-.55.31-.9l.38-.35a6.17 6.17 0 0 0 2.33-4.07a5.9 5.9 0 0 0-.1-2.51m-5.07 10.63h-1.58v-.63h1.58zm-.79-10.56a1.23 1.23 0 0 0-1.23 1.23a1 1 0 1 1-2 0a3.21 3.21 0 0 1 3.23-3.23a1 1 0 0 1 0 2m9.16 2.5h-1.83a.75.75 0 0 1 0-1.5h1.83a.75.75 0 1 1 0 1.5m-3.68-6.01a.74.74 0 0 1-.53-.22a.75.75 0 0 1 0-1.06l1.3-1.3a.75.75 0 0 1 1.06 1.06l-1.3 1.3a.73.73 0 0 1-.53.22m2.3 12.44a.8.8 0 0 1-.53-.22l-1.3-1.3a.75.75 0 0 1 .242-1.226a.74.74 0 0 1 .818.166l1.3 1.3a.74.74 0 0 1 0 1.06a.75.75 0 0 1-.53.22M6.535 6.855a.75.75 0 0 1-.53-.22l-1.3-1.3a.753.753 0 1 1 1.07-1.06l1.29 1.3a.75.75 0 0 1-.53 1.28m-2.29 12.44a.7.7 0 0 1-.53-.22a.75.75 0 0 1 0-1.06l1.3-1.3a.75.75 0 0 1 1.06 1.06l-1.29 1.31a.8.8 0 0 1-.54.21m.42-6.43h-1.83a.75.75 0 1 1 0-1.5h1.83a.75.75 0 1 1 0 1.5" />""",
            ?size = size,
            ?className = className
        )

    static member IconDashMenu(?size: int, ?className: string) =
        App.Icon(
            """<rect width="24" height="24" fill="none" />
	<path fill="none" stroke="currentColor" stroke-linecap="round" stroke-miterlimit="10" stroke-width="1.5" d="M4.5 12h15m-15 5.77h15M4.5 6.23h15" />""",
            ?size = size,
            ?className = className
        )
    static member IconX(?size: int, ?className: string) =
        App.Icon(
            """<polygon
      points="400 145.49 366.51 112 256 222.51 145.49 112 112 145.49 222.51 256 112 366.51 145.49 400 256 289.49 366.51 400 400 366.51 289.49 256 400 145.49" />""",
            ?size = size,
            ?className = className,
            viewBox = (0,0,512,512)
        )

    static member Chat(speech: ISpeak, msgs: MessageLog list, companion: Companion) =

        let CompanionBubble (content: ReactElement, msg: MessageLog) =
            Html.div [
                prop.className "chat chat-start"
                prop.children [
                    Html.div [
                        prop.className "chat-image avatar"
                        prop.children [
                            Html.div [
                                prop.className "w-10 rounded-full"
                                prop.children [
                                    Html.img [ prop.src companion.avatarUrl; prop.alt companion.name ]
                                ]
                            ]
                        ]
                    ]
                    Html.div [
                        prop.className "chat-header"
                        prop.children [
                            Html.text companion.name
                            Html.time [ prop.className "text-xs opacity-50"; prop.text msg.time ]
                        ]
                    ]
                    Html.div [ prop.className "chat-bubble tracking-wide max-sm:text-sm"; prop.children [ content ] ]
                    Html.div [
                        prop.className "chat-footer opacity-50"
                        prop.textf "%A %s" msg.trigger msg.emoji
                    ]
                ]
            ]

        Html.div [
            prop.testId "chat-container"
            prop.className "lg:w-2/3 max-w-5xl grow overflow-y-auto flex flex-col-reverse"
            prop.children [

                match msgs with
                | [] ->
                    Html.div [
                        prop.className "text-sm text-muted-foreground w-full text-center"
                        prop.children [ Html.small "No messages" ]
                    ]
                | head :: tail ->
                    CompanionBubble(speech.Text(), head)

                    for msg in tail do
                        CompanionBubble(Html.text msg.text, msg)

            ]
        ]

    [<ReactComponent>]
    static member Avatar(companion: Companion, speakRndTxt: Trigger -> unit, currentEmoji: string) =
        Html.div [
            prop.className "avatar relative indicator cursor-pointer"
            prop.onClick (fun _ ->
                speakRndTxt Trigger.Generic
            )
            prop.children [
                Html.button [
                    prop.className [ "indicator-item indicator-top indicator-end btn btn-circle !size-12 !aspect-auto"; "btn-error" ]
                    prop.style [ style.custom ("translate", "-50% -50%") ]
                    prop.children [ App.IconRobotDead(className = "size-8") ]
                    prop.onClick (fun e ->
                        e.stopPropagation ()
                        speakRndTxt Trigger.BadActionSelf
                    )
                ]
                Html.button [
                    prop.className "indicator-item indicator-top indicator-end btn btn-circle !size-12 btn-success !aspect-auto"
                    prop.style [ style.custom ("translate", "50% 50%") ]
                    prop.children [ App.IconRobotWink(className = "size-8") ]
                    prop.onClick (fun e ->
                        e.stopPropagation ()
                        speakRndTxt Trigger.GoodActionSelf
                    )
                ]
                Html.button [
                    prop.className [ "indicator-item btn-circle btn indicator-bottom indicator-end !size-12 !aspect-auto"; "btn-error" ]
                    prop.style [ style.custom ("translate", "-50% 50%") ]
                    prop.children [ App.IconDwarf(className = "size-8") ]
                    prop.onClick (fun e ->
                        e.stopPropagation ()
                        speakRndTxt Trigger.BadAction
                    )
                ]
                Html.button [
                    prop.className [ "indicator-item btn-circle btn indicator-bottom indicator-end !size-12 !aspect-auto"; "btn-success" ]
                    prop.style [ style.custom ("translate", "50% -50%") ]
                    prop.children [ App.IconDwarf(className = "size-8") ]
                    prop.onClick (fun e ->
                        e.stopPropagation ()
                        speakRndTxt Trigger.GoodAction
                    )
                ]
                Html.button [
                    prop.className [ "indicator-item btn-circle btn indicator-bottom indicator-start !size-12 !aspect-auto"; "btn-warning" ]
                    prop.style [ style.custom ("translate", "50% 50%") ]
                    prop.children [ App.IconLightBulb(className = "!size-8") ]
                    prop.onClick (fun e ->
                        e.stopPropagation ()
                        speakRndTxt Trigger.Idea
                    )
                ]
                Html.div [
                    prop.key currentEmoji
                    prop.className [
                        "spin-blurred indicator-item !aspect-auto p-2 indicator-middle indicator-start bg-neutral rounded-xl min-h-fit min-w-fit !flex !items-center !justify-center w-auto h-fit cursor-default"
                    ]
                    prop.onClick (fun e -> e.stopPropagation ())
                    prop.children [ Html.div [ prop.className "text-3xl font-bold"; prop.text currentEmoji ] ]
                ]
                Html.div [
                    prop.className
                        "absolute inset-0 rounded-full ring-primary ring-offset-base-100 ring-8 ring-offset-2 transition-all hover:animate-pulse"
                ]
                Html.div [
                    prop.className "size-52 rounded-full"
                    prop.children [ Html.img [ prop.src companion.avatarUrl; prop.alt companion.name ] ]
                ]
            ]
        ]

    static member CompanionItem(companion: Companion, isActive: bool, setCompanion: Companion -> unit, ?key: string) =
        Html.li [
            prop.className "list-row cursor-pointer transition hover:bg-base-200/20"
            prop.onClick (fun _ -> setCompanion companion)
            prop.children [
                Html.input [
                    prop.className "checkbox"
                    prop.type'.checkbox
                    prop.isChecked isActive
                    prop.onChange (fun (_: bool) -> ())
                ]
                Html.div [
                    Html.img [
                        prop.className "size-12 rounded-lg"
                        prop.src companion.avatarUrl;
                        prop.alt companion.name
                    ]
                ]
                Html.div [
                    prop.className "list-col-grow"
                    prop.children [
                        Html.div companion.name
                        Html.div [
                            prop.className "text-xs font-semibold opacity-60"
                            prop.text companion.description
                        ]
                    ]
                ]
            ]
        ]

    static member Navbar(modalId: string) =
        Html.nav [
            prop.className "w-full p-2 flex gap-4"
            prop.children [
                Html.button [
                    prop.className "btn btn-square ml-auto"
                    prop.children [ App.IconCog(className = "") ]
                    prop.onClick (fun _ -> document.getElementById(modalId)?showModal() |> ignore)
                ]
                // Html.label [
                //     prop.className "btn btn-square swap swap-rotate"

                //     prop.children [
                //         Html.input [prop.type'.checkbox]

                //         App.IconDashMenu(className = "swap-off fill-current")
                //         App.IconDashMenu(className = "swap-on fill-current")
                //     ]

                // ]
            ]
        ]

    [<ReactComponent>]
    static member OnMousePressedEventHandler(children: ReactElement, callback: unit -> unit, ?duration: int) =
        let steps = 10
        let duration = defaultArg duration 2000
        let stepduration = duration / steps

        let intervalRef = React.useRef(None: int option)
        let mainCallbackTimeoutRef = React.useRef(None: int option)
        let delayRef = React.useRef(None: int option) /// Used to delay ring animation and timer
        let position, setPosition = React.useState(None: {| x: float; y: float |} option)
        let status, setStatus = React.useStateWithUpdater(None: int option)
        let parentRef = React.useElementRef()

        let cancel = fun () ->
            delayRef.current |> Option.iter Fable.Core.JS.clearTimeout
            intervalRef.current |> Option.iter Fable.Core.JS.clearInterval
            mainCallbackTimeoutRef.current |> Option.iter Fable.Core.JS.clearTimeout
            setStatus (fun _ -> None)
            setPosition (None)
            delayRef.current <- None
            intervalRef.current <- None
            mainCallbackTimeoutRef.current <- None

        let callback = fun () ->
            cancel()
            callback ()

        let onMousedown = fun (e: Browser.Types.MouseEvent) ->
            if intervalRef.current.IsNone then
                let parent = parentRef.current.Value.getBoundingClientRect()
                let relativeX = e.clientX - parent.left
                let relativeY = e.clientY - parent.top
                setPosition (Some {| x = relativeX - 10.; y = relativeY - 10. |})
                setStatus (fun _ -> Some (100/steps))
                let intervalId =
                    Fable.Core.JS.setInterval
                        (fun _ ->
                            setStatus (fun current ->
                                current |> Option.map ((+) steps)
                            )
                        )
                        stepduration
                let timeoutId =
                    Fable.Core.JS.setTimeout
                        (fun _ -> callback ())
                        duration
                intervalRef.current <- Some intervalId
                mainCallbackTimeoutRef.current <- Some timeoutId

        Html.div [
            prop.ref parentRef
            prop.className "relative"
            prop.onMouseDown (fun e ->
                match delayRef.current with
                | Some _ -> ()
                | None ->
                    let delayid = Fable.Core.JS.setTimeout (fun () -> onMousedown e) 1000
                    delayRef.current <- Some delayid
            )
            prop.onPointerDown(fun e ->
                match delayRef.current with
                | Some _ -> ()
                | None ->
                    let delayid = Fable.Core.JS.setTimeout (fun () -> onMousedown e) 1000
                    delayRef.current <- Some delayid
            )
            prop.onMouseUp (fun _ ->
                cancel()
            )
            prop.onPointerUp(fun _ ->
                cancel()
            )
            prop.children [
                if status.IsSome && position.IsSome then
                    Html.div [
                        prop.className "radial-progress size-8 z-[1000] text-red-600/80 bg-black/50 border-4 border-black/50"
                        prop.role.progressBar
                        prop.style [
                            style.custom("--value", status.Value)
                            style.position.absolute
                            style.top (unbox<int> (position.Value.y)) //245 770
                            style.left (unbox<int> (position.Value.x))
                        ]
                        prop.ariaValueNow status.Value
                    ]
                children
            ]
        ]

    [<ReactComponent>]
    static member Settings(modalId: string, volume: int, setVolume: int -> unit, companion: Companion, setCompanion: Companion -> unit) =

        let showTrueGenny, setShowTrueGenny = React.useState(false)
        Html.dialog [
            prop.id modalId
            prop.className "modal modal-bottom"
            prop.children [
                Html.div [
                    prop.className "modal-box max-h-3/4"
                    prop.children [
                        Html.form [
                            prop.method "dialog"
                            prop.children [
                                Html.button [
                                    prop.className "btn btn-sm btn-circle btn-ghost absolute right-2 top-2"
                                    prop.text "✕"
                                ]
                            ]
                        ]
                        Html.h2 [
                            prop.className "text-2xl font-bold"
                            prop.text "Settings"
                        ]
                        Html.fieldSet [
                            prop.className "fieldset p-4"

                            prop.children [
                                Html.legend [prop.className "fieldset-legend text-lg"; prop.text "Sound Volume"]

                                Html.div [
                                    prop.className "flex gap-2"
                                    prop.children [
                                        Html.span [
                                            prop.className "text-xl min-w-[35px]"
                                            prop.text volume
                                        ]
                                        Html.input [
                                            prop.className "range range-lg max-w-lg"
                                            prop.type'.range
                                            prop.min 0
                                            prop.max 100
                                            prop.value volume
                                            prop.step 5
                                            prop.onChange (fun (e: int) -> setVolume e)
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.fieldSet [
                            prop.className "fieldset p-4"

                            prop.children [
                                Html.legend [prop.className "fieldset-legend text-lg"; prop.text "Companion"]

                                Html.ul [
                                    prop.className "list"
                                    prop.children [
                                        Html.li [
                                            prop.className "p-4 pb-2 text-xs opacity-60 tracking-wide"
                                            prop.text "Choose your companion!"
                                        ]
                                        App.CompanionItem(Companions.Beretta, (companion = Companions.Beretta), setCompanion = setCompanion, key = "beretta")
                                        if showTrueGenny then
                                            App.CompanionItem(Companions.TrueGenny, (companion = Companions.TrueGenny), setCompanion = setCompanion, key = "true-genny")
                                        else
                                            App.OnMousePressedEventHandler(
                                                App.CompanionItem(Companions.Genny, (companion = Companions.Genny), setCompanion = setCompanion, key = "genny"),
                                                (fun _ -> setShowTrueGenny true)
                                            )
                                    ]

                                ]
                            ]
                        ]

                        Html.footer [
                            prop.className "p-4 text-xs opacity-60 tracking-wide"
                            prop.text AppHelper.__VERSION__
                        ]
                    ]
                ]
                Html.form [
                    prop.method "dialog"
                    prop.className "modal-backdrop"
                    prop.children [
                        Html.button [
                            // prop.onClick (fun _ -> document.getElementById(modalId)?closeModal() |> ignore)
                            prop.text "Close"
                        ]
                    ]
                ]
            ]
        ]

    static member private DisabledAlert() =
        Html.div [
            prop.className "alert alert-error"
            prop.children [
                Html.p [
                    prop.dangerouslySetInnerHTML """<svg xmlns="http://www.w3.org/2000/svg" class="h-6 w-6 shrink-0 stroke-current" fill="none" viewBox="0 0 24 24">
<path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M10 14l2-2m0 0l2-2m-2 2l-2-2m2 2l2 2m7-2a9 9 0 11-18 0 9 9 0 0118 0z" />
</svg>"""
                ]
                Html.div [
                    Html.p "Companions cannot be summoned in this browser!"
                    Html.p "Please try a different browser!"
                ]
            ]
        ]

    [<ReactComponent>]
    static member Main() =

        let speak = rtts.useSpeak ()
        let storedCompanion, setStoredCompanion = React.useLocalStorage<string>(AppHelper.__APP_NAME__ + "_companion", Companions.Beretta.name)

        let companions = React.useMemo(fun () ->
            [Companions.Beretta; Companions.Genny; Companions.TrueGenny]
        )

        let initCompanion = companions |> List.tryFind (fun c -> c.name = storedCompanion) |> Option.defaultValue Companions.Beretta

        let companion, setCompanion = React.useState<Companion> (initCompanion)

        let messages, setMessages = React.useState<MessageLog list> []

        let volume, setVolume = React.useLocalStorage<int>(AppHelper.__APP_NAME__ + "_volume", 100)

        let isDisabled, setIsDisabled = React.useState<bool>(false)

        React.useEffect((fun _ ->
            let speech = Browser.Dom.window?speechSynthesis
            if isNullOrUndefined speech then setIsDisabled true
        ), [||])

        let setCompanion (c: Companion) =
            setMessages []
            setCompanion c
            setStoredCompanion c.name

        let random = React.useRef (Random())

        let modalId = React.useId ()

        React.useEffect((fun _ ->
            Browser.Dom.document.body.setAttribute("data-theme", !!companion.theme)
        ), [|box companion.theme|])

        let latestEmoji =
            messages
            |> List.tryHead
            |> Option.map (fun m -> m.emoji)
            |> Option.defaultValue "💤"

        let speakRndTxt (trigger: Trigger) =
            let randomFloat (baseValue: float) (variance: float) =
                let delta = (random.current.NextDouble() * 2.0 - 1.0) * variance
                baseValue + delta

            let pitch = randomFloat companion.basePitch 0.15
            let rate = randomFloat 1.05 0.1

            let rndMsg =
                companion.messages.[trigger]
                |> Array.item (random.current.Next(0, companion.messages.[trigger].Length))

            let msgLog = {|
                text = rndMsg.text
                emoji = rndMsg.emoji
                trigger = trigger
                time = DateTime.Now.ToShortTimeString()
                companion = companion.name
            |}

            setMessages (msgLog :: messages)

            speak.stop()

            speak.speak (
                rndMsg.text,
                ISpeakOptions(
                    lang = !!Languages.German,
                    pitch = pitch,
                    rate = rate,
                    volume = (float volume / 100.),
                    enableDirectives = true,
                    highlightText = true,
                    voiceUri = !!companion.voiceUris,
                    preserveUtteranceQueue = false,
                    highlightProps = {|
                        className = "bounce-once bg-primary text-primary-content rounded"
                    |}
                )
            )

        Html.div [
            prop.className "h-svh flex flex-col w-full overflow-hidden"
            prop.children [
                App.Navbar(modalId = modalId)
                App.Settings(modalId = modalId, volume = volume, setVolume = setVolume, companion = companion, setCompanion = setCompanion)
                Html.div [
                    prop.className "flex grow overflow-hidden flex-col items-center gap-12 p-6 md:p-10"
                    prop.children [
                        Html.div [
                            prop.children [
                                Html.h1 [ prop.className "text-3xl font-bold"; prop.text companion.name ]
                                Html.small [
                                    prop.className "text-sm text-muted-foreground"
                                    prop.text companion.description
                                ]
                            ]
                        ]
                        App.Avatar(companion, speakRndTxt = speakRndTxt, currentEmoji = latestEmoji)
                        if isDisabled then
                            App.DisabledAlert()
                        App.Chat(speech = speak, msgs = messages, companion = companion)
                    ]
                ]
            ]
        ]