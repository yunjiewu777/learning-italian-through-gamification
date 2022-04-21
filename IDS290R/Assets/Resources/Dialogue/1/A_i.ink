-> main

=== main===

// start converstaion
Ciao #speaker:Abdullah
    + [practica del parlare?]
        -> chat
    + [sfida]
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
    +[Sì, lavoro]
        Ah, molto bene
        ->DONE
    +[No, non lavoro]
        Neanche io
        ->DONE
===a===
Parli Italiano?
    +[Sì, parlo Italiano]
        Ah, molto bene
        ->DONE
    +[No, non parlo Italiano]
        Studia Italiano!
        ->DONE

===e===
Pronuncia di “che”?
    +[È “keh”]
        Sì, giusto!
        ->DONE
    +[È “chee”]
        No, peccato!
        ->DONE


-> END