using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGrid : MonoBehaviour
{
    public GameObject grid_prefab;
    public float start_x;
    public float start_y;
    public float size;
    // Start is called before the first frame update
    void Start()
    {
        for (float row = 0; row <= size*2-1; row++) {
            float y = start_y - 0.48f * row;
            if (row < size) {
                float x = start_x - 0.64f * row;
                for (float i = 0; i < row; i++) {
                    x += 1.28f;
                    Instantiate(grid_prefab, new Vector2(x, y), Quaternion.identity).SetActive(true);
                }
            } else {
                float x = start_x - 0.64f * (size*2-row);
                for (float i = 0; i < (size*2-row); i++) {
                    x += 1.28f;
                    Instantiate(grid_prefab, new Vector2(x,y), Quaternion.identity).SetActive(true);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
