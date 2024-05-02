using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class AccountController : Controller
{
    private readonly HttpClient _httpClient;

    public AccountController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
        _httpClient.BaseAddress = new System.Uri("https://your-auth-service-url.com/");
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var content = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/auth/login", content);

            if (response.IsSuccessStatusCode)
            {
                // Authentication successful, redirect to dashboard or home page
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Authentication failed, display error message to the user
                ModelState.AddModelError(string.Empty, "Invalid username or password.");
            }
        }
        // If model state is not valid, return the login view with validation errors
        return View(model);
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var content = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/auth/register", content);

            if (response.IsSuccessStatusCode)
            {
                // Registration successful, redirect to login page or display success message
                return RedirectToAction("Login");
            }
            else
            {
                // Registration failed, display error message to the user
                ModelState.AddModelError(string.Empty, "Failed to register user.");
            }
        }
        // If model state is not valid, return the registration view with validation errors
        return View(model);
    }
}