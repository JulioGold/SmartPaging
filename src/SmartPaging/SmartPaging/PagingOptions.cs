using System;

namespace SmartPaging
{
    /// <summary>
    /// Opções de páginação para uma listagem.
    /// </summary>
    public sealed class PagingOptions
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public PagingOptions()
        {
        }

        /// <summary>
        /// Constructor with configurations.
        /// </summary>
        /// <param name="page">The number of the page you want to get.</param>
        /// <param name="pageSize">Size of page.</param>
        /// <param name="limit">Max number of items on each page.</param>
        public PagingOptions(int page, int pageSize, int limit)
            : this()
        {
            Page = page;
            PageSize = Math.Min(pageSize, limit);
        }

        /// <summary>
        /// Constructor with configurations.
        /// Here the default limit is 100 items.
        /// </summary>
        /// <param name="page">The number of the page you want to get.</param>
        /// <param name="pageSize">Size of page.</param>
        public PagingOptions(int page, int pageSize)
           : this(page, pageSize, 100)
        {
        }

        /// <summary>
        /// Número da página a ser obtida.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Quantidade de itens por página.
        /// </summary>
        public int PageSize { get; set; }
    }
}

