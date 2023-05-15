using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int money;
    public int happiness;
    public int health;

    public TMP_Text moneyDisplay;
    public TMP_Text happinessDisplay;
    public TMP_Text healthDisplay;

    private Building buildingToPlace;
    public GameObject grid;

    public CustomCursor customCursor;

    private void Update() {
        moneyDisplay.text = money.ToString();
        happinessDisplay.text = happiness.ToString();
        healthDisplay.text = health.ToString();
    }
    public void BuyBuilding(Building building) {
        Debug.Log("Something");
        if (money >= building.cost) {
            customCursor.gameObject.SetActive(true);
            customCursor.GetComponent<SpriteRenderer>().sprite = building.GetComponent<SpriteRenderer>().sprite;
            Cursor.visible = false;
            money -= building.cost;
            buildingToPlace = building;
            grid.SetActive(true);
            Debug.Log("Building bought");
        }
    }
}
