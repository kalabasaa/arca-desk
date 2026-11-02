<div align="center">

# Arca Desk

A desktop-based inventory and sales management system designed to help sari-sari stores organize products, monitor stock levels, and manage daily business transactions.

![C#](https://img.shields.io/badge/C%23-Desktop%20Application-239120?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-Windows%20Forms-512BD4?logo=dotnet&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-Windows-0078D6?logo=windows&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2022-5C2D91?logo=visualstudio&logoColor=white)

</div>

---

## About

Arca Desk is a Windows desktop application prototype designed to simplify inventory and sales management for sari-sari stores. It aims to provide an organized and accessible platform for handling everyday store operations, from managing product information and monitoring inventory to recording sales and tracking business activities.

Arca Desk is the desktop adaptation of **Arca Online**, an earlier web-based inventory and sales management system. This version explores a native Windows application approach using C# and Windows Forms.

The project focuses on providing a straightforward desktop experience with organized navigation, dedicated application pages, and a centralized interface for managing store operations.

## Features

- **Dashboard** – Provides an overview of store activities and important business information.
- **Product Management** – Organizes product records, including names, categories, quantities, and pricing.
- **Inventory Management** – Monitors available stock and product quantities.
- **Sales Management** – Records and organizes store sales and transactions.
- **Receipts Management** – Maintains records of purchase receipts.
- **Supply Management** – Organizes incoming supplies and stock information.
- **Counter Management** – Provides a dedicated interface for counter-related operations.

*Features are currently under development and may change throughout the project.*

## Technology Stack

<p align="left">
  <img src="https://img.shields.io/badge/C%23-Programming%20Language-239120?logo=csharp&logoColor=white" alt="C#"/>
  <img src="https://img.shields.io/badge/.NET-Framework-512BD4?logo=dotnet&logoColor=white" alt=".NET"/>
  <img src="https://img.shields.io/badge/Windows%20Forms-Desktop%20UI-0078D6?logo=windows&logoColor=white" alt="Windows Forms"/>
  <img src="https://img.shields.io/badge/Visual%20Studio-IDE-5C2D91?logo=visualstudio&logoColor=white" alt="Visual Studio"/>
  <img src="https://img.shields.io/badge/Git-Version%20Control-F05032?logo=git&logoColor=white" alt="Git"/>
  <img src="https://img.shields.io/badge/GitHub-Repository-181717?logo=github&logoColor=white" alt="GitHub"/>
</p>

## Application Structure

The application follows a modular structure, separating the main window, individual pages, reusable components, and visual assets.

```text
arca_desk/
│
├── Assets/
│   └── logo.png
│
├── Components/
│   └── Navigation.cs
│
├── Forms/
│   └── MainForm.cs
│
├── Pages/
│   ├── Counter.cs
│   ├── Dashboard.cs
│   ├── Inventory.cs
│   ├── Receipts.cs
│   ├── Sales.cs
│   └── Supply.cs
│
└── Program.cs
```

## Project Status

- `MainForm` set up with `headerPanel`, `navPanel`, `contentPanel`.
- All six page UserControls scaffolded under `Pages/`: `Dashboard`, `Inventory`, `Counter`, `Supply`, `Sales`, `Receipts`.
- `Navigation` reusable component built under `Components/`, containing the menu buttons (Dashboard, Inventory, Counter, Supply, Sales, Receipts).
- `Navigation` raises a custom event (`NavigationItemClicked`) instead of `MainForm` handling each button directly — this keeps the nav bar self-contained and reusable.
- `MainForm` listens to that event and swaps the active page into `contentPanel` via a `LoadPage()` method.
- Basic page-switching flow works end-to-end (clicking a nav item loads the matching blank page).

**Not yet done:** none of the pages have real functionality yet — they're empty UserControls waiting for UI and logic. The "active button highlight" feature (`SetActiveButton`) was removed during the nav refactor and needs to be rebuilt to work inside the new `Navigation` component.

## Architecture & Flow

**Core idea:** `MainForm` never contains page-specific logic. It only hosts a navigation bar and a content area, and swaps whichever `UserControl` is active.

```
MainForm
 ├─ headerPanel        (logo, title, status — static)
 ├─ navPanel
 │   └─ Navigation (navigation1)   ← reusable component, owns its own buttons
 └─ contentPanel
     └─ [active page UserControl]  ← swapped at runtime
```

**How navigation works:**
1. `Navigation` owns the 6 buttons internally and wires each `Click` to raise one shared event:
   ```csharp
   public event EventHandler<string>? NavigationItemClicked;
   ```
2. `MainForm` subscribes to that event once, in its constructor:
   ```csharp
   navigation1.NavigationItemClicked += Navigation1_NavigationItemClicked;
   ```
3. When a button is clicked, `Navigation` fires the event with the page name (e.g. `"Dashboard"`).
4. `MainForm`'s handler matches the name to a page instance and loads it:
   ```csharp
   private void Navigation1_NavigationItemClicked(object? sender, string pageName)
   {
       UserControl page = pageName switch
       {
           "Dashboard" => new Dashboard(),
           "Inventory" => new Inventory(),
           "Counter"   => new Counter(),
           "Supply"    => new Supply(),
           "Sales"     => new Sales(),
           "Receipts"  => new Receipts(),
           _ => new Dashboard()
       };
       LoadPage(page);
   }
   ```
5. `LoadPage()` clears `contentPanel` and docks the new page into it:
   ```csharp
   private void LoadPage(UserControl page)
   {
       contentPanel.Controls.Clear();
       page.Dock = DockStyle.Fill;
       contentPanel.Controls.Add(page);
   }
   ```

**Why this matters for the team:** any page's internal logic (buttons, grids, calculations) stays fully inside that page's own `.cs`/`.Designer.cs` files. Nobody needs to touch `MainForm` or `Navigation` to build out a page — only `LoadPage()` ever creates/swaps them.

### Adding a new page (pattern to follow)
1. Right-click `Pages` → **Add → New Item → User Control**, name it (e.g. `Expenses.cs`).
2. Build its UI inside that file's Designer, same as any WinForms UserControl.
3. If it needs to appear in the nav bar, add a button in `Navigation.cs`/Designer, and raise `NavigationItemClicked` with its name from the constructor.
4. Add a matching case in `MainForm`'s `switch` statement.

## Page Responsibilities (To Be Built)

### Dashboard
Overview screen. Should show at-a-glance previews of:
- Recent/summary sales figures
- Stock levels: items low in stock and items out of stock
- Likely pulls summary data from the same data source Inventory/Sales use — avoid duplicating business logic; read from one shared data layer.

### Inventory
Full product list management:
- View all inventory items
- Search/filter items
- Delete items
- (Add/Edit likely needed too, even though not explicitly listed — confirm with team)

### Counter
Point-of-sale / checkout screen:
- Generates a receipt for a transaction
- Tracks quantity in real time: "staging" quantity (being added to the current transaction) vs. "current" quantity (what's left in stock)
- Calculates per-item price and running total price to pay
- On completion, should deduct stock (connects to Inventory's data) and create a record Receipts can display

### Supply
Restocking screen:
- Edit existing item details
- Restock (increase quantity) for existing items
- Distinct from Inventory in that this is focused on incoming stock, not browsing/searching

### Sales
Reporting screen:
- Graphical view of sales over time
- Compares sales against expenses/cost (to show profit/margin)
- Needs a charting approach — decide whether to use a WinForms charting control or a custom-drawn graph

### Receipts
History screen:
- Displays past transactions/receipts generated by Counter
- Likely needs search/filter by date similar to Inventory

## Suggested Next Steps

1. Decide on a shared data layer (e.g. a simple in-memory model first, or SQLite/SQL Server later) so Inventory, Counter, Supply, Sales, and Receipts aren't duplicating data access logic.
2. Rebuild the "active nav button highlight" feature inside `Navigation.cs` itself (it previously lived in `MainForm.SetActiveButton`, which no longer has access to the buttons).
3. Build out Inventory first (search/view/delete), since Counter, Supply, and Dashboard all depend on reading/writing the same product data.
4. Build Counter next (depends on Inventory's data model for stock deduction and pricing).
5. Build Receipts (depends on Counter producing transaction records).
6. Build Supply (depends on Inventory's data model for restocking).
7. Build Sales and Dashboard last, since both aggregate/report on data the other pages produce.

## Getting Started

### Requirements

- Windows operating system.
- Microsoft Visual Studio.
- .NET SDK compatible with the project.
- Windows Forms development workload.

## Screenshots

Arca Desk is currently under development. The screenshot below shows the application's current progress.

<img width="1917" height="1078" alt="image" src="https://github.com/user-attachments/assets/25290d72-e920-4705-9ff5-7b99a8b82ed6" />

## Related Project

**Arca Online** – The original web-based inventory and sales management system that served as the foundation for Arca Desk.

## Contribution Conduct

All contributors must follow the guidelines in **[CODE_OF_CONDUCT.md](./CODE_OF_CONDUCT.md)**.

## Developer

### Renier Tambogon

**Lead Developer**

Responsible for the development, interface design, and implementation of Arca Desk.

**GitHub:** [kalabasaa](https://github.com/kalabasaa)

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

Copyright (c) 2026 Renier Tambogon
