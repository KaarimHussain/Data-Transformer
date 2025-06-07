# DataTransformX

**DataTransformX** is a simple, multi-language CLI tool for transforming data between **XML** and **JSON** formats. Built to support developers working in **JavaScript (Node.js)**, **C# (.NET Core)**, and **Dart** — it's perfect for projects, quick conversions, or coding competitions.

---

## 🚀 Features

- ✅ XML → JSON conversion
- ✅ JSON → XML conversion
- ✅ CLI usage with file input
- ✅ Works in Node.js, C#, and Dart
- ✅ Lightweight, no external config needed
- ✅ Easy to modify and extend

---

## 📁 Project Structure

```
DataTransformX/
├── datatransformx-js/
│   ├── index.js
│   ├── xmlToJson.js
│   ├── jsonToXml.js
│   └── package.json
├── DataTransformX-CSharp/
│   ├── Program.cs
│   └── Transformer.cs
└── datatransformx-dart/
    └── main.dart
```

---

## 🧑‍💻 Usage

### JavaScript (Node.js)

**1. Install dependencies:**
```bash
cd datatransformx-js
npm install
```

**2. Run:**
```bash
node index.js xml2json input.xml
node index.js json2xml input.json
```

---

### C# (.NET Core)

**1. Install dependencies:**
- Make sure [.NET SDK](https://dotnet.microsoft.com/download) is installed.
- Run this in the `DataTransformX-CSharp` directory:
```bash
dotnet add package Newtonsoft.Json
```

**2. Build and run:**
```bash
dotnet run xml2json input.xml
dotnet run json2xml input.json
```

---

### Dart

**1. Setup:**
- Make sure you have [Dart SDK](https://dart.dev/get-dart) installed.
- Add dependency in `pubspec.yaml`:
```yaml
dependencies:
  xml: ^6.3.0
```

**2. Run:**
```bash
dart main.dart xml2json input.xml
dart main.dart json2xml input.json
```

---

## 🔧 CLI Syntax (All Languages)

```
[language command] [xml2json|json2xml] [file_path]
```

✅ Supports any file path  
✅ Outputs the result in terminal

---

## 🤔 When to Use

- ⚡ During competitive programming or hackathons
- 🔄 For converting API responses between XML/JSON
- 📦 As a utility in backend data pipelines
- 👨‍🏫 For learning how serialization works in multiple languages

---

## 👥 Contributing

Feel free to fork and contribute! Here’s how:

1. Fork the repository
2. Create a new branch (`feature/my-feature`)
3. Commit your changes
4. Push to your fork
5. Create a Pull Request

---

## ✅ Todo / Improvements (PRs Welcome)

- [ ] Add file output option
- [ ] Add error handling for invalid XML/JSON
- [ ] Create web version using HTML + JS
- [ ] Unit tests for each language
- [ ] Add benchmarking for large files

---

## 📄 License

MIT License. Free to use for any purpose. Attribution appreciated.

---

## 🙌 Acknowledgments

Special thanks to:
- `xml2js`, `js2xmlparser` for Node.js
- `Newtonsoft.Json` for C#
- `xml` package for Dart

Made with 💻 by **Kaarim**.
