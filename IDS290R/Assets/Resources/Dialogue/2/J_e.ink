-> main

=== main===

// start converstaion
Good afternoon #speaker:J
    + [Chat?]
        -> chat
    + [Give me a challange?]
        #scene:AsteroidMainMenu
        -> DONE
    + [Nothing, just say hi.]
        Ok, bye.
        -> DONE

=== chat ===
What time is it?
    + [it is 13:00]
        Time for lunch
        -> DONE
    + [it is 15:10]
        I have a lesson in 20 minutes
        -> DONE

-> END