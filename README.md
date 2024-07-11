# Universal Color Translator

## Overview
The Universal Color Translator tool converts color names into their respective hexadecimal codes. It is implemented in C# using Windows Form App.

## Setup and Execution
1. Clone the repository.
2. Open the solution in Visual Studio 2022.
3. Build the solution to restore dependencies.
4. Run the Form application to use the tool.

## Design Decisions
- **Dictionary**: Used to map color names to hexadecimal codes for O(1) lookup time.
- **Lowercase Conversion**: Ensures case-insensitive matching of color names.

## Technologies Used
- **C#**
- **Windows Form App**
- **Visual Studio 2022**

## Running Tests
1. Open the solution in Visual Studio 2022.
2. Build the solution.
3. Run all unit tests using the Test Explorer.

## Example Usage
- Input: "red"
- Output: "#FF0000"

- Input: "blue"
- Output: "#0000FF"

- Input: "green"
- Output: "#008000"
