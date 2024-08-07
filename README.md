# RomanFacts

RomansFacts includes a basic library, a JSON file (facts repository), and a MAUI GUI. The goal of the project was to create a “Fact of the Day” app, but the idea has since been abandoned. The GUI includes a few basic selections.

## Table of Contents

- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [How It Works](#how-it-works)
- [Classes and Methods](#classes-and-methods)
- [Usage](#usage)

## Project Structure

The project consists of the following main components:

- **RomanFacts.Library**: Contains the logic for retrieving facts from the JSON file and category logic.
  - `Repository.cs`: Reads facts from the JSON file.
  - `Service.cs`: Provides random facts based on the requested category.
  - `facts.json`: Basic fact list.
- **RomanFacts.Desktop**: MAUI application for displaying facts.
  - `MainPage.xaml`: UI definitions.
  - `MainPage.xaml.cs`: Basic code-behind for UI actions.

## Getting Started

### Prerequisites
- Visual Studio/VSCode
- .NET 6.0 or later
- .NET MAUI workload installed

### Installation

1. Clone the repository:
   `git clone https://github.com/BlakePeavy/RomanFacts.git`
   
2. Navigate to the project directory:
   `cd RomanFacts`

3. Build the project:
   `dotnet build`

4. Run the application:
   `dotnet run --project RomanFacts.Desktop`

## How It Works

The application reads facts from a JSON file (`facts.json`) stored in the `RomanFacts.Library` project. During the build process, this JSON file is copied to the output directory of the `RomanFacts.Desktop` project. The `Service` class fetches a random fact from the requested category.

## Classes and Methods

### `Repository.cs`

- **GetFacts()**: Reads the `facts.json` file and returns a dictionary containing lists of facts categorized by type (history, architecture, culture, famous figures).

### `Service.cs`

- **GetFact(string category)**: Fetches a random fact from the requested category.

### `MainPage.xaml.cs`

- **ShowNewFact(string category)**: Using the requested category sends a request to `GetFact()` to display on a label.
- **OnRefreshFactClicked(object sender, EventArgs e)**: Click event for the "Refresh Fact" button.
- **OnCategoryChanged(object sender, EventArgs e)**: Event change for the "CategoryPicker" picker.

## Usage

1. **Select a Category**: Uses the picker to select a category (history, architecture, culture, famous figures).
3. **Refresh Fact**: Click the "Refresh Fact" button to get a new random fact from the selected category.
