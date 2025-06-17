[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

# Portfolio

# ![Logo][logo] Portfolio

A personal portfolio website built from scratch using [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) and .NET 9.

- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Download](#download)
- [Customization](#customization)
- [Releases](#releases)
- [📂 Folder Overview](#-folder-overview)
- [Create this structure and project](#create-this-structure-and-project)
  - [Powershell](#powershell)
  - [Bash](#bash)
- [License](#license)
- [Contact](#contact)
- [Acknowledgments](#acknowledgments)

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (recommended)

### Download

To quickly get started, you can download the latest version of this project directly from GitHub and extract it to your local machine using PowerShell.
Follow these steps:

1. **Download and extract the repository:**

   Open a PowerShell window and run the following commands.
   This will download the repository as a ZIP file, extract its contents, and remove the ZIP file afterward.

```powershell
$repoUrl = "https://github.com/TirsvadWeb/Dotnet.Portfolio"
$zipUrl = "$repoUrl/archive/refs/heads/master.zip"
$zipFile = "Dotnet.Portfolio-master.zip"
$extractPath = "Dotnet.Portfolio"

Invoke-WebRequest -Uri $zipUrl -OutFile $zipFile
Expand-Archive -Path $zipFile -DestinationPath .
Remove-Item $zipFile

Write-Host "Repository downloaded and extracted to .\$extractPath"
```


2. **Apply the database migrations:**

   After extracting the files, navigate to the `src/Portfolio` directory. Then, run the following command to create and update the local SQLite database using Entity Framework Core migrations:

```powershell
dotnet ef database update
```

---

## Customization

You can easily tailor this portfolio to reflect your own projects, skills, and personal information. Here are some suggestions to help you get started:

1. **Update Pages Content**  
   Open the files in the `Pages/` directory. Here you can edit the default text, add new sections, or remove content you don't need. For example, you might want to update your About, Projects, or Contact pages with your own information.

2. **Add Your Projects and Skills**  
   - To showcase your work, add your projects to the relevant section or page. You can create new components or simply edit the existing ones in the `Pages/` or `Components/` folders.
   - List your skills, technologies, or experience in a way that best represents you. This could be a simple list, a set of cards, or any layout you prefer.

3. **Customize the Design**  
   - Modify styles in the `wwwroot/css` folder to change colors, fonts, or layout to match your personal branding.
   - Update images in the `wwwroot/images` or `Portfolio/images/` folders to use your own photos, logos, or icons.

4. **Add or Remove Pages**  
   - If you want to add new pages (for example, a Blog or Portfolio page), create a new `.razor` file in the `Pages/` directory and update your navigation menu accordingly.
   - To remove a page, simply delete the corresponding `.razor` file and remove its link from the navigation.

5. **Advanced Customization**  
   - If you are comfortable with C#, you can add new components, services, or models in the `Components/`, `Shared/`, or `Data/` folders to extend the site's functionality.
   - Update routing in `App.razor` or `Routes.razor` if you add or remove pages.

6. **Social Media Banner**  
   - The portfolio supports a customizable social media banner at the top of the home page.
   - To change the banner, you have two options:

      1. **Replace the static image file:**  
         - Go to `Portfolio/wwwroot/images/` in your project.
         - Replace the file named `socialMediaBanner.png` with your own banner image.
         - Make sure your new image has the same filename (`socialMediaBanner.png`) or update the image path in your code if you use a different name.

      2. **Use a dynamic image from the database:**  
         - Update the `SocialBannerUrl` property in the `DeveloperInfo` table of your database to point to your desired image URL (this can be an external URL or a path to an image in your `wwwroot/images` folder, e.g., `/images/yourBanner.png`).
         - The application will automatically use this URL as the banner if it is set and not empty.
         - You can update this value using a database tool (like SQLite Browser for SQLite) or by adding an admin/edit page in your Blazor app to manage your profile information.

  **Note:**  
  - If both the static file and the `SocialBannerUrl` are set, the application will prioritize the `SocialBannerUrl` from the database if your code is set up to do so.
  - For best results, use a wide image (recommended size: 1200x300px or similar).
  - You can also update the banner dynamically by setting the `SocialBannerUrl` property in the `DeveloperInfo` data model (if supported in your database).
  - The banner is displayed as a background with optional transparency, and your profile image and details are overlaid on top.
  - For best results, use a wide image (recommended size: 1200x300px or similar).

After making your changes, rebuild and run the project to see your personalized portfolio in action.

---

## Releases
Releases step by step for learning / easy following

| Version | Desciption | href |
|---------|------------|------|

---

## 📂 Folder Overview

**Portfolio/src/Portfolio/**  
Main Blazor project (host/server for Blazor WebAssembly and server-side rendering).
- **wwwroot/**: Static web assets (CSS, JS, images, etc.) served directly to the browser.
- **Components/**: Reusable Blazor components, layouts, and UI logic.
  - **Layout/**: Layout components (e.g., `MainLayout.razor`) that define page structure.
  - **Pages/**: Page components (e.g., `Error.razor`) for routed views.
  - `App.razor`: Root component for the Blazor app.
  - `Routes.razor`: Routing configuration for the app.
  - `_Imports.razor`: Common using statements for components.
- **Pages/**: (Optional) Additional Blazor pages.
- **Shared/**: Shared components, models, or services used across the app.
- `Program.cs`: Application entry point and configuration.
- `Portfolio.csproj`: Project file for build and dependencies.

**Portfolio/src/Portfolio.Client/**  
Blazor WebAssembly client project.
- `Program.cs`: Entry point for the WebAssembly client.
- `_Imports.razor`: Common using statements for client components.
- `Portfolio.Client.csproj`: Project file for the client.

**Portfolio/images/**
Images used in this file.

**Portfolio/documentation/dozygen**

**Portfolio/documentation/artifact**

### Create this structure and project

powershell

```powershell
New-Item -ItemType Directory -Path "Portfolio","Portfolio/document/artifact","Portfolio/document/doxygen","Portfolio/images","Portfolio/src" -Force
Set-Location -Path "Portfolio"
dotnet new sln -n Portfolio
dotnet new blazor --interactivity Auto --empty -n Portfolio -o ./src -f net9.0
Remove-Item -Path './src/Portfolio.sln'
dotnet sln Portfolio.sln add ./src/Portfolio/Portfolio.csproj
dotnet sln Portfolio.sln add ./src/Portfolio.Client/Portfolio.Client.csproj
```

Bash

```bash
#!/bin/bash

# Create directories
mkdir -p Portfolio/Portfolio/document/artifact
mkdir -p Portfolio/Portfolio/document/doxygen
mkdir -p Portfolio/images
mkdir -p Portfolio/src

# Change to the Portfolio directory
cd Portfolio

# Create a new solution
dotnet new sln -n Portfolio

# Create a new Blazor project
dotnet new blazor --interactivity Auto --empty -n Portfolio -o ./src -f net9.0

# Remove the Portfolio.sln file
rm -f ./src/Portfolio.sln

# Add projects to the solution
dotnet sln Portfolio.sln add ./src/Portfolio/Portfolio.csproj
dotnet sln Portfolio.sln add ./src/Portfolio.Client/Portfolio.Client.csproj
```

---

## License

Distributed under the GPL-3.0 [License][license-url].

---

## Contact

Jens Tirsvad Nielsen - [LinkedIn][linkedin-url]

---

## Acknowledgments

<!-- MARKDOWN LINKS & IMAGES -->
[contributors-shield]: https://img.shields.io/github/contributors/TirsvadWeb/Dotnet.Portfolio?style=for-the-badge
[contributors-url]: https://github.com/TirsvadWeb/Dotnet.Portfolio/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/TirsvadWeb/Dotnet.Portfolio?style=for-the-badge
[forks-url]: https://github.com/TirsvadWeb/Dotnet.Portfolio/network/members
[stars-shield]: https://img.shields.io/github/stars/TirsvadWeb/Dotnet.Portfolio?style=for-the-badge
[stars-url]: https://github.com/TirsvadWeb/Dotnet.Portfolio/stargazers
[issues-shield]: https://img.shields.io/github/issues/TirsvadWeb/Dotnet.Portfolio?style=for-the-badge
[issues-url]: https://github.com/TirsvadWeb/Dotnet.Portfolio/issues
[license-shield]: https://img.shields.io/github/license/TirsvadWeb/Dotnet.Portfolio?style=for-the-badge
[license-url]: https://github.com/TirsvadWeb/Dotnet.Portfolio/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/jens-tirsvad-nielsen-13b795b9/
[githubIssue-url]: https://github.com/TirsvadWeb/Dotnet.Portfolio/issues/
[repos-size-shield]: https://img.shields.io/github/repo-size/TirsvadWeb/Dotnet.Portfolio?style=for-the-badg

[logo]: https://raw.githubusercontent.com/TirsvadWeb/Dotnet.Portfolio/master/images/logo/32x32/logo.png