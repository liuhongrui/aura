﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;

namespace Aura.Shared.Const
{
	[Flags]
	public enum SkillFlags : ushort
	{
		Shown = 0x01,
		CountType = 0x02,
		InUse = 0x04,
		Rankable = 0x08,
		PassiveApplied = 0x10,
		Default = 0xFF80,
	}

	// The client calculates the Dan based on the rank id.
	// 19 = Dan4, 30 = Dan15, etc.
	public enum SkillRank : byte
	{
		Novice = 0, RF = 1, RE = 2, RD = 3, RC = 4, RB = 5, RA = 6, R9 = 7, R8 = 8, R7 = 9, R6 = 10, R5 = 11, R4 = 12, R3 = 13, R2 = 14, R1 = 15, Dan1 = 16, Dan2 = 17, Dan3 = 18
	}

	public enum SkillConst : ushort
	{
		None = 0,

		// Life
		Tailoring = 10001,
		ReadinDetail = 10002,
		PlayingInstrument = 10003,
		Rest = 10004,
		Composing = 10005,
		MusicalKnowledge = 10006,
		TownCry = 10007,
		Campfire = 10008,
		FirstAid = 10009,
		Gathering = 10010,
		Weaving = 10011,
		Milling = 10012,
		Handicraft = 10013,
		Weaving2 = 10014,
		Refining = 10015,
		Blacksmithing = 10016,
		Cooking = 10020,
		Herbalism = 10021,
		PotionMaking = 10022,
		Fishing = 10023,
		ProductionMastery = 10024,
		OpenTreasureChest = 10025,
		TamingWildAnimals = 10026,
		ControlPaddle = 10027,
		Metallurgy = 10028,
		HotAirBalloonControl = 10029,
		Fragmentation = 10030,
		Synthesis = 10031,
		ExclusiveStreetArtistskill = 10032,
		Carpentry = 10033,
		Gardening = 10034,
		InstallKiosk = 10035,
		MakeTheatreMissionPass = 10036,
		WineMaking = 10037,
		//향수제조 =  10038, 
		StudyPotionLore = 10039,

