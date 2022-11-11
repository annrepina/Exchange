using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Model
{
    /// <summary>
    /// Валюта
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// Имя валюты
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Код валюты
        /// </summary>
        public int CurrencyCode { get; set; }

        /// <summary>
        /// Количество валюты
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Цена валюты
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Currency()
        {

        }
    }

}
