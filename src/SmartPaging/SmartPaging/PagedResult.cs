namespace SmartPaging
{
    using System.Collections.Generic;

    /// <summary>
    /// Objeto de retorno para realizar páginação.
    /// </summary>
    /// <typeparam name="T">Classe a dos objetos a serem retornados.</typeparam>
    public sealed class PagedResult<T>
    {
        /// <summary>
        /// Lista com uma fração (uma página) de registros a serem entregues.
        /// </summary>
        public IList<T> Items { get; set; }

        /// <summary>
        /// Total de registros.
        /// </summary>
        public int Count { get; set; }
    }
}
