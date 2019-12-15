using System;

namespace AJT.Dtos
{
    public class ShortenedUrlDto
    {
        public string Id { get; set; }
        public string LongUrl { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ShortUrl { get; set; }
    }
}