		// Combat
		Defense = 20001,
		Smash = 20002,
		MeleeCounterattack = 20003,
		NaturalShield = 20004,
		HeavyStander = 20005,
		ManaDeflector = 20006,
		FullSwing = 20007,
		FinalSmash = 20008,
		FuryofBard = 20009,
		Jump = 20010,
		Charge = 20011,
		AssaultSlash = 20012,
		Berserker = 20013,
		Berserkerhidden = 20014,
		AngerManagement = 20015,
		LanceCounter = 20016,
		LanceCharge = 20017,
		RangedCombatMastery = 21001,
		MagnumShot = 21002,
		ArrowRevolver = 21003,
		ArrowRevolver2 = 21004,
		Chaingun = 21005,
		SupportShot = 21006,
		MirageMissile = 21007,
		BombIgnition = 21008,
		SpiritBowAwakening = 21009,
		ThrowingAttack = 21010,
		HotAirBalloonCrossbowShot = 21011,
		SpiderShot = 21012,
		Windmill = 22001,
		Stomp = 22002,
		SelfDestructionActive = 22003,
		FinalHit = 22004,
		SpiritSwordAwakening = 22005,
		SpiritBluntAwakening = 22006,
		GiantStomp = 22007,
		WendigoStomp = 22008,
		AlligatorFullSwing = 22009,
		GiantLionRoar = 22010,
		CrashShot = 22011,
		InstinctiveReaction = 23001,
		MeleeCombatMastery = 23002,
		CriticalHit = 23003,
		NaturalShieldPassive = 23004,
		HeavyStanderPassive = 23005,
		ManaDeflectorPassive = 23006,
		DarkLord = 23007,
		GlasGhaibhleannSkill = 23008,
		ChainCasting = 23009,
		SelfDestruction = 23010,
		SharpMind = 23011,
		SwordMastery = 23012,
		AxeMastery = 23013,
		BluntMastery = 23014,
		DaggerMastery = 23015,
		ShieldMastery = 23016,
		DualWeaponMastery = 23017,
		DragonTailAttack = 23021,
		StoneBreath = 23022,
		DragonFireBreath = 23023,
		DragonDashAttack = 23024,
		SandwormMeleeAttack = 23025,
		LionBite = 23026,
		LionSwing = 23027,
		WindGuard = 23028,
		Taunt = 23029,
		FinalShot = 23030,
		ShadowBreath = 23031,
		DarkFlame = 23032,
		LightofSword = 23033,
		ClaimhSolasDash = 23034,
		ClaimhSolasFullSwing = 23035,
		ScarecrowCurse = 23036,
		GriffinRoar = 23037,
		WallDecorationFireBolt = 23038,
		WallDecorationIceBolt = 23039,
		WallDecorationLightningBolt = 23040,
		WallDecorationBoltAttack = 23041,
		WallDecorationPoisonGasAttack = 23042,
		Evasion = 23043,
		PythonStoneLongRangeAttack = 23044,
		PythonStoneShortRangeAttack = 23045,
		PythonStoneBreath = 23046,
		NuadhaStomp = 23047,
		NuadhaSpearOfLight = 23048,
		NuadhaFuryOfLight = 23049,
		NuadhaLightOfSword = 23050,
		NuadhaSmash = 23051,
		TigerRoar = 23052,
		GrimReaperVerticalAttack = 23053,
		GrimReaperHorizontalAttack = 23054,
		GrimReaperWindmill = 23055,
		ArmorBearRoar = 23057,
		ShadowBunshin = 23058,
		BowMastery = 23060,
		CrossbowMastery = 23061,
		LanceMastery = 23062,
		KnuckleMastery = 23063,
		BranShockwave = 23101,
		BranCharge = 23102,
		BranArmSwing = 23103,
		Loot = 23104,
		Escape = 23105,
		GoldStrike = 23106,
		Berserk = 23107,
		ChainMastery = 24001,
		ChargingStrike = 24101,
		FocusedFist = 24102,
		ChainCounterPunch = 24103,
		SpinningUppercut = 24201,
		SomersaultKick = 24202,
		DropKick = 24301,
		Pummel = 24302,
		Respite = 25000,
		Tumble = 25001,

		// Magic
		Meditation = 30003,
		Enchant = 30004,
		Enchant2 = 30005,
		Healing = 30006,
		MagicMastery = 30007,
		PartyHealing = 30008,
		PetMeditation = 30009,
		LifeDrainMagic = 30010,
		MirrorWitchRest = 30011,
		MonsterResurrection = 30012,
		YarnBinding = 30013,
		SilentMove = 30014,
		EnthrallingPerformance = 30015,
		FireMastery = 30016,
		IceMastery = 30017,
		LightningMastery = 30018,
		BoltMastery = 30019,
		MagicWandMastery = 30020,
		MagicStaffMastery = 30021,
		Lightningbolt = 30101,
		Thunder = 30102,
		FloatingStoneThunder = 30103,
		InstantThunder = 30104,
		Shockwave = 30105,
		Firebolt = 30201,
		Fireball = 30202,
		TrainingFireball = 30203,
		FloatingStoneFireBall = 30204,
		Icebolt = 30301,
		IceSpear = 30302,
		IceHug = 30303,
		SuperIcebolt = 30304,
		WaterSpray = 30305,
		FloatingStoneIceSpear = 30306,
		HailStorm = 30307,
		SpiritWandAwakening = 30401,
		IceLightning = 30450,
		IceFire = 30451,
		FireLightning = 30452,
		FusionBolt = 30453,
		FireMagicShield = 30460,
		IceMagicShield = 30461,
		LightningMagicShield = 30462,
		NaturalMagicShield = 30463,
		ManaShield = 30464,
		Blaze = 30470,
		PaperAirplaneBomb = 30471,
		InvitationofDeath = 30472,
		FlamesofHell = 30473,

