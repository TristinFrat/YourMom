using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YourMom.Projectiles
{

    public class CactusWaffle : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("CactusWaffle");
        }
        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.penetrate = 30;
            projectile.timeLeft = 200;
            projectile.light = 0.65f;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
            projectile.aiStyle = 3;
        }
        public override void AI()
        {
            
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }
    }
}