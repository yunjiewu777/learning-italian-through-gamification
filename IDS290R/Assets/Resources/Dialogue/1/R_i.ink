-> main

=== main===

// start converstaion
Ciao #speaker:Ruby
    + [practica del parlare?]
        -> chat
    + [sfida]
        #scene:QuizGame_MainMenu
        -> DONE
    + [niente]
        ok, ciao
        -> DONE

=== chat ===
Ciao! 
    +[Buongiorno]
        ->m
    +[Buon pomeriggio]
        ->a
    +[Buonasera]
        ->e


=== m ===
Pronuncia di “ci”?
    +[È “see”]
        No, peccato!
        ->DONE
    +[È “chee”]
        Sì, giusto!
        ->DONE
===a===
Ascolti musica?
    +[Sì, ascolto musica]
        Anch’io
        ->DONE
    +[No, non ascolto musica]
        La musica è buona
        ->DONE

===e===
Come stai?
    +[Bene]
        Mi fa piacere
        ->DONE
    +[Male]
        Mi dispiace
        ->DONE


-> END