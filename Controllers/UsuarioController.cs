﻿using AutoMapper;
using LoginUsuarioAPI.Data.Dtos;
using LoginUsuarioAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace LoginUsuarioAPI.Controllers
{
    [ApiController]
    [Route("usuario")]
    public class UsuarioController : ControllerBase
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;

        public UsuarioController(IMapper mapper, UserManager<Usuario> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>(dto);

            var resultado = await _userManager.CreateAsync(usuario, dto.Password);

            if (resultado.Succeeded)
                return Ok("Usuario Cadastrado com Sucesso");

            throw new ApplicationException("Falha ao cadastrar usuario");
        }

    }
}
