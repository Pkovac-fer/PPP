# PPP

Skripta za rad s dekompajlerima se nalazi u datoteci Skripta/main i zove se Main.py


Naredbe ovog programa su: -D, -C, -DA, -DQ

Naredba -D (Decompile) dekompajlira jednu izvršnu datoteku i prima 2 argumenta: Dekompajler koji se koristiti (ilspy/justdecompile) i putanja do datoteke kompajliranog C# programa (.exe ili .dll).
Naredba -C (Compare) uspoređuje dvije datoteke i prima 2 argumenta: Izvorni program i dekompajlirani program.
Naredba -DA (Decompile All) dekompajlira jednu izvršnu datoteku koristeći svaki dekompajler i prima 1 arugment: putanju do datoteke kompajliranog C# programa (.exe ili .dll).
Naredba -DQ (Decompiler Quality) uspoređuje dvije dekompajlirane datoteka istog izvršnog koda i prima 2 argumenta: putanje do datoteka dekompajliranih s 2 različita dekompajlera.
        -DQ može primiti dodatni paramtetar SHOW koja će pokazivati međurezultate dobivene tijekom izvođenja programa

Skripta trenutno radi s dva dekompajlera, ILSpy i JustDecompile.
Rezultati dekompilacije se nalaze u datoteci Rezultati.
Predlošci za dekompilaciju i komparaciju se nalaze u datoteci Originalni_Primjeri
