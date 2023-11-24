# MainSignalClient

## Description of the sample project.

A simple app to consume the information our server is providing in real time.
Defining a method to consume the data that the server is making available in real time For that, We create a connection to the Hub, passing our server’s URL, which returns a list of dates and displays it on the terminal.

## Getting Started

1. Create a new console application:

    ```bash
    dotnet new console -o MainSignalClient
    ```

2. Navigate to the project directory:

    ```bash
    cd MainSignalClient
    ```

3. Add the SignalR client package:

    ```bash
    dotnet add package Microsoft.AspNetCore.SignalR.Client
    ```

4. Open the project in your preferred code editor.

5. In your code, you can use the SignalR client to connect to a SignalR hub.

### Prerequisites

- .NET 6 SDK or later
- ASP.NET Core, SignalR

### Running the Application

To start the client project with this command in the console :

```bash
dotnet watch run
