Gruppövning

Bygg ett fullständigt API med ett eget användarsystem. Använd controller-service-repository arkitektur. Man skall kunna:

    Skapa användare med namn, email och lösenord minst, som lagras till databas
    Verifiera sin email genom en endpoint (på låtsas, inte genom riktig email)

Användare måste verifiera sitt konto inom 5 minuter annars raderas kontot automatiskt.

Var femte minut skall även en notifikation "skickas ut" till alla användare om olika nyheter (låtsas nyheter). En notifikation kan sparas till databas och hämtas genom en endpoint.