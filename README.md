# The control similar to the Outlook Calendar control
This is a .NET WinForms control which allows to fetch data from database and manipulate it like in Outlook Calendar Planner, but with some differences.

![Image alt](https://github.com/practicalDeveloper/Calendar-Planner/blob/main/Images/Header1.png)

![Image alt](https://github.com/practicalDeveloper/Calendar-Planner/blob/main/Images/Header2.png)

## Introduction
During my job, I was in need of a .NET WinForms control which would allow to fetch data from the database and manipulate it like in Outlook Calendar Planner (add, delete, drag items), but with a few differences. Instead of showing the time information in the left side of the control, it was necessary to retrieve and show columnar data from the database. For commercial components, I didn't want to pay. So I created my own Calendar Planner.

## Control Features
The control consists of rows with items and columns on the left side, as you can see from the screenshot below:

![Image alt](https://github.com/practicalDeveloper/Calendar-Planner/blob/main/Images/Details1.png)

Each item in the row can be updated individually. You can change the background color, specify text, drag it, change date, etc. In the left side of the calendar, you can add columns with some text, it may be used in order to retrieve data from different data sources (for example, from DB or XML file). The component can show date intervals in two modes: daily and weekly. In daily mode, each date shows day name, as in the screenshot above. In weekly mode, the date shows the week number, as in the screenshot below. Control supports rows nesting. For this, you can set a row as collapsible.

![Image alt](https://github.com/practicalDeveloper/Calendar-Planner/blob/main/Images/Details2.png)

## Background

In order to manage the behaviour of the control, you can use different properties. Some of them are:

- `CurrentDate`: gets/sets calendar date
- `DatesIntervalMode`: possible modes to show date intervals in the header
- `DayCount`: day count to show by the calendar
- `GridCellHeight`: height of each row
- `HeaderStyleMode`: possible modes to fill background header
- `IsAllowedDraggingBetweenRows`: allows/disallows item drag/drop between rows
- `ItemHeight`: height of each item
- `LeftMargin`: margin of left column
- `SelectedRowIndex`: gets the index of the selected row
- `SelectedItem`: gets the selected item
- `Rows`: list of rows of the calendar
- `Items`: list of items of the row
- `Columns`: columns in the left side of the control
- `IsAllowedTreeViewDrawing`: enables/disables lines drawing like in treeview

Events:

- `ItemClick`: occurs when an item is clicked
- `ItemDoubleClick`: occurs when an item is double-clicked
- `RowClick`: occurs when a row is clicked
- `ItemDatesChanged`: occurs when an item date range has changed
- `ItemTextEdited`: occurs when an item text is edited

The source code for the article https://www.codeproject.com/Articles/252247/Calendar-Planner
