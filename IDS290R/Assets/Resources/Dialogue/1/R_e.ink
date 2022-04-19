-> main

=== main===

// start converstaion
Hi #speaker:Ruby
    + [talking practice]
        -> chat
    + [game challenge]
        #scene:QuizGame_MainMenu
        -> DONE
    + [nothing]
        ok bye
        -> DONE

=== chat ===
Hello！
    +[good morning]
        ->m
    +[good afternoon]
        ->a
    +[good evening]
        ->e


=== m ===
how do you pronounce “ci”
    +[it is “see”]
        no, sorry
        ->DONE
    +[it is “chee”]
        yes, good job
        ->DONE
===a===
do you listen to music
    +[yes, I listen to music]
        me too
        ->DONE
    +[No, I do not listen to music]
        the music is good
        ->DONE

===e===
How are you
    +[well]
        good
        ->DONE
    +[bad/poorly]
        I’m sorry
        ->DONE


-> END