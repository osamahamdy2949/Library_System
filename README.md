# 📚 Library Management System (Console App)

A simple **Library Management System** built using **C# and .NET**, designed as a console application.
This project demonstrates solid understanding of **Object-Oriented Programming (OOP)** principles, clean code structure, and basic system design.

---

## 🚀 Features

* 📖 Manage library branch information
* 👤 Register new members
* 📚 View all users (Librarian + Members)
* 📦 View all book copies
* ✅ View available books only
* 🔄 Borrow books
* ↩️ Return books with fine calculation
* 📊 Track member borrowing history

---

## 🧱 Project Structure

The project is organized into multiple layers:

```
Library_System/
│
├── Models/              # Core entities (Book, Member, BookCopy, etc.)
├── Contracts/           # Interfaces & abstractions
├── Services/            # Business logic (Borrow, Return, etc.)
├── Helpers/             # UI helpers & data seeding
├── Extensions/          # Custom extension methods
├── Enums/               # Enums like CopyStatus
└── Program.cs           # Entry point
```

---

## 🧠 Concepts Applied

* Object-Oriented Programming (OOP)

  * Encapsulation
  * Inheritance
  * Abstraction
  * Polymorphism
* SOLID Principles (basic level)
* Interfaces & Contracts
* Separation of Concerns
* Extension Methods
* Exception Handling

---

## 📌 Key Entities

* **LibraryBranch** → Manages books, members, and operations
* **Book** → Represents book metadata
* **BookCopy** → Represents physical copies of books
* **Member** → Library users who can borrow books
* **Librarian** → Branch manager
* **BorrowTransaction** → Tracks borrowing and returns

---

## ⚙️ How It Works

1. The system starts with pre-seeded data using `DataSeeder`
2. User interacts through a console menu
3. Operations include:

   * Borrowing a book
   * Returning a book (with fine calculation)
   * Viewing history
   * Registering new members

---

## 🖥️ Sample Menu

```
════════════════════════════════════════
      CITY LIBRARY - MAIN MENU
════════════════════════════════════════
  1. Branch Information
  2. Show All Users
  3. Show Available Books
  4. Show All Book Copies
  5. Borrow a Book
  6. Return a Book
  7. Member Borrowing History
  8. Register New Member
----------------------------------------
  0. Exit
========================================
```

---

## 🧮 Business Logic Highlights

* ✔️ Book borrowing allowed only if copy is available
* ✔️ Each borrow creates a transaction
* ✔️ Late return fine = **10 EGP per day**
* ✔️ Member history is tracked بالكامل
* ✔️ Input validation (Email, Phone, IDs normalization)

---

## 🛠️ Technologies Used

* C#
* .NET (Console Application)
* OOP Principles

---

## ▶️ How to Run

1. Clone the repository:

```bash
git clone https://github.com/your-username/library-system.git
```

2. Open in Visual Studio

3. Run the project:

```
Ctrl + F5
```

---

## 📈 Future Improvements

* Add database (SQL Server / SQLite)
* Add search & filtering
* GUI (WinForms / WPF / Web API + Frontend)
* Authentication system
* Book reservation system

---

## ⭐ Notes

This project is built for learning purposes and demonstrates strong fundamentals in:

* Backend logic
* System design (basic level)
* Clean and maintainable code

---

## 💡 Feedback

Feel free to open issues or suggest improvements!
