<p align="center">
Zadatak 1

**Napomena: Klase implementirati tako da atributi imaju najniži mogući nivo pristupa (private ili protected).
Na programskom jeziku C# kreirati:**
1. Apstraktnu klasu Student koja sadrži atribute:
• broj indeksa,
• ime,
• prezime
i sledeće javne metode:
• konstruktor koji postavlja sve atribute,
• apstraktni property koji vraća bodove studenta sa ispita,
• predefinisanu metodu ToString(),
• operatore < i > za poređenje dva objekta klase Student po broju bodova.
2. Klasu StudentFIB izvedenu iz klase Student kod kog se broj bodova na ispitu računa kao zbir bodova sa 1.
kolokvijuma, 2. kolokvijuma i laboratorijskih vežbi i koja sadrži privatne članove:
• atribute za predstavljanje broja bodova sa 1. kolokvijuma, broja bodova sa 2. kolokvijuma i broja
bodova sa laboratorijskih vežbi,
javne:
• konstruktor koji postavlja vrednosti svih atributa.
3. Klasu StudentSAF izvedenu iz klase Student kod kog se broj bodova na ispitu računa kao zbir bodova
pismenog ispita i seminarskog rada i koja sadrži privatne članove:
• atribute za predstavljanje broja bodova sa pismenog ispita i broja bodova sa seminarskog rada,
javne:
• konstruktor koji postavlja vrednosti svih atributa.
4. Klasu Kolekcija koja sadrži atribute:
• maksimalni broj elemenata u kolekciji,
• trenutni broj elemenata u kolekciji,
• niz elemenata tipa Student.
U javnom delu klase definisati sledeće metode:
• konstruktor koji postavlja maksimalni broj elemenata u kolekciji,
• metodu za dodavanje elementa u kolekciju,
• metodu za prikaz svih elemenata kolekcije na standardni izlaz.
5. Interfejs Uredjivac koji sadrži metodu za:
• uređivanje elemenata u zadati redosled (rastući ili opadajući).
6. Klasu UredjenaKolekcija izvedenu iz klase Kolekcija koja implementira interfejs Uredjivac i ima atribut
koji kaže u kakvom je stanju kolekcija (neuređena, uređena u rastući ili uređena u opadajući redosled) koja je
inicijalno uvek postavljena na „neuređena”.
U metodi main kreirati objekat klase UredjenaKolekcija koja može da primi naksimalno 100 elemenata, upisati u nju
2 objekta tipa StudentFIB i 2 objekta tipa StudentSAF, urediti je u rastući redosled, a zatim izvršiti promenu
uređenja. Štampati elemente kolekcije nakon svake transformacije.
</p>
