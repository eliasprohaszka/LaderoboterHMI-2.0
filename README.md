# Laderoboter HMI

Eine .NET MAUI Desktop-Anwendung zur Steuerung und Überwachung von FANUC-Industrierobotern in palettenbasierten Materialhandhabungssystemen.

## Funktionen

- **Echtzeit-Überwachung** von Roboterstatus und Werkstückpositionen
- **Dual-Paletten-System** mit je 8 Werkstückpositionen pro Palette
- **Robotersteuerung** (Start, Stop, Pause, Reset, Geschwindigkeitsanpassung)
- **Digitale I/O-Steuerung** für Türen und Signale
- **Offline-Modus** für Tests mit FANUC RoboGuide Simulation
- **SQLite-Datenbank** für Konfiguration und Protokollierung

## Systemvoraussetzungen

- Windows 10/11 (Version 1809 oder höher)
- .NET 8.0 SDK
- Node.js (für Tailwind CSS)
- Optional: FANUC RoboGuide für Offline-Simulation

## Installation

### 1. Repository klonen

```bash
git clone <repository-url>
cd LaderoboterHMI-2.0
```

### 2. Frontend-Abhängigkeiten installieren

```bash
cd src/Laderoboter.Desktop/wwwroot
npm install
cd ../../..
```

### 3. Projekt bauen

```bash
dotnet build
```

### 4. Anwendung starten

```bash
dotnet run --project src/Laderoboter.Desktop
```

## Build-Befehle

```bash
# Debug-Build
dotnet build

# Release-Build
dotnet build -c Release

# Für Windows veröffentlichen
dotnet publish -c Release -r win10-x64
```

## Projektstruktur

```
src/
├── Laderoboter.Core/        # Business-Logik und Datenschicht
│   ├── Data/                # EF Core DbContext (SQLite)
│   ├── Models/              # Domain-Modelle
│   └── Services/            # Roboter-Kommunikation & Monitoring
│
├── Laderoboter.UI/          # Blazor-Komponentenbibliothek
│   ├── Components/          # UI-Komponenten
│   └── Pages/               # Hauptseiten (Main, Settings, Maintenance)
│
└── Laderoboter.Desktop/     # MAUI-Shell für Blazor UI
    └── wwwroot/             # Statische Assets & Tailwind CSS
```

## Architektur

### Kernkomponenten

| Komponente             | Beschreibung                                              |
| ---------------------- | --------------------------------------------------------- |
| `RobotService`         | FANUC-Roboter-Kommunikation via UnderAutomation.Fanuc SDK |
| `RobotMonitor`         | Reaktives Monitoring mit System.Reactive (Rx.NET)         |
| `LaderoboterDbContext` | Entity Framework Core SQLite-Kontext                      |

### Werkstück-Zustände

| Wert | Zustand     | Beschreibung              |
| ---- | ----------- | ------------------------- |
| 0    | Unused      | Position nicht belegt     |
| 1    | Locked      | Position gesperrt         |
| 2    | Unprocessed | Werkstück unbearbeitet    |
| 3    | Processed   | Werkstück bearbeitet      |
| 4    | AtRobot     | Werkstück am Roboter      |
| 5    | InMachine   | Werkstück in der Maschine |

## Konfiguration

Die Anwendung speichert Konfigurationsdaten in einer SQLite-Datenbank:

```
%LocalAppData%/Laderoboter/laderoboter.db
```

## Technologie-Stack

- **.NET 8.0** - Framework
- **.NET MAUI** - Cross-Platform UI Framework
- **Blazor** - Web-UI-Komponenten
- **Entity Framework Core** - ORM mit SQLite
- **System.Reactive** - Reactive Extensions für .NET
- **UnderAutomation.Fanuc** - FANUC-Roboter SDK
- **Tailwind CSS v4** - Styling

## Lizenz

Proprietär - Geibel & Hotz GmbH