		// Alchemy
		ManaCrystallization = 35001,
		LifeDrain = 35002,
		AlchemyMastery = 35003,
		WaterCannon = 35004,
		Crystallization = 35005,
		BarrierSpikes = 35006,
		WindBlast = 35007,
		FlameBurst = 35008,
		SandBurst = 35009,
		RainCasting = 35010,
		FrozenBlast = 35011,
		MetalConversion = 35012,
		Shock = 35013,
		HeatBuster = 35014,
		ChainCylinder = 35015,
		FireAlchemy = 35016,
		WaterAlchemy = 35017,
		ClayAlchemy = 35018,
		WindAlchemy = 35019,
		AlchemyCylinderMastery = 35020,
		Transmutation = 35021,
		SpiritCylinderAwakening = 35101,

		// Trans
		SpiritOfOrder = 40001,
		PowerofOrder = 40002,
		EyeofOrder = 40003,
		SwordofOrder = 40004,
		PaladinNaturalShield = 40011,
		PaladinHeavyStander = 40012,
		PaladinManaRefractor = 40013,
		SoulOfChaos = 41001,
		ControlofDarkness = 41002,
		BodyofChaos = 41011,
		MindofChaos = 41012,
		HandsofChaos = 41013,
		DarkNaturalShield = 41021,
		DarkHeavyStander = 41022,
		DarkManaDeflector = 41023,
		RaceTransformation = 42001,
		WindMillTrans = 42002,
		FuryOfConnous = 43001,
		ElvenMagicMissile = 43002,
		ArmorofConnous = 43011,
		MindofConnous = 43012,
		SharpnessofConnous = 43013,
		ConnousNaturalShield = 43021,
		ConnousHeavyStander = 43022,
		ConnousManaRefractor = 43023,
		DemonofPhysis = 44001,
		GiantFullSwing = 44002,
		ShieldofPhysis = 44011,
		LifeofPhysis = 44012,
		SpellofPhysis = 44013,
		PhysisNaturalShield = 44021,
		PhysisHeavyStander = 44022,
		PhysisManaRefractor = 44023,
		AwakeningofLight = 45001,
		SpearofLight = 45002,
		FuryofLight = 45003,
		AwakeningofLightDisposable = 45004,
		SpearOfLightDisposable = 45005,
		FuryOfLightDisposable = 45006,
		ShadowSpirit = 45007,
		WingsofEclipse = 45008,
		WingsofRage = 45009,

		// Hidden
		HiddenEnchant = 50001,
		HiddenResurrection = 50002,
		HiddenTownBack = 50003,
		HiddenGuildStoneSetting = 50004,
		WebSpinning = 50005,
		HiddenBlessing = 50006,
		CampfireKit = 50007,
		SkillUntrainKit = 50008,
		BigBlessingWaterKit = 50009,
		Dye = 50010,
		EnchantElementalAllSlot = 50011,
		HiddenPoison = 50012,

		// Actions
		Sketch = 50013,
		Exploration = 50014,
		HiddenBomb = 50015,
		Playdead = 50016,
		Hide = 50017,
		Performance = 50018,
		LandMaker = 50019,
		RockThrowing = 50020,
		DiceTossing = 50021,
		JamSession = 50022,
		ThrowPaperAirplane = 50023,
		MakeChocoStatue = 50024,
		FossilRestoration = 50025,
		SeesawJump = 50026,
		SeesawCreate = 50027,
		DragonSupport = 50029,
		IceMine = 50030,
		Scan = 50031,
		SummonGolem = 50032,
		UseManaForming = 50033,
		UseSupportItem = 50034,
		TickingQuizBomb = 50035,
		ItemSeal = 50036,
		ItemUnseal = 50037,
		ItemDungeonPass = 50038,
		UseElathaItem = 50039,
		ThrowConfetti = 50040,
		UsePartyPopper = 50041,
		HammerGame = 50042,
		WaterBalloonThrowing = 50043,
		WaterBalloonThrowing2 = 50044,
		SpiritShift = 50045,
		EmergencyEscapeBomb = 50046,
		NameColorChange = 50047,
		InstallUninstallCylinder = 50048,
		HolyFlame = 50049,


		UseMorrighansFeather = 50050,
		CreateFaliasPortal = 50051,
		UseItemChattingColorChange = 50052,
		InstallPrivateFarmFacility = 50053,
		ReorientHomesteadbuilding = 50054,


