﻿using CaLOLateAPI.Data;
using CaLOLateAPI.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CaLOLateAPI.Controllers
{
    [RoutePrefix("auth")]
    [EnableCors("*", "*", "*")]
    public class AuthenticationController : ApiController
    {
        [Route("login")]
        [HttpPost]
        public IHttpActionResult Login([FromBody]User user)
        {
            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password))
            {
                return BadRequest("Enter your username and password");
            }
            try
            {
                using(var context = new AppDbContext())
                {
                    var exists = context.Users.Any(n => n.UserName == user.UserName && n.Password == user.Password);
                    if (exists) return Ok(CreateToken(user));

                    return BadRequest("Wrong credentails");
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [Route("register")]
        [HttpPost]
        public IHttpActionResult Register([FromBody]User user)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var exists = context.Users.Any(n => n.UserName == user.UserName);
                    if (exists) return BadRequest("User already exists");

                    context.Users.Add(user);
                    context.SaveChanges();

                    return Ok(CreateToken(user));
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        private JwtPackage CreateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var claims = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Email, user.UserName)
            });

            const string secretKey = "141324123";
            var securityKey = new SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(secretKey));
            var signinCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var token = (JwtSecurityToken)tokenHandler.CreateJwtSecurityToken(
                    subject: claims,
                    signingCredentials: signinCredentials
                );

            var tokenString = tokenHandler.WriteToken(token);

            return new JwtPackage()
            {
                UserName = user.UserName,
                Token = tokenString
            };
        }
    }
}

public class JwtPackage
{
    public string Token { get; set; }
    public string UserName { get; set; }
}
