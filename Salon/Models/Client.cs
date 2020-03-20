  
using System.Collections.Generic;

namespace Salon.Models
{
  public class Client
  {
    public Client()
    {
      this.Reviews = new HashSet<Review>();
    }
    public int ClientId { get; set; }
    public string Name { get; set; }
    public int StylistId { get; set; }
    public string PriceRange { get; set; }

    public virtual Stylist Stylist { get; set; }
  }
}