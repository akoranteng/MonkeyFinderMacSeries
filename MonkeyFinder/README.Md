# MonkeyFinder Mac Series — Part 3: Services, API, and Async (.NET 8 • VS Code • iOS)

Part 3 introduces **data services**, **API calls**, and **async/await** to the MonkeyFinder app.  
This is where the project becomes dynamic — fetching live data instead of using hard‑coded lists.

This branch builds on the MVVM + Navigation foundation from Part 2 and adds real networking, error handling, and connectivity checks.

---

## What’s Included in Part 3

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

## Folder Structure

# MonkeyFinder Mac Series — Part 3: Services, API, and Async (.NET 8 • VS Code • iOS)

Part 3 introduces **data services**, **API calls**, and **async/await** to the MonkeyFinder app.  
This is where the project becomes dynamic — fetching live data instead of using hard‑coded lists.

This branch builds on the MVVM + Navigation foundation from Part 2 and adds real networking, error handling, and connectivity checks.

---

## What’s Included in Part 3

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

## Folder Structure

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

## Running the Project

### Switch to Part 3:
```bash
git switch part3-services