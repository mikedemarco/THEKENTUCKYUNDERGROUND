using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THEKENTUCKYUNDERGROUND
{
	public class UnderGroundRepository
	{
		public static UndergroundRoutes[] InitializeRoutes()
		{
			return new UndergroundRoutes[] {
				new UndergroundRoutes(1,new string[]{"Covington", "Lexington"}),
				new UndergroundRoutes(2,new string[]{"Lexington", "Owensboro"}),
				new UndergroundRoutes(3,new string[]{"Owensboro", "Louisville"}),
				new UndergroundRoutes(4,new string[]{"Louisville", "Covington"})
			};
		}
	}
}