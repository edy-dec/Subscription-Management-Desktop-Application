# MEDICHUB - Medical Journal Subscription Management System

A comprehensive Windows Forms desktop application designed for managing medical journal subscriptions with advanced data visualization, analytics, and robust data management capabilities.

## Overview

MEDICHUB is a professional-grade subscription management system built for healthcare organizations to efficiently track, manage, and analyze medical journal subscriptions. The application provides an intuitive interface with powerful features for subscription lifecycle management, data analytics, and reporting.

## Key Features

### Data Management
- **Full CRUD Operations**: Create, Read, Update, and Delete subscription records
- **CSV Import/Export**: Robust data import/export with support for multiple date formats
- **Data Validation**: Comprehensive input validation with error handling
- **Undo/Redo System**: Stack-based undo functionality for data recovery
- **Data Persistence**: Reliable CSV-based storage with error handling

### User Interface
- **Modern Design**: Custom-styled Windows Forms with MEDICHUB branding
- **Responsive Layout**: Professional interface with rounded buttons and hover effects
- **Multi-form Navigation**: Intuitive dashboard with seamless form transitions
- **Custom Styling**: Consistent color scheme and typography throughout the application

### Analytics & Visualization
- **Real-time Charts**: Dynamic data visualization using Microsoft Chart Controls
- **Subscription Status Distribution**: Pie charts showing active/inactive/pending subscriptions
- **Magazine Analysis**: Column charts displaying subscription distribution by magazine
- **Interactive Filtering**: Real-time chart updates based on applied filters

### Advanced Filtering & Search
- **Multi-criteria Filtering**: Search by text, status, and multiple attributes
- **Advanced Sorting**: Sort by date, status, newest/oldest entries
- **Quick Filters**: One-click filtering by subscription status
- **Text Search**: Fast search across all subscription fields

## Technologies

### Core Technologies
- **C#** - Primary programming language
- **.NET Framework 4.7.2** - Application framework
- **Windows Forms** - Desktop UI framework
- **System.Windows.Forms.DataVisualization** - Chart controls

### Data Management
- **CSV Parsing** - Custom CSV import/export engine
- **Serialization** - Data model serialization for persistence
- **Collections** - Generic collections for data handling

### Design Patterns
- **Service Layer Pattern** - `AbonamentService` for business logic
- **Model-View Pattern** - Separation of data and presentation
- **Stack Pattern** - Undo/redo implementation

## Installation

### Prerequisites
- Windows 7 or later
- .NET Framework 4.7.2 or higher
- Visual Studio 2019 or later (for development)

### Setup Instructions

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/medichub.git
   cd medichub
   ```

2. **Open in Visual Studio**
   - Open `proiect_practica.sln`
   - Restore NuGet packages if prompted

3. **Build the project**
   - Build > Build Solution (Ctrl+Shift+B)
   - Ensure no compilation errors

4. **Run the application**
   - Press F5 or click Start
   - The MEDICHUB dashboard will launch

## Usage

### Getting Started

1. **Launch Application**
   - Run `proiect_practica.exe`
   - The main dashboard displays with overview analytics

2. **Add New Subscription**
   - Click "Adauga Abonament" button
   - Fill in subscription details:
     - Subscription type (Abonament/Donatie)
     - Package type (Revista/Revista + Aplicatie)
     - Magazine name
     - Status (Activ/Inactiv/In asteptare)
     - Start and end dates
     - Order number and user information
   - Click Save

3. **View and Manage Subscriptions**
   - Browse subscriptions in the DataGridView
   - Use search box to find specific subscriptions
   - Apply status filters for quick filtering
   - Sort by various criteria using advanced sorting

4. **Edit Subscription**
   - Select a subscription from the grid
   - Click "Modifica" button
   - Update details and save changes

5. **Delete Subscription**
   - Select subscription to delete
   - Click "Sterge" button
   - Confirm deletion

6. **Undo Changes**
   - Click "Undo" button to revert last action
   - Multiple undo operations supported

7. **Export Data**
   - Click "Export CSV" to save current data
   - Data saved to `abonamente.csv`

### Advanced Features

#### Filtering and Search
```
- Text Search: Enter search term in search box
- Status Filter: Select from "Activ", "Inactiv", "In asteptare"
- Advanced Sorting: 
  * Sort by date (Sorteaza dupa data)
  * Sort by status (Sorteaza dupa status)
  * Show newest (Cele mai noi)
  * Show oldest (Cele mai vechi)
