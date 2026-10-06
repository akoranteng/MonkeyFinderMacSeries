# MonkeyFinder (MAUI • VS Code • macOS • iOS)

A clean, modern .NET MAUI application built entirely on **macOS using VS Code**, targeting **iOS**.  
This project demonstrates a full MVVM architecture, Shell navigation, routed pages, and polished UI layouts — all without Visual Studio for Windows.

This branch includes major UI enhancements to both the Monkeys list and the Details page.

---

## 🚀 Features

### ✔ Cross‑platform .NET MAUI app  
Runs on iOS, Android, macOS, and Windows.

### ✔ Built using VS Code on macOS  
No Visual Studio for Windows required — full iOS simulator support.

### ✔ MVVM architecture  
- `MonkeysViewModel`  
- `MonkeyDetailsViewModel`  
- `BaseViewModel`  
- Routed navigation via Shell

### ✔ Monkey list page  
A clean, scrollable list of monkeys with:
- Rounded image thumbnails  
- Card‑style layout  
- Spacing between items  
- Smooth scrolling  
- Tap‑to‑navigate behavior

### ✔ Details page  
A polished details screen showing:
- Full monkey image  
- Name  
- Location  
- Description  
- **New two‑column layout** for clean label/value presentation

---

## 🎨 UI Enhancements in This Branch

### 🟦 MonkeysPage.xaml
- Rounded image frames  
- Card layout with shadows  
- Spacing between items  
- Clean typography  
- ScrollView wrapping for smooth scrolling

### 🟩 MonkeyDetailsPage.xaml
- Clean, readable layout  
- Full image header  
- **Two‑column Grid layout**  
  - Left column: labels  
  - Right column: values  
- Improved spacing and readability  
- Fully stable bindings (`Monkey.Name`, `Monkey.Location`, `Monkey.Details`, `Monkey.Image`)

---



