# Constructors Demo in C\#

## Overview

This project demonstrates the use of **constructors**, **object-oriented principles**, and 
**exception handling** in C#. It introduces two classes: `Human` and `Car`, each showcasing how 
constructors initialize object properties and how methods represent behaviors.

The `Solution` class orchestrates the demonstration logic, while the `Program` class serves as the application entry point.

## Features

* Demonstrates how to use **constructors** to initialize class objects
* Illustrates **basic class structure**, including properties and methods
* Implements **basic exception handling**
* Provides a simple, console-based output to simulate real-world behavior

## Project Structure

```
constructors_demo_cs/
├── Program.cs       # Main entry point of the application
└── Solution.cs      # Main logic for object creation and method calls
```

## Classes

### 1. `Human`

Represents a human being with the following:

* **Properties**:

  * `Name` (string)
  * `Age` (int)
* **Constructor**: Initializes `Name` and `Age`
* **Methods**:

  * `Eat()`: Prints eating behavior
  * `Sleep()`: Prints sleeping behavior

### 2. `Car`

Represents a car with the following:

* **Properties**:

  * `Make` (string)
  * `Model` (string)
  * `Year` (int)
  * `Color` (string)
* **Constructor**: Initializes all properties
* **Method**:

  * `Drive()`: Displays car details

## Execution Flow

1. The `Program.Main()` method creates an instance of `Solution` and calls its `Run()` method.
2. Inside `Run()`:

   * Two `Human` objects are created and perform actions (`Eat` and `Sleep`).
   * Two `Car` objects are created and display their details via `Drive()`.

## Sample Output

```
Jacky is eating.
Jacky is sleeping.
Mason is eating.
Mason is sleeping.
This is the car you drive:
MAKE: Ford
MODEL: F-150
This is the car you drive:
MAKE: Chevy
MODEL: Corvette
```

## Requirements

* .NET SDK (version 6.0 or later recommended)
* C# compatible IDE or code editor (e.g., Visual Studio, Rider, VS Code)

## How to Run

1. Clone the repository or copy the source code into your C# project.
2. Open the project in an IDE that supports C#.
3. Build and run the project.

## DISCLAIMER

UNDER NO CIRCUMSTANCES SHOULD IMAGES OR EMOJIS BE INCLUDED DIRECTLY 
IN THE README FILE. ALL VISUAL MEDIA, INCLUDING SCREENSHOTS AND IMAGES 
OF THE APPLICATION, MUST BE STORED IN A DEDICATED FOLDER WITHIN THE 
PROJECT DIRECTORY. THIS FOLDER SHOULD BE CLEARLY STRUCTURED AND NAMED 
ACCORDINGLY TO INDICATE THAT IT CONTAINS ALL VISUAL CONTENT RELATED TO 
THE APPLICATION (FOR EXAMPLE, A FOLDER NAMED IMAGES, SCREENSHOTS, OR MEDIA).

I AM NOT LIABLE OR RESPONSIBLE FOR ANY MALFUNCTIONS, DEFECTS, OR ISSUES 
THAT MAY OCCUR AS A RESULT OF COPYING, MODIFYING, OR USING THIS SOFTWARE. 
IF YOU ENCOUNTER ANY PROBLEMS OR ERRORS, PLEASE DO NOT ATTEMPT TO FIX THEM 
SILENTLY OR OUTSIDE THE PROJECT. INSTEAD, KINDLY SUBMIT A PULL REQUEST 
OR OPEN AN ISSUE ON THE CORRESPONDING GITHUB REPOSITORY, SO THAT IT CAN 
BE ADDRESSED APPROPRIATELY BY THE MAINTAINERS OR CONTRIBUTORS.

---

Let me know if you'd like a version in Markdown or to include it in your project as a `README.md` file.
