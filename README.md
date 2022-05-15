Probléma:


       Egy telefontársaság a központi telefonközpont log állományait kívánja feldolgozni, hogy az adatokból különböző forgalmi kimutatásokat készítsen. A feldolgozás alapja a hívott szám és az időtartam. A hívott szám alapján be kell azonosítani a hivott fél számához tartozó országot és azon belül körzetet, és így kell összegezni a hívások időtartamát. Az egyszerűsítés kedvéért élünk a feltételezéssel, hogy egy országkód nincs benne más országkódban (ami a gyakorlatban nem igaz, mert néhány, USA környéki sziget országhívókódja 1-el kezdődik).

 

Bemenő adatok:

       Log állomány – szöveges állomány, amely egy sora egy hívás rekordot tartalmaz. A rekordkép a következő (a mezők TAB karakterrel vannak elválasztva): 

-          hívás dátuma (éééé-hh-nn formában)

-          hívás időpontja (óó:pp formában)

-          hívó fél száma (+országkódkörzetkódtelefonszám formában)

-          hívott fél száma (+országkódkörzetkódtelefonszám formában)

-          időtartama (egész szám, másodperc egységben)

 

        Ország adatbázis – szöveges állomány, amelynek egy sora egy ország adatait tartalmazza. A rekordkép a következő (a mezők TAB karakterrel vannak elválasztva): 

-          ország hívókódja

-          ország néve

 

        Körzet adatbázis – szöveges állomány, amelynek egy sora egy körzet adatait tartalmazza. A rekordkép a következő (a mezők TAB karakterrel vannak elválasztva): 

-          ország hívókódja

-          körzet kódja

-          körzet néve

 

Kimenő adatok:

       Kimutatás állomány – szöveges állomány, amelynek egy sora egy eredménysort tartalmaz. A rekordkép a következő (a mezők TAB karakterrel vannak elválasztva): 

-          ország neve

-          körzet neve

-          ország hívókódja

-          körzet hívókódja

-          összes hívás időtartam (egész szám, másodperc egységben összegezve)
