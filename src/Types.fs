namespace App

open Fable.Core

[<StringEnum(CaseRules.LowerFirst); RequireQualifiedAccess>]
type Theme =
    | Highkeyturbo
    | Dripfrost

[<StringEnum>]
type Trigger =
    | Idea
    | GoodAction
    | BadAction
    | GoodActionSelf
    | BadActionSelf
    | Generic

[<StringEnum>]
type Languages =
    | [<CompiledName("de-DE")>] German
    | [<CompiledName("en-US")>] English

type Message = {| text: string; emoji: string |}

type MessageLog = {|
    text: string
    emoji: string
    trigger: Trigger
    time: string
    companion: string
|}

type Companion = {
    name: string
    description: string
    avatarUrl: string
    voiceUris: Map<Languages, string array>
    messages: Map<Trigger, Message[]>
    basePitch: float
    baseRate: float
    theme: Theme
}