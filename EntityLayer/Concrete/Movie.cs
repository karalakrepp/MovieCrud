using Core.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace EntityLayer.Concrete;

public class Movie : BaseEntity<Guid>
    
{
    public Movie()
    {
        
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }

    public float Score { get; set; }

    public int Year { get; set; }

    public int Duration { get; set; }

    public string Country { get; set; }

    public string Director { get; set; }
    public Movie(string name, string title, string description, float score, int year, int duration, string country, string director)
    {
        Name = name;
        Title = title;
        Description = description;
        Score = score;
        Year = year;
        Duration = duration;
        Country = country;
        Director = director;
  
    }
}

