namespace App

open Fable.Core
open Fable.Core.JsInterop
open Feliz

module private RTTSHelper =

    [<Literal>]
    let LIB_NAME = "react-text-to-speech"

open RTTSHelper


[<StringEnum(CaseRules.LowerAll)>]
type HighlightMode =
    | Word
    | Sentence
    | Line
    | Paragraph

[<AllowNullLiteral>]
[<Global>]
type ISpeakOptions
    [<ParamObject; Emit("$0")>]
    (
        ?pitch: float,
        ?rate: float,
        ?volume: float,
        ?lang: string,
        ?voiceUri: string[],
        ?autoPlay: bool,
        ?preserveUtteranceQueue: bool,
        ?highlightText: bool,
        ?showOnlyHighlightedText: bool,
        ?highlightMode: HighlightMode,
        ?highlightProps: obj,
        ?enableDirectives: bool,
        ?maxChunkSize: int,
        ?onError: obj -> unit,
        ?onStart: unit -> unit,
        ?onResume: unit -> unit,
        ?onPause: unit -> unit,
        ?onStop: unit -> unit,
        ?onBoundary: unit -> unit,
        ?onQueueChange: unit -> unit
    ) =
    member val pitch: float option = pitch with get, set
    member val rate: float option = rate with get, set
    member val volume: float option = volume with get, set
    member val lang: string option = lang with get, set
    member val voiceUri: string[] option = voiceUri with get, set
    member val autoPlay: bool option = autoPlay with get, set
    member val preserveUtteranceQueue: bool option = preserveUtteranceQueue with get, set
    member val highlightText: bool option = highlightText with get, set
    member val showOnlyHighlightedText: bool option = showOnlyHighlightedText with get, set
    member val highlightMode: HighlightMode option = highlightMode with get, set
    member val highlightProps: obj option = highlightProps with get, set
    member val enableDirectives: bool option = enableDirectives with get, set
    member val maxChunkSize: int option = maxChunkSize with get, set
    member val onError = onError with get, set
    member val onStart = onStart with get, set
    member val onResume = onResume with get, set
    member val onPause = onPause with get, set
    member val onStop = onStop with get, set
    member val onBoundary = onBoundary with get, set
    member val onQueueChange = onQueueChange with get, set

type SpeechSynthesisVoice =
    abstract member ``default``: bool
    abstract member lang: string
    abstract member localService: bool
    abstract member name: string
    abstract member voiceURI: string

type IVoices =
    abstract member languages: string[]
    abstract member voices: SpeechSynthesisVoice[]

type ISpeak =
    abstract member speak: txt: string -> unit
    abstract member speak: txt: string * options: ISpeakOptions -> unit
    abstract member Text: unit -> ReactElement
    abstract member speechStatus: string
    abstract member isInQueue: bool
    abstract member start: unit -> unit
    abstract member pause: unit -> unit
    abstract member stop: unit -> unit


module rtts =

    type directives =
        static member custom(name: string, value: obj) = sprintf "[[%s=%A]]" name value

        static member delay(duration: int) = directives.custom ("delay", duration)

        static member skip(b: bool) = directives.custom ("skip", b)

        static member pitch(pitch: float) = directives.custom ("pitch", pitch)
        static member pitchDefault = directives.custom ("pitch", "default")

        static member rate(rate: float) = directives.custom ("rate", rate)

        static member volume(volume: float) = directives.custom ("volume", volume)

        static member voice(voice: string) = directives.custom ("voice", voice)

[<Erase; Mangle(false)>]
type rtts =

    [<ImportMember(LIB_NAME)>]
    static member useVoices() : IVoices = jsNative

    [<ImportMember(LIB_NAME)>]
    static member useSpeak() : ISpeak = jsNative