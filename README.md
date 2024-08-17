# Blazor Client Documentation

## Overview
This Blazor WebAssembly client is part of a larger application that interacts with an API to manage students and their parents. The client application provides a user interface for performing CRUD operations on student and parent data, including pagination and filtering.

## Installation
After clone repository update the appsettings.json file located in the wwwroot folder with the correct API base URL:
    
    
    {
      "ApiOption": {
        "BaseUrl": "https://api.yourdomain.com/"
      }
    }
    
## Project Structure
The project is organized as follows:
- wwwroot: Contains static assets like CSS files and the appsettings.json.
- Pages: Contains the Blazor components that represent pages in the application.
- Components: Contains reusable Blazor components.
- Services: Contains services that handle API calls.
- Models: Contains model classes that represent data structures

## Components
### Student Components
- StudentsTable.razor: Displays a paginated table of students with options to view, edit, or delete a student.
- StudentDetail.razor: Displays detailed information about a student.
- StudentForm.razor: A form for adding or editing a student.

### Parent Components
- ParentsTable.razor: Displays a paginated table of parents with options to view, edit, or delete a parent.
- ParentDetail.razor: Displays detailed information about a parent.
- ParentForm.razor: A form for adding or editing a parent.

## Services
The Blazor client uses services to interact with the API. These services are located in the Services folder and include:
- StudentService.cs: Handles CRUD operations for students.
- ParentService.cs: Handles CRUD operations for parents.
These services use HttpClient to send requests to the API. The base URL for the API is injected into these services via dependency injection.
  
