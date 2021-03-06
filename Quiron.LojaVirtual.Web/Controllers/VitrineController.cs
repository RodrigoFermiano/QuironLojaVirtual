﻿using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 3;

        // GET: Produtos
        public ActionResult ListaProdutos(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos.OrderBy(p => p.Nome).Skip((pagina - 1) * ProdutosPorPagina).Take(ProdutosPorPagina);

            return View(produtos);
        }
    }
}