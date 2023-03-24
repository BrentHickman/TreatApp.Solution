using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TreatApp.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The Treat's name can't be empty!")]
    public string Name { get; set; }
    [Required(ErrorMessage = "The Treat's description can't be empty!")]
    public string Description { get; set; }
    public float Price { get; set; }
    public List<TreatFlavor> JoinEntities { get;}
    public ApplicationUser User { get; set; }

  }
}