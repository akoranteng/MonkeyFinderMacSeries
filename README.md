MonkeyFinder Mac Series — Part 2: Navigation & MVVM (.NET 8 • VS Code • iOS)
Part 2 builds on the baseline MAUI project by introducing MVVM architecture, navigation, and data binding. This branch restructures the app to follow best practices and prepares it for services, API calls, and platform features in later parts.
---
What’s Included in Part 2
✔ MVVM Architecture
This branch introduces a clean MVVM structure:
• Models/ — data models
• ViewModels/ — UI logic
• Views/ — XAML pages
• Commands — user actions
• ObservableObject / INotifyPropertyChanged — property change notifications
The UI is now fully driven by ViewModels instead of code-behind.
---
✔ Navigation
Navigation is added using:
• AppShell.xaml
• Shell routes
• Navigation from list → details page
This enables multi‑page flow and prepares the app for deeper features in Part 3 and Part 4.
---
✔ Data Binding
Views now bind directly to ViewModel properties:
• Monkey list
• Selected monkey
• Commands for navigation
• Loading indicators
This removes UI logic from the code-behind and makes the app testable and maintainable.
---
Folder Structure
MonkeyFinder/
│
├── Models/
├── ViewModels/
├── Views/
├── Services/        (added in Part 3)
│
├── App.xaml
├── AppShell.xaml
└── MonkeyFinder.csproj
Running the Project
Switch to Part 2:

Open the project:
Build and run:
dotnet build
dotnet build -t:Run -f net8.0-ios

