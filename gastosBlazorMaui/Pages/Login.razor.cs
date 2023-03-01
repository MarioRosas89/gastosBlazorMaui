using MaquetadoPemex.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace gastosBlazorMaui.Pages
{
    partial class Login

    {
        private User Model { get; set; } = new User();

        private string ErrorMessage { get; set; }

        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        private async void HandleValidSubmit()
        {
            var response = await HttpClient.PostAsJsonAsync("https://localhost:7160/api/auth/signin", Model);

            if (response.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/");
            }
            else
            {
                ErrorMessage = "El nombre de usuario o la contraseña son incorrectos";
            }
        }

	}
}
