using Terraria.ModLoader;

namespace MoreThingsMod
{
	class MoreThingsMod : Mod
	{
		public MoreThingsMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
