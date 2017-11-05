//Michael Lawrence.
//Add fishes to tank and write total grams of fish food required.
using System;
using System.Collections;

namespace FishTank01
{
	//build a class to store the fish's name. 
	public class Fish
	{
		public string name { get; set; }
		
	}
	
	public class Tank
	{
		//build ArrayList because it expands and will want to add more fishes later.
		ArrayList list = new ArrayList();
		
		//Public variables for the Fish Food amounts.
		public double GoldFish = 0;
		public double AngelFish = 0;
		public double BabelFish = 0;
		public double ExtraFish = 0;
		
		//-- Ask user to add the fishes into the tank --
		public void AddGoldFish()
		{
				//build a fish object using the fish class, to get the string name.
				var fish1 = new Fish()
				{
					name = "Gold Fish"
				};
				
				//add the object fish1 to the ArrayList.
				list.Add(fish1);
				//get the index number of the object.
				int loc1 = list.IndexOf(fish1);
				//create individual objects for each fish, store in loc1-3 and name them item1-3.
				Fish item1 = (Fish)list[loc1];
				//display location number stored in ArrayList.
				Console.Write(loc1+".");
				//write objects variable name.
				Console.WriteLine(item1.name);
				Console.WriteLine();
				//Fish Food amounts.
				GoldFish = 0.1;				
		} //------------------------- Gold Fish Added -------------------------------------		
		
		public void AddAngelFish()
		{
				//build a fish object.
				var fish2 = new Fish()
				{
					name = "Angel Fish"
				};
				
				//add the object fish2 to the ArrayList.
				list.Add(fish2);
				//get the index number of the object.
				int loc2 = list.IndexOf(fish2);
				//create individual objects for each fish, store in loc1-3 and name them item1-3.
				Fish item2 = (Fish)list[loc2];
				//display location number stored in ArrayList.
				Console.Write(loc2+".");
				//write objects variable name.
				Console.WriteLine(item2.name);
				Console.WriteLine();
				//Fish Food amounts.
				AngelFish = 0.2;			
		} //------------------------- Angel Fish Added -------------------------------------		
		
		public void AddBabelFish()
		{
				//build a fish object.
				var fish3 = new Fish()
				{
					name = "Babel Fish"
				};
				
				//add the object fish3 to the ArrayList.
				list.Add(fish3);
				//get the index number of the object.
				int loc3 = list.IndexOf(fish3);
				//create individual objects for each fish, store in loc1-3 and name them item1-3.
				Fish item3 = (Fish)list[loc3];
				//display location number stored in ArrayList.
				Console.Write(loc3+".");
				//write objects variable name.
				Console.WriteLine(item3.name);
				Console.WriteLine();
				//Fish Food amounts.
				BabelFish = 0.3;
		} //------------------------- Babel Fish Added -------------------------------------		
		
		public void AddExtraFish()
		{
				//build a fish object.
				var fish4 = new Fish()
				{
					name = "Extra Fish"
				};
				
				//add the object fish3 to the ArrayList.
				list.Add(fish4);
				//get the index number of the object.
				int loc4 = list.IndexOf(fish4);
				//create individual objects for each fish, store in loc1-4 and name them item1-4.
				Fish item4 = (Fish)list[loc4];
				//display location number stored in ArrayList.
				Console.Write(loc4+".");				
				//write objects variable name.
				Console.WriteLine(item4.name);
				Console.WriteLine();
				//Fish Food amounts.
				ExtraFish = 0.4;
		} //------------------------- Extra Fish Added -------------------------------------		
				
//-- Method to feed the fishes. -----------------------------------------------------------------------------------------------------
		public void Feed()
		{			
			Console.WriteLine("-- Michael Lawrence's Fish Tank. --");
			Console.WriteLine("Displayed below are the: Location Numbers, and Fish Names.\n");
			
			//-- Gold Fish ----------------------------------
			Console.Write("Add a Gold Fish, y or n?");
			string GoldFishChoice;
			GoldFishChoice = Console.ReadLine(); //enter data.		 
			if (GoldFishChoice.Equals("y".ToLower()))
			{
				Console.WriteLine();
				//If yes, then call the add gold fish method.
				AddGoldFish();
			}
			else
			{
				//keep going.
			}
			//-----------------------------------------------
			
			//-- Angel Fish --
			Console.Write("Add a Angel Fish, y or n?");
			string AngelFishChoice;
			AngelFishChoice = Console.ReadLine(); //enter data.		 
			if (AngelFishChoice.Equals("y".ToLower()))
			{
				Console.WriteLine();
				//If yes, then call the add angel fish method.
				AddAngelFish();
			}
			else
			{
				//keep going.
			}
			//-----------------------------------------------
			
			//-- Babel Fish --
			Console.Write("Add a Babel Fish, y or n?");
			string BabelFishChoice;
			BabelFishChoice = Console.ReadLine(); //enter data.		 
			if (BabelFishChoice.Equals("y".ToLower()))
			{
				Console.WriteLine();
				//If yes, then call the add Babel fish method.
				AddBabelFish();	
			}
			else
			{
				//keep going.
			}
			//-----------------------------------------------
			
			//-- Extra Fish --
			Console.Write("Add an Extra Fish, y or n?");
			string ExtraFishChoice;
			ExtraFishChoice = Console.ReadLine(); //enter data.		 
			if (ExtraFishChoice.Equals("y".ToLower()))
			{
				Console.WriteLine();
				//If yes, then call the add Babel fish method.
				AddExtraFish();	
			}
			else
			{
				//keep going.
			}
			//-----------------------------------------------
						
			//add up total fish food required.
			double TotalFishFood = GoldFish + AngelFish + BabelFish + ExtraFish;
			Console.WriteLine("-----------------------------");
			//write total in grams.
			Console.WriteLine("Total Fish Food reguired: " +TotalFishFood+ "g"); 
		}
	} 
}