		Paint = 50055,
		MixPaint = 50056,
		ContinentWarp = 50057,
		AddSeasoning = 50058,
		WaterBalloonAttack = 50059,
		EmergencyIceBomb = 50060,
		MarionetteHiddenResurrection = 50061,
		SnowBomb = 50062,
		PetBuffing = 50101,
		Swallow = 50102,
		BubbleBlast = 50103,
		Dash = 50104,
		FakeDeathCombat = 50105,
		MasterTeleport = 50106,
		Detection = 50107,
		PetSealToItem = 50108,

		PetHide = 50109,
		DragonMeteor = 50110,
		RedDragonFireBreath = 50111,
		ThunderRain = 50112,
		/*EatVolcanicBomb = 50113, // WARNING: POSSESSING THIS SKILL *WILL* CRASH YOUR CLIENT. */
		DragonRoar = 50114,
		WyvernFireBreath = 50115,
		WyvernLightning = 50116,
		WyvernIceBreath = 50117,

		CherryTreeKit = 50118,
		DragonSupportMeteor = 50119,
		Spin = 50120,
		Bewilder = 50121,
		NeidRisingandDiving = 50122,
		NeidRoar = 50123,
		NeidTailAttack = 50124,
		NeidWaterBomb = 50125,
		Watering = 50126,
		Fertilizing = 50127,
		BugCatching = 50128,
		BeholderBeamAttack = 50129,
		BeholderAlarm = 50130,
		AxeThrowing = 50131,
		ChandelierAttack = 50132,
		ShadowDeath = 50133,
		GachaponSynthesis = 50134,
		Summon = 50135,
		ThunderStorm = 50136,
		Boost = 50137,
		ThunderBreath = 50138,
		FireStorm = 50139,
		FireBreath = 50140,
		IceStorm = 50142,
		FlameDive = 50143,
		RunningBoost = 50144,
		FlownHotAirBalloon = 50145,
		Umbrella = 50146,
		ItemSeal2 = 50147,
		CureZombie = 50148,
		HandsofSalvation = 50149,
		Scare = 50150,
		FrostStorm = 50151,
		IceBreath = 50152,
		NormalAttack = 50153,
		FlameofResurrection = 50154,
		ExplosiveResurrection = 50155,
		PhoenixsFlame = 50156,
		DevilsDash = 50157,
		PetrifyingRoar = 50158,
		DevilsCry = 50159,
		SaveLocation = 50160,
		PetTeleport = 50161,
		RestfulWind = 50162,
		HolyShower = 50163,
		HolyRush = 50164,
		SpreadWings = 50165,
		//몬스터소환 =  50500, 
		//악의확산 =  50501, 
		//생명의확산 =  50502, 
		//폭주기관차 =  50503, 
		//성지순례 =  50504, 
		//화이트브레스 =  50505, 
		//블랙브레스 =  50506, 
		//지옥의손길 =  50507, 
		//데빌허그 =  50508, 
		//칼날서리 =  50509, 
		//철옹성 =  50510, 

		// Personas
		HamletsAnguish = 51001,
		ClaudiussConspiracy = 51002,
		OpheliasTears = 51003,
		RomeosConfession = 51004,
		TybaltsFencingSkills = 51005,
		JulietsFeelings = 51006,
		ShylocksStep = 51007,


		MerrowSmash = 52000,
		MerrowRisingDragon = 52001,
		MerrowTidalWave = 52002,

		// Bard
		Dischord = 53001,
		BattlefieldOverture = 53101,
		Lullaby = 53102,
		Vivace = 53103,
		EnduringMelody = 53104,
		HarvestSong = 53105,
		MarchSong = 53106,

		// Puppetry
		ControlMarionette = 54001,
		PierrotMarionette = 54081,
		ColossusMarionette = 54082,
		Act2ThresholdCutter = 54101,
		Act1IncitingIncident = 54102,
		Act4RisingAction = 54103,
		Act6Crisis = 54104,
		Act7ClimacticCrash = 54105,
		Act9InvigoratingEncore = 54106,
		Act2ThresholdCutterAI = 54151,
		Act1IncitingIncidentAI = 54152,
		Act4RisingActionAI = 54153,
		Act6CrisisAI = 54154,
		Act7ClimacticCrashAI = 54155,
		Act9InvigoratingEncoreAI = 54156,
		WirePull = 54201,
		PuppetsSnare = 54202,

