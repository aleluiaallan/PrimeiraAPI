﻿using Blog.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Blog.Services
{
    public class TokenService
    {
        public string GenerateToken(User user)
        {

            var tokenHandler = new JwtSecurityTokenHandler(); //cria instancia
            var key = Encoding.ASCII.GetBytes(Configuration.JwtKey); //pega a chave
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] 
                {
                    new (ClaimTypes.Name, "andreblatieri"), //user.identity.name
                    new (ClaimTypes.Role,"admin"), //user.IsInrole
                    new ("fruta","banana")
                }),
                Expires = DateTime.UtcNow.AddHours(8),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
            }; //espcifica o token

            var token = tokenHandler.CreateToken(tokenDescriptor); //cria o token
            return tokenHandler.WriteToken(token); //retorna o token em string
        }
    }
}