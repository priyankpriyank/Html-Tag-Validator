# HTML Tag Validator
<small>&copy; Priyank Vora - 000922930</small>

A C# WinForms application designed to validate HTML files by ensuring container tags are properly balanced. The program offers a user-friendly interface for loading and analyzing HTML files.

## Features

- **GUI Interface**: Includes menu options for easy navigation.
- **File Loading**: Supports the selection of valid HTML files through the `OpenFileDialog` with a filter for `.html` files.
- **Tag Validation**: Uses a stack-based algorithm to check if container tags are properly balanced.
- **Ignored Tags**: Automatically excludes non-container tags such as `<img>`, `<hr>`, and `<br>` during validation.
- **Modular Design**: Includes a `Process=>Check Tags` method for efficient and reusable code structure.
- **Status Display**: Provides real-time feedback on whether the tags are balanced or not.

## How to Use

1. Clone this repository to your local machine:
   ```bash
   git clone https://github.com/priyankpriyank/Html-Tag-Validator
