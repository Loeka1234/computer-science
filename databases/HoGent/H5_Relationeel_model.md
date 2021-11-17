# Relationeel model

**Stappen ontwikkeling databank**

![](C:\Users\Loeka\AppData\Roaming\marktext\images\2021-11-03-18-02-12-image.png)

We maken eerst een **conceptueel model (ER-model)**: wordt niet rechtstreeks geïmplementeerd in de DB, moet eerst worden gemapt naar een relationeel model

---

**Relationeel model**: bestaat uit **tupelverzamelingen**: met elkaar verbonden via **vreemde sleutels**

Definities:

- **Tupel (record)**
  
  - **Geordende** lijst met waarden van kenmerken die een object beschrijven
  
  - Steeds **uniek**

- **Attribuut**
  
  - **Benoemd kenmerk** van een tupel
  
  - Mag **geen meerdere waarde** hebben (moet éénwaardig en atomair (ondeelbaar) blijven)

- **Domein**
  
  - **Beperkte** verzameling van **mogelijke (toegelaten) waarden** die voor de attributen in de tupels van een relatie kunnen worden gebruikt
  
  - Bv: Domein `kleuren` bij alle mogelijke kleuren die een auto kan hebben

- **Attribuuttype (Datatype)**
  
  - Afgeleid uit het domein
  
  - Bv: auto heeft 2 tot 5 deuren (domein) --> datatype is numeriek

- **Tupelverzameling**
  
  - Verzameling van tupels die gelijksoortige objecten beschrijven

![](C:\Users\Loeka\AppData\Roaming\marktext\images\2021-11-03-18-10-50-image.png)

---

**ER-model vs Relationeel model**

![](C:\Users\Loeka\AppData\Roaming\marktext\images\2021-11-03-18-11-44-image.png)

---

**Tupel** moet voldoen aan volgende **regels**:

1. Uniek

2. attributen **éénwaardig** (kan maar 1 waarde hebben)

3. attributen **atomair** (kan niet meer opgesplitst worden)

4. relaties met **vreemde sleutels**

---

**Sleutels** zorgen er voor dat elk tupel uniek is

Soorten:

1. Kandidaatsleutels
   
   - **Minimale verzameling** van attributen in de tupel waarvan de combinatie **uniek** kan identificeren
   
   - Enkelvoudig: bv: StudentNummer van student in HOGENT
   
   - Samengesteld: bv: Vluchtnummer + dag van vertrek van een vlucht

2. Primaire sleutels
   
   - Gekozen uit de kandidaatsleutels
   
   - **Steeds ingevuld zijn** (NULL niet toegelaten)

3. Alternatieve sleutels
   
   - Elke **kandidaatsleutel die geen primaire sleutel geworden is**
   
   - Verliest dit als de alternatieve sleutel **NULL-waarde** heeft (**niet langer uniek**)

---

**Vreemde sleutel (foreign key)**:

- **Verbindende schakel** tussen twee tupelverzamelingen

- **Verwijst naar de primaire sleutel** uit de andere tabel

---

**Mapping** = het omzetten van een ER-model (conceptueel model) naar een relationeel model (logisch model)

1. Elk entiteittype wordt een tupelverzameling of tabel

2. Enkelvoudige attribuuttypes overnemen

3. Samengestelde attribuuttypes opsplitsen in enkelvoudige attribuuttypes

4. Meerwaardige attributen in een aparte, nieuwe verzameling plaatsen

5. Primaire sleutel bepalen (opgelet bij zwakke entiteiten)

6. Voor elke relatie tussen entiteittypen de vreemde sleutel(s) bepalen

7. Integriteitregels bepalen van elke vreemde sleutel

---

**Regels voor bepalen vreemde sleutels**

- **Binair** verband:
  
  - 1 op N verband: vreemde sleutel aande N-zijde
  
  - 1 op 1 verband vreemde sleutel aan de 1 zijde (zelf te kiezen)
  
  - Veel op veel: aparte tabel met 2 vreemde sleutels

- **Unair** verband:
  
  - 1 op veel: vreemde sleutels in zelfde (naam van rol 1-zijde)
  
  - 1 op 1: vreemde sleutel met zichzelf
  
  - Veel op veel: nieuwe tabel met 2 vreemde sleutels

---

**Integriteitsregels** vreemde sleutel:

- Naar welke **primaire sleutel** verwijst deze vreemde sleutel

- **Verplicht** of **optioneel**? (bepaald aan de hand van de minimumcardinaliteit)

- **Uniek**? (bij 1 op 1)

---

Zorg ervoor dat je als ontwerper steeds **controle** hebt over de gekozen **primaire sleutel**: bij twijfel --> zelf een sleutel creëren (**Surrogaatsleutel**)

---

**Mapping van specialisatie**

![](C:\Users\Loeka\AppData\Roaming\marktext\images\2021-11-03-18-34-49-image.png)


