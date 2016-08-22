using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondSightWeb.Api.Models
{
    public interface IEyeglassDataService
    {
        IEnumerable<Eyeglass> ListEyeglasses(int venueId);
        Eyeglass Insert(Eyeglass eg, string memberId);
    }
}
