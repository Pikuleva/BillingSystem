using Microsoft.EntityFrameworkCore;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Свързваща таблица - клиента какви услуги ползва и създадентите тикети към договора
    /// </summary>
    [Comment("Services used by the client")]
    public class ClientService
    {
        /// <summary>
        /// Идентификатор на клиента
        /// </summary>
        [Comment("Client identificator")]
        public int ClientId { get; set; }
        /// <summary>
        /// Клиент
        /// </summary>
        [Comment("Client")]
        public Client Client { get; set; } = null!;

        /// <summary>
        /// Идентификатор на интернет услуга
        /// </summary>
        [Comment("Internet service identificator")]
        public int InternetServiceId { get; set; }

        /// <summary>
        /// Интернет услуга
        /// </summary>
        [Comment("Internet service")]
        public InternetService? InternetService { get; set; }

        /// <summary>
        /// Идентификатор на интерактивна телевизия
        /// </summary>
        [Comment("IPTV identificator")]
        public int IPTVId { get; set; }

        /// <summary>
        /// Интерактивна телевизия
        /// </summary>
        [Comment("IPTV service")]
        public IPTV? IPTV { get; set; }

        /// <summary>
        /// Идентификатор на сателитна телевизия
        /// </summary>
        [Comment("SatelliteTV identificator")]
        public int SatelliteTVId { get; set; }

        /// <summary>
        /// Сателитна телевизия
        /// </summary>
        [Comment("SatelliteTV")]
        public SatelliteTV? SatelliteTV { get; set;}

        /// <summary>
        /// Идентификатор на заявка към договора
        /// </summary>
        [Comment("Ticket identificator")]
        public int TicketId { get; set; }

        /// <summary>
        /// Заявка към договора
        /// </summary>
        [Comment("Ticket")]
        public Ticket? Ticket { get; set; }
    }
}
