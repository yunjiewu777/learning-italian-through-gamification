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
Sei andato a lavorare ieri?
    +[Si, sono andato a lavorare a quindici e un quarto, ieri]
        sono contento!
        ->DONE
    +[No, non sono andato a lavorare ieri, ma sono andato a lavorare oggi alle dieci.]
        sono contento!
        ->DONE
-> END