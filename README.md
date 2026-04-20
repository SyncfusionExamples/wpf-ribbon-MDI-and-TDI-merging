# Ribbon Merging in WPF Using MDI and TDI Modes

This sample demonstrates how to perform **Ribbon merging** in a WPF application using the **Syncfusion Ribbon control** when working with **MDI (Multiple Document Interface)** and **TDI (Tabbed Document Interface)** document layouts. It shows how child view ribbons can merge with a parent ribbon when documents are activated.

## Overview
In complex applications, it is often necessary for child documents to contribute commands to a shared Ribbon interface. This example illustrates how Syncfusion’s Ribbon supports dynamic merging of ribbon tabs and items from child views into a parent ribbon when those views are hosted inside a DocumentContainer.

The sample covers both **MDI merging**, where documents are displayed as overlapping windows, and **TDI merging**, where documents are displayed as tabs. The ribbon content changes automatically based on the active document.

## What This Sample Demonstrates
- How to merge child view ribbons with a parent ribbon
- How to control ribbon merging behavior using `MergeType` and `MergeOrder`
- How to host child views inside a DocumentContainer
- How ribbon merging works in both MDI and TDI document modes
- How to dynamically add or remove ribbon items based on the active document

## Key Controls Used
- **RibbonWindow**: Hosts the main application window with ribbon support
- **Ribbon**: Displays command tabs and supports dynamic merging
- **RibbonTab / RibbonBar / RibbonButton**: Define ribbon commands
- **DocumentContainer**: Hosts child views and manages MDI or TDI layouts
- **UserControl**: Represents child document views with individual ribbons

## How It Works
1. A parent Ribbon is defined in the main RibbonWindow.
2. Child views contain their own Ribbon definitions.
3. Child views are hosted inside a DocumentContainer.
4. The DocumentContainer is configured for either `MDI` or `TDI` mode.
5. Ribbon tabs from the active child view are merged into the parent ribbon.
6. Merging behavior is controlled using properties such as `MergeType` and `MergeOrder`.

## Benefits
- Creates a clean and dynamic ribbon interface for document‑based applications
- Eliminates the need for duplicate commands across documents
- Automatically updates ribbon content based on the active view
- Works seamlessly for both MDI and TDI user experiences
- Ideal for editor‑style and productivity applications

This approach is useful for WPF applications that require context‑specific ribbon commands while working with multiple documents in MDI or TDI layouts.