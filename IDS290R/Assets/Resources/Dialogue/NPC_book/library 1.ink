-> main

=== main===

// start converstaion
Cosa vuoi? #speaker:Librarian
    + [Chiacchierata?]
        -> chat
    + [Mi dai una sfida?]
        Sure. #scene:Asteroid
        -> DONE
    + [Niente, saluta.]
        Ok ciao.
        -> DONE

=== chat ===
Come stai? 
    * [Buona]
    * [Bad]
- OK
-> DONE

-> END