using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;

namespace WebApplication1.TokenFolder
{
    public class JwtConfig
    {
        private IConfiguration _config;
        public string GenerateKey(string username)
        {
            List<Claim> claims = new List<Claim> { new Claim(ClaimTypes.Name, username) };
            var symetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("5d3e6727f7e5787d47479d58e3307c8b"));
            var credentials = new SigningCredentials(symetricKey, SecurityAlgorithms.HmacSha256);
            var header = new JwtHeader(credentials);

            var payload = new JwtPayload("http://localhost:3005", "http://localhost:3005", claims,null,DateTime.Today.AddDays(1));
            var token = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
