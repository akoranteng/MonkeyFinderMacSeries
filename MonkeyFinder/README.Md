# MonkeyFinder Mac Series — Part 3: Services, API, and Async (.NET 8 • VS Code • iOS)

Part 3 introduces **data services**, **API calls**, and **async/await** to the MonkeyFinder app.  
This is where the project becomes dynamic — fetching live data instead of using hard‑coded lists.

This branch builds on the MVVM + Navigation foundation from Part 2 and adds real networking, error handling, and connectivity checks.

---

## ✔ What’s Included in Part 3

### ✔ MonkeyService (API + HttpClient)
A new service layer is added to handle data retrieval:

- **MonkeyService.cs**
- **HttpClient** for API calls  
- **Async/await** for non‑blocking operations  
- **JSON deserialization**  
- **Error handling**  
- **Connectivity checks** (optional)

This replaces the static monkey list with real data from a remote endpoint.

---

### ✔ ViewModel Updates
ViewModels now:

- Call **MonkeyService**  
- Load data asynchronously  
- Handle errors gracefully  
- Expose loading indicators  
- Refresh data on demand  

This keeps UI logic clean and testable.

---

### ✔ UI Updates
The UI now reflects real data loading:

- Loading spinner  
- Pull‑to‑refresh  
- Error messages (optional)  
- Updated bindings for dynamic data  

The app now behaves like a real production mobile app.

---

## 📁 Folder Structure
MonkeyFinder/
│
├── Models/              # Monkey model (Id, Name, Location, Image, etc.)
├── ViewModels/          # MainViewModel, MonkeyDetailsViewModel
├── Views/               # MainPage.xaml, MonkeyDetailsPage.xaml
│
├── Services/            # MonkeyService.cs (API + HttpClient)
│
├── App.xaml             # Global resources
├── AppShell.xaml        # Shell navigation + routes
└── MonkeyFinder.csproj  # Project file


---

## ▶️ Running the Project

### Switch to Part 3:
```bash
git switch part3-services

Open the project:
cd part3-services/MonkeyFinder
code .
Build and run:
dotnet build
dotnet build -t:run -f net8.0-ios
⭐ Important Note — MAUI Simulator Deployment Behavior (New Discovery)
⭐ Important Note — MAUI Simulator Deployment Behavior (New Discovery)
When running MAUI apps on macOS using Xcode simulators, MAUI uses a specific device‑selection rule:
If multiple iOS simulators exist, MAUI auto‑boots and deploys to the newest iOS runtime available — even if you manually booted a different device.
What this means in practice:
• If you have simulators with iOS 26.x or 27.x, MAUI will prefer those.
• Older simulators (e.g., iPhone 16 Pro on iOS 18.6) may be ignored.
• MAUI may auto‑boot an iPad simulator behind your back.
• You may see two simulators appear when running the app.
• The app may deploy to the wrong device unless you override it.
This behavior is not documented in the official MAUI tutorials and is important for developers working with multiple runtimes.
---
✔ Fix Option 1 — Force MAUI to Use a Specific Device (Recommended)
Use the _DeviceId override to deploy to the correct simulator:
dotnet build -t:run -f net8.0-ios -p:_DeviceId=<YOUR_DEVICE_UUID>
Example for iPhone 16 Pro:
dotnet build -t:run -f net8.0-ios -p:_DeviceId=3BB87357-E29F-494D-9C42-1E12189842BD
✔ Fix Option 2 — Delete Newer Simulators (Optional)
If MAUI keeps auto‑booting newer iPads, you can remove them:
xcrun simctl delete <UUID>
This prevents MAUI from selecting those devices.
You can recreate them later if needed.

