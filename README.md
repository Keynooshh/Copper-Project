# Copper Project OOP - Windows Forms Application

## Overview

The **Copper Project OOP** is a Windows Forms application designed to manage various processes related to copper production, including customer orders, production management, quality checks, and inventory management. The application is built using C# and SQLite for database management. It provides a user-friendly interface for different roles such as storekeepers, product managers, sales managers, and quality checkers.

## Features

- **User Authentication**: Secure login system with role-based access control.
- **Customer Management**: Customers can place orders and track their order amounts.
- **Production Management**: Manage and track production processes such as crushing, leaching, and electro-winning.
- **Quality Check**: Perform quality checks on copper cathodes and approve or reject them based on purity levels.
- **Inventory Management**: Storekeepers can manage inventory, view orders, and handle customer requests.
- **Reporting**: Generate reports on production durations and order amounts.

## Technologies Used

- **C#**: Primary programming language.
- **Windows Forms**: For building the user interface.
- **SQLite**: Lightweight database for storing application data.
- **Entity Framework**: For database operations and management.

## Getting Started

### Prerequisites

- **.NET Framework**: Ensure you have the .NET Framework installed on your machine.
- **Visual Studio**: Recommended IDE for development and debugging.
- **SQLite**: Ensure SQLite is installed and configured.

### Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/Keynooshh/Copper-Project.git
   ```
2. **Open the Project**:
   - Open the solution file (`Copper-Project-OOP.sln`) in Visual Studio.
3. **Build the Project**:
   - Restore NuGet packages and build the solution.
4. **Run the Application**:
   - Set the `logInForm` as the startup form and run the application.

### Database Setup

1. **Initialize the Database**:
   - The application will automatically create the necessary database and tables on first run.
2. **Sample Data**:
   - Sample user data is inserted into the `Users` table for testing purposes.

## Usage

1. **Login**:
   - Use the provided sample credentials to log in as different roles (e.g., StoreKeeper, ProductManager).
   - **Sample Credentials**:
     | Username          | Password  | User_Role       |
     |-------------------|-----------|-----------------|
     | سیما مجتبوی       | password  | StoreKeeper     |
     | علی آشنا          | password  | ProductManager  |
     | زامیاد ذاکری      | password  | SalesManager    |
     | بابک معین         | password  | ProductOperator |
     | مهران رحمانیان    | password  | QualityChecker  |
2. **Customer Panel**:
   - Customers can place orders and view their order history.
3. **Production Panel**:
   - Manage production processes, track durations, and update production statuses.
4. **Quality Check Panel**:
   - Perform quality checks on copper cathodes and approve or reject them.
5. **Storekeeper Panel**:
   - Manage inventory, view orders, and handle customer requests.

## Code Structure

- **Forms**:
  - `logInForm.cs`: Handles user authentication.
  - `costumer.cs`: Manages customer orders.
  - `productManage.cs`: Manages production processes.
  - `qualityCheck.cs`: Handles quality checks.
  - `storeKeeper.cs`: Manages inventory and customer requests.
  - `saleManage.cs`: Manages sales and order tracking.
- **Helpers**:
  - `DatabaseHelper.cs`: Contains methods for database operations.
- **Entities**:
  - `DataSentEventArgs.cs`: Custom event arguments for data transfer between forms.

---

If you have any questions, please don't hesitate to ask!
