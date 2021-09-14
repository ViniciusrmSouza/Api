﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using AulaApi.Models;
using System.Threading.Tasks;

namespace AulaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Produto>> Get()
        {
            var p1 = new Produto
            {
                Id = 1,
                Descricao = "Notebook",
                Estoque = 2,
                Valor = 2499
            };

            var p2 = new Produto
            {
                Id = 2,
                Descricao = "TV",
                Estoque = 5,
                Valor = 2000
            };

            var produtos = new List<Produto>();
            produtos.Add(p1);
            produtos.Add(p2);
            return produtos;
        }

        
    }
}
