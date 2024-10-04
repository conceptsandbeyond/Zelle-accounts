# ZELLE00: Feature File Only (Cucumber Testing)

## Project Overview
This project demonstrates the first step of Test-Driven Development (TDD) by defining only the feature file. No step definitions or code implementations are provided at this stage.

## Features
- Cucumber feature file for ZELLE Accpunts (no code or step definitions)
- Focuses solely on defining behavior-driven development (BDD) test scenarios

## Prerequisites
- .NET 7 SDK (or higher)
- SpecFlow for Cucumber testing in C#

## Getting Started
1. Clone the repository.
2. Open the project in Visual Studio or any C# IDE.
3. Navigate to `Features/ZelleAccounts.feature` to see the test scenarios.
4. No need to run the tests yet, as step definitions and code implementations are missing.

## Example Feature
```gherkin
Feature: Zelle Pay
  Scenario: Retrive Zelle Account Type
    Given I am a "Retail" user
    When I retrieve Zelle eligibility status "F"
    Then I get "Retail Zelle"
