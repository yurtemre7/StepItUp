# StepItUp Overlay

A lightweight overlay application that provides a counter with global F8 key detection, memory save/load functionality, and max count limits.

## Features

- **Global F8 Detection**: Press F8 anywhere on your computer to increment the counter (when enabled)
- **Counter Controls**: Manual increment/decrement with visual counter display
- **Max Count Limit**: Set a maximum value to prevent the counter from going beyond a certain point
- **Memory System**: Save and load counter states with associated text labels
- **Persistent Settings**: All settings are saved between application sessions
- **Hamburger Menu**: Clean interface with organized menu options

## Dependencies

To build and run this application, you'll need:

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) or later
- Windows OS (the application uses Windows-specific APIs for global key detection)

## Building the Application

### Prerequisites

1. Install the .NET 6.0 SDK from the official Microsoft website
2. Clone or download this repository to your local machine

### Build Instructions

Open a command prompt or terminal in the project directory and run:

```bash
# Restore dependencies
dotnet restore

# Build the application
dotnet build

# Build and run the application
dotnet run
```

### Creating an Executable

To create a standalone executable for distribution:

```bash
# Publish as a self-contained executable for Windows
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true

# The executable will be located in bin/Release/net6.0-windows/win-x64/publish/
```

## Usage

1. **Starting the Application**: Run the executable or use `dotnet run` from the project directory
2. **Moving the Window**: Drag the window by clicking and holding anywhere on the overlay
3. **Using the Counter**:
   - Use the +/- buttons to manually increment/decrement the counter
   - Press the Reset button to reset the counter to zero
4. **Global F8 Detection**:
   - Toggle the "F8 OFF/ON" switch to enable/disable global F8 detection
   - When enabled, pressing F8 anywhere on your computer (except when this app is focused) will increment the counter
5. **Setting Max Count**:
   - Enter a number in the "Max" field
   - Click "Set Max" to apply the limit
   - The counter will stop incrementing once it reaches this value
6. **Memory System**:
   - Click the hamburger menu (☰) in the top-left corner
   - Select "Memory" to open the memory management dialog
   - Save the current state or load a previously saved state
7. **Other Options**:
   - Access "App Info" from the hamburger menu to view application information
   - Use "Quit App" to close the application

## Troubleshooting

- **F8 Key Not Working**: Make sure the toggle is switched to "F8 ON" and that no other applications are capturing the F8 key
- **Application Not Starting**: Ensure you have the .NET 6.0 runtime installed
- **Settings Not Saving**: Check that you have write permissions to the application directory

## Development

This application is built using WPF (Windows Presentation Foundation) with C# and .NET 6.0. The global key detection uses Windows API hooks through P/Invoke calls.

### Key Components

- `MainWindow.xaml/.cs`: Main application window and logic
- `GlobalHotkeyManager.cs`: Handles global keyboard hook for F8 detection
- `StateMemory.cs`: Manages saving and loading of counter states
- `MemoryManagementDialog.xaml/.cs`: Dialog for managing saved states