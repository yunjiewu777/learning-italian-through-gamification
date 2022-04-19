-> main

=== main===

// start converstaion
Hi #speaker:Abdullah
    + [talking practice]
        -> chat
    + [game challenge]
        #scene:Word_Match_MainMenu
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
do you work?
    +[yes, I work]
        Ah, very good
        ->DONE
    +[No, I do not work]
        me too
        ->DONE
===a===
Do you speak Italian?
    +[yes, I speak italian]
        Ah, very good
        ->DONE
    +[No I do not speak Italian]
        Study Italian
        ->DONE

===e===
Where are you from?
    +[it is “keh"]
        yes, good job
        ->DONE
    +[it is “chee”]
        No, sorry
        ->DONE


-> END