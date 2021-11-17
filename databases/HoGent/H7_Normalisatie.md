# Normalisatie

Genormaliseerd datamodel ontwerpen zonder:

- Overtolligheden (redundante data)
  Heeft volgende nadelen:
  
  - Wijzigingen moet op **verschillende plaatsen gebeuren**
  
  - **Inconsistentie** kan optreden
  
  - **Meer plaats** nodig voor **stockeren**

- Anomalieën (problemen bij bijwerken tabel) / Abnormaliteiten

--> Consisente data

---

**3 soorten anomalieën**

1. Invoeg-anomalie

2. Verwijder-anomalie

3. Modificatie-anomalie

Oozaken:

1. Partiële afhankelijkheden

2. Transitieve afhankelijkheden

---

**Functionele afhankelijkheid (FA)**

B is functioneel afhankelijk van A (kan samengesteld zijn) als er met een waarde van A **ten hoogste één waarde** van B overeenkomt

Notatiewijze: A --> B

We lezen: A bepaalt B, B is FA van A

---

**Partiële Functionele afhankelijkheid**

![](C:\Users\Loeka\AppData\Roaming\marktext\images\2021-11-03-18-52-12-image.png)

Partiële afhankelijkheid kan **enkel** bij samengestelde sleutels

---

**Transitieve Functionele afhankelijkheid**

C is transitief afhenkelijk van A als geldt: (A --> B) en (B --> C) en niet (B --> A)

---

**Normalisatiestappen**

We werken partiële en transitieve afhankelijkheden weg, elk attribuuttype plaatsen we in een nieuwe verzameling waar het volledig functioneel afhankelijk is van de gehele primaire sleutel

- Top down

- Bottom up (=identificeren van functionele afhankelijkheden aan de hand van, documenten, formulieren, rapporten, gesprek met gebruikers)

Normalisatiestappen van Codd:

<img src="file:///C:/Users/Loeka/AppData/Roaming/marktext/images/2021-11-03-19-03-15-image.png" title="" alt="" width="495">

We gaan tem. 3de normaalvorm

**Normalisatie** = process waarbij een aantal stappen gevolgd worden om uiteindelijk tot genormaliseerde verzamelingen te kompen aan de hand van een document of formulier

Stappen:

1. **Samenstellen RO** (niet-genormaliseerde verzameling)
   
   - FA opstellen
   
   - RO opstellen

2. **Opstellen R1 a.d.h.v. R0 (R in de 1e normaalvorm)**
   
   - Wegwerken procesgegevens (kan reeds in voorgaande stap gebeuren)
   
   - Opsplitsen samengestelde gegevens
   
   - Wegwerken herhalende gegevens (HG)

3. **Opstellen R2 a.d.h.v. R1 (R in de 2e normaalvorm)**
   
   - Wegwerken van **partiële** afhankelijkheden

4. **Opstellen R3 a.d.h.v. R2 (R in de 3e normaalvorm)**
   
   - Wegwerken **transitieve** afhankelijkheden

5. **Opstellen relationeel model (RM) a.d.h.v. R3**

---

Na dit alles **valideren van verzamelingen door normalisatie**