```

#### Analytics Dashboard
- **Pie Chart**: Visual distribution of subscription statuses
- **Column Chart**: Magazine subscription comparison
- **Real-time Updates**: Charts update automatically with data changes

#### Data Import
- Place CSV file in application directory
- Format: `tip,pachet,revista,status,data_inceput,data_sfarsit,nr_comanda,utilizator`
- Supported date formats: `dd/MM/yyyy`, `yyyy-MM-dd`, `MM/dd/yyyy`

## Project Structure

```
proiect_practica/
│
├── Forms/
│   ├── Form1.cs              # Main dashboard
│   ├── Form1.Designer.cs     # UI designer code
│   └── Form1.resx            # Form resources
│
├── Models/
│   └── Abonament.cs          # Subscription data model
│
├── Services/
│   └── AbonamentService.cs   # Business logic and CSV operations
│
├── Resources/
│   └── logo.png              # MEDICHUB branding assets
│
├── Data/
│   └── abonamente.csv        # Subscription data storage
│
├── App.config                # Application configuration
├── Program.cs                # Application entry point
└── proiect_practica.csproj   # Project file
```

## Data Model

### Abonament Class
```csharp
public class Abonament
{
    public string Tip { get; set; }              // Abonament/Donatie
    public string Pachet { get; set; }           // Revista/Revista + Aplicatie
    public string Revista { get; set; }          // Magazine name
    public string Status { get; set; }           // Activ/Inactiv/In asteptare
    public DateTime DataInceput { get; set; }    // Start date
    public DateTime DataSfarsit { get; set; }    // End date
    public string NrComanda { get; set; }        // Order number
    public string Utilizator { get; set; }       // User name
}
```

## Features in Detail

### Subscription Management
- **Create**: Add new subscriptions with comprehensive validation
- **Read**: View all subscriptions in sortable, filterable grid
- **Update**: Edit existing subscriptions with change tracking
- **Delete**: Remove subscriptions with confirmation
- **Undo**: Revert changes using stack-based undo system

### Data Validation
- Required field validation
- Date range validation (end date > start date)
- Format validation for dates and order numbers
- Duplicate prevention

### Analytics Engine
- Real-time calculation of subscription metrics
- Status distribution analysis
- Magazine popularity tracking
- Visual representation with interactive charts

### User Experience
- Intuitive navigation with clear visual hierarchy
- Hover effects on interactive elements
- Loading indicators for long operations
- Error messages with actionable feedback
- Confirmation dialogs for destructive actions

## Configuration

### CSV File Format
```csv
Abonament,Revista,Nature Medicine,Activ,01/01/2024,31/12/2024,CMD001,Dr. Popescu
Donatie,Revista + Aplicatie,The Lancet,Activ,15/03/2024,15/03/2025,CMD002,Dr. Ionescu
```

### Customization
- Modify colors in `Form1.Designer.cs`
- Adjust chart styles in chart configuration
- Update validation rules in `AbonamentService.cs`
- Customize CSV delimiter and format in service layer

## Troubleshooting

### Common Issues

**CSV Import Fails**
- Verify CSV format matches expected structure
- Check date format consistency
- Ensure proper encoding (UTF-8)

**Charts Not Displaying**
- Verify data exists in CSV file
- Check chart controls are properly initialized
- Ensure .NET Framework version is correct

**Application Crashes on Startup**
- Verify .NET Framework 4.7.2 is installed
- Check CSV file is not corrupted
- Review Windows Event Viewer for details

## Performance Considerations

- CSV file size: Optimized for up to 10,000 records
- Chart rendering: Real-time updates with minimal lag
- Memory usage: Efficient data structure management
- Search performance: O(n) linear search with caching

## Future Enhancements

- [ ] Database integration (SQL Server/SQLite)
- [ ] Multi-user support with authentication
- [ ] Email notifications for expiring subscriptions
- [ ] Advanced reporting with export to PDF/Excel
- [ ] Cloud synchronization
- [ ] Mobile companion app
- [ ] Automated renewal reminders
- [ ] Payment integration
- [ ] Multi-language support

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### Coding Standards
- Follow C# naming conventions
- Add XML documentation comments
- Include unit tests for new features
- Maintain consistent code formatting

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Microsoft Chart Controls for data visualization
- .NET Framework team for robust desktop framework
- Healthcare professionals for requirements gathering

