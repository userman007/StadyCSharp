using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Vehicles;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			object value = new object();
			var truck = new Truck();
			var airBus = new AirBus();
			var vehicle = new Vehicle();
			vehicle.Move(10, 10);
			vehicle.Move(new Position(10, 10));

			Vehicle testREference;

			//test again
			//test repository
			//testagain

			var f16 = new F16();


			TestTypes();
			Console.ReadKey();

			Math.Abs(1234);
		}

		private static void TestTypes()
		{
			House house1 = new House();
			Door doorHouse1 = new Door();
			Material doorMaterial = Material.Metal;
			doorHouse1.material = doorMaterial;

			//второй вариант
			int material = 4;
			doorHouse1.material = (Material)material;

			//третий вариант
			doorHouse1.material = (Material)3;

			Position doorLockPosition = new Position(0, 90);
			//doorLockPosition.x = 0;
			//doorLockPosition.y = 90;

			Lock doorLock = new Lock(Material.Brass);
			//doorLock.material = Material.Brass;
			//doorLock.doorLockPosition = doorLockPosition;
			Lock doorLock1 = new Lock(Material.Brass, doorLockPosition);
			Lock doorLock2 = new Lock(Material.Brass, new Position(0, 90));

			doorLock.position = doorLockPosition;
			doorHouse1.lockType = doorLock;

			house1.door = doorHouse1;


			//----------------------------------------------------------
			Door newDoor = new Door(new Lock(Material.Brass, new Position(0, 90)));
			House newHouse = new House();
			newHouse.door = newDoor;

			CottegeTown cTown = new CottegeTown();
			cTown.houses = new House[1];
			cTown.houses[0] = newHouse;


			House house2 = new House();
		}
	}

	public class CottegeTown
	{
		public House[] houses;//null
	}


	public class House
	{
		//двери
		public Door door;

		//окна
		public Window[] windows;

		public Position position;

		//стены
		//крыша
		//...
	}

	public class Door
	{
		public Material material = Material.Metal;
		public Lock lockType;

		public Door()
		{
			material = Material.Metal;
		}

		public Door(Material material)
		{
			this.material = material;
		}

		public Door(Material material, Lock lockType) : this(material)
		{
			this.lockType = lockType;
		}

		public Door(Lock lockType)
		{
			this.lockType = lockType;
		}
	}

	public enum Material
	{
		Fabric, //0
		Metal, //1
		Plastic, //2
		Gold, //3
		PVC,
		Brass,
	}

	public enum Lokation
	{
		Out,
		Inside,
	}

	public class Lock
	{
		public Material material;//null
		public Position position;//null

		public Lock() {}

		public Lock(Material material)
		{
			this.material = material;
		}

		public Lock(Material material, Position position):this(material)
		{
			//this.material = material;
			this.position = position;
		}
	}

	public class Position
	{
		public readonly int z;
		public int x;//0
		public int y;//0

		public Position()
		{
			z = 5;
			Console.WriteLine("Position. Main Constructor");
		}

		public Position(int posX, int posY): this(posX)
		{
			y = posY;
			Console.WriteLine("Position. Constructor with params");
		}

		public Position(int posX) : this()
		{
			x = posX;
			Console.WriteLine("Position. Constructor with one param");
		}
	}

	public class Window
	{
		public Material material;
		public Position position;
	}
}

