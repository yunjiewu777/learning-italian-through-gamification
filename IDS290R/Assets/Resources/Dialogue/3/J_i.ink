-> main

=== main===

// start converstaion
Buonasera #speaker:J
    + [Chiacchierata?]
        -> chat
    + [Mi dai una sfida?]
        #scene:AsteroidMainMenu
        -> DONE
    + [Niente, saluta.]
        Ok ciao.
        -> DONE

=== chat ===
Vado a casa tra 15 minuti. Fai?
    + [Sì]
        Ci vediamo domani!
        -> DONE
    + [No, ho lavoro]
        Buona fortuna!
        -> DONE

-> END