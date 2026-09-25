MonkeyFinder Mac Series (.NET 8 • VS Code • iOS)
A simplified, Mac‑friendly .NET 8 MAUI version of the MonkeyFinder workshop. Built for macOS, VS Code, and the iOS simulator, with each part organized into its own branch.
Branches
• main — Part 1: Baseline MAUI project
• part2 — Navigation + MVVM
• part3 — Services + API + async
• part4 — Polish + deployment
Purpose
Provides a clean, updated MonkeyFinder learning path for developers using Mac + VS Code instead of Windows + Visual Studio.
---
Usage
Clone:
git clone https://github.com/akoranteng/MonkeyFinderMacSeries.git

Switch parts:
git checkout part2
Run
dotnet build
dotnet build
dotnet build -t:Run -f net8.0-ios
License
MIT