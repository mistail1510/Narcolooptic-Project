using UnityEngine;
using UnityEngine.UIElements;

public class InventoryWheel : MonoBehaviour
{
   [SerializeField] private GameData _gameData;
   
   public void SetupInventory()
   {
      for (var i = 0; _gameData.inventory.Count > i; i++)
      {
         transform.GetChild(i).GetChild(0).GetComponent<Image>().sprite = _gameData.inventory[i].objImage;
      }
   }
}
