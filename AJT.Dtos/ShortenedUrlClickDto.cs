using System;
using NetTopologySuite.Geometries;

namespace AJT.Dtos
{
    public class ShortenedUrlClickDto
    {
        public int Id { get; set; }
        public int ShortenedUrlId { get; set; }
        public DateTime ClickDate { get; set; }
        public string Referrer { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Point Geography { get; set; }
    }
}
