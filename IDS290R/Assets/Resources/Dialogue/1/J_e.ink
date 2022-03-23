-> main

=== main===

// start converstaion
Hello! #speaker:J
    + [Chat?]
        -> chat
    + [Give me a challange?]
        #scene:Asteroid
        -> DONE
    + [Nothing, just say hi.]
        Ok, bye.
        -> DONE

=== chat ===
I eat toast for breakfast. What do you eat?
    + [I eat bread with marmalade]
        I don’t like marmalade
        -> DONE
    + [I eat fruit salad]
        I like fruit salad
        -> DONE

-> END