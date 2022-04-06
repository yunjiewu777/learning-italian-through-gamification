-> main

=== main===

// start converstaion
Buon pomeriggio #speaker:J
    + [Chiacchierata?]
        -> chat
    + [Mi dai una sfida?]
        #scene:AsteroidMainMenu
        -> DONE
    + [Niente, saluta.]
        Ok ciao.
        -> DONE

=== chat ===
Che ora sono?
    + [Sono le tredici]
        Ora di pranzo
        -> DONE
    + [Sono le quindici e dieci]
        Ho una lezione tra venti minuti
        -> DONE

-> END