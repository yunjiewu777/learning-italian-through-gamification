-> main

=== main===

// start converstaion
Ciao #speaker:Abdullah
    + [practica del parlare?]
        -> chat
    + [sfida di gioco]
        #scene:Word_Match_MainMenu
        -> DONE
    + [niente]
        ok, ciao
        -> DONE

=== chat ===
Vieni sempre a lezione tardi?
    +[No, non vengo mai a lezione tardi]
        Buono, devi venire in tempo
        ->DONE
    +[Qualche volta arrivo con un minuto di ritardo]
        Qualche volte va bene
        ->DONE
-> END