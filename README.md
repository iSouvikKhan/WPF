# Optimize.WPF

A small WPF desktop application (.NET Framework 4.8) that demonstrates view-model-first navigation with the MVVM pattern. It has three screens: Home, Login and Account. A shared navigation bar and a navigation store switch between them.

There are no PC optimization features in the code yet, despite the solution name (`PC-Optimization.sln`). The project is a navigation demo; the navigation bar shows the title "Navigation Demo".

## Features

- **Home**: shows a welcome message and a button that opens the Login screen.
- **Login**: has Username and Password text boxes. Pressing Login creates an in-memory `Account` with the entered username and the email `<username>@test.com`, saves it in `AccountStore`, and opens the Account screen. No real authentication happens, and the password is not checked or stored.
- **Account**: shows the current account's username and email, plus a button that goes back to Home.
- **Navigation bar**: a reusable `NavigationBar` user control on the Home and Account screens with Home, Login and Account links.

## Tech stack

- C# / WPF
- .NET Framework 4.8 (classic `.csproj`)
- No external NuGet packages

## How navigation works

- `NavigationStore` holds the current view model and raises `CurrentViewModelChanged` when it changes.
- `MainViewModel` exposes `CurrentViewModel`. `MainWindow` renders it in a `ContentControl`, using `DataTemplate`s to map each view model to its view.
- `NavigationService<TViewModel>` builds a view model from a factory and sets it as current.
- `NavigateCommand<TViewModel>` and `LoginCommand` (both based on `CommandBase : ICommand`) start navigation from the UI.
- `App.xaml.cs` sets up the stores and navigation services, then opens the Home screen at startup.

`Services/ParameterNavigationService.cs`, a variant that passes a parameter to the view-model factory, is included but not used yet.

## Project structure

```
PC-Optimization.sln
Optimize.WPF/
  App.xaml(.cs)          Application startup and composition of services/stores
  MainWindow.xaml(.cs)   Host window that displays the current view model
  Commands/              CommandBase, NavigateCommand, LoginCommand
  Components/            NavigationBar user control
  Models/                Account
  Services/              NavigationService, ParameterNavigationService
  Stores/                AccountStore, NavigationStore
  ViewModels/            Main, Home, Login, Account, NavigationBar view models
  Views/                 HomeView, LoginView, AccountView
```

## Prerequisites

- Windows (WPF runs only on Windows)
- .NET Framework 4.8 Developer Pack
- Visual Studio 2019 or later with the ".NET desktop development" workload, or MSBuild for .NET Framework

## Build and run

Visual Studio:

1. Open `PC-Optimization.sln`.
2. Set `Optimize.WPF` as the startup project if it is not already.
3. Press F5 to build and run.

Command line (Developer Command Prompt for Visual Studio):

```cmd
msbuild PC-Optimization.sln /p:Configuration=Debug
Optimize.WPF\bin\Debug\Optimize.WPF.exe
```

## Notes

- The button on the Home screen is labeled "Home", but it opens the Login screen.
- The password field is a plain `TextBox`, not a `PasswordBox`.
- Account data is kept only in memory and is lost when the app closes.
