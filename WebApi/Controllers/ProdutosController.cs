using Business.InterfaceProduto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : Controller
    {
        private readonly IProduto _IProduto;

        public ProdutosController(IProduto IProduto)
        {
            _IProduto = IProduto;
        }

        [HttpGet("ListarProdutos")]
        public async Task<IActionResult> ListarProdutos()
        {
            return Json(await _IProduto.List());
        }

        [HttpPost("ObterProdutoPorId")]
        public async Task<IActionResult> ObterProdutoPorId(int id)
        {
            return Json(await _IProduto.GetEntityById(id));
        }

        [HttpPost("AdicionarProduto")]
        public async Task AdicionarProduto(ProdutoViewModel produto)
        {
            await _IProduto.Add(produto);
        }

        [HttpPost("AtualizarProduto")]
        public async Task AtualizarProduto(ProdutoViewModel produto)
        {
            await _IProduto.Update(produto);
        }

        [HttpPost("RemoverProduto")]
        public async Task RemoverProduto(ProdutoViewModel produto)
        {
            await _IProduto.Delete(produto);
        }

    }
}
