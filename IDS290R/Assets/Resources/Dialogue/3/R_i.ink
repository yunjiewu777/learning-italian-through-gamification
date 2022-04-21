-> main

=== main===

// start converstaion
Ciao #speaker:Ruby
    + [practica del parlare?]
        -> chat
    + [sfida]
        #scene:QuizGame_MainMenu
        -> DONE
    + [niente]
        ok, ciao
        -> DONE

=== chat ===
Vado a casa tra 15 minuti. Anche tu?
    +[Sì]
        Ci vediamo domani!
        ->DONE
    +[No, devo lavorare]
        Buon lavoro!
        ->DONE

-> END