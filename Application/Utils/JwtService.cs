using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public static class JwtService
{
    // public static string GenerateJsonWebToken(this User user, string secretKey, DateTime now)
    // {
    //     var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
    //     var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
    //     var claims = new[]
    //     {
    //     new Claim(ClaimTypes.NameIdentifier ,user.UserName),
    // };
    //     var token = new JwtSecurityToken(
    //         claims: claims,
    //         expires: now.AddMinutes(15),
    //         signingCredentials: credentials);


    //     return new JwtSecurityTokenHandler().WriteToken(token);
    // }
}