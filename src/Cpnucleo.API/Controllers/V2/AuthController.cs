﻿using Cpnucleo.API.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Cpnucleo.API.Controllers.V2
{
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("2")]
    public class AuthController : ControllerBase
    {
        private const string userT = "USERBOLADAO";
        private const string passT = "SENHABOLADONA";

        private readonly IJwtManager _jwtManager;

        public AuthController(IJwtManager jwtManager)
        {
            _jwtManager = jwtManager;
        }

        /// <summary>
        /// Obter Token
        /// </summary>
        /// <remarks>
        /// # Obter Token
        /// 
        /// Obtém um token válido por 60 minutos para utilização na API.
        /// </remarks>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <response code="200">Retorna um token válido por 60 minutos</response>
        /// <response code="400">Usuário ou senha inválidos</response>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Index(string user, string pass)
        {
            string token;

            if (user == userT && pass == passT)
            {
                token = _jwtManager.GenerateToken(user, 60);
            }
            else
            {
                return BadRequest();
            }

            return Ok(token);
        }
    }
}