# Script om de "dubbele" backups van quexs te verwijderen 
# <joostvdhorst@gmail.com>

import os
from datetime import datetime

TIJD = datetime.now().strftime("%Y%m%d_%H%M")
BACKUPPATH = "Z:\\02-BACKUPS\\MYSQLDUMPS\\"
BESTANDEN = os.listdir(BACKUPPATH)
bestandenDict = {}
bestandenDictVerwijderen = {}
VERWIJDERENBESTAND = BACKUPPATH + TIJD + "_verwijderdebestanden.txt" 
BEHOUDENBESTAND = BACKUPPATH + TIJD + "_behoudenbestanden.txt" 
VRIJTEMAKENRUIMTE = 0

print("Bezig met checken van: {0}...".format(BACKUPPATH))

for BESTAND in BESTANDEN: 
    GROOTTE = os.path.getsize(BACKUPPATH+BESTAND)
    INFO = "{0} : {1}\n".format(BACKUPPATH+BESTAND, GROOTTE)
    if GROOTTE in bestandenDict.values():
            bestandenDictVerwijderen[BACKUPPATH+BESTAND] = GROOTTE
            VRIJTEMAKENRUIMTE = VRIJTEMAKENRUIMTE + GROOTTE
    else:
        bestandenDict[BACKUPPATH+BESTAND] = GROOTTE

#Vraag om bevestiging
print("- Te behouden bestanden: {0}".format(len(bestandenDict)))
print("- Te verwijderen bestanden: {0} [totale grootte: {1} MB]".format(len(bestandenDictVerwijderen), VRIJTEMAKENRUIMTE >> 20)) # >> 20 om er MB van te maken
if len(bestandenDictVerwijderen) == 0:
    print("Geen 'dubbele' bestanden gevonden. Script afgesloten.")
    exit()

actie = input("\nTik 'Y' in (zonder de quotes) en druk op [ENTER] om de bestanden te verwijderen.")
if actie == "Y":
    for bestand in bestandenDictVerwijderen:
        os.remove(bestand)
        print("- {0} verwijderd.".format(bestand))

    #LOGGEN
    f1 = open(VERWIJDERENBESTAND, "w", encoding="utf-8")
    for bestand in bestandenDictVerwijderen: 
        f1.write("{0} : {1}\n".format(bestand, bestandenDictVerwijderen[bestand]))
    f1.close()
    
    f2 = open(BEHOUDENBESTAND, "w", encoding="utf-8")
    for bestand in bestandenDict:
        f2.write("{0} : {1}\n".format(bestand, bestandenDict[bestand]))
    f2.close()

    print("Bestanden verwijderd en opschoning gelogd in:")
    print(" -"+VERWIJDERENBESTAND)
    print(" -"+BEHOUDENBESTAND)

else:
    print("Geen 'Y'. Script afgesloten.")
    exit()

