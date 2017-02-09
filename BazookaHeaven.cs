public void onPressedLeft(TriggerArgs args) {
	IPlayer player = (IPlayer)args.Sender;
	Vector2 newLoc = new Vector2(-300, -210);
	player.SetWorldPosition(newLoc);
	player.RemoveWeaponItemType(WeaponItemType.Rifle);
	player.GiveWeaponItem(WeaponItem.GRENADES);
}

public void onPressedRight(TriggerArgs args) {
	IPlayer player = (IPlayer)args.Sender;
	Vector2 newLoc = new Vector2(300, -210);
	player.SetWorldPosition(newLoc);
	player.RemoveWeaponItemType(WeaponItemType.Rifle);
	player.GiveWeaponItem(WeaponItem.GRENADES);
}
