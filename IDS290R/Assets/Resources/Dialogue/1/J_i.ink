-> main

=== main===

// start converstaion
Ciao! #speaker:J
    + [Chiacchierata?]
        -> chat
    + [Mi dai una sfida?]
        #scene:AsteroidMainMenu
        -> DONE
    + [Niente, saluta.]
        Ok ciao.
        -> DONE

=== chat ===
Mangio pane tostato a colazione. Cosa Mangi?
    + [Mangio il pane alla marmellata]
        Non mi piace la marmellata
        ->DONE
    + [Mangio macedonia]
        Mi piace la macedonia
        ->DONE
-> DONE

-> END