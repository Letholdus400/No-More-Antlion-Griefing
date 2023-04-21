using Terraria;
using Terraria.ID;
using Terraria.Audio;
using Terraria.ModLoader;
using ReLogic.Utilities;

namespace AntlionNoGrief
{
	class MyGlobalProjectile : GlobalProjectile
	{
		//prevent antlion sand projectiles from being killed by returning false
		public override bool PreKill(Projectile projectile,int timeLeft)
		{
			//antlion projectiles are the same as falling sand, but are not friendly
			if (projectile.type == ProjectileID.SandBallFalling && !projectile.friendly)
			{
                //since the projectile isn't killed, play the sound now
                SoundEngine.PlaySound(SoundID.Dig, projectile.position);
				//returning false skips the vanilla kill code
				return false;
            }
			//all other projectiles remain unaffected
			return true;
		}
	}
}