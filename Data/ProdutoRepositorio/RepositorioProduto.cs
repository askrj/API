﻿using Business.InterfaceGenerica;
using Business.InterfaceProduto;
using Data.Config;
using Microsoft.EntityFrameworkCore;
using Model.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ProdutoRepositorio
{
    public class RepositorioProduto : RepositoryGenerics<ProdutoViewModel>, IProduto
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositorioProduto()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

    }
}
