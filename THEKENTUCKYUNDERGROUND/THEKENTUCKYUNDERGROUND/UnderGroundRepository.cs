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
				new UndergroundRoutes(1,new string[]{"COVINGTON", "LEXINGTON"}),
				new UndergroundRoutes(2,new string[]{"LEXINGTON", "OWENSBORO"}),
				new UndergroundRoutes(3,new string[]{"OWENSBORO", "LOUISVILLE"}),
				new UndergroundRoutes(4,new string[]{"LOUISVILLE", "COVINGTON"}),
				new UndergroundRoutes(5,new string[]{"NEWPORT", "FRANKFORT"})
			};
		}
	}
}