VB.NET Windows Forms Application – Recycle Management System
📌 Overview
This project is a VB.NET Windows Forms Application built using Visual Studio.
It includes features such as:
User login and authentication
Data storage using SQLite
Dashboard with analytics
CRUD operations (Create, Read, Update, Delete)

The Recycle Management System is designed to support sustainable environmental practices by allowing users to manage recyclable materials digitally. Users can submit items, track approval status (pending/approved/rejected), choose drop-off locations, and earn reward points based on their recycling activities.

System Highlights
User Authentication – Secure login and profile management
Recycling Submission Form – Select material type, quantity, location, and data
History Tracking – View, sort, search, and filter past submissions
Wishlist System – Save items users plan to recycle in the future
Admin Controls – Auto-approval system, data monitoring, and database management

With a clean UI and integrated SQLite database, this application makes recycling easier, accessible, and more rewarding while encouraging greener habits.

🛠️ Technologies Used
VB.NET
Windows Forms
SQLite Database
Visual Studio 2022
NuGet Packages
- System.Data.SQLite

📂 Project Setup
1. Open in Visual Studio
Launch Visual Studio
Open the:
M44100433 WONG ZHENG CHYI.sln file
2. Restore NuGet Packages
Visual Studio usually auto-restores packages.
If not:
Tools > NuGet Package Manager > Restore
3. Database Setup
Ensure the SQLite database is located at:
Data Source = C:\Users\USER\Documents\VB NET PROGRAMMING\VB.NET_ASSIGNMENT\VB.assignment.database.sqbpro
4. Run the Application
Press F5 to start debugging.

🚀 Features
👤 USER FEATURES
User Profile Management
Users can update their email, username, and other account information.
Recycle Submission Form
Submit recyclable items by selecting category, location, quantity, weight, and date.
View Reward Points
Users can track the points earned from recycling activities.
Wishlist System
Save items users wish to recycle later.

📊 DATA & HISTORY FEATURES
Detailed Submission History
Displays date, category, quantity, weight, points, and status.
Sorting & Filtering
Sort by date, category, location, status, and weight.
Search Bar
Search by category or location for quick access

🛠️ ADMIN / SYSTEM FEATURES
Admin Dashboard
Shows total items recycled for each material and overall totals.
Auto-Approval System
Random or rule-based automatic approval for submissions.

💾 DATABASE FEATURES
SQLite Integration
All data stored locally in an SQLite database.
Safe Transactions
Prevents data corruption during insert, update, or delete operations.

🎨 UI FEATURES
Modern Styled Interface
Clean layout with organized panels and icons.
Icon-Based Navigation
Vector icons for Home, History, Wishlist, Settings, etc.
Hover Effects
Button colour or shadow changes when hovered.
Side Menu Panel
Collapsible left navigation panel for better UI organization.

🔒 SECURITY FEATURES
Login Authentication
Validates username and password via SQLite.
Password Hashing
Secure password storage using cryptographic hashing.
