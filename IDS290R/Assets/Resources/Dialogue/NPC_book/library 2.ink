-> main

=== main===
What do you want? #speaker:Librarian
    + [Chat?]
        -> chat
    + [Do you need any help?]
        Oh yeah! Here you are.
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