using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
	public List<Item> Items; // Список предметов
	public GameObject InventoryUI; // UI инвентаря
	public List<Image> ItemSlots; // Список слотов для изображений предметов

	void Start()
	{
		InventoryUI.SetActive(false);
	}

	void Update()
	{
		// Переключение UI инвентаря
		if (Input.GetKeyDown(KeyCode.Q)) {
			InventoryUI.SetActive(!InventoryUI.activeSelf);
		}

		// Обновление UI инвентаря
		if (InventoryUI.activeSelf) {
			for (int i = 0; i < ItemSlots.Count; i++) {
				if (i < Items.Count) {
					ItemSlots[i].sprite = Items[i].IMG;
					ItemSlots[i].enabled = true; // Включаем отображение слота
				} else {
					ItemSlots[i].enabled = false; // Выключаем отображение слота, если в нем нет предмета
				}
			}
		}
	}

	// Метод для добавления предмета в инвентарь
	public void Add(Item item)
	{
		if (!Items.Contains(item)) {
			Items.Add(item);
			// Обновление UI можно добавить здесь, если необходимо мгновенное обновление после добавления предмета
		}
	}

	// Поиск предмета по ID
	public Item FindItem(int id)
	{
		return Items.Find(item => item.ID == id);
	}

	// Поиск предмета по имени
	public Item FindItem(string name)
	{
		return Items.Find(item => item.Name == name);
	}
}
