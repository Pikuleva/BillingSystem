using NuGet.Packaging.Signing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Цени на предлаганите услуги
    /// </summary>
    public class Price
    {
        /// <summary>
        /// Цени на ТВ услуги
        /// </summary>
        public class TVPrice
        {
           
            public const decimal TVBasePrice = 9.99m;
            public const decimal TVFilmsPrice = 4.99m;
            public const decimal TVSportPrice = 3.99m;
            public const decimal TVPopularSciencePrice = 5.99m;
            public const decimal TVKidsPrice = 2.99m;
            public const decimal TVEroticPrice = 8.99m;
            public const decimal TVMusicPrice = 1.99m;
        }
        /// <summary>
        /// Цени на интернет услуги
        /// </summary>

        public class InternetPrices
        {
            public const decimal Internet200MbpsPrice = 19.99m;
            public const decimal Internet100MbpsPrice = 14.99m;
            public const decimal Internet50MbpsPrice = 10.99m;
            public const decimal Internet15MbpsPrice = 8.99m;
        }
       
       
    }
}

