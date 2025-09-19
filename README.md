# CopilotTest

CopilotTest is a simple Windows Forms application built with .NET 8. It demonstrates how to use a switch statement for control flow and integrates with GitHub Copilot PR review to enforce code conventions.

## Features

- Enter an HTTP status code in the textbox.
- Click the **Show Message** button to display the corresponding status message.
- Uses a switch statement for control flow (as enforced by Copilot configuration).
- Shows an error message for invalid input.

## Getting Started

1. **Clone the repository:**
2. **Open the solution in Visual Studio 2022.**
3. **Build and run the project.**

## Usage

### 1. Launch the Application

![Application Start](screenshots/app_start.png)

### 2. Enter a Status Code

Type a status code (e.g., `200`, `400`, `404`, `500`) into the textbox.

![Enter Status Code](screenshots/enter_code.png)

### 3. Click "Show Message"

Click the **Show Message** button.

![Click Button](screenshots/click_button.png)

### 4. View the Result

The textbox will display the corresponding message:

| Entered Value | Displayed Message         |
|---------------|--------------------------|
| 200           | OK                       |
| 400           | Bad Request              |
| 404           | Not Found                |
| 500           | Internal Server Error    |
| Any other     | Unknown Status           |

![Result](screenshots/result.png)

### 5. Invalid Input

If you enter a non-numeric value, the application will prompt you to enter a valid status code.

![Invalid Input](screenshots/invalid_input.png)

## Code Convention

This project uses a Copilot configuration (`.github/copilot.yaml`) to enforce the following rules:
- Prefer switch statements over multiple if-else clauses.
- Do not use `message` as a variable name for string variables.

## License

MIT