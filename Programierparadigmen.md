# Programmierparadigmen

## Imperative Programmierparadigmen

Anweisungen werden abgearbeitet. Ansatz: "Wie soll etwas berechnet werden?" 
z. B. Assembler(Maschinencode), Basic

+ Strukturierte Programmierung
	- Einsatz von Krontrollstrukturen (´if ... else ...´, ´do ... while´, ... )
	- Verzicht von absoluten Sprunganweisungen (GOTO)
+ Prozedurale Programmierung
	- Aufteilung in kleinere Aufgaben (Unterprogramme)
	- Prozedur (Aktion) / Funktion (Ergebnis) / Methode in OOP
	- Sprachen: Pascal, C
+ Modulare Programmierung
	- Aufteilung des Codes in mehrere Dateien zu logischen Einheiten (Modulen)
	- Sprache: Modula-2

## Deklarative Programmierparadigmen

eher mathematische Ansatz: "Was soll denn berechnet werden"
Beispiel quicksort-Algorithmus in Haskel:

```Haskel
quicksort [] = []
 quicksort (x:xs) = quicksort [n | n<-xs, n<x] ++ [x] ++ quicksort [n | n<-xs, n>=x]
```

+ Funktionale Programmierung
	- Haskel, F#, Scala, Lisp
+ Logische Programmierung
	- Prolog
+ Funktional-logische Prgrammierung
	- Babel, Escher
+ Mengenorientierte Programmierung
	- SQL

## Objektoriente Programmierparadigmen

Zusammenfassung von Daten und Routinen in Objekten

Sprachen: Smalltalk, Java, C#, C++, ...