		// Life Part 2
		SheepShearing = 55001,
		Mining = 55002,
		EggGathering = 55003,
		MushroomGathering = 55004,
		Milking = 55005,
		Harvesting = 55006,
		Hoeing = 55007,
		CommerceMastery = 55100,
		TransformationMastery = 56001,

		// GM
		PickupItemGMSkill = 65001,
		SuperWindmillGMSkill = 65002,
		BlockWorldGMSkill = 65003,

	}

	public enum SharpMindStatus : uint
	{
		None = 0,
		Loading = 1,
		Loaded = 2,
		Cancelling = 6
	}

	public enum PlayingQuality
	{
		VeryBad = 0,
		Bad = 1,
		Good = 2,
		VeryGood = 3
	}

	public enum TalentId : byte
	{
		Adventure = 0,
		Warrior = 1,
		Mage = 2,
		Archer = 3,
		Merchant = 4,
		BattleAlchemy = 5,
		Fighter = 6,
		Bard = 7,
		Puppeteer = 8,
		Knight = 9,
		HolyArts = 10,
		Transmutaion = 11,
		Cooking = 12,
		Blacksmith = 13,
		Tailoring = 14,
		Medicine = 15,
		Carpentry = 16,

		None = 255
	}

	public enum TalentLevel : byte
	{
		None = 0,
		Fledgling,
		Novice,
		Amateur,
		Green,
		Naive,
		Apprentice,
		Senior,
		Advanced,
		Seasoned,
		Skilled,
		Expert,
		Great,
		Champion,
		Wise,
		Master,
		Grandmaster,
	}

	public enum TalentTitle : ushort
	{
		Adventure = 10000,
		Warrior = 10100,
		Mage = 10200,
		Archer = 10300,
		Merchant = 10400,
		BattleAlchemy = 10500,
		Fighter = 10600,
		Bard = 10700,
		Puppeteer = 10800,
		Knight = 10900,
		HolyArts = 11000,
		Transmutaion = 11100,
		Cooking = 11200,
		Blacksmith = 11300,
		Tailoring = 11400,
		Medicine = 11500,
		Carpentry = 11600,

		// Hybrid start
		Artisan = 20900,
		Artiste = 24800,
		BattleBard = 22100,
		BattleMage = 21600,
		Bombardier = 21700,
		Bowyer = 22900,
		Brawler = 23800,
		Challenger = 24500,
		Cheerleader = 25000,
		Choirmaster = 21400,
		CostumeDesigner = 28000,
		Doctor = 20800,
		Elementalist = 21800,
		Executioner = 22600,
		FoodFighter = 21500,
		FullAlchemist = 24100,
		Gourmet = 21200,
		Gypsy = 22400,
		Hawker = 24900,
		HolyArcher = 24200,
		HolyKnight = 21900,
		HolyWarrior = 21000,
		HomeEconomist = 21300,
		Idol = 26000,
		IronFist = 24400,
		JoySpreader = 30000,
		KnightErrant = 24300,
		Lumberjack = 24700,
		MagicKnight = 20100,
		Miner = 24600,
		Missionary = 23700,
		Monk = 21100,
		Nutritionist = 23400,
		Peddler = 23300,
		Philosopher = 23500,
		Polymath = 22200,
		Puppetmancer = 27000,
		Ranger = 20200,
		Researcher = 33000,
		Sage = 20700,
		Scholar = 20300,
		Slayer = 20400,
		Spellsword = 20000,
		Striker = 23100,
		ToyMaker = 29000,
		Tracker = 22000,
		Trapper = 32000,
		Troubadour = 23200,
		Trouper = 31000,
		Vagabond = 20600,
		Vanguard = 20500,
	}

	public enum TalentRace : byte
	{
		None = 0,
		Human = 0x1,
		Elf = 0x2,
		Giant = 0x4,

		HumanAndElf = Human | Elf,
		HumanAndGiant = Human | Giant,

		GiantAndElf = Giant | Elf,

		All = Human | Elf | Giant
	}
}
