## MvcMovie
 Tutorial for __MVC 5__ using __.NET 8__.

### Part 1:
[First app](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-8.0&source=recommendations&tabs=visual-studio)
1. Prereqs
   - Localhost (IIS)
   - Visual Studio 2022
   - NET 8.0
1. Create a working basic app
1. Enjoy an out-of-box experience

### Part 2:
[Controllers](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-8.0)
The controller handles and responds to user input and interaction. For example, the controller handles URL segments and query-string values, and passes these values to the model.
	- HTTP `GET`
	- Routing pattern `/[Controller]/[ActionName]`
	- Model binding and `MapControllerRoute`
	- Input sanitization using `HtmlEncoder.Default.Encode`
### Part 3:
[Views](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view?source=recommendations)
1. Add a view (Razor)
   - Action methods
     - `IActionResult` Interface
   - `return View();`
1. Change views and layout pages
   - `Views/Shared/_Layout.cshtml`
   - `@RenderBody()`
   - `Layout = ...`
   - `ViewData` dictionary
1. Change the title, footer, and menu link in the layout file
1. Passing Data from the Controller to the View

### Part 4:
[Models](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?source=recommendations)
   - Routing pattern `/[Controller]/[ActionName]/[Parameters]`
   
### Part 5:
[Data](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql?source=recommendations)

