using System;
using System.Collections.Generic;

namespace Tentod
{
    //encapsulamento na classe Inventory
    //para fácil consumo de métodos que
    //escondem a implementação para o usuário
    public class Inventory
    {
        private ItemType inventoryType;
        private List<Item> items = new List<Item>();
        private int maxWeight;

        public Inventory(ItemType inventoryType, int maxWeight)
        {
            this.inventoryType = inventoryType;
            this.maxWeight = maxWeight;
        }

        public List<Item> GetInventory()
        {
            return items;
        }

        public void ListInventory()
        {
            if (items.Count != 0)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i} - {items[i].GetName()}");
                }
            } 
            else
            {
                Console.WriteLine($"Teu inventório de {inventoryType} está vazio!");
            }
        }

        public Item GetItemAt(int index)
        {
            return items[index];
        }

        public int InventoryWeight()
        {
            int sum = 0;
            foreach (var i in items)
            {
                sum += i.GetWeight();
            }
            return sum;
        }

        public void AddItem(Item item)
        {
            //cada inventório é utilizado para apenas uma categoria de item
            if (item.GetItemType() == this.inventoryType)
            {
                if (InventoryWeight() + item.GetWeight() < maxWeight)
                {
                    items.Add(item);
                }
            } 
            else 
            {
                Console.WriteLine($"Você não pode adicionar um {item.GetItemType().ToString()} num inventório de {this.inventoryType.ToString()}!");
            }
        }

        public void RemoveItem(int index)
        {
            items.RemoveAt(index);
        }
    }
}
