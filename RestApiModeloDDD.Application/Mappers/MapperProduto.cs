using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Application.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor
            };

            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };

            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutosToDto(IEnumerable<Produto> produtos)
        {
            var listaProdutosDtos = produtos.Select(c => MapperEntityToDto(c));

            return listaProdutosDtos;
        }
    }
}