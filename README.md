# Carpark

A take-home coding assignment for backend developer interview.

## Prerequisites

Before you begin, ensure you have met the following requirements:

- [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/) or higher.
- [.NET 6.x](https://dotnet.microsoft.com/download/dotnet/6.0).
- Azure Storage Account (for batch job and file storage).
- SQL Server (for database storage).

## Database Setup

This project uses SQL Server as the database. Follow these steps to set up the database:

1. **Connection String**: Make sure you have the connection string for your SQL Server database. You can usually find this in your `appsettings.json` file.

2. **Database Migration**: If the database hasn't been created yet, you can use Entity Framework Core Migrations to create it. Open a command prompt or terminal in the project directory and run the following commands:

    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

3. **Seed Data (Optional)**: If your project includes seed data, you can run it using a database seed script or a custom method in your code. Provide instructions here if necessary.

## Azure Storage Setup

This project utilizes Azure Storage for batch jobs and file storage. Follow these steps to set up Azure Storage:

1. **Azure Storage Account**: Create an Azure Storage Account if you don't have one already.

2. **Connection String**: Retrieve the connection string for your Azure Storage Account. You will need this connection string to interact with Azure Storage.

## Running the Project

Follow these steps to run the project:

1. Open the project in Visual Studio.

2. Build the project to ensure all dependencies are restored.

3. Start the project by pressing `F5` or using the "Start" button in Visual Studio.

4. The project should now be running, and you can access it in your web browser at `http://localhost:7026`, where `7026` is the port number configured in your project settings.

## Batch Job

To run the batch job:

1. Ensure you have the Azure Storage connection string and SQL Server connection string configured in your `appsettings.json`.

2. Implement the batch job logic using Azure Functions or a similar technology.

3. Trigger the batch job by calling the appropriate endpoint or executing the Azure Function.

4. The batch job will read a file from Azure Storage, import data into the database, and save a backup of the file in Azure Storage.

## Usage

Provide information on how to use your project, including any specific endpoints, APIs, or user interfaces. Explain how users can trigger the batch job and monitor its progress.

## Contributing

If you'd like to contribute to this project, please follow these steps:

1. Fork the project.

2. Create a new branch for your feature or bug fix.

3. Make your changes and submit a pull request.