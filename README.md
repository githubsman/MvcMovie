## ASP.NET Tutorial from Microsoft
Use __MVC 5__ and __.NET 8__ to put together a Model-View-Controller framework in __C#__.

### Part 1: [First app](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-8.0&source=recommendations&tabs=visual-studio)</u>
1. Prereqs
   - Localhost (IIS)
   - Visual Studio 2022
   - NET 8.0
1. Create a working basic app
1. Enjoy an out-of-box experience

### Part 2: [Controllers](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-8.0)</u>
- HTTP `GET`
- Routing pattern `/[Controller]/[ActionName]`
- Model binding and `MapControllerRoute`
- Input sanitization using `HtmlEncoder.Default.Encode`

### Part 3: [Views](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view?source=recommendations)</u>
1. Add a view (Razor)
   - HTTP `POST`
   - Action methods
   - `IActionResult` Interface
   - `return View();`
1. Change views and layout pages
   - `Views/Shared/_Layout.cshtml`
   - `@RenderBody()`
   - `Layout = ...`
1. Change the title, footer, and menu link in the layout file
1. Passing Data from the Controller to the View

### Part 4: [Models](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?source=recommendations)</u>
The second half of this page does a good job tying together pattern concepts.  
1. Add a data model class
   - Entity-Framework Core
   - Data structure via POCO _(Plain Old CLR Objects)_ classes
1. Scaffold movie pages
   - _Scaffolding_ an EF to enable CRUD
   - The data context
   - Supporting pages with action methods
   - Database connectivity
1. Initial migration
   - NuGet Package Manager Console
   - `Add-Migration InitialCreate`
   - `Update-Database`  
1. Test the app
   - Routing pattern `/[Controller]/[ActionName]/[Parameters]`
1. Dependency injection in the controller
   - "Kids have it so easy these days." 
   - `#MARK` Dependency injection ... is used in this constructor
   - Management of connection string
     - `#MARK` See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
1. Strongly typed models and the `@model` directive
   - `#MARK` MVC 5 feature: `ViewData` dictionary is a dynamic object...

### Part 5: [SQL](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql?source=recommendations)</u>
1. _SQL Server Express LocalDB_
   - Using the _SQL Server Obj eXplorer pane_
   - View/Edit tables using View Designer from SSOX
   - View/Edit Data using View Data from SSOX 
1. Seeding the database
   
### Part 6: [Controllers, cont'd](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/controller-methods-views?view=aspnetcore-8.0)</u>  
This page pulls together many pattern concepts.  
- `GET` and `POST` methods compared 
- Generated HTML 
- Tag helpers (meaning, HTML tag)
- [Bind] ... effective against over-posting
- Preventing request forgeries: `ValidateAntiForgeryToken`
- Scaffolding and views
1. Processing the `POST` Request
- Client-side data validation

### Part 7: [Search functionality](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/search?view=aspnetcore-8.0)</u>
1. Add Search by genre
- `LINQ` query
- `.Contains(searchString)`
- Minimal user input form (`GET`)
1. Add search by genre to the Index view
- _Evaluation_ VS _Inspection_

### Part 8: [Add a field](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/new-field?view=aspnetcore-8.0&tabs=visual-studio)</u>
1. Add a Rating Property to the Movie Model
- Three approaches to data schema changes:
    - Drop the database and recreate it with seed data
    - Explicitly modify the schema
	    - manually (so they call it) 
		- using a database change script
    - Use _Code First Migrations_

### Part 9: [Validation](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/validation?view=aspnetcore-8.0)</u>
- Keeping things DRY
    - rules established at the model layer
    - data-entry validation provided for both record creation and editing
- Delete the previously edited data
    - the app pulls from the seed data on next launch
1. Add validation rules to the movie model
- using `DataAnnotations` namespace
    - `DataType`
	- `DisplayFormat`
	- `Required`
1. How validation works (jQuery)
- `ModelState.IsValid`
- Server- and client-side (redundant)  operations
    - testing on server-side only
1. More about DataType Attributes
- `Range`
- Regular expressions for validation

### Part 10: [Examine `Details` and `Delete` methods](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/details?view=aspnetcore-8.0)</u>
---
## Directory structure

