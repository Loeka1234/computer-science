# EERD (Enhanced Entity Relationship Model)

= uitbereiding van het ERD, nieuw modelleringsconcept wordt toegevoegd (specialisatie/generalisatie)

Entiteitstype = verzameling van entiteiten met gemeenschappelijke karakteristieken

---

Om subcollectie van entiteiten te karakteriseren --> apparte entiteitstypes worden aangemaakt (**Sub(entiteit)types**)

Oorspronkelijke entiteitstype = **supertype**

- **Specialisatie** = het creëren van  specifiekere subtypes voor een gegeven entiteitstype (definieert een **IS-EEN** relatie)
  
  - Komt overeen met een top-down process van conceptuele verfijning

- **Generalisatie** = het creëren van een algemeen supertype dat de gemeenschappelijke attribuuttypesenrelatietypesvan eenaantalgegevenentiteittypesverenigt. (Omgekeerdeprocesvan specialisatie)
  
  - Komt overeen met een bottom-up process van conceptuele synthese

---

- **Participatie constraint**: Er kunnen entiteiten van het supertype zijn die niet tot één van de opgesomde subtypes behoren => **Optional**
  
  - **Totale participatie**: Elke entiteit van het supertype moet op elk tijdstip ook entiteit zijn van ten minste één subtype. Er bestaan geen entiteiten van het supertype die niet tot een subtype behoren => **Mandatory**
  
  - **Partiële participatie**: Er kunnen entiteiten van het supertype zijn die niet tot één van de opgesomde subtypes behoren => **Optional**

- **Disjoint constraint**: een entiteit van het supertype kan tegelijkertijd voorkomen in meerdere subtypes => **And**
  
  - **Overlappende subtypes**: Een entiteit kan tot meer dan één subtype behoren => **AND**
  
  - **Disjunctesubtypes**: Een exclusieve OR tussen de subtypes: een entititeit kan maar tot 1 subtype behoren => **OR**
  
  ---
  
  Beperkingen
  
  1. Tijdelijke beperkingen (dit zijn beperkingen die gelden in een bepaald tijdsinterval) kunnen niet worden gemodelleerd.
  
  2. Het ERD kan geen consistentie garanderen tussen verschillende relatietypes.
  
  3. In het ERD is het domein waartoe attributen behoren, niet bekend. Men kan niet de mogelijke verzamelingen van waarden voor een attribuut vastleggen.
  
  4. In het ERD is het niet mogelijk de definitie van de functies op te nemen.
