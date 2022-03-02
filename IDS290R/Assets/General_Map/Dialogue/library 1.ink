-> main

=== main===
// start converstaion
Cosa vuoi?
    + [Chiacchierata?]
        -> chat
    + [Mi dai una sfida?]
        Sure.
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