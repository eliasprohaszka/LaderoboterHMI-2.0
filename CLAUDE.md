# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

BlazorLaderoboter is a .NET MAUI desktop HMI (Human Machine Interface) application for controlling FANUC industrial robots in a palette-based material handling system. The application manages dual palettes with 8 workpiece positions each, providing real-time monitoring and control.

## Build & Run Commands

```bash
# Build all projects
dotnet build

# Build release
dotnet build -c Release

# Run desktop application
dotnet run --project src/Laderoboter.Desktop

# Publish for Windows
dotnet publish -c Release -r win10-x64

# Frontend dependencies (Tailwind CSS)
cd src/Laderoboter.Desktop/wwwroot && npm install
```

## Architecture

### Solution Structure (3 projects)

**Laderoboter.Core** - Business logic and data layer
- `Services/RobotService.cs` - FANUC robot communication via UnderAutomation.Fanuc SDK
- `Services/RobotMonitor.cs` - Reactive monitoring with System.Reactive (Rx.NET)
- `Data/LaderoboterDbContext.cs` - EF Core SQLite context
- `Models/` - Domain models (RobotStatus, PaletteData, WorkpieceStatus)

**Laderoboter.UI** - Blazor component library
- `Pages/MainPage.razor` - Main monitoring dashboard with offline/online modes
- `Pages/SettingsPage.razor` - Configuration UI
- `Pages/MaintenancePage.razor` - Maintenance operations
- `Components/` - Organized in subdirectories: Layout, Main, Settings, Maintenance, Dialogs, Shared

**Laderoboter.Desktop** - MAUI shell hosting Blazor UI
- `MauiProgram.cs` - DI configuration via `AddLaderoboterCore()`
- `wwwroot/` - Tailwind CSS, static assets

### Key Patterns

- **Dependency Injection**: Services registered in `ServiceCollectionExtensions.cs`
- **Reactive Streams**: `IRobotMonitor` provides IObservable for register/palette changes
- **Event-Driven**: `IRobotService` raises events for status/register/palette/error changes
- **Scoped CSS**: Each Blazor component has corresponding `.razor.css` file

### Robot Communication

The `IRobotService` interface handles:
- Connection to FANUC robot via IP or RoboGuide offline simulation
- Register read/write for palette data (addresses mapped to workpiece positions)
- Digital I/O operations for door controls and signals
- Program control (run, stop, pause, resume, reset)
- Speed override adjustment

### Data Model

- **Palettes**: 2 palettes, 8 positions each
- **WorkpieceState enum**: Unused(0), Locked(1), Unprocessed(2), Processed(3), AtRobot(4), InMachine(5)
- **Database**: SQLite at `%LocalAppData%/Laderoboter/laderoboter.db`

## UI Styling

- Tailwind CSS v4.2 with custom theme
- Primary color: `#004F7C`
- German language UI ("de" default)
