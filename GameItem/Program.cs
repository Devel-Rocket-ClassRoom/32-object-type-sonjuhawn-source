using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("=== 인벤토리 시스템 테스트 ===");
Inventory inventory = new Inventory();
Weapon weapon1 = new Weapon("불꽃 검", 500, 25);
Weapon weapon2 = new Weapon("얼음 활", 450, 20);
Potion potion1 = new Potion("체력 물약", 50, 100);
Potion potion2 = new Potion("마나 물약", 80, 50);

inventory.AddItem(weapon1);
inventory.AddItem(weapon2);
inventory.AddItem(potion1);
inventory.AddItem(potion2);
inventory.ShowInventory();

Console.WriteLine("=== 타입 확인 테스트 ===");
Console.WriteLine($"sword의 타입: {weapon1.GetType()}");
Console.WriteLine($"sword.GetType() == typeof(Weapon): {weapon1.GetType() == typeof(Weapon)}");
Console.WriteLine($"sword.GetType() == typeof(Item): {weapon1.GetType() == typeof(Item)}");
Console.WriteLine($"sword is Item: {weapon1 is Item}");

