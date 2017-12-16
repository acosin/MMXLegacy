﻿using System;

namespace Legacy.Core.Abilities
{
	[Flags]
	public enum EExecutionPhase
	{
		BEGIN_OF_MONSTERS_TURN = 1,
		BEFORE_MONSTER_ATTACK = 2,
		AFTER_MONSTER_ATTACK = 4,
		AFTER_DAMAGE_CALCULATION = 8,
		BEFORE_TARGET_SELECTION = 16,
		ON_CHARACTER_ATTACKS_MONSTER_BEFORE_DAMAGE_REDUCTION = 32,
		ON_CHARACTER_ATTACKS_MONSTER_AFTER_DAMAGE_REDUCTION = 64,
		ON_CHARACTER_ATTACKS_MONSTER_COUNTER_ATTACK = 128,
		END_OF_MONSTERS_TURN = 256,
		MONSTER_DIES = 512,
		ON_APPLY_MONSTER_BUFF = 1024,
		AFTER_MONSTER_SPELL = 2048,
		AFTER_MONSTER_ATTACK_INSTANT = 4096
	}
}