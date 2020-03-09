﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;
using RimWorld;
using Verse;

using HarmonyLib;

namespace O21Toolbox.Shield
{
    [StaticConstructorOnStartup]
    public static class NonPublicProperties
    {
        public static Func<Projectile, float> Projectile_get_StartingTicksToImpact = (Func<Projectile, float>)Delegate.CreateDelegate(typeof(Func<Projectile, float>), null, AccessTools.Property(typeof(Projectile), "StartingTicksToImpact").GetGetMethod(true));

        public static Action<TurretTop, float> TurretTop_set_CurRotation = (Action<TurretTop, float>)Delegate.CreateDelegate(typeof(Action<TurretTop, float>), null, AccessTools.Property(typeof(TurretTop), "CurRotation").GetSetMethod(true));
    }
}
