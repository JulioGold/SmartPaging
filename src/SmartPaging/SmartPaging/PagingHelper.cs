namespace SmartPaging
{
    using System.Linq;

    /// <summary>
    /// Classe de extensão para ajudar na paginação.
    /// </summary>
    public static class PagingHelper
    {
        /// <summary>
        /// Ajuda a realizar a paginação de uma consulta já ordenada, basta apenas passar o objeto de opções de paginação.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="orderedQuery">Consulta que desejo paginar.</param>
        /// <param name="pagingOptions">Objeto com as opções de paginação.</param>
        /// <returns><typeparamref name="T"/>Tipo da consulta que será retornada.</returns>
        public static IQueryable<T> GetPage<T>(this IOrderedQueryable<T> orderedQuery, PagingOptions pagingOptions)
        {
            return orderedQuery.Skip((pagingOptions.Page - 1) * pagingOptions.PageSize).Take(pagingOptions.PageSize);
        }
    }
}
