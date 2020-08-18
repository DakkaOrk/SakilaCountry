using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SakilaCountry.Models
{
    public class Country
    {
        [Key]
        public Int16? country_id { get; set; }
        public string country { get; set; }
        public DateTime last_update { get; set; }
        public int Extraterrestrials { get; set; }
    }
}

/*[country_id] [smallint] IDENTITY(1,1) NOT NULL,
	[country] [varchar](50) NOT NULL,
	[last_update] [datetime] NULL,
	[Extraterrestrials] [int] NULL,
*/