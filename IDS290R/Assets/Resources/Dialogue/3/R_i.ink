-> main

=== main===

// start converstaion
Ciao #speaker:Ruby
    + [practica del parlare?]
        -> chat
    + [sfida di gioco]
        #scene:QuizGame_MainMenu
        -> DONE
    + [niente]
        ok, ciao
        -> DONE

=== chat ===
Vado a casa tra 15 minuti. Fai?
    +[Sì]
        Ci vediamo domani!
        ->DONE
    +[No, ho lavoro]
        Buona fortuna!
        ->DONE

-> END