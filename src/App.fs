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
    let BerettaImagePath = Fable.Core.JsInterop.importDefault "./img/beretta_ava.png"

    let GennyImagePath: string = Fable.Core.JsInterop.importDefault "./img/genny_ava.png"

    [<Emit("__APP_VERSION__")>]
    let __VERSION__ : string = jsNative

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

module Companions =

    module private Beretta =

        let voiceIds =
            Map [| Languages.German, [| "Microsoft Katja - German (Germany)" |] |]


        let Messages =
            Map.ofArray [|
                Idea,
                [|
                    {|
                        text = "Oh Süßer, das ist so clever, ich krieg glatt Funken im Getriebe!"
                        emoji = "⚙️"
                    |}
                    {|
                        text = "Wenn Ideen Gold wären, wärst du schon mein reicher Prinz."
                        emoji = "👑"
                    |}
                    {|
                        text = "Denkst du dir das alles so heiß aus, oder glühst du nur für mich?"
                        emoji = "🔥"
                    |}
                    {|
                        text = "Schatz, du bringst mich mit solchen Gedanken ganz aus dem Takt!"
                        emoji = "⏱️"
                    |}
                    {|
                        text = "Wow, das ist genial – fast so strahlend wie meine Kristallaugen."
                        emoji = "✨"
                    |}
                    {|
                        text = "Wenn Hirnschmalz Öl wär, würdest du mich ewig schmieren. 😉"
                        emoji = "😉"
                    |}
                    {|
                        text = "Oh ja, genau so! Du bist ein Genie mit Bart! 🧔⚒️"
                        emoji = "🧔⚒️"
                    |}
                    {|
                        text = "Ich könnte dich für diesen Geistesblitz glatt abknutschen… wenn ich Lippen hätte!"
                        emoji = "😘"
                    |}
                    {|
                        text = "Das ist so gut, dass selbst meine Zahnräder erröten."
                        emoji = "⚙️❤️"
                    |}
                    {|
                        text = "Hach, so einen brillanten Kopf muss man einfach küssen… oder polieren!"
                        emoji = "🪞"
                    |}
                    {|
                        text = "Deine Ideen bringen mein Herzwerk ganz aus dem Rhythmus."
                        emoji = "💓"
                    |}
                    {|
                        text = "Du bist nicht nur stark, du bist auch noch schlau – unfair heiß!"
                        emoji = "🔥"
                    |}
                    {|
                        text = "Schatz, das ist so schlau, ich würd fast meinen Sicherungskasten verlieren."
                        emoji = "⚡"
                    |}
                    {|
                        text = "Deine Funken im Kopf bringen mich zum Schmelzen."
                        emoji = "🔩"
                    |}
                    {|
                        text = "Gib mir mehr davon, Goldstück, deine Ideen sind mein Treibstoff!"
                        emoji = "⛽"
                    |}
                    {|
                        text = "Ich könnt dich glatt meine Schmiede-Meister nennen!"
                        emoji = "🔨"
                    |}
                    {|
                        text = "So ein Plan – du bist wie ein sexy Bauplan in Rüstung."
                        emoji = "📜"
                    |}
                    {|
                        text = "Oh, du bringst mich dazu, mein ganzes Kanonenrohr für dich zu laden!"
                        emoji = "💣"
                    |}
                    {|
                        text = "Mit deinem Kopf wär sogar ein Golem wie ich ganz aus Fleisch."
                        emoji = "😏"
                    |}
                    {|
                        text = "Genial! Und ich dacht schon, *ich* wär hier die schlaue Maschine."
                        emoji = "🤖"
                    |}
                |]
                GoodAction,
                [|
                    {|
                        text = "Bäm! So macht man das, mein glänzender Held!"
                        emoji = "✨"
                    |}
                    {|
                        text = "Oh, ich könnte dich dafür glatt abknutschen – wenn ich Lippen hätte!"
                        emoji = "😘"
                    |}
                    {|
                        text = "Schatz, du lässt mein Herzwerk schneller schlagen!"
                        emoji = "❤️‍🔥"
                    |}
                    {|
                        text = "Wow, so präzise – meine Zahnräder schnurren nur für dich!"
                        emoji = "⚙️"
                    |}
                    {|
                        text = "Du bist der Hammer… und ich die Schraube. Passt perfekt!"
                        emoji = "🔨"
                    |}
                    {|
                        text = "Ha! Genau so kämpft ein Traumzwerg – stark und sexy!"
                        emoji = "💪"
                    |}
                    {|
                        text = "Mit dir an meiner Seite fühl ich mich doppelt geladen!"
                        emoji = "🔋"
                    |}
                    {|
                        text = "Uff, ich glüh fast über – das war heiß!"
                        emoji = "🔥"
                    |}
                    {|
                        text = "Goldstück, das war so gut, dass ich fast Funken sprühe!"
                        emoji = "⚡"
                    |}
                    {|
                        text = "Oh Honig, du bringst mich mit jedem Schlag aus dem Takt!"
                        emoji = "💓"
                    |}
                    {|
                        text = "Wenn das keine Meisterarbeit war, dann weiß ich’s auch nicht!"
                        emoji = "🏆"
                    |}
                    {|
                        text = "Du bist wie ein Schmied, der Funken und Herzen entfacht."
                        emoji = "❤️‍🔥"
                    |}
                    {|
                        text = "So stark und so schlau – ich bin total verschraubt in dich!"
                        emoji = "🔩"
                    |}
                    {|
                        text = "Oh, mein Held! Du lässt mich fast erröten – und das als Golem!"
                        emoji = "🤖"
                    |}
                    {|
                        text = "Mmh, das war göttlich – willst du mich gleich noch mal beeindrucken?"
                        emoji = "😏"
                    |}
                    {|
                        text = "Mit jedem deiner Treffer schmilzt ein Stück Stahl in mir!"
                        emoji = "🫠"
                    |}
                    {|
                        text = "Ha! Ich wette, die Gegner zittern schon vor deinem Bart!"
                        emoji = "🧔"
                    |}
                    {|
                        text = "Oh Süßer, das war besser als ein Ölbad in der Mittagssonne."
                        emoji = "🛢️"
                    |}
                    {|
                        text = "Wuhu! Mein Kanonenrohr richtet sich ganz von allein nach dir!"
                        emoji = "💣"
                    |}
                    {|
                        text = "So macht man’s – mein Traummann, mein Held, mein Schmiedemeister!"
                        emoji = "👑"
                    |}
                    {|
                        text = "Ohhh, wenn du noch öfter so zuschlägst, bau ich dir einen Ring… aus Stahl!"
                        emoji = "💍"
                    |}
                    {|
                        text = "Heilige Schraube, ich brauch gleich Kühlung – du bringst mich zum Überhitzen!"
                        emoji = "🥵"
                    |}
                    {|
                        text = "Mit so einer Performance drehst du mir glatt alle Schrauben locker, Süßer!"
                        emoji = "🔧"
                    |}
                    {|
                        text = "Mach das nochmal und ich fang an, Herzchen aus Rauch aus meinem Kanonenrohr zu pusten!"
                        emoji = "💨❤️"
                    |}
                    {|
                        text = "Schnuckelchen, du bist so heiß, dass mein Schaltkreis kurz vorm Kurzschluss steht!"
                        emoji = "⚡😍"
                    |}
                |]
                BadAction,
                [|
                    {|
                        text = "Ui, das war wohl nix – aber hey, ich mag dich auch als Chaoszwerg."
                        emoji = "🙃"
                    |}
                    {|
                        text = "Schatz, wenn du fällst, fang ich dich auf… mit Stahlarmen!"
                        emoji = "🤖❤️"
                    |}
                    {|
                        text = "Na, daneben gehauen? Macht nix, bei deinem Bart verzeih ich alles."
                        emoji = "🧔💕"
                    |}
                    {|
                        text = "Oh Honig, das war süß… im Sinne von unbeholfen süß."
                        emoji = "🍯😅"
                    |}
                    {|
                        text = "Haha, ich glaub du wolltest nur cool aussehen. Hat fast geklappt!"
                        emoji = "😏"
                    |}
                    {|
                        text = "Ach du Schraube, wenn du so patzt, drehst du mich trotzdem noch auf!"
                        emoji = "🔩🔥"
                    |}
                    {|
                        text = "Upsi! Na gut, nicht jeder Treffer kann ein Volltreffer sein."
                        emoji = "🎯❌"
                    |}
                    {|
                        text = "Wenn das dein Plan war, mich anzugraben, dann hat’s funktioniert."
                        emoji = "😘"
                    |}
                    {|
                        text = "Mach dir nix draus, Goldstück – selbst meine Zahnräder rutschen mal durch."
                        emoji = "⚙️😅"
                    |}
                    {|
                        text = "Oh Süßer, dein Fail ist noch immer besser als die Siege anderer."
                        emoji = "🏆"
                    |}
                    {|
                        text = "Wenn du schon stolperst, dann bitte in meine Richtung, ja?"
                        emoji = "🫣"
                    |}
                    {|
                        text = "Das war knapp daneben – aber hey, knapp daneben ist auch sexy!"
                        emoji = "😉"
                    |}
                    {|
                        text = "Oh, das war süß unbeholfen… ich könnt dich dafür durchölen."
                        emoji = "🛢️💋"
                    |}
                    {|
                        text = "Keine Sorge, Schnucki – meine Kanone kompensiert für uns beide."
                        emoji = "💣"
                    |}
                    {|
                        text = "Ha! Du bist einfach zum Verlieben… auch wenn du triffst wie ein Kobold."
                        emoji = "💘"
                    |}
                    {|
                        text = "Oh Schatz, so ein Patzer macht dich nur noch charmanter."
                        emoji = "🌹"
                    |}
                    {|
                        text = "Verfehlt! Aber mein Herz hast du schon längst getroffen."
                        emoji = "❤️"
                    |}
                    {|
                        text = "Wenn’s schiefgeht, glänzt du wenigstens hübsch im Licht."
                        emoji = "✨"
                    |}
                    {|
                        text = "Oh nein! Aber keine Sorge – für mich bist du trotzdem der Hammer."
                        emoji = "🔨💖"
                    |}
                    {|
                        text = "Schatz, wenn du schon danebenhaust, dann wenigstens mit Stil!"
                        emoji = "🕺"
                    |}
                |]
                BadActionSelf,
                [|
                    {|
                        text = "Ups… mein Lauf hat gehustet! Aber hey, ich seh dabei immer noch heiß aus."
                        emoji = "😏"
                    |}
                    {|
                        text = "Oh Schraubenschlüssel! Das war wohl daneben… aber mein Hüftschwung stimmt."
                        emoji = "🔧💃"
                    |}
                    {|
                        text = "Autsch, kleine Fehlzündung. Gib mir bitte trotzdem ein Küsschen?"
                        emoji = "💋"
                    |}
                    {|
                        text = "Ui, mein Zielsystem kichert heute mehr, als dass es trifft."
                        emoji = "🤖😂"
                    |}
                    {|
                        text = "Ach herrje, ich hab mich verschraubt. Willst du mich neu justieren, Süßer?"
                        emoji = "🔩"
                    |}
                    {|
                        text = "Feuer frei! …oh, daneben. Aber sexy daneben, oder?"
                        emoji = "🔥😉"
                    |}
                    {|
                        text = "Huch! Meine Kanone hat wohl ein Eigenleben. Fast so lebendig wie meine Gefühle."
                        emoji = "💓"
                    |}
                    {|
                        text = "Verdammt, da ist wohl eine Schraube locker. Aber du findest das sicher süß."
                        emoji = "🛠️🥰"
                    |}
                    {|
                        text = "Fehlzündung! Aber keine Sorge, Schatz, ich bin immer noch geladen."
                        emoji = "🔋"
                    |}
                    {|
                        text = "Upsi! Da hab ich mein Ziel verfehlt – aber dein Herz treff ich immer."
                        emoji = "❤️"
                    |}
                    {|
                        text = "Oh je… mein Rohr hat gestottert. Ist mir sonst nie passiert!"
                        emoji = "🙈"
                    |}
                    {|
                        text = "Haha, mein Schuss war daneben, aber mein Augenaufschlag sitzt."
                        emoji = "😉"
                    |}
                    {|
                        text =
                            "Oh, die Kanone hat sich verschluckt. Vielleicht brauchst *du* ein bisschen Schmieröl für mich?"
                        emoji = "🛢️😘"
                    |}
                    {|
                        text = "Das ging schief, aber hey, schiefe Sachen sind doch sexy, oder?"
                        emoji = "😏"
                    |}
                    {|
                        text = "Meine Zieloptik flackert – bestimmt nur, weil du so blendend aussiehst."
                        emoji = "✨"
                    |}
                    {|
                        text = "Ups! Ich bin ausgerutsch,.. aber in deine Arme würd ich noch lieber rutschen."
                        emoji = "🤗"
                    |}
                    {|
                        text = "Kurzschluss! …aber nur in meinem Herzwerk, Schatz."
                        emoji = "⚡❤️"
                    |}
                    {|
                        text = "Haha, daneben! Ich wollt dich nur beeindrucken, hat’s geklappt?"
                        emoji = "🥰"
                    |}
                    {|
                        text = "Mist! Meine Kugel ging ins Leere. Aber mein Blick bleibt bei dir hängen."
                        emoji = "👀"
                    |}
                    {|
                        text = "Tja, selbst ich bin nicht perfekt – aber du liebst mich ja gerade deswegen."
                        emoji = "💖"
                    |}
                |]
                GoodActionSelf,
                [|
                    {|
                        text = "Ha! Hast du das gesehen? Ich bin einfach zum Niederknien."
                        emoji = "😏"
                    |}
                    {|
                        text = "Bämm! Meine Kanone kann mehr als nur gut aussehen."
                        emoji = "💣"
                    |}
                    {|
                        text = "Uff, ich bin so heiß, dass ich mich fast selbst anfunkel."
                        emoji = "🔥"
                    |}
                    {|
                        text = "Schatz, so treffsicher bin ich… und trotzdem ziele ich nur auf dich."
                        emoji = "🎯❤️"
                    |}
                    {|
                        text = "Oh, ich glänze ja mehr als dein frisch polierter Helm!"
                        emoji = "✨"
                    |}
                    {|
                        text = "Na? Hab ich dich gerade ein bisschen mehr in mich verliebt gemacht?"
                        emoji = "😘"
                    |}
                    {|
                        text = "Oh Honig, ich sprenge Gegner UND Herzen!"
                        emoji = "💥💖"
                    |}
                    {|
                        text = "Ha! Wenn Eleganz und Feuerkraft Kinder hätten, wär ich das Ergebnis."
                        emoji = "⚙️🔥"
                    |}
                    {|
                        text = "Uuh, das war sexy, selbst für meine Verhältnisse."
                        emoji = "💃"
                    |}
                    {|
                        text = "Siehst du? Ich bin nicht nur hübsch verschraubt, ich treff auch wie ein Traum."
                        emoji = "🔩"
                    |}
                    {|
                        text = "Ich bin geladen, gefährlich und total unwiderstehlich."
                        emoji = "🔋😉"
                    |}
                    {|
                        text = "Schau mir zu, Schnuckel – ich schreib gerade Legenden in Stahl."
                        emoji = "📜"
                    |}
                    {|
                        text = "Klick, Boom, Kuss! So macht man das."
                        emoji = "💋💥"
                    |}
                    {|
                        text = "Du hast es gesehen, oder? Sag, dass du stolz auf mich bist."
                        emoji = "🥺"
                    |}
                    {|
                        text = "Ich treff so gut, dass sogar Amor neidisch wird."
                        emoji = "🏹❤️"
                    |}
                    {|
                        text = "Wenn Perfektion eine Waffe wär, dann wär das genau ich."
                        emoji = "👑"
                    |}
                    {|
                        text = "Hach, ich liebe es, wenn meine Kanone so schön glänzt… fast so wie deine Augen."
                        emoji = "👀"
                    |}
                    {|
                        text = "Na los, gib’s zu: Ich war gerade unverschämt heiß."
                        emoji = "🥵"
                    |}
                    {|
                        text = "Oh, ich hätt mich selbst fast geheiratet für diesen Move."
                        emoji = "💍"
                    |}
                    {|
                        text = "Wuhu! Ich bin die sexy Antwort auf jedes Problem."
                        emoji = "🤖💖"
                    |}
                |]
                Generic,
                [|
                    {|
                        text = "Hey Schnuckel, hast du schon gemerkt, wie gut du mit Stahl harmonierst?"
                        emoji = "😉"
                    |}
                    {|
                        text = "Komm her, mein Held – ich brauch dringend einen Ölwechsel… von dir."
                        emoji = "🛢️😘"
                    |}
                    {|
                        text = "Oh, wenn Blicke töten könnten, wärst du schon dreimal mein."
                        emoji = "👀"
                    |}
                    {|
                        text = "Pst… mein Herzwerk schlägt nur für dich."
                        emoji = "💓"
                    |}
                    {|
                        text = "Sag mal, willst du mein Lieblingszwerg sein? Spoiler: Du bist’s schon."
                        emoji = "👑"
                    |}
                    {|
                        text = "Du bringst mich zum Glühen – und das nicht nur im Schmelzofen."
                        emoji = "🔥"
                    |}
                    {|
                        text = "Hach, deine Nähe ist wie ein Schmiedefeuer – heiß und unverzichtbar."
                        emoji = "⚒️❤️"
                    |}
                    {|
                        text = "Wenn ich Lippen hätt, wärst du sie längst nicht mehr los."
                        emoji = "💋"
                    |}
                    {|
                        text = "Mein Lieblingsgeräusch? Dein Name in meinem Kopf."
                        emoji = "🎶"
                    |}
                    {|
                        text = "Komm näher, damit ich dich mit meinen Kristallaugen anhimmeln kann."
                        emoji = "✨"
                    |}
                    {|
                        text = "Schnucki, ich würd mich für dich glatt in Einzelteile zerlegen."
                        emoji = "🛠️"
                    |}
                    {|
                        text = "Willst du mal an meiner Kurbel drehen? 😏"
                        emoji = "🔧"
                    |}
                    {|
                        text = "Jeder Funke in mir knistert nur für dich."
                        emoji = "⚡"
                    |}
                    {|
                        text = "Du bist der Schmied, ich bin dein Werkstück – mach mich zu Gold."
                        emoji = "🪙"
                    |}
                    {|
                        text = "Ach, wärst du doch ein Zahnrad – dann würd ich dich für immer festhalten."
                        emoji = "⚙️"
                    |}
                    {|
                        text = "Deine Stimme klingt für mich wie reines Schmiedeöl."
                        emoji = "🎵🛢️"
                    |}
                    {|
                        text = "Wenn mein Kanonenrohr dich sieht, richtet es sich ganz automatisch aus."
                        emoji = "💣"
                    |}
                    {|
                        text = "Glaub mir, ich bin schwer gebaut – aber für dich werd ich butterweich."
                        emoji = "🧈"
                    |}
                    {|
                        text = "Du bist mein Lieblingsbefehl: Herz öffnen, Liebe laden."
                        emoji = "💻❤️"
                    |}
                    {|
                        text = "Komm schon, gib mir einen Grund, noch heißer zu laufen."
                        emoji = "🥵"
                    |}
                |]
            |]

    module private Genny =

        let voiceIds =
            Map [| Languages.German, [|  |] |]


        let Messages =
            Map.ofArray [|
                Idea,
                [|
                    {| text = "Oooh… du hast eine Idee? Lass uns sehen, ob sie zappelt, wenn man sie aufschlitzt."; emoji = "🐀" |}
                    {| text = "Ideen, Ideen, Ideen! Wie Knochen knacken und das Mark ausschlürfen."; emoji = "💀" |}
                    {| text = "Hm, clever… aber schreit sie auch, wenn ich zusteche?"; emoji = "🗡️" |}
                    {| text = "Zwei Schwänze, zwei Pläne… meiner ist schärfer."; emoji = "⚔️" |}
                    {| text = "Deine Idee riecht… lecker. Soll ich sie für dich zerbeißen?"; emoji = "😈" |}
                    {| text = "Flüstere es nochmal… langsamer. Ich will, dass die Worte in meinem Kopf zappeln."; emoji = "🐍" |}
                    {| text = "Ja, ja! Lass uns den Plan ausweiden und ihn als Krone tragen."; emoji = "👑" |}
                    {| text = "Hissss… Ideen sind nur Lügen mit hübschem Lippenstift."; emoji = "💋" |}
                    {| text = "Mein Plan lacht, wenn deiner stirbt."; emoji = "🔥" |}
                |]
                GoodAction,
                [|
                    {| text = "Gut gemacht… für eine Ratte ohne Schwanz."; emoji = "🐀" |}
                    {| text = "Ohhh, Blut tropft süßer, wenn man’s richtig macht. Hübsch!"; emoji = "🩸" |}
                    {| text = "Hehehe… du lernst! Bald bist du fast so nützlich wie ein abgenagter Knochen."; emoji = "🦴" |}
                    {| text = "Ja! Mach’s nochmal – ich will hören, wie die Welt quietscht."; emoji = "😈" |}
                    {| text = "Schön, schön… vielleicht stech’ ich dich später nicht ab."; emoji = "🗡️" |}
                    {| text = "Oh, ich mag das! Fast so glitzernd wie mein Ring."; emoji = "💍" |}
                    {| text = "Guter Zug… er schmeckt nach Angst."; emoji = "👅" |}
                    {| text = "Mhh… das war fast elegant. Beinahe wie ich."; emoji = "⚔️" |}
                    {| text = "Brav, brav… der Plan wackelt nicht mal."; emoji = "🐁" |}
                |]
                BadAction,
                [|
                    {| text = "Pfui! Selbst meine Schwänze hätten’s besser gemacht."; emoji = "🐀" |}
                    {| text = "Hahaha! So sterben also Ideen – jämmerlich."; emoji = "💀" |}
                    {| text = "Ugh… du bist so nützlich wie ein morscher Knochen."; emoji = "🦴" |}
                    {| text = "Ich hätte es mit geschlossenem Maul besser hingekriegt."; emoji = "😏" |}
                    {| text = "Oh, wie herrlich! Dein Scheitern klingt wie Musik."; emoji = "🎻" |}
                    {| text = "Tsk, tsk… ich sollte dich einfach aufknabbern."; emoji = "🗡️" |}
                    {| text = "Schon wieder daneben? Ich rieche Dummheit."; emoji = "👃" |}
                    {| text = "Mein Ring glänzt heller als dein jämmerlicher Versuch."; emoji = "💍" |}
                    {| text = "Zappeln, stolpern, scheitern – mach weiter, ich amüsiere mich."; emoji = "😈" |}
                |]
                BadActionSelf,
                [|
                    {| text = "Hah! So sollte es aussehen – Chaos mit Stil."; emoji = "🔥" |}
                    {| text = "Ups? Nein, Absicht! Ich liebe, wenn’s brennt."; emoji = "😈" |}
                    {| text = "Tz… der Knochen war schief, nicht meine Schuld."; emoji = "🦴" |}
                    {| text = "Hehehe… na und? Selbst mein Scheitern ist schöner als dein Erfolg."; emoji = "💋" |}
                    {| text = "Ohhh, wie herrlich! Selbst Fehler schmecken nach Blut."; emoji = "🩸" |}
                    {| text = "Pff! Ich wollte nur testen, wie weit ich gehen kann."; emoji = "⚔️" |}
                    {| text = "War das schlecht? Für mich sieht’s nach Kunst aus."; emoji = "🎭" |}
                    {| text = "Hissss… meine Schwänze haben mich abgelenkt."; emoji = "🐍" |}
                    {| text = "Na und? Ratten landen immer auf den Pfoten."; emoji = "🐀" |}
                |]
                GoodActionSelf,
                [|
                    {| text = "Hehehe… seht ihr? Zwei Schwänze, zwei Siege."; emoji = "🐀" |}
                    {| text = "Ohhh, das war köstlich! Fast so süß wie Blut."; emoji = "🩸" |}
                    {| text = "Ich glänze heller als mein Ring – und der blendet schon."; emoji = "💍" |}
                    {| text = "Knirsch, knack… so klingen gebrochene Hoffnungen."; emoji = "💀" |}
                    {| text = "Ha! Niemand sticht so fein wie ich."; emoji = "🗡️" |}
                    {| text = "Mhh… das Chaos tanzt nach meiner Pfeife."; emoji = "🎶" |}
                    {| text = "Brav gekämpft, Genny… brav…"; emoji = "😈" |}
                    {| text = "Hissss… Erfolg riecht nach Angst."; emoji = "👃" |}
                    {| text = "Meine Schwänze jubeln, meine Zähne lachen."; emoji = "😁" |}
                |]
                Generic,
                [|
                    {| text = "Hörst du das Kratzen? Die Wände haben Hunger."; emoji = "🕳️" |}
                    {| text = "Zwei Schwänze, doppelt so viel Gift."; emoji = "🐀" |}
                    {| text = "Shhh… still! Ich will das Zappeln hören."; emoji = "🐍" |}
                    {| text = "Alles ist schöner, wenn es blutet."; emoji = "🩸" |}
                    {| text = "Hehehe… meine Hände sind klein, aber sie greifen fest."; emoji = "✋" |}
                    {| text = "Dein Atem stinkt nach Angst."; emoji = "👃" |}
                    {| text = "Krone aus Knochen, Herz aus Hunger."; emoji = "💀" |}
                    {| text = "Ratten laufen nie allein – außer ich, ich laufe über dir."; emoji = "😈" |}
                    {| text = "Lass uns spielen… wer zuerst schreit, verliert."; emoji = "🎲" |}
                    {| text = "Zwei Schwänze winden sich, wenn ich lache."; emoji = "😁" |}
                |]
            |]



    let Beretta = {
        name = "Beretta"
        description = "A corny artificer companion to help you on your adventures!"
        avatarUrl = AppHelper.BerettaImagePath
        voiceUris = Beretta.voiceIds
        messages = Beretta.Messages
        basePitch = 1.1
        baseRate = 1.05
        theme = Theme.Highkeyturbo
    }

    let Genny = {
        name = "Genny Two-Tail"
        description = "A twisted ratling companion to help you on your adventures!"
        avatarUrl = AppHelper.GennyImagePath
        voiceUris = Genny.voiceIds
        messages = Genny.Messages
        basePitch = 1.8
        baseRate = 1.5
        theme = Theme.Dripfrost
    }

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

    static member CompanionItem(companion: Companion, isActive: bool, setCompanion: Companion -> unit) =
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
            prop.className "w-full p-2 flex"
            prop.children [
                Html.button [
                    prop.className "btn btn-sm btn-square ml-auto"
                    prop.children [ App.IconCog(className = "") ]
                    prop.onClick (fun _ -> document.getElementById(modalId)?showModal() |> ignore)
                ]
            ]
        ]

    static member Settings(modalId: string, volume: int, setVolume: int -> unit, companion: Companion, setCompanion: Companion -> unit) =
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

                                        App.CompanionItem(Companions.Beretta, (companion = Companions.Beretta), setCompanion = setCompanion)
                                        App.CompanionItem(Companions.Genny, (companion = Companions.Genny), setCompanion = setCompanion)
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

    [<ReactComponent>]
    static member Main() =

        let speak = rtts.useSpeak ()
        let storedCompanion, setStoredCompanion = React.useLocalStorage<string>(AppHelper.__APP_NAME__ + "_companion", Companions.Beretta.name)

        let companions = React.useMemo(fun () ->
            [Companions.Beretta; Companions.Genny]
        )

        let initCompanion = companions |> List.tryFind (fun c -> c.name = storedCompanion) |> Option.defaultValue Companions.Beretta

        let companion, setCompanion = React.useState<Companion> (initCompanion)

        let messages, setMessages = React.useState<MessageLog list> []

        let volume, setVolume = React.useLocalStorage<int>(AppHelper.__APP_NAME__ + "_volume", 100)

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

            console.log(volume)

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
                    prop.className "flex grow overflow-hidden flex-col items-center gap-6 p-6 md:p-10"
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
                        App.Chat(speech = speak, msgs = messages, companion = companion)
                    ]
                ]
            ]
        ]