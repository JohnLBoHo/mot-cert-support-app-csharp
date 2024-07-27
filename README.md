# TimeSheet Manager
This project is a simple time sheet manager application. It allows users to log in to the application and add time sheet entries. Users can log in as either standard or admin users with admin users being able to create new timesheets, users and view reports.

## Getting Started
Download and install GitHub for Windows Desktop, create an account and login.
Fork and clone the mot-cert-support-app-csharp and modify the README file.

### Prerequisites
To build and run this project you will require the following:
- DotNet Core 8

### Running project
Assuming DotNet Core is installed correctly on your machine. The following is required to start the application up:

```Bash
cd Timesheet
dotnet run
```

Once complete, the application will be available via http://localhost:8080

## Running Automated Checks
The project contains UNIT, API and E2E checks. The automated checks can be run in two ways.

### Running UNIT Checks
To run these checks run the following command in the root of the project:

```Bash
cd TimeSheet
dotnet test --filter FullyQualifiedName~Timesheet.Test/Timesheet.Test.UNIT
```

### Running API and E2E Checks
API and E2E checks can be run after the application is started and available. To run these checks run the following commands in the root of the project:

```Bash
dotnet test --filter FullyQualifiedName~Timesheet.Test/Timesheet.Test.API
```
```Bash
dotnet test --filter FullyQualifiedName~Timesheet.Test/Timesheet.Test.E2E
```

### CI/CD Integration
The project is integrated with GitHub Actions, the build and test process being triggered everytime a change is pushed to the trunk branch.

The config file for Actions can be found at the following location:

```Bash
.github/workflows/build_test.yml
```