```
Folder PATH listing
Volume serial number is AA35-206F
C:.
|   .gitattributes
|   .gitignore
|   MvcMovie.sln
|   MvcMovies_tree_build.txt
|   README.md
|   
+---.github
|   \---workflows
\---MvcMovie
    |   appsettings.Development.json
    |   appsettings.json
    |   MvcMovie.csproj
    |   MvcMovie.csproj.user
    |   Program.cs
    |   
    +---bin
    |   \---Debug
    |       \---net8.0
    |           |   appsettings.Development.json
    |           |   appsettings.json
    |           |   
    |           |   drivers ... 220+ .dll files
    |                   
    +---Controllers
    |       HelloWorldController.cs
    |       HomeController.cs
    |       MoviesController.cs
    |       
    +---Data
    |       MvcMovieContext.cs
    |       
    +---Migrations
    |       20240701174435_InitialCreate.cs
    |       20240701174435_InitialCreate.Designer.cs
    |       MvcMovieContextModelSnapshot.cs
    |       
    +---Models
    |       Class.cs
    |       ErrorViewModel.cs
    |       Movie.cs
    |       
    +---obj
    |   |   MvcMovie.csproj.nuget.dgspec.json
    |   |   MvcMovie.csproj.nuget.g.props
    |   |   MvcMovie.csproj.nuget.g.targets
    |   |   project.assets.json
    |   |   project.nuget.cache
    |   |   
    |   \---Debug
    |       \---net8.0
    |           |   .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
    |           |   apphost.exe
    |           |   MvcMovie.AssemblyInfo.cs
    |           |   MvcMovie.AssemblyInfoInputs.cache
    |           |   MvcMovie.assets.cache
    |           |   MvcMovie.csproj.AssemblyReference.cache
    |           |   MvcMovie.csproj.BuildWithSkipAnalyzers
    |           |   MvcMovie.csproj.CoreCompileInputs.cache
    |           |   MvcMovie.csproj.FileListAbsolute.txt
    |           |   MvcMovie.csproj.Up2Date
    |           |   MvcMovie.dll
    |           |   MvcMovie.GeneratedMSBuildEditorConfig.editorconfig
    |           |   MvcMovie.genruntimeconfig.cache
    |           |   MvcMovie.GlobalUsings.g.cs
    |           |   MvcMovie.MvcApplicationPartsAssemblyInfo.cache
    |           |   MvcMovie.pdb
    |           |   MvcMovie.RazorAssemblyInfo.cache
    |           |   MvcMovie.RazorAssemblyInfo.cs
    |           |   MvcMovie.sourcelink.json
    |           |   project.razor.vs.bin
    |           |   staticwebassets.build.json
    |           |   staticwebassets.development.json
    |           |   staticwebassets.pack.json
    |           |   
    |           +---ref
    |           |       MvcMovie.dll
    |           |       
    |           +---refint
    |           |       MvcMovie.dll
    |           |       
    |           +---scopedcss
    |           |   +---bundle
    |           |   |       MvcMovie.styles.css
    |           |   |       
    |           |   +---projectbundle
    |           |   |       MvcMovie.bundle.scp.css
    |           |   |       
    |           |   \---Views
    |           |       \---Shared
    |           |               _Layout.cshtml.rz.scp.css
    |           |               
    |           \---staticwebassets
    |                   msbuild.build.MvcMovie.props
    |                   msbuild.buildMultiTargeting.MvcMovie.props
    |                   msbuild.buildTransitive.MvcMovie.props
    |                   msbuild.MvcMovie.Microsoft.AspNetCore.StaticWebAssets.props
    |                   
    +---Properties
    |       launchSettings.json
    |       serviceDependencies.json
    |       serviceDependencies.local.json
    |       serviceDependencies.local.json.user
    |       
    +---Views
    |   |   _ViewImports.cshtml
    |   |   _ViewStart.cshtml
    |   |   
    |   +---HelloWorld
    |   |       Index.cshtml
    |   |       Welcome.cshtml
    |   |       
    |   +---Home
    |   |       Index.cshtml
    |   |       Privacy.cshtml
    |   |       
    |   +---Movies
    |   |       Create.cshtml
    |   |       Delete.cshtml
    |   |       Details.cshtml
    |   |       Edit.cshtml
    |   |       Index.cshtml
    |   |       
    |   \---Shared
    |           Error.cshtml
    |           _Layout.cshtml
    |           _Layout.cshtml.css
    |           _ValidationScriptsPartial.cshtml
    |           
    \---wwwroot
        |   favicon.ico
        |   
        +---css
        |       site.css
        |       
        +---js
        |       site.js
        |       
        \---lib
            +---bootstrap
            |   |   LICENSE
            |   |   
            |   \---dist
            |       +---css
            |       |
            |       |                            | x | .rtl.min.css
            |       |       bootstrap            | x | .rtl.css.map
            |       |       bootstrap-grid       | x | .rtl.css
            |       |       bootstrap-reboot     | x | .min.css.map
            |       |       bootstrap-utilities  | x | .min.css
            |       |                            | x | .css.map
            |       |                            | x | .css   
            |       |       
            |       |       
            |       \---js
            |               bootstrap            | x | 
            |               bootstrap.min        | x | 
            |               bootstrap.esm        | x | 
            |               bootstrap.esm.min    | x | 
            |               bootstrap.bundle     | x | 
            |               bootstrap.bundle.min | x | .js
            |               bootstrap            | x | .js.map
            |               bootstrap.min        | x | 
            |               bootstrap.esm        | x | 
            |               bootstrap.esm.min    | x | 
            |               bootstrap.bundle     | x | 
            |               bootstrap.bundle.min | x | 
            |               
            +---jquery
            |   |   LICENSE.txt
            |   |   
            |   \---dist
            |           jquery.js
            |           jquery.min.js
            |           jquery.min.map
            |           
            +---jquery-validation
            |   |   LICENSE.md
            |   |   
            |   \---dist
            |           additional-methods.js
            |           additional-methods.min.js
            |           jquery.validate.js
            |           jquery.validate.min.js
            |           
            \---jquery-validation-unobtrusive
                    jquery.validate.unobtrusive.js
                    jquery.validate.unobtrusive.min.js
                    LICENSE.txt                    
```
					