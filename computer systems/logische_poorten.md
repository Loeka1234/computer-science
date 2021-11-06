# Logische poorten

<img src="file:///C:/Users/Loeka/AppData/Roaming/marktext/images/2021-11-06-17-18-41-image.png" title="" alt="" width="267">

- Ingang A als signaal

- Ingang B als stuurlijn

---

**EN-poort** als doorlaatfilter

![](C:\Users\Loeka\AppData\Roaming\marktext\images\2021-11-06-17-20-18-image.png)

Stuurlijn:

- 0 --> Signaal wordt geblokkeerd

- 1 --> Signaal wordt doorgelaten

---

**Exclusieve OF-poort** als flexibele invertor

![](C:\Users\Loeka\AppData\Roaming\marktext\images\2021-11-06-17-21-08-image.png)

Stuurlijn:

- 0 --> Signaal wordt doorgelaten

- 1 --> Signaal wordt geïnverteerd

---

**OF-poort** als samensteller

![](C:\Users\Loeka\AppData\Roaming\marktext\images\2021-11-06-17-22-20-image.png)

Kan signalen samenvoegen naar uitgang. Slechts op 1 ingang mag signaal aanwezig zijn. De andere ingangen moeten signaal 0 krijgen.

---

**Combinatorische schakelingen**: Netwerk van logische poorten dat een vooropgestelde functie uitvoert

---

**Decoder**: Alle uitgangen 0 behalve degene waarvan de index (adres) als binair getal op de ingangen staat

![](C:\Users\Loeka\AppData\Roaming\marktext\images\2021-11-06-17-25-59-image.png)

---

**Decoder** met n ingangen tekenen:

1. Inverteer alle ingangen

2. Plaats $2^n$ EN-poorten met n-ingangen

3. Benoem de uitgangen D

4. De ingang van elke EN-poort wordt oftewel met dezelfde ingang van de schakeling verbonden, ofwel met zijn inverse, afhankelijk van de bainaire schrijfwijze van de ingang
   
   - 0 --> inverse ingang
   
   - 1 --> ingang

<img src="file:///C:/Users/Loeka/AppData/Roaming/marktext/images/2021-11-06-17-33-20-image.png" title="" alt="" width="275">

---

**Multiplexer**: combinatie van:

- Een decoder

- EN-doorlaatfilters

- Een OF-samensteller

Functie: De ingang waarvan de index (adres) als binair getal op de adreslijnen (A, B en C) staat, wordt doorgegeven naar de uitgang

Kan **vereenvoudigt** worden door de **EN-poorten samen** te **voegen**

---

**Multiplexing**: Wanneer we meerdere bronnen en meerdere onvtangers hebben, maar slechts 1 medium om gegevens te over te brengen --> we moeten multiplexen toepassen

**Vormen**: 

- **Time Devision Multiplexing** (TDM): We brengen signalen van verschillende bronnen naar verschillende ontvangers achter elkaar in de tijd

- **Frequency Devision Multiplexing** (FDM): We plaatsen elk signaal op een andere frequentie in de ruimte (Bv: elke radio op andere frequentie)

- **Wavelength Devision Multiplexing** (WDM): Bij glasvezelnetwerk, datastromen worden op één en dezelfde glasvezel naast elkaar geplaatst door deze op een andere golflengte (=andere kleurschakeling) van licht te plaatsen 

---

**Optellers**

![](C:\Users\Loeka\AppData\Roaming\marktext\images\2021-11-06-17-38-57-image.png)

![](C:\Users\Loeka\AppData\Roaming\marktext\images\2021-11-06-17-39-06-image.png)

---

De **Ripple Carry Adder**: Opteller die twee n-bit woorden in 1 keer bij elkaar optelt, bestaat uit **1 halve** en **n - 1 hele** optellers. De varry bits golven doorheen de schakeling, vandaar de term "ripple" in de naam.
