# StepItUp - Elsword Counter App

An Elsword-focused counter application designed to track runs, titles, achievements, and everything related to counting up in the game! Perfect for Elsword players who want to keep track of their progress, farming sessions, and accomplishments.

## Features

- **Elsword Session Tracking**: Manual increment/decrement with visual counter display for tracking runs, titles, or achievements
- **Persistent Settings**: All Elsword tracking data is saved between application sessions
- **Overlay Interface**: Lightweight overlay that stays on top while you play Elsword

## Dependencies

To build and run this application, you'll need:

- .NET 10.0 SDK
- Windows OS (the application uses Windows-specific APIs for global key detection)

## Building the Application

### Prerequisites

1. Install the .NET 10.0 SDK from the official Microsoft website
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

# The executable will be located in `bin\Release\net10.0-windows10.0.26100.0\win-x64\publish\`
```

## Usage

1. **Starting the Application**: Run the executable or use `dotnet run` from the project directory
2. **Moving the Window**: Drag the window by clicking and holding anywhere on the overlay (position it conveniently while playing Elsword)
3. **Tracking Elsword Progress**:
   - Use the +/- buttons to manually increment/decrement your counter for runs, titles, or achievements
   - Press the Reset button to reset the counter when starting a new tracking session

## Elsword Use Cases

- **Title Tracking**: Count how many titles you've earned or how many remain for a milestone
- **Run Counting**: Track how many times you've completed specific dungeons or quests
- **Achievement Progress**: Monitor your progress toward achievement completion
- **Farming Sessions**: Keep track of how many farming attempts you've made
- **Event Participation**: Count your participation in limited-time Elsword events

## Troubleshooting

- **Application Not Starting**: Ensure you have the .NET 10.0 runtime installed

## Development

This application is built using WPF (Windows Presentation Foundation) with C# and .NET 10.0.

### Key Components

- `MainWindow.xaml/.cs`: Main application window and logic