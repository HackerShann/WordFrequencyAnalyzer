# Word Frequency Analyzer

## Description

**Word Frequency Analyzer** is a simple Windows Forms application that reads a text file, calculates the frequency of each word, and allows you to display and save the results. The program processes a given text file, counts how often each word appears, and allows users to view and export the results. This tool is helpful for analyzing text content, such as finding the most frequently used words in a document.

## Features

- **Browse for File**: Select a text file to analyze.
- **Word Frequency Calculation**: Counts the frequency of each word in the text file.
- **Display Results**: View the word frequencies in a sorted list.
- **Save Results**: Save the word frequency data to a text file.
- **Case-insensitive**: Words are counted without regard to case.
- **Error Handling**: Displays error messages if issues arise while reading or saving files.

## How It Works

1. **Load a Text File**:  
   Click the **Browse** button to select a `.txt` file. The program will process the file and calculate the word frequencies.

2. **Display Word Frequencies**:  
   After the file is processed, click **Display** to show the word frequencies in descending order. Each word and its frequency will be displayed in the list box.

3. **Save the Results**:  
   Click **Save** to save the word frequencies to a `.txt` file. The file will contain the word and its corresponding frequency, sorted by frequency.

4. **Exit**:  
   Click **Exit** to close the application.

## Requirements

- **Windows Operating System** (Windows 7 or later)
- **.NET Framework 4.7.2 or later**
- **Visual Studio** (for building the application)

## Installation

1. **Clone or Download the Repository**  
   Clone this repository or download the project files to your local machine.

2. **Open the Project in Visual Studio**  
   Open the project in Visual Studio and build it using **Build** > **Build Solution**.

3. **Run the Application**  
   After building the project, run the application by selecting **Start** in Visual Studio or directly executing the compiled `.exe` file.

## Usage

1. Click **Browse** to select a `.txt` file containing the text to analyze.
2. After the file is loaded, click **Display** to show the word frequencies.
3. Optionally, click **Save** to export the results to a `.txt` file.
4. Click **Exit** to close the program.

## Example

**Input file (`sample.txt`)**:
Hello world! This is a test. Hello world, hello.

**Processed Output**:
hello: 3 world: 2 this: 1 is: 1 a: 1 test: 1


## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
