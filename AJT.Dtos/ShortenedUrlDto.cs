using System;

namespace AJT.Dtos
{
    public class ShortenedUrlDto
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string Domain { get; set; }
        public string LongUrl { get; set; }
        public string ShortUrl { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
