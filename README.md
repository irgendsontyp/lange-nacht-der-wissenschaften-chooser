# Warnung
Achtung! Der Code ist grottig, weil ich ihn nur mal eben hingeschustert hab. Texte der Termine beinhalten teilweise Zeichen aus HTML. Das liegt daran, dass ich nichts parse, sondern nur per Regex raushole. 

# Lange Nacht der Wissenschaften Chooser
Dieses Programm erleichtert die Auswahl von spannenden Terminen, die man gerne auf der langen Nacht der Wissenschaften (http://www.nacht-der-wissenschaften.de/2017/home/) besuchen möchte.

# Benutzung
## Erster Start
Nach dem Auschecken des Projektes startet man einfach die gewünschte Konfiguration (Debug oder Release). Das Programm sucht dann nach einer Datei namens "initialized". Ist diese nicht vorhanden (was beim ersten Start nicht der Fall ist), werden alle verfügbaren Termine aus der Seite http://www.nacht-der-wissenschaften.de/2017/programm/nach-programmpartnern/ extrahiert und lokal in nummerierten Ordnern im Pfad "content/appointmentDetails/" innerhalb des Ordners "Debug" oder "Release" gespeichert. Den Fortschritt dieses Prozesses kann man verfolgen, indem man mit dem Dateiexplorer diesen Pfad öffnet. Hier werden nach und nach die Ordner für die einzelnen Programmpunkte erstellt. Der Prozess ist abgeschlossen, wenn es 1.028 Ordner sind. (Stand 03.10.2017)

## Termine auswählen
Nachdem die Initialisierung abgeschlossen ist, wird der erste Termin im Hauptfenster angezeigt. Folgende Informationen sind sichtbar (in dieser Reihenfolge): URL zur Seite mit dem Termin, Titel, Bild, Beschreibung, Footer. Darüber ist die Nummer des aktuell angezeigten Termins und die Anzahl aller heruntergeladenen Termine sichtbar. Außerdem findet sich hier die Information, wie viele Termine "Gemerkt" wurden, also welche vom Benutzer als interessant gekennzeichnet wurden.

## Termine als interessant kennzeichnen
Findet man einen Termin interessant, drückt man die Leertaste. Der Termin wird dann als "Gemerkt" markiert, was bedeutet, dass der Ordner des Termins von "content/appointmentDetails/" nach "chooser/interesting/" kopiert wird. Der Original-Ordner wird nicht gelöscht. Die Anzahl "Gemerkt" wird entsprechend um 1 erhöht.

Findet man den Termin nicht interessant, drückt man die Taste AltGr. Der Termin wird dann nicht gespeichert.

In beiden Fällen wird anschließend der nächste Termin angezeigt und das Spiel beginnt von vorn.

## Erneute Durchgänge
Den unter "Termine als interessant kennzeichnen" beschriebenen Prozess kann man beliebig oft durchführen, um die Ergebnisse immer weiter zu verfeinern. Dazu entfernt man nach jedem Durchgang alle nummerierten Ordner aus "content/appointmentDetails" und kopiert die nummerierten Ordner aus "chooser/interesting" in "content/appointmentDetails". Anschließend löscht man die Datei "chooser/current-index.txt", da sonst beim nächsten Start das Programm abschmiert.

Nun das Programm neustarten und weiter geht die Qual der Wahl.
