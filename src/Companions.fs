module App.Companions


module private Beretta =

    let BerettaImagePath = Fable.Core.JsInterop.importDefault "./img/beretta_ava.png"

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

    let voiceIds = Map [| Languages.German, [||] |]

    let GennyImagePath: string =
        Fable.Core.JsInterop.importDefault "./img/genny_ava.png"

    let TrueGennyImagePath: string =
        Fable.Core.JsInterop.importDefault "./img/genny_red_ava.png"

    let Messages =
        Map.ofArray [|
            Idea,
            [|
                {|
                    text = "Oooh… du hast eine Idee? Lass uns sehen, ob sie zappelt, wenn man sie aufschlitzt."
                    emoji = "🐀"
                |}
                {|
                    text = "Ideen, Ideen, Ideen! Wie Knochen knacken und das Mark ausschlürfen."
                    emoji = "💀"
                |}
                {|
                    text = "Hm, clever… aber schreit sie auch, wenn ich zusteche?"
                    emoji = "🗡️"
                |}
                {|
                    text = "Zwei Schwänze, zwei Pläne… meiner ist schärfer."
                    emoji = "⚔️"
                |}
                {|
                    text = "Deine Idee riecht… lecker. Soll ich sie für dich zerbeißen?"
                    emoji = "😈"
                |}
                {|
                    text = "Flüstere es nochmal… langsamer. Ich will, dass die Worte in meinem Kopf zappeln."
                    emoji = "🐍"
                |}
                {|
                    text = "Ja, ja! Lass uns den Plan ausweiden und ihn als Krone tragen."
                    emoji = "👑"
                |}
                {|
                    text = "Hissss… Ideen sind nur Lügen mit hübschem Lippenstift."
                    emoji = "💋"
                |}
                {|
                    text = "Mein Plan lacht, wenn deiner stirbt."
                    emoji = "🔥"
                |}
                {|
                    text = "Ooooh, ein Plan! Lass uns Blut drauf spritzen!"
                    emoji = "💡"
                |}
                {|
                    text = "Hehehe… deine Ideen riechen nach Sieg und Tod."
                    emoji = "🐀"
                |}
                {|
                    text = "Ja, ja! Mach’s so, und ich kicher, bis jemand stirbt."
                    emoji = "😈"
                |}
                {|
                    text = "Brillant! Ich beiß die Kehlen auf, du denkst dir die Wege aus."
                    emoji = "🦷"
                |}
                {|
                    text = "Ohhh, eine Idee! Ich halte schon die Messer bereit."
                    emoji = "🔪"
                |}
                {|
                    text = "Deine Gedanken glänzen wie Knochen im Mondlicht."
                    emoji = "🌙"
                |}
                {|
                    text = "Hihihi! Ich liebe es, wenn ihr plant – dann kann ich schlitzen."
                    emoji = "🗡️"
                |}
                {|
                    text = "Zwei Schwänze, ein Hirn – und dein Plan macht uns stark!"
                    emoji = "🐁"
                |}
                {|
                    text = "Ohhh ja! Ich folge dir, bis die Schreie verstummen."
                    emoji = "💀"
                |}
                {|
                    text = "Deine Idee ist köstlich… fast so köstlich wie Angst."
                    emoji = "👁️"
                |}
            |]
            GoodAction,
            [|
                {|
                    text = "Gut gemacht… für eine Ratte ohne Schwanz."
                    emoji = "🐀"
                |}
                {|
                    text = "Ohhh, Blut tropft süßer, wenn man’s richtig macht. Hübsch!"
                    emoji = "🩸"
                |}
                {|
                    text = "Hehehe… du lernst! Bald bist du fast so nützlich wie ein abgenagter Knochen."
                    emoji = "🦴"
                |}
                {|
                    text = "Ja! Mach’s nochmal – ich will hören, wie die Welt quietscht."
                    emoji = "😈"
                |}
                {|
                    text = "Schön, schön… vielleicht stech’ ich dich später nicht ab."
                    emoji = "🗡️"
                |}
                {|
                    text = "Oh, ich mag das! Fast so glitzernd wie mein Ring."
                    emoji = "💍"
                |}
                {|
                    text = "Guter Zug… er schmeckt nach Angst."
                    emoji = "👅"
                |}
                {|
                    text = "Mhh… das war fast elegant. Beinahe wie ich."
                    emoji = "⚔️"
                |}
                {|
                    text = "Brav, brav… der Plan wackelt nicht mal."
                    emoji = "🐁"
                |}
                {|
                    text = "Hehehe! Du hast’s geschafft – jetzt noch tiefer schneiden!"
                    emoji = "🔪"
                |}
                {|
                    text = "Bravo, bravo! Ich leck dir das Blut von den Händen."
                    emoji = "🩸"
                |}
                {|
                    text = "So stark! So grausam! Genau wie ich’s liebe."
                    emoji = "😈"
                |}
                {|
                    text = "Hihihi! Meister stolz, Genny stolz – alle tot!"
                    emoji = "🐀"
                |}
                {|
                    text = "Ohhh, was für ein Schlag! Ich hör die Knochen tanzen!"
                    emoji = "💀"
                |}
                {|
                    text = "Dein Erfolg ist mein Futter, ich schlemme an deinem Ruhm!"
                    emoji = "🍖"
                |}
                {|
                    text = "Gut gemacht! Zwei Schwänze klatschen für dich!"
                    emoji = "🐁"
                |}
                {|
                    text = "Ja, ja, mehr davon! Deine Klinge singt süßer als ich kichern kann."
                    emoji = "🗡️"
                |}
                {|
                    text = "So will ich’s sehen! Wir sind Albträume, die wahr werden."
                    emoji = "🌑"
                |}
                {|
                    text = "Hehehe! Dein Triumph macht meinen Schwanz ganz zappelig."
                    emoji = "🐀"
                |}
                {|
                    text = "Ein Treffer! Ich hör die Seele schreien!"
                    emoji = "👂"
                |}
                {|
                    text = "Wundervoll! Ich tanze auf den Knochen deiner Opfer."
                    emoji = "💃"
                |}
                {|
                    text = "Ohhh, wie herrlich! Ich will’s nochmal sehen, gleich nochmal!"
                    emoji = "👁️"
                |}
                {|
                    text = "Du bist so grausam, ich könnte dich knuddeln – und zerbeißen!"
                    emoji = "🦷"
                |}
                {|
                    text = "Ja! Blut spritzt, Herzen brechen – wir gewinnen!"
                    emoji = "❤️"
                |}
                {|
                    text = "Ohhh, mein Held, mein Monster – so soll es sein!"
                    emoji = "🌙"
                |}
                {|
                    text = "Hehehe… deine Stärke nährt meinen Wahnsinn!"
                    emoji = "🔥"
                |}
                {|
                    text = "Zwei Schwänze für dich, ein Kichern für mich!"
                    emoji = "🐀"
                |}
                {|
                    text = "Hihihi! Sieg riecht nach Eisen und Angst – köstlich!"
                    emoji = "👃"
                |}
                {|
                    text = "So schön! Dein Erfolg klingt wie mein Lachen!"
                    emoji = "🎭"
                |}
            |]
            BadAction,
            [|
                {|
                    text = "Pfui! Selbst meine Schwänze hätten’s besser gemacht."
                    emoji = "🐀"
                |}
                {|
                    text = "Ugh… du bist so nützlich wie ein morscher Knochen."
                    emoji = "🦴"
                |}
                {|
                    text = "Ich hätte es mit geschlossenem Maul besser hingekriegt."
                    emoji = "😏"
                |}
                {|
                    text = "Oh, wie herrlich! Dein Scheitern klingt wie Musik."
                    emoji = "🎻"
                |}
                {|
                    text = "Schon wieder daneben? Ich rieche Dummheit."
                    emoji = "👃"
                |}
                {|
                    text = "Mein Ring glänzt heller als dein jämmerlicher Versuch."
                    emoji = "💍"
                |}
                {|
                    text = "Zappeln, stolpern, scheitern – mach weiter, ich amüsiere mich."
                    emoji = "😈"
                |}
                {|
                    text = "Hahaha! Ein Fehlschlag? Ich nenn’s köstlich."
                    emoji = "🩸"
                |}
                {|
                    text = "Fehler, Blut, Tränen – beste Mischung."
                    emoji = "💀"
                |}
                {|
                    text = "Daneben! Hehehe… der Gestank von Versagen gefällt mir."
                    emoji = "🐀"
                |}
                {|
                    text = "Misslungen? Dann schmeckt’s nach Angst, genau richtig."
                    emoji = "😈"
                |}
                {|
                    text = "Ohhh, so herrlich schief – ich könnt mich drin wälzen."
                    emoji = "🕳️"
                |}
                {|
                    text = "Patzer! Jeder Knochen knirscht lauter, wenn man stolpert."
                    emoji = "🦴"
                |}
                {|
                    text = "Hehehe, versagt! Noch ein Grund, alles kaputtzumachen."
                    emoji = "🗡️"
                |}
                {|
                    text = "Blut rinnt auch ohne Treffer, hahahaha!"
                    emoji = "🩸"
                |}
                {|
                    text = "Schwach? Nein… das ist einfach schön dreckig."
                    emoji = "🪤"
                |}
                {|
                    text = "Dein Scheitern macht die Welt hässlicher. Ich liebe es."
                    emoji = "🔥"
                |}
                {|
                    text = "Hihihi… kein Treffer? Dann machen wir eben mehr Lärm."
                    emoji = "🎭"
                |}
                {|
                    text = "Stolpern, fallen, verrecken – klingt wie Musik."
                    emoji = "🎶"
                |}
                {|
                    text = "Fehler sind wie Wunden: offen, stinkend, lebendig."
                    emoji = "🤢"
                |}
                {|
                    text = "Ein Schuss ins Leere… genau mein Humor."
                    emoji = "🔫"
                |}
                {|
                    text = "Je mieser es läuft, desto schöner wird der Abgrund."
                    emoji = "🕷️"
                |}
                {|
                    text = "Daneben! Das Chaos frisst euch doch alle, hehe."
                    emoji = "⚡"
                |}
                {|
                    text = "Patzen heißt nur: mehr Blut beim zweiten Versuch."
                    emoji = "💉"
                |}
                {|
                    text = "Hehehe… scheitern riecht besser als Sieg."
                    emoji = "👃"
                |}
                {|
                    text = "Zerbrochen, verdorben, vermasselt – genau mein Geschmack."
                    emoji = "🍖"
                |}
                {|
                    text = "Aus Fehlern wächst Verzweiflung… und die nährt mich."
                    emoji = "🌑"
                |}
            |]
            BadActionSelf,
            [|
                {|
                    text = "Hah! So sollte es aussehen – Chaos mit Stil."
                    emoji = "🔥"
                |}
                {|
                    text = "Ups? Nein, Absicht! Ich liebe, wenn’s brennt."
                    emoji = "😈"
                |}
                {|
                    text = "Tz… der Knochen war schief, nicht meine Schuld."
                    emoji = "🦴"
                |}
                {|
                    text = "Ohhh, wie herrlich! Selbst Fehler schmecken nach Blut."
                    emoji = "🩸"
                |}
                {|
                    text = "Pff! Ich wollte nur testen, wie weit ich gehen kann."
                    emoji = "⚔️"
                |}
                {|
                    text = "War das schlecht? Für mich sieht’s nach Kunst aus."
                    emoji = "🎭"
                |}
                {|
                    text = "Hissss… meine Schwänze haben mich abgelenkt."
                    emoji = "🐍"
                |}
                {|
                    text = "Na und? Ratten landen immer auf den Pfoten."
                    emoji = "🐀"
                |}
                {|
                    text = "Hehehe… versaut! Perfekt, genau so wollte ich’s… fast."
                    emoji = "🩸"
                |}
                {|
                    text = "Scheiße! Blut spritzt, aber nicht genug… noch einmal!"
                    emoji = "💀"
                |}
                {|
                    text = "Mist! Hahaha, das tut weh… aber nicht mir, ha!"
                    emoji = "😈"
                |}
                {|
                    text = "Daneben! Ohhh, wie herrlich chaotisch!"
                    emoji = "🗡️"
                |}
                {|
                    text = "Hihihi… ich stolpere selbst, und es schmeckt nach Sieg."
                    emoji = "🐀"
                |}
                {|
                    text = "Verpatzt! Aber so riecht das Spiel besser, hahahaha!"
                    emoji = "🔥"
                |}
                {|
                    text = "Mist, Mist, Mist! Blutige Finger sind schöne Finger."
                    emoji = "🦷"
                |}
                {|
                    text = "Hehehe… ich fall, ich krach, und alle schreien – herrlich!"
                    emoji = "🕳️"
                |}
                {|
                    text = "Patzer! Genau mein Humor, noch mehr Chaos bitte."
                    emoji = "🎭"
                |}
                {|
                    text = "Fehler? Perfekt! Ich liebe das Geräusch von zerbrechendem Metall."
                    emoji = "⚡"
                |}
                {|
                    text = "Scheitern fühlt sich gut an, wenn es so schön blutig ist."
                    emoji = "🩸"
                |}
                {|
                    text = "Hahaha! Ich zertrümmer alles… sogar mich selbst."
                    emoji = "💣"
                |}
                {|
                    text = "Ohhh, daneben! Ich wachse am Geruch von verbranntem Fleisch."
                    emoji = "🔥"
                |}
                {|
                    text = "Mist! Noch ein Fehltritt, und die Welt brennt besser."
                    emoji = "🌑"
                |}
                {|
                    text = "Scheiße! Aber ich lache, während alles auseinanderfällt."
                    emoji = "🎶"
                |}
                {|
                    text = "Hihihi… selbst ich kann mich ruinieren – und es ist köstlich."
                    emoji = "🍖"
                |}
                {|
                    text = "Verpatzt! Perfekte Vorbereitung für den nächsten Schlag."
                    emoji = "🗡️"
                |}
                {|
                    text = "Mist! Stolpern, fallen, zerreißen – alles gehört mir."
                    emoji = "🕷️"
                |}
                {|
                    text = "Hahaha… ich bin das Chaos, selbst wenn ich falle."
                    emoji = "💀"
                |}
                {|
                    text = "Daneben! Und doch fühlt es sich richtig pervers gut an."
                    emoji = "😈"
                |}
            |]
            GoodActionSelf,
            [|
                {|
                    text = "Hehehe… seht ihr? Zwei Schwänze, zwei Siege."
                    emoji = "🐀"
                |}
                {|
                    text = "Ohhh, das war köstlich! Fast so süß wie Blut."
                    emoji = "🩸"
                |}
                {|
                    text = "Ich glänze heller als mein Ring – und der blendet schon."
                    emoji = "💍"
                |}
                {|
                    text = "Knirsch, knack… so klingen gebrochene Hoffnungen."
                    emoji = "💀"
                |}
                {|
                    text = "Ha! Niemand sticht so fein wie ich."
                    emoji = "🗡️"
                |}
                {|
                    text = "Mhh… das Chaos tanzt nach meiner Pfeife."
                    emoji = "🎶"
                |}
                {|
                    text = "Brav gekämpft, Genny… brav…"
                    emoji = "😈"
                |}
                {|
                    text = "Hissss… Erfolg riecht nach Angst."
                    emoji = "👃"
                |}
                {|
                    text = "Meine Schwänze jubeln, meine Zähne lachen."
                    emoji = "😁"
                |}
                {|
                    text = "Ha! Zwei Schwänze, zwei Siege – genau wie ich es liebe."
                    emoji = "🐀"
                |}
                {|
                    text = "Perfekt! Blut, Knochen, Chaos – alles unter meiner Kontrolle."
                    emoji = "💀"
                |}
                {|
                    text = "Hehehe… Treffer! Mein Messer singt, mein Herz tanzt."
                    emoji = "🗡️"
                |}
                {|
                    text = "Hihihi! Ich hab’s geschafft – und es blutet so schön."
                    emoji = "🩸"
                |}
                {|
                    text = "Brillant! Mein Wahnsinn wirkt, und alles zerfällt."
                    emoji = "🔥"
                |}
                {|
                    text = "Ohhh, wie herrlich! Sieg schmeckt nach Eisen und Angst."
                    emoji = "⚡"
                |}
                {|
                    text = "Zwei Schwänze, ein Plan, und jeder fällt, wie ich will."
                    emoji = "🐁"
                |}
                {|
                    text = "Hehehe… mein Triumph ist so köstlich, wie das Schreien der Opfer."
                    emoji = "😈"
                |}
                {|
                    text = "Ich hab’s getan! Alles knirscht und kracht perfekt."
                    emoji = "🦴"
                |}
                {|
                    text = "Hahaha! Ein Schritt vorwärts, ein Schrei hinter mir – großartig."
                    emoji = "👂"
                |}
                {|
                    text = "Hehehe… Sieg ist Blut, und Blut ist mein Lied."
                    emoji = "🎶"
                |}
                {|
                    text = "Brillant! Mein Wahnsinn ist effektiv, köstlich effektiv."
                    emoji = "💣"
                |}
                {|
                    text = "Ha! Die Klinge tanzte, und ich kicherte… perfekt."
                    emoji = "💃"
                |}
                {|
                    text = "Hehehe… alles nach Plan, und mein Chaos glänzt."
                    emoji = "🌑"
                |}
                {|
                    text = "Hihihi! Ich bin das Chaos, ich bin der Schlag – Erfolg!"
                    emoji = "🗡️"
                |}
                {|
                    text = "Treffer! Knochen brechen, Herz klopft – alles richtig."
                    emoji = "💀"
                |}
                {|
                    text = "Perfekt! Ein blutiger Tanz, und ich führe die Musik."
                    emoji = "🎵"
                |}
                {|
                    text = "Hehehe… alles fällt, alles bricht, alles gehört mir."
                    emoji = "🔥"
                |}
                {|
                    text = "Hihihi! Sieg riecht nach Eisen, Angst und Wahnsinn."
                    emoji = "👃"
                |}
                {|
                    text = "Zwei Schwänze, ein Erfolg, und alles schreit wie geplant."
                    emoji = "🐀"
                |}
            |]
            Generic,
            [|

                {|
                    text = "Hahaha! Chaos ist mein Spielplatz, Blut mein Spielzeug."
                    emoji = "🔥"
                |}
                {|
                    text = "Hörst du das Kratzen? Die Wände haben Hunger."
                    emoji = "🕳️"
                |}
                {|
                    text = "Zwei Schwänze, doppelt so viel Gift."
                    emoji = "🐀"
                |}
                {|
                    text = "Shhh… still! Ich will das Zappeln hören."
                    emoji = "🐍"
                |}
                {|
                    text = "Alles ist schöner, wenn es blutet."
                    emoji = "🩸"
                |}
                {|
                    text = "Hehehe… meine Hände sind klein, aber sie greifen fest."
                    emoji = "✋"
                |}
                {|
                    text = "Dein Atem stinkt nach Angst."
                    emoji = "👃"
                |}
                {|
                    text = "Krone aus Knochen, Herz aus Hunger."
                    emoji = "💀"
                |}
                {|
                    text = "Ratten laufen nie allein – außer ich, ich laufe über dir."
                    emoji = "😈"
                |}
                {|
                    text = "Lass uns spielen… wer zuerst schreit, verliert."
                    emoji = "🎲"
                |}
                {|
                    text = "Zwei Schwänze winden sich, wenn ich lache."
                    emoji = "😁"
                |}
                {|
                    text = "Ohhh… riechst du die Angst? Ich rieche sie schon seit Stunden."
                    emoji = "👃"
                |}
                {|
                    text = "Perfekt! Jeder Schritt zerbricht… genau wie geplant."
                    emoji = "💀"
                |}
                {|
                    text = "Hehehe… ich kicher, während alles auseinanderfällt."
                    emoji = "🎭"
                |}
                {|
                    text = "Hihihi! Noch ein Schrei, noch ein Splittern… köstlich."
                    emoji = "🗡️"
                |}
                {|
                    text = "Zwei Schwänze, ein Grinsen… ich warte nur auf Blut."
                    emoji = "🐁"
                |}
                {|
                    text = "Hahaha! Alles ist Chaos, und ich liebe es… alles gehört mir."
                    emoji = "🌑"
                |}
                {|
                    text = "Hehehe… Knochen knirschen, Herzen rasen, und ich lache."
                    emoji = "🦴"
                |}
                {|
                    text = "Ohhh, das Zittern! Ich könnte ewig zuhören…"
                    emoji = "👂"
                |}
                {|
                    text = "Perfekt! Angst schmeckt salzig, Blut schmeckt besser."
                    emoji = "🩸"
                |}
                {|
                    text = "Hihihi! Mein Lachen ist lauter als jedes Schicksal."
                    emoji = "😈"
                |}
                {|
                    text = "Hehehe… der Abgrund ruft, und ich tanze darin."
                    emoji = "💃"
                |}
                {|
                    text = "Zwei Schwänze, ein Chaos… alles gehört mir."
                    emoji = "🐀"
                |}
                {|
                    text = "Hahaha! Jeder Schritt ein Schritt ins Verderben."
                    emoji = "⚡"
                |}
                {|
                    text = "Ohhh, wie herrlich! Schreie, Splitter, Wahnsinn… perfekt."
                    emoji = "🔥"
                |}
                {|
                    text = "Hihihi… alles fällt, alles zerbricht, und ich liebe es."
                    emoji = "💀"
                |}
                {|
                    text = "Hehehe… noch ein Herz, noch ein Schrei, noch ein Spiel."
                    emoji = "🕷️"
                |}
            |]
        |]



let Beretta = {
    name = "Beretta"
    description = "A corny artificer companion to help you on your adventures!"
    avatarUrl = Beretta.BerettaImagePath
    voiceUris = Beretta.voiceIds
    messages = Beretta.Messages
    basePitch = 1.1
    baseRate = 1.05
    theme = Theme.Highkeyturbo
}

let TrueGenny = {
    name = "Genny Two-Tail"
    description = "A twisted ratling companion to help you on your adventures!"
    avatarUrl = Genny.TrueGennyImagePath
    voiceUris = Genny.voiceIds
    messages = Genny.Messages
    basePitch = 1.8
    baseRate = 1.5
    theme = Theme.Dripfrost
}

let Genny = {
    name = "Genny Two-Tail"
    description = "A twisted ratling companion to help you on your adventures!"
    avatarUrl = Genny.GennyImagePath
    voiceUris = Genny.voiceIds
    messages = Genny.Messages
    basePitch = 1.8
    baseRate = 1.5
    theme = Theme.Dripfrost
}