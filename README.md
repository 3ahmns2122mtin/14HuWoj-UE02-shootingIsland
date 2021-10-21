# UE02 ShootingIsland

### Projektbeschreibung: 
Einführung in / Zusammenfassung des Projektes. 

### Entwicklungsplattform: 
Windows 10, Unity 2020.3.18f1, Visual Studio 2019

### Zielplattform: 
WebGL Referenzauflösung (960x600) 

### Visuelle Einblicke in das Projekt: 
![Skizze_02UE-ShootingIsland_HuWoj](https://user-images.githubusercontent.com/90834280/136345648-8c7d025e-2058-476b-91ad-c8d290c5d685.jpg)

### Notwendiges für die Ausführung: 
z.B.: Installationsprozess, Schritt für Schritt Anweisung, spezielles Packages welches geladen werden muss, etc.  

### Drittmaterial: 
Falls verwendet Fonts, Sounds, Music, Graphics, Materials, Code etc. welches nicht von mir stammt muss hier referenziert werden. 

### Anforderungsliste:  
 - [x] WebGL export/upload lauffähig/spielbar
 - [x] 2D Untiyprojekt Version 2020.3.18f1 LTS öffnen
 - [x] In Assets Folder MyGame anlegen.
 - [x] Den Ordner Scenes in Assets > MyGame ziehen
 - [x] Die Szene SampleScene im Ornder Scenes umbenennen in ShootingScene
 - [x] Ein Canvas GameObject anlegen.
 - [x] Das Canvas auf screenindependent einstellen: Komponente Canvas --> Render Mode --> Screen Space - Camera, das GameObject Main Camera per Drag & Drop auf Render Camera ziehen in der Komponente Canvas.
 - [x] In der Komponente Canvas Scaler unter UI Scale Mode --> Scale with Screen Size einstellen und als Reference Resolution 960x600 einstellen.
 - [x] In Asstets > MyGame den Folder Sprites anlegen.
 - [x] Ein Hintergrund Sprite reinladen.
 - [x] In der Hierarchy dem Canvas GameObject ein Kind GameObject vom Typ Image hinzufügen und in Background umbenennen.
 - [x] Das Image ggf. positionieren und größentechnisch anpassen.
 - [x] Dem Canvas Eltern GameObject ein empty GameObject (Create Empty) hinzufügen.
 - [x] Auf dem Empty GameObject ein Reset auführen (Komponente Rect Transform --> Menü = 3 vertikale Punkte öffnen --> obester Eintrag.
 - [x] Das empty GameObject umbenennen in ParentTargets.
 - [x] in Assets > MyGame > Prefabs Folder anlegen.
 - [x] Sprite Target in der Hierarchy als Kind GameObject von ParentTargets ziehen und umbenennen in Target.
 - [x] Das GameObject per Drag and Drop in den Prefabs Ornder ziehen. Sollte dann blau erscheinen.
 - [x] Ändern des Mauszeigers: 1) auf Sprite clicken und im Inspector Texture Type Cursor setzen. Wichtig ist am Ende Apply (unten rechts) zu bestätigen, sonst werden die
 - [x] Änderungen nicht übernommen. 2) Unter BuildSettings > PlayerSettings per Drag and Drop das Cursorsprite in Default Cursor ziehen.
 - [x] In Assets > MyGame einen neuen Ordner anlegen Scripts
 - [x] In Scripts ein neues C# Script anlegen: Rechtsklick > Create > C# Script. Script gleich umbenennen in Target. Mit Doppelklick öffnen in Visual Studio (https://github.com/HTL-SBG/FAQIssuesUnityVSGitGitHub/issues/2).
 - [x] Anhängen des Scripts Target als Komponente an das GameObject Target (per Drag and Drop).
 - [x] Einen 2D Collider als Komponente dem Target hinzufügen.
 - [ ] Dem Script Target eine Methode OnMouseDown() hinzufügen.
 - [ ] In der OnMouseDown() Methodendeklaration, die Methodenaufruf Destroy(gameObject); hinzufügen
 - [ ] Das GO Target in der Hierarchy auswählen und mit Apply All die Änderungen bestätigen.
 - [ ] In der Szene ein empty GameObject anlegen, umbenennen in GameManager und Reset ausführen.
 - [ ] Im Scripts Ordner ein neues C# Script erstellen mit dem Namen GameManager.
 - [ ] Das GameManager Script per Drag and Drop dem GameObject GameManager hinzufügen.
 - [ ] ... (noch unvollständig)

### Limitationen:
Bitte hier nicht, ich kann nicht programmieren, sondern was wurde im Projekt von den Anforderungen nicht umgesetz. Wo waren die Probleme. 

### Lessons Learned:
- [] Saturn
- [ ] Uranus
- [ ] Neptune
- [ ] Comet Haley

Copyright by HuWoj
