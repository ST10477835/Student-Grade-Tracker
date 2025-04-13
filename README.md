# Student Grade Tracker

A simple Java console application for tracking student names and their grades for a particular subject. This tool allows users to add student data, display the list of students, search for a specific student, calculate the class average, and exit the program.

## 📋 Features

- ✅ Add a new student and their grade  
- 📜 Display a list of all students with their grades  
- 🔍 Search for a student and display their grade  
- 📊 Calculate the average grade for the subject  
- ❌ Exit the program safely

## 🧑‍💻 How It Works

Upon running the program, the user will be prompted with a menu to choose from various options. Input is taken via the command line using `Scanner`, and exception handling is used to catch input errors.

All student names and grades are stored in separate `ArrayList`s.

### Main Menu Options

1. **Add a new student and grade** – Prompts the user to input a student's name and grade.  
2. **Display list of students and their grades** – Shows all stored student records.  
3. **Calculate average grade** – Computes and prints the average of all grades.  
4. **Search for a student and display their grade** – Searches for a student by name and prints their grade if found.  
5. **Exit** – Ends the program with a thank you message.

## 🛠️ Technologies Used

- Java (JDK 17+ recommended)
- Standard Java Libraries (`java.util.ArrayList`, `java.util.Scanner`)

## 📂 File Structure


## 🚀 Getting Started

1. Clone or download the project.
2. Open the project in your favorite Java IDE (NetBeans, IntelliJ, VS Code, etc.).
3. Compile and run the `StudentGradeTracker` class.
4. Follow the on-screen prompts in the console.

## 📌 Notes

- This is a basic learning project and doesn't use advanced data structures or persistent storage.
- All data is lost once the program terminates.
- The subject is hardcoded as `"Mathematics"` but can be modified in the `main` method.

## 🤝 Contributing

This project is designed for educational purposes. If you have suggestions or want to expand its features (like adding file storage or multiple subjects), feel free to fork and contribute!
