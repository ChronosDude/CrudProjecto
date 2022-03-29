using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http;
using System.Security.Claims;

namespace CRUDProject5.Data
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        public ILocalStorageService _localStorageService { get; }
        private readonly HttpClient _httpClient;

        public CustomAuthenticationStateProvider(ILocalStorageService localStorageService,
            HttpClient httpClient)
        {
            _localStorageService = localStorageService;
            _httpClient = httpClient;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {


            return null;
        }
        public async Task MarkUserAsAuthenticated(UserLogin user)
        {
            await _localStorageService.SetItemAsync("accessToken", user.Name);
            await _localStorageService.SetItemAsync("refreshToken", user.LastName);

            var identity = GetClaimsIdentity(user);

            var claimsPrincipal = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }
        private ClaimsIdentity GetClaimsIdentity(UserLogin user)
        {
            var claimsIdentity = new ClaimsIdentity();

            if (user.Name != null)
            {
                claimsIdentity = new ClaimsIdentity(new[]
                                {
                                    new Claim(ClaimTypes.Name, user.Name),
                                    new Claim(ClaimTypes.Role, user.Rolename),
                                }, "apiauth_type");
            }

            return claimsIdentity;
        }
    }
}
