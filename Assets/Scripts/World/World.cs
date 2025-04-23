using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class World : MonoBehaviour
{
    [SerializeField] private int MaxXCoordinate;
    [SerializeField] private int MaxYCoordinate;
    [SerializeField] private int MinXCoordinate;
    [SerializeField] private int MinYCoordinate;
    [SerializeField] public LandTile[][] WorldMap;
    private Vector2 GridOffset;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Initialize Array
        WorldMap = new LandTile[WorldWidth()][];
        for (int i = 0; i < WorldMap.Length; i++){
            WorldMap[i] = new LandTile[WorldHeight()];
        }
        GridOffset = new Vector2(x: 0-MinXCoordinate, y: 0-MinYCoordinate);

        Debug.Log("-100, -100"+WorldToGridCoordinates(new Vector2(-100,-100)));
        Debug.Log("99, 99"+WorldToGridCoordinates(new Vector2(99,99)));
        Debug.Log("0, 0"+WorldToGridCoordinates(new Vector2(0,0)));
        Debug.Log("World Size: "+WorldWidth()+"x"+WorldHeight());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int WorldWidth() {
        return MaxXCoordinate - MinXCoordinate;
    }

    private int WorldHeight() {
        return MaxYCoordinate - MinYCoordinate;
    }

    public Vector2 WorldToGridCoordinates(Vector2 coord){
        return coord - GridOffset;
    }

    public Vector2 GridToWorldCoordinates(Vector2 coord){
        return coord + GridOffset;
    }
}
