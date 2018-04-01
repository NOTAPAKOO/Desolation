using Terraria.ModLoader;

namespace desolation
{
	class desolation : Mod
	{
		public desolation()
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
