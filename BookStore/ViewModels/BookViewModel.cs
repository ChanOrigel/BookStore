using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.ViewModels
{
    public class BookViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public string Cover { get; set; } = "Default.jpeg";
        public string Description { get; set; }
        public bool isAvailable { get; set; }
        public IFormFile DocuFile { get; set; }


        //HISTORY
        public History info { get; set; }
        public List<History> HistListB { get; set; }
        public List<History> HistListR { get; set; }

        public class History
        {
            public Guid Id { get; set; }
            public bool Type { get; set; } //0-Borrowed, 1-Returned
            public DateTime? Date { get; set; }

            public string FormattedDate
            {
                get
                {
                    return Date == null ? "" : string.Format("{0:MMMM dd yyy hh:mm:ss}", Date.Value);
                }
            }

        }
    }
}
