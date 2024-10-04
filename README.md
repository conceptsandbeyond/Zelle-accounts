# ZELLE TDD Training Project

## Overview
This repository contains a series of projects demonstrating the Test-Driven Development (TDD) process using a Zelle application as the example. Each project progressively builds upon the last, illustrating the TDD cycle:
1. **Testing (Feature Definition)**
2. **Code Implementation**
3. **Refactoring**

The repository is broken down into five separate projects that reflect different stages of development:

1. **ZELLE00**: Feature files only (Cucumber testing).
2. **ZELLE01**: Feature files with step definitions (no code implementation).
3. **ZELLE02**: Feature files and step definitions, with code skeleton but no functionality.
4. **ZELLE03**: Full feature, step definitions, and complete Zelle functionality..
5. **ZELLE04**: Full implementation with Moq-based unit tests for mocking behaviors.

## Project Structure

```text
├── ZELLE00/                  # Project with feature files only
├── ZELLE01/                  # Project with step definitions but no code implementation
├── ZELLE02/                  # Project with step definitions and a code skeleton
├── ZELLE03/                  # Project with full Zelle implementation
├── ZELLE04/                  # Full implementation with Moq testing
└── README.md               # Parent repository README file (this file)
```

## Prerequisites
- .NET 7 SDK (or higher)
- Visual Studio or any other IDE with C# support
- NuGet for package management (used to install Moq, SpecFlow, etc.)


## Setup Instructions
1. **Clone the Repository**
   ```
   git clone https://github.com/conceptsandbeyond/Zelle-Accounts-TDD-Training.git
   ```
2. **Open Projects** Navigate to the project folder you're interested in (ZELLE00, ZELLE01, etc.) and open the project in Visual Studio or your preferred IDE.
3. **Installing Dependencies** Each project might require different dependencies, such as SpecFlow for Cucumber testing or Moq for mocking. Install them via the NuGet Package Manager or .NET CLI:
   - Example for Moq:
   ```
   dotnet add package Moq
   ```
4. **Run Tests** For each project, tests can be run using the following command:
   ``dotnet test``

5. **Exploring the TDD Stages**
   - Start with `ZELLE00` to see how the feature files are written.
   - Move to `ZELLE01` to see the step definitions.
   - In `ZELLE02`, explore the skeleton code and try writing your own implementation.
   - In `ZELLE03`, see the completed implementation.
   - In `ZELLE04`, check out the usage of Moq for unit testing with mocks.

## Project Breakdown

### 1. ZELLE00: Feature File Only (Cucumber Testing)

   - Defines the test scenarios in a Gherkin-based feature file.
   - No code or step definitions are implemented.

### 2. ZELLE01: Feature and Step Definitions (No Code Implementation)

   - Contains feature files and step definitions but no Zelle Account Type logic is implemented.
   - Illustrates the "write tests first" principle of TDD.

### 3. ZELLE02: Feature, Steps, and Code Skeleton

   - Adds a code skeleton for the Zelle Account Type without any actual functionality.
   - Tests will fail due to unimplemented methods.

### 4. ZELLE03: Fully Implemented Zelle Account Type 

   - Complete implementation of the Zelle Account Type.
   - All tests should pass successfully.

### 5. ZELLE04: Full Implementation with Moq Testing

   - Fully implemented Zelle with unit tests that use Moq for mocking dependencies.
   - Demonstrates how to mock dependencies and test them.
   
## Contributing
   Feel free to fork this repository and create pull requests if you would like to contribute to the project or make improvements to the TDD training cycle.

## License
This project is licensed under the **ConceptsandBeyond** License. See the LICENSE file for more details.

---

This parent `README.md` file provides an overview of the repository, details about each sub-project, instructions for setup, and a general description of the TDD process in relation to each stage of the project. It is designed to be the first point of reference for users exploring the repository.
