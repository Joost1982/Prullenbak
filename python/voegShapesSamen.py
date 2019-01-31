# functie om gemeenten samen te voegen (als er bijvoorbeeld een gemeentelijke herindeling is)
#
# ziet er raar uit, omdat het samenvoegen niet met meer dan 2 tegelijk kan
# workaround als er meer dan 2 zijn: eerste 2 worden samengevoegd, die 2 vormen
# samen opnieuw een beginpunt voor een join met de derde etc. etc.
#
# LET OP: polygonen / gemeenten moeten elkaar raken voor een goede samenvoeging
# als ze elkaar niet raken, werkt het niet.

from shapely.geometry import Polygon
from shapely.ops import cascaded_union
import sys

def VoegGemeentenSamen(areas, areasinfo, *argv):

    print 'Gemeenten samenvoegen: ', argv

    t = 0
    gemposlist = []
    polygons = []

    for gemeente in argv:

        #positie gemeentes opzoeken:
        for i, x in enumerate(areasinfo):
            ding = str(x)
            if ding.find(gemeente) > 0:
                print gemeente + ' positie: '+ str(i)
                gempos = i
                gemposlist.append(i)
                gempoly =  Polygon(areas[gempos])
                polygons.append(gempoly)

                t += 1

                if t == 2:
                    samengevoegd = cascaded_union(polygons)

                    #samengevoegd is een polygon-type en ik moet een list hebben (om te gebruiken in de df)
                    #
                    # Extract the point values that define the perimeter of the polygon
                    try:
                        x, y = samengevoegd.exterior.coords.xy

                        # samenvoegen
                        z = zip(x,y)
                        # nu is z vergelijkbaar met de andere shapes in de shapefile
                       
                        #polygonen inserten op de plek van de eerste gemeente in de grote lijst:
                        areas[gemposlist[0]] = z
                        #de overige gemeenten verwijderen:
                        for i in gemposlist[1:]:
                            del areas[i]
                            del areasinfo[i] #gemeentenamen ook verwijderen (anders zijn de arrays niet gelijk en krijg je een error)

                        #lijsten opschonen voor een eventuele toevoeging van een andere gemeente
                        gemposlist = [gemposlist[0]]
                        polygons = []
                        polygons.append(samengevoegd) # de samengevoegde polygon er in zetten, waar de nieuwe aangezet wordt
                        t = 1
                        
                    except AttributeError: #error handling toegevoegd
                        print 'FOUT! Samenvoegen niet gelukt: (enkele) polygonen / gemeenten liggen niet tegen elkaar!'
                        sys.exit(1)
     
    return areas, areasinfo
