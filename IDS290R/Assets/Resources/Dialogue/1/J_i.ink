-> main

=== main===

// start converstaion
Ciao #speaker:Julianna
    + [practica del parlare?]
        -> chat
    + [sfida di gioco]
        #scene:AsteroidMainMenu
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
Come ti chiami?
    +[Mi chiamo Maria]
        Piacere Maria
        ->DONE
    +[Mi chaimo Giovanni]
        Piacere Giovanni
        ->DONE
===a===
Quanti anni hai?
    +[Ho 21 anni]
        sono vecchio!
        ->DONE
    +[Ho 19 anni]
        Sono vecchio!
        ->DONE

===e===
Di dove sei?
    +[Sono di Londra]
        Benvenuto in Italia
        ->DONE
    +[Sono di Madrid]
        Benvenuto in Italia
        ->DONE


-> END