-> main

=== main===

// start converstaion
Ciao #speaker:Abdullah
    + [practica del parlare?]
        -> chat
    + [sfida]
        #scene:Word_Match_MainMenu
        -> DONE
    + [niente]
        ok, ciao
        -> DONE

=== chat ===
Sei andato a lavorare ieri?
    +[Si, sono andato a lavorare alle quindici e quindici, ieri]
        Bene!
        ->DONE
    +[No, non sono andato a lavorare ieri, ma sono andato a lavorare oggi alle dieci.]
        Bene!
        ->DONE
-> END