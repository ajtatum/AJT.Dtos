using System;

namespace AJT.Dtos
{
    public class ShortenedUrlClickDto
    {
        public int Id { get; set; }
        public int ShortenedUrlId { get; set; }
        public DateTime ClickDate { get; set; }
        public string Referrer { get; set; }
    }
}
