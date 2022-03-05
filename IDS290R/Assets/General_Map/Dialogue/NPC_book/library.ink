-> main

=== main===
// start converstaion
What do you want? #speaker:Librarian
    + [Chat?]
        -> chat
    + [Give me a challange?]
        Sure. #scene:Asteroid
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