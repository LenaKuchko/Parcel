using Nancy;
using Parcels.Objects;
using System;
using System.Text;
namespace Parcels
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/price"] = _ => {
        ParcelVariables myParcelVariables = new ParcelVariables();

        int height;
        int width;
        int depth;
        int weight;
        //
        bool ifSuccess = int.TryParse(Request.Query["height"], out height);
        bool ifSuccess1 = int.TryParse(Request.Query["width"], out width);
        bool ifSuccess2 = int.TryParse(Request.Query["depth"], out depth);
        bool ifSuccess3 = int.TryParse(Request.Query["weight"], out weight);

        if (!int.TryParse(Request.Query["height"], out height) || !int.TryParse(Request.Query["width"], out width) || !int.TryParse(Request.Query["depth"], out depth) || !int.TryParse(Request.Query["weight"], out weight)) {
          return View["error.cshtml"];
        }
        else
        {
          int dimension = myParcelVariables.Volume(height, width, depth);
          int shippingCost = myParcelVariables.CalculateCost(weight, dimension);

          myParcelVariables.SetCost(shippingCost);

          return View["price.cshtml", myParcelVariables];
        }
      };
    }
  }
}
