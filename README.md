# StepItUp Overlay Application

## Overview
StepItUp is a lightweight Windows WPF overlay application designed to serve as a counter utility. It provides a transparent, always-on-top window that allows users to increment, decrement, and reset a numeric counter while optionally labeling it with custom text.

## Features
- **Transparent Overlay Window**: Semi-transparent window that stays on top of other applications
- **Counter Functionality**: Increment (+), decrement (-), and reset buttons for tracking numbers
- **Custom Label**: Text field to add a custom label or topic to the counter
- **Persistent Storage**: Settings and counter values are saved between sessions
- **Draggable Interface**: Window can be moved by dragging anywhere on the interface
- **Quick Close Button**: Easy access close button in the top-right corner

## Technical Details
- **Platform**: .NET 6.0 Windows
- **UI Framework**: Windows Presentation Foundation (WPF)
- **Language**: C#
- **Architecture**: XAML-based UI with code-behind logic
- **Persistence**: Uses application settings to store counter value and text between sessions

## User Interface
The application features a compact, semi-transparent window with the following elements:
- Title bar with "StepItUp Overlay" and application icon
- Close button (top-right corner)
- Main counter display showing the current number
- Control buttons: minus (-), plus (+), and reset
- Text input field for custom labeling
- Custom styling with rounded buttons and transparent text fields

## Functionality
- **Increment/Decrement**: Click '+' or '-' buttons to adjust the counter
- **Reset**: Click 'Reset' button to clear the counter and label (with confirmation dialog)
- **Persistence**: Counter value and text are automatically saved when changed
- **Window Management**: Drag anywhere on the window to move it around the screen
- **Game Integration**: Contains code to focus on a specific game process named "x2"

## Project Structure
```
StepItUp/
├── App.xaml              # Application definition
├── App.xaml.cs           # Application logic
├── MainWindow.xaml       # Main window UI
├── MainWindow.xaml.cs    # Main window event handlers
├── StepItUp.csproj       # Project configuration
├── AssemblyInfo.cs       # Assembly metadata
├── Properties/           # Application properties and settings
│   ├── Settings.settings # User settings (counter value, text)
│   └── Resources.resx    # Application resources
└── Resources/            # Resource files
```

## Use Cases
This application is ideal for:
- Gamers tracking scores, levels, or achievements
- Students counting study sessions or practice repetitions
- Professionals monitoring tasks or activities
- Anyone needing a quick, always-accessible counter overlay

## Installation
1. Clone or download the repository
2. Open the solution in Visual Studio
3. Build and run the application
4. The overlay window will appear with default settings

## Notes
- The application window is designed to be always on top
- Settings are stored per-user and persist between application restarts
- The application includes functionality to switch focus to a game process named "x2"