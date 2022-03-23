-> main

=== main===

// start converstaion
Good evening！ #speaker:J
    + [Chat?]
        -> chat
    + [Give me a challange?]
        #scene:Asteroid
        -> DONE
    + [Nothing, just say hi.]
        Ok, bye.
        -> DONE

=== chat ===
I go home in 15 minutes. Do you?
    + [yes]
        see you tomorrow
        -> DONE
    + [No, i have work]
        good luck
        -> DONE

-> END