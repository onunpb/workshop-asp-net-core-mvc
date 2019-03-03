﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        //Declaração de dependência
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            //Acessar a fonte de dados realacionada à tabela Sellers e converte para uma lista
            //Operação síncrona (a aplicação pára enquanto o sistema faz a pesquisa)
            return _context.Seller.ToList();
        }
    }
}
