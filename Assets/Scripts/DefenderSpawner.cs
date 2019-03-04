using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{

    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        Vector2 clickedPosition = GetSquareClicked();
        SpawnDefender(clickedPosition);
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(clickPosition);
        return worldPosition;
    }

    private void SpawnDefender(Vector2 worldPositionDefender)
    {
        GameObject newDefender = Instantiate(defender, worldPositionDefender, Quaternion.identity) as GameObject;
    }

}
