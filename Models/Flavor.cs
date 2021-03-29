using System.Collections.Generic;

namespace PierreTreats.Models
{
  public class Flavor
{
    public Flavor()
  {
    JoinEntities = new HashSet<FlavorTreat>();
  }
  public int FlavorId {get; set;}

  public string FlavorDescription {get; set;}

  


  public virtual ApplicationUser User { get; set; }

  public virtual ICollection<RecipeTag> JoinEntities { get;}

    }
}