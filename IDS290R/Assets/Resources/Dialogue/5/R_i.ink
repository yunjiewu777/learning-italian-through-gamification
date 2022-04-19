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
Puoi leggere bene l’Italiano?
    +[Si, posso leggere bene l’Italiano]
        Bravissimo!
        ->DONE
    +[No, devo leggere molto lentamente]
        Va bene
        ->DONE

-> END