###### Script zoekt naar significante correlaties tussen variabelen en
###### zet die in een plaatje waarin de desbetreffende variabelen met 
###### elkaar gelinkt worden.
######
###### Joost van der Horst (joostvdhorst@gmail.com)


####libs
import pandas as pd
import scipy.stats
import networkx as nx
import matplotlib.pyplot as plt
import csv
import numpy as np

####config

#databestand
bestand = 'limeexport.csv'
#variabelenlijst
variabelenlijst = 'variabelen2.csv'
#kritieke waarde r
rval = 0.471819
#kritieke p-waarde
pval = 0.00965549

####code

variabelen = []

with open(variabelenlijst, 'rb') as csvfile:
    variabelenuitcsv = csv.reader(csvfile)
    for i in variabelenuitcsv:
        variabelen.append(i[0])

df = pd.read_csv(bestand, usecols=variabelen)

### recode variabelen? Bijv:
df = df.replace(4,0)
df = df.replace(3,0)
df = df.replace(2,1)

#Geef een overzicht van de correlaties
print df[variabelen].corr()

### Alleen relevante correlaties (gebaseerd op kritieke
### waarden bepaald in config-sectie)

print 'Alleen significante sterke correlaties:'

aantal = len(variabelen) - 1
kolom = 0
vanaf = 0
sigvars1 = []
sigvars2 = []
gewicht = []

for i in variabelen:
    for z in range (vanaf, aantal):
        #subset data
        sub = df[[variabelen[kolom],variabelen[z+1]]]
        sub_data = sub.copy()

        #verwijder rijen met lege waarden (en copy) -> lege waarden resulteert in 'nan' uitkomst
        sub2 = sub_data.dropna()
        sub_data2 = sub2.copy()
        waarden = scipy.stats.pearsonr(sub_data2[variabelen[kolom]], sub_data2[variabelen[z+1]])
        if (waarden[0] > rval) & (waarden[1] < pval):
            print '%s met %s : %s oftwel: %s met %s'  % (kolom+1, z+2, 
            scipy.stats.pearsonr(sub_data2[variabelen[kolom]], sub_data2[variabelen[z+1]]),
            variabelen[kolom], variabelen[z+1])
            sigvars1.append(variabelen[kolom])
            sigvars2.append(variabelen[z+1])      
            gewicht.append(1)
    vanaf = vanaf + 1
    kolom = kolom + 1
    z = 1

### rename vars als ze langer zijn dan 3 characters

if len(max(variabelen, key=len)) > 3:
    # maak een lijst met alle vars
    lijstalles = sigvars1 + sigvars2
    unieklijst = list(set(lijstalles))

    # maak een lijst met hernoemvariabelen zo lang
    # als de unieke lijst lang is
    hernoemlijst = []
    y = 1

    for x in range(0,len(unieklijst)):
        varrecode = 'v%d' % (y)
        hernoemlijst.append(varrecode)
        y +=1

    # zoek sigvars op in unieke lijst en geef ze
    # de corresponderende naam uit de hernoemlijst 
    for x in range (0,len(sigvars1)):
        positie = unieklijst.index(sigvars1[x])
        sigvars1[x] = hernoemlijst[positie]

    for x in range(0,len(sigvars2)):
        positie = unieklijst.index(sigvars2[x])
        sigvars2[x] = hernoemlijst[positie]

    # geef een "legenda"
    for x in range(0,len(hernoemlijst)):
        print '%s = %s' % (hernoemlijst[x],unieklijst[x])

### plot corrs
    
df = pd.DataFrame ({'node1': sigvars1,
                    'node2': sigvars2,
                    'weight': gewicht})

MG = nx.from_pandas_dataframe(df, 
                              'node1', 
                              'node2', 
                               edge_attr='weight',
                               create_using=nx.MultiGraph(),
                              )

positions = nx.spring_layout(MG) 
nx.draw(MG, pos=positions, hold=True, with_labels=True, node_size=1000, font_size=8)
plt.show()
