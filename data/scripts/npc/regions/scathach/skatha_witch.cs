using Common.Constants;
using Common.Events;
using Common.World;
using System;
using World.Network;
using World.Scripting;
using World.World;

public class Skatha_witchScript : NPCScript
{
	public override void OnLoad()
	{
		base.OnLoad();
		SetName("_skatha_witch");
		SetRace(10001);
		SetBody(height: 0.9999999f, fat: 1f, upper: 1f, lower: 1f);
		SetFace(skin: 15, eye: 163, eyeColor: 38, lip: 48);

		NPC.ColorA = 0x808080;
		NPC.ColorB = 0x808080;
		NPC.ColorC = 0x808080;		

		EquipItem(Pocket.Face, 0xF54, 0x36FA9, 0x8C96CB, 0x704E50);
		EquipItem(Pocket.Hair, 0xC3F, 0xECE6DC, 0xECE6DC, 0xECE6DC);
		EquipItem(Pocket.Armor, 0x3E2F, 0x808080, 0x808080, 0x808080);
		EquipItem(Pocket.Head, 0x48F4, 0x808080, 0x808080, 0x808080);

		SetLocation(region: 4015, x: 32951, y: 40325);

		SetDirection(194);
        
        ServerEvents.Instance.ErinnDaytimeTick += On12HrTick;
        
		SetStand("chapter4/human/female/anim/female_c4_npc_skatha_stand");
        
        Phrases.Add("Don't come any closer!");
        Phrases.Add("Perhaps I should just kill her.");
        Phrases.Add("What a fool...");
        Phrases.Add("What do you want, whelp?");
        Phrases.Add("You'll pay for this, Manannan...");

	}
    public override void Dispose()
	{
		ServerEvents.Instance.ErinnDaytimeTick -= On12HrTick;
		base.Dispose();
	}

	private void On12HrTick(object sender, TimeEventArgs e)
	{
		if (e.Hour >= 6 && e.Hour < 18) //Daytime
			Warp(region: 4015, x: 32951, y: 40325, flash: false);
		else
			Warp(region: 15, x: 100, y: 0, flash: false);
	}
}