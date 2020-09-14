# 2gl_verkefni_1
1. Hvað er leikjavél?
Leikavélin er bara forrit sem heldur utanum allan leikinn. Sér um hljóð, hreyfingu o.fl.

2. Útskýrðu e. GameLoop í Unity.
GameLoop er það sem gerist í hverjum ramma. Update, FixedUpdate og allt svoleiðis.

3. Hvað er e. asset? Nefndu algengar tegundir.
Asset þýðir bara eign. Það er allt sem þú notar til að búa til leikinn. Skripturnar, módelin, prefabin, o.s.frv.

4. Hvað er e. game object og hvernig tengist það e. components í e.
Game Object er hlutur í leiknum. Allt frá myndavélinni, spilarans til levelsins.
Components eru auka eiginleikar fyrir Game Object. Components segja t.d. um hvernig á að teikna hlutinn, hvernig hluturinn er í laginu og allar skriptur og svoleiðis

5. Hvað er líkt og ólíkt með game object og e. prefab?
Game Object og prefab er næstum það sama. Prefab er bara Game Object sem hefur verið 'vistaður'. Þetta er gert ef þú þarft að vera með sama hlutinn oft í leik. Þá getur þú einfaldlega dregið hann inn í leikinn og hann er alltaf nákvæmlega eins og þú gerðir hann áður. Þú getur líka uppfært alla GameObjects sem eru gerðir með prefabi á sama tíma með því að einfaldlega breyta prefabinu svo það gerir auðvelt að breyta hlutum seinnameir.

6. Hvað er e. tags og e. layers?
Tags er leið til þess að hópa saman hluti eftir því hvað þeir eru, t.d. Player, Enemy, Obstacle
Layers eru mismunandi lög leiksins sem hægt er að nota til að breyta ýmsu, t.d. hægt að gera layer sem myndavélin sér ekki o.f.l

7. Útskýrðu stuttlega hlutverk eftirfarandi glugga/svæði í Unity:  
  
**Scene View:**  
    Senan þín. Hérna hannar þú leikinn þinn  
      
**Game View**:  
  Leikurinn. Hérna sérð þú senuna frá myndavélinni  
    
**Project**:  
  Verkefnið þitt. Leikurinn þinn  
    
**Hierarchy**:  
  Þar sem allt í senuni er geymt, game objects semsagt  
    
**Inspector**:  
  þar sem þú getur séð og breytt eiginleikum game objects  
  
  
Síðan er windows binary í boði í ['releases'](https://github.com/marteinnsi/2gl_verkefni_1/releases)
