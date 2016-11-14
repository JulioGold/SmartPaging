namespace SmartPaging
{
    /// <summary>
    /// Opções de páginação para uma listagem.
    /// </summary>
    public sealed class PagingOptions
    {
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
