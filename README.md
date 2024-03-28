# Corona Management System at the HMO

A system for managing corona patients and vaccinations for the HMO.

## Target Audience: 
Management system for the HMO.

### Technologies Used:
Programming language: C#
Frameworks: Angular
Databases: SQL Server
Development tools: Git, Visual Studio, Visual Studio Code
Operating systems: Windows

#### Installation and Running:
**Download the Code from GitHub**:
   - Open the project page on GitHub: [Corona Database Management-HMO](https://github.com/shoshana2133/HMO).
   - Click on the "Code" button and then on "Download ZIP" to download the code to your computer.

The files for installing and running the project are located in the HMO folder:
- **Database Setup**: The script.sql file must be run in a SQL Server workspace.
- **Server Setup**: In the API folder, the HMO.sln file must be run in the Visual Studio workspace.
- **Client Setup**: Open an Angular project in a Visual Studio Code workspace. Replace the src folder created in the project with the src folder located in the HMO folder. The client-side project must be run in the terminal using the command: `ng s -o`.

##### Key Features:
Managing Members:
- Show Member Details: Displaying a table of all HMO members. Clicking on a member will lead to viewing all their details.
- Add Members: Users can add a health insurance member to the system, add vaccinations, and a date of recovery from corona.
- Remove Members: Users can remove members from the system.