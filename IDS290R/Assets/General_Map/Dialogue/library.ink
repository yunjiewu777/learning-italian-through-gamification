-> main

=== main===
// start converstaion
What do you want?
    + [Chat?]
        -> chat
    + [Give me a challange?]
        Sure.
        -> DONE
    + [Nothing, just say hi.]
        Ok, bye.
        -> DONE

=== chat ===
How are you?
    * [Good]
    * [Bad]
- OK
-> DONE

-> END