# Conceptueel model

**Fases ontwerpen databank** (vertrekt vanuit bedrijfsprocessen):

1. Verzamelen en analyseren van de functionele/inhoudelijke vereisten

2. Conceptueel ontwerp

3. Logisch ontwerp

4. Fysiek ontwerp

Mogelijke bedrijfsprocessen:

- Maken van facturen

- Werkroosters en prestaties van werknemers

- Voorraadbeheer

- Puntenadministratie

---

![](C:\Users\Loeka\AppData\Roaming\marktext\images\2021-11-07-12-14-48-image.png)

---

**Fase 1 = verzamelen en analyseren informatie** (domeinanalyse, functionele analyse, behoefteanalyse)

Doel: Stappen en benodigde data van het bedrijfsproces begrijpen, kan via:

- Interviews met opdrachtgever

- Analyse van bestaande formulieren en rapporten

Vragen die beantwoord moeten worden:

- Welke data moet opgenomen worden?

- Betekenis en context van alle data, symbolen, gebruikte coderingen?

- Hoe data verwerkt?

- Beoogde functionaliteit?

- Waarvoor data gebruikt?

---

**Fase 2 = Conceptueel ontwerp**

**Conceptueel model**

- Abstractie van de data en de onderlinge verbanden

- Moet voldoende formeel en ondubbelzinnig zijn voor de DBontwerper

- Moet gebruiksvriendelijk zijn

- Doorgaans grafische representatie

- Basis voor communicatie en discussie tussen gebruiker van het bedrijfsproces en de databankontwerper

- Gebeurt onafhankelijk van enig databankmodel of applicatie

---

**Fase 3 = Logisch ontwerp**

- **Type** databank is bekend (relationele databank, NoSQL databank, hiërarchische databank, ...)

- Product zelf ligt nog niet vast

Overgang conceptueel model naar logisch model --> mogelijks verlies van specificaties (in appart document bijhouden om te gebruiken bij de applicatie-ontwikkeling)

 ---

**Fase 4 = Fysiek ontwerp**

- Feitelijke implementatie van logisch model

- Kiezen voor product, ook wel DMBS genoemd (MySQL, ...)

- Je implementeert logisch model en zet dit om in datadefinitiecode (=DDL)

- Technische details worden toegevoegd (datatypes van de attribuuttypes, ...)

- Indien mogelijk: functionele beschrijvingen 'vertaald' naar databaseconcepten, zo kunnenbedrijfsregels rond correct geboortejaar en jaar van overlijden omgezet worden naar een integriteitsrestrictie

- DBA kan ook aanbevelingen doen in verband met performantie --> Zie Relational Databases and Datawarehousing

---

**ERD** (Entity Relationship Diagram)

1 van populairste voorstellingsswijzen voor conceptueel gegevensmodel

Heeft volgende bouwstenen:

- Entiteittypes (een entiteit is hier een instantie van)
  
  - Moet identificeerbaar zijn en eeninhoud hebben

- Attribuuttypes
  
  - **Samengesteld attribuuttype**: het attributtype kan nog opgesplitst worden, bijv: `adres` kan opgesplitst worden in `straat`, `huisnummer`, ...
  
  - **Afhankelijk van de context** zullen ze verder opgesplitst worden of niet
  
  - **Enkelwaardig attribuuttype**: het heeft 1 waarde, bijv: `geboortejaar` en `jaar overlijden` van `Artiest`
  
  - **Meerwaardig attribuuttype**: het kan (meerdere) waarden bevatten, bijv: `Artiest` kan meerdere talen spreken of hobbys hebben
  
  - **Afgeleid attribuuttype**
    
    - Waarde kan berekend worden adhv andere attribuuttypes
    
    - Bv: Leeftijd kan afgeleid worden uit geboortedatum
    
    - Worden **niet opgeslagen** in de databank
    
    - Wordt vervangen door de **basisinformatie** waaruit de waarde van het attribuuttype berekend kan worden
  
  - **Kandidaatsleutelattributen**
    
    - 1 of meerdere die samen de entiteiten van een entiteittype op een unieke, irreducibele manier identificeren, vormen een **kandidaatsleutel** van het entiteittype
    
    - **Kandidaatsleutelattributen**: Attributen die deel uitmaken van een kandidaatsleutel
    
    - Er kunnen meerdere **kandidaatsleutels** zijn

- Relatietypes (verzameling van relaties tussen instanties van 1, 2 of meer al dan niet verschillende entiteittypes)
  
  - Gekenmerkt door een naam
  
  - **Unair (n = 1), binair (n = 2)**, ternair (n = 3), n-air (n > 3)

---

**Cardinaliteiten**

- Elk relatietype heeft een minimum- en een maximumcardinaliteit

- Cardinaliteit betekent aantal en wordt uitgedrukt als een getal

- MODELLEREN WAT WE WETEN (niet veronderstellen)

- Verkeerd gekozen cardinaliteiten --> minder kwalitaiteve applicaties

**Maximumcardinaliteit** = maximum aantal entiteiten van het entiteittype dat op een gegeven tijdsstip **kan** deelnemen aan een relatie van het relatietype (1 of N)

**Minimumcardinaliteit** = minimum aantal entiteiten van het entiteittype dat op elk tijdstip **moet** voorkomen in een relatie van het relatietype (0 of 1)


