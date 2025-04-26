using UnityEngine;

public class LandPlot : MonoBehaviour
{

    public LandTile[][] Grid;
    public int GridSizeX, GridSizeY;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        //Initialize Plot
        Grid = new LandTile[GridSizeX][];
        for (int i = 0; i < GridSizeX; i++) {
            Grid[i] = new LandTile[GridSizeY];
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
