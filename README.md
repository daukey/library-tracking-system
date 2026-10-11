# Library Book Tracking System

A simple Windows Forms desktop app for keeping track of the books in a virtual library. 
Built with C# and .NET as an OOP course project.

## Features

- Add books with a title, author, genre, page count and availability status
- View all books in a table (title, author, genre, pages, availability)
- Search by book title or author name (case-insensitive)
- Delete the selected book from the list
- Show the details of a selected book in a message box
- Clear the input fields with one click

> **Important Note:** For now books are stored in memory only, so the list resets when you close the app.

## Download

1. Go to the [Releases](../../releases) page.
2. Download the latest `.exe` from the **Assets** section.
3. Run `library-tracking-system.exe`.

### Windows SmartScreen warning

Since the app is not code-signed, Windows may show a **"Windows protected your PC"** message the first time you run it. This is normal for small unsigned apps.

To continue:

1. Click **More info**.
2. Click **Run anyway**.

If you downloaded a `.zip`, extract it first and run the `.exe` from the extracted folder.

## Build from source

If you have Windows 11 and .NET 10 SDK, you can build this from source using bash:

```bash
git clone https://github.com/daukey/library-tracking-system.git
cd library-tracking-system
dotnet build
```

Or open the `.sln` file in Visual Studio and press **F5**.

## Project structure

| Project | Description |
| --- | --- |
| `library-tracking-system` | Windows Forms UI (`Form1`) |
| `library-tracking-system.Entities` | Class library containing the `Book` class |


## License

This project is for educational purposes.
