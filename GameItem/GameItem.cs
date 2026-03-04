using System;
using System.Collections.Generic;
using System.Text;

class Item
{
    public string Name;
    public int Price;
    public Item(string name, int price)
    {
        Name = name;
        Price = price;
    }
    public override string ToString()
    {
        return "아이템 정보 출력";
    }
}
class Weapon : Item
{
    public int Damage;
    public Weapon(string name, int price, int damage) : base(name, price)
    {
        Damage = damage;
    }
    public override string ToString()
    {
        return $"Weapon {{ Name = {Name} Price = {Price}, Damage = {Damage} }} [Weapon]";
    }
}

class Potion : Item
{
    public int HealthAmount;
    public Potion(string name, int price, int healthamount) : base(name, price)
    {
        HealthAmount = healthamount;
    }
    public override string ToString()
    {
        return $"Potion {{ Name = {Name} Price = {Price}, HealAmount = {HealthAmount} }} [Potion]";
    }
}

class Inventory
{
    public object[] objects = new object[10];
    int count = 0;
    public void AddItem(object item)
    {
        if (count < 10)
        {
            objects[count] = item;
            count++;
        }
        else
        {
            Console.WriteLine("인벤토리가 가득 찼습니다");
        }
    }
    public void ShowInventory()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i] != null)
            {
                Console.Write($"슬롯 {count}: ");
                Console.WriteLine(objects[i].ToString());
            }
        }
    }
}