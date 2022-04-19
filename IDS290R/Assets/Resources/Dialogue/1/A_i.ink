-> main

=== main===

// start converstaion
Ciao #speaker:Abdullah
    + [practica del parlare?]
        -> chat
    + [sfida di gioco]
        #scene:Word_Match_MainMenu
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
Lavori?
    +[Si, lavoro]
        Ah, molto bene
        ->DONE
    +[No, non lavoro]
        Anch’io
        ->DONE
===a===
Parli Italiano?
    +[Si, parlo Italiano]
        Ah, molto bene
        ->DONE
    +[No, non parlo Italiano]
        Studia Italiano!
        ->DONE

===e===
Pronuncia di “che”?
    +[È “keh”]
        Si, bravissimo
        ->DONE
    +[È “chee”]
        No, scusa
        ->DONE


-> END