# 🌡️📏⚖️ Unit Converter (Length, Weight, Temperature)

A simple full-stack **unit conversion web application** built with **ASP.NET Core Razor Pages**.  
The app allows converting between units of **length**, **weight**, and **temperature**, following the project requirements from:

👉 https://roadmap.sh/projects/unit-converter

---

## 🚀 Live Demo

The project is deployed via Render (Docker):

🔗 **https://unitconvertorrazor-q6t1.onrender.com**

---
## ✨ Features

### ✔ Convert between multiple unit categories:

#### **Length**
- millimeter (mm)
- centimeter (cm)
- meter (m)
- kilometer (km)
- inch (in)
- foot (ft)
- yard (yd)
- mile (mi)

#### **Weight**
- milligram (mg)
- gram (g)
- kilogram (kg)
- ounce (oz)
- pound (lb)

#### **Temperature**
- Celsius (°C)
- Fahrenheit (°F)
- Kelvin (K)

### ✔ Clean UI  
### ✔ Form submits to the same page (`target="_self"`)  
### ✔ Instant calculation result  
### ✔ No database required  
### ✔ Fully server-side logic  

---

## 🛠️ Technologies Used

| Layer | Technology |
|-------|------------|
| Frontend | HTML, CSS, JavaScript, Bootstrap, Razor Pages UI |
| Backend | ASP.NET Core 8 Razor Pages |
| Language | C# |
| Deployment | Docker + Render |
| Server | Kestrel |

---

## 📂 Project Structure

```
UnitConverterRazor/
│
├── Pages/
│   ├── Length.cshtml
│   ├── Length.cshtml.cs
│   ├── Weight.cshtml
│   ├── Weight.cshtml.cs
│   ├── Temperature.cshtml
│   ├── Temperature.cshtml.cs
│   ├── Shared/_Layout.cshtml
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
│
├── wwwroot/
├── Dockerfile
├── Program.cs
└── README.md
```

---

## ⚙️ How It Works

Each converter page:

- Shows a form for value input  
- Lets the user choose units  
- Submits the form to the same page (`method="post"`)  
- Executes backend logic in its `*.cshtml.cs` file  
- Returns the converted result back to the UI

No JavaScript, no database — pure server processing.

---

## ▶️ Running Locally

### 1. Clone the repository

```bash
git clone https://github.com/yanamak89/UnitConvertorRazor.git
cd UnitConvertorRazor
```

### 2. Run the app

```bash
dotnet run --urls http://localhost:5090
```

App will be available at:

```
http://localhost:5090
```

---

## 🐳 Running via Docker

```bash
docker build -t unit-converter .
docker run -p 5090:5000 unit-converter
```

---

## 📤 Deployment

This project is deployed on **Render Web Services using Docker**:

🔗 Deployment dashboard:  
https://dashboard.render.com/web/srv-d4ov4ueuk2gs73d191qg/deploys/

---

## 📘 Source Requirement

Project follows the specification from roadmap.sh:

👉 https://roadmap.sh/projects/unit-converter

---

## ❤️ Author

**Yana Makogon**  
Founder, Full-stack Developer  
🔗 GitHub: https://github.com/yanamak89

---

## ⭐ If you like this project, feel free to star the repo!
