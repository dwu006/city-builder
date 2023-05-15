using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealGrid : MonoBehaviour
{
    public GameObject grid_prefab;
    public float start_x;
    public float start_y;
    public float size;

    const float dx = 0.64f;
    const float dy = 0.48f;
    // Start is called before the first frame update
    void Start()
    {
        float bottom_x = start_x;
        float bottom_y = start_y - size * dy * 2;
        for (float row_id = 0; row_id < size * 2 + 1; row_id++) {
            float row = row_id;
            if (row_id > size) {
                row = size * 2 - row;
            }
            float x = start_x - dx * row;
            float y = bottom_y + dy * row_id;
            for (float col = 0; col < row; col++) {
                x += dx * 2;
                Instantiate(grid_prefab, new Vector2(x, y), Quaternion.identity).SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
