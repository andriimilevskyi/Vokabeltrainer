
# 🧠 Vokabeltrainer (C# Console App)

A simple console-based vocabulary trainer written in C#.  
The application allows users to add, review and practice vocabulary using a quiz system.

---

## 📖 Description

This application helps users learn foreign language vocabulary through interactive input.  
Words and their translations are stored using a `Hashtable` (key-value structure).

The user can add new words, display all stored vocabulary, and practice them in a learning mode where words are presented in random order.

---

## 🚀 Features

- Add new vocabulary (word + translation)
- Display all stored words
- Learning mode (quiz system)
- Randomized word order using LINQ
- Case-insensitive answer checking
- Keyboard-based menu navigation
- Basic input validation

---

## 🎮 Controls

| Key | Action |
|-----|--------|
| 1 | Add new vocabulary |
| 2 | Show vocabulary list |
| 3 | Start learning mode |
| ESC | Exit program |

---

## 🛠️ Technologies

- C#
- .NET
- Console Application
- `Hashtable` (data storage)
- LINQ (randomization)

---

## ▶️ How to run

```bash
dotnet run --project Vokabeltrainer
