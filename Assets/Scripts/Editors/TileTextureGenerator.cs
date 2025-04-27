using UnityEngine;
using UnityEditor;
using System.IO;

//This is a tool that will generate a pallet of colored tiles.
//Each tile will be 64x64, and the pallet can be edited by adding
//to or removing from colorList. Soon I will create a color list
//for the tiles I want for this project. These will mostly become
//the "Ground" for the project.



public class DistinctTileTextureGenerator
{
    [MenuItem("Tools/Generate Distinct Tile Grid PNG")]
    public static void GenerateTileTextureGrid()
    {
        // Define a list of visually distinct colors
        Color[] colorList = new Color[]
        {
            FluxColor.theVoid,
            FluxColor.earth,
            FluxColor.wind,
            FluxColor.water,
            FluxColor.fire, 
            FluxColor.nature, 
            FluxColor.forest, 
            FluxColor.life, 
            FluxColor.death, 
            FluxColor.between, 
            FluxColor.space, 
            FluxColor.spirit, 
            FluxColor.nullAffinity,
            FluxColor.plains,
            FluxColor.desert, 
            FluxColor.ocean, 
            FluxColor.lake,
            FluxColor.poison,
            FluxColor.chaos,
            //These might be useful, I will trim them down more later.
            Color.green,
            Color.blue,
            Color.yellow,
            Color.magenta,
            Color.cyan,
            Color.gray,
            Color.black,
            Color.white,
            new Color(1f, 0.5f, 0f),      // orange
            new Color(0.5f, 0f, 1f),      // purple
            new Color(0.5f, 1f, 0f),      // lime
            new Color(1f, 0f, 0.5f),      // rose
            new Color(0f, 0.5f, 1f),      // sky blue
            new Color(0.5f, 0.5f, 0f),    // olive
            new Color(0f, 0.5f, 0.5f),    // teal
            new Color(0.5f, 0f, 0.5f),    // maroon
            new Color(0.75f, 0.75f, 0.75f), // light gray
            new Color(0.25f, 0.25f, 0.25f), // dark gray
            new Color(1f, 0.75f, 0.8f),   // pink
            new Color(0.9f, 0.4f, 0.1f),  // rust
            new Color(0f, 0.8f, 0.6f),    // aqua green
            new Color(0.3f, 0.2f, 0.5f),  // indigo
            new Color(0.6f, 0.8f, 0.2f),  // chartreuse
            new Color(0.2f, 0.6f, 0.3f),  // forest green
            new Color(0.7f, 0.2f, 0.3f),  // cranberry
            new Color(0.9f, 0.6f, 0.2f),  // gold
        };

        int tileSize = 64;
        int columns = 16;
        int rows = 0;
        while (rows * columns < colorList.Length) {
            rows++;
        }
        int totalTiles = rows * columns;
        int width = tileSize * columns;
        int height = tileSize * rows;

        Texture2D texture = new Texture2D(width, height, TextureFormat.RGBA32, false);


        // Shuffle the color array
        System.Random rng = new System.Random();
        //Color[] shuffledColors = colorList.OrderBy(c => rng.Next()).ToArray();
        Color[] ourColors = colorList;
        // Expand if there are more tiles than distinct colors
        while (ourColors.Length < totalTiles)
        {
            //ourColors = ourColors.Concat(colorList.OrderBy(c => rng.Next())).ToArray();
            ourColors = FluxColor.AppendColor(ourColors, Color.black);
        }

        // Fill each tile with its own unique, distinct color
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                int tileIndex = row * columns + col;
                //Color color = shuffledColors[tileIndex];
                Color color = ourColors[tileIndex];

                int startX = col * tileSize;
                int startY = row * tileSize;

                for (int x = 0; x < tileSize; x++)
                {
                    for (int y = 0; y < tileSize; y++)
                    {
                        texture.SetPixel(startX + x, startY + y, color);
                    }
                }
            }
        }

        texture.Apply();

        // Save the texture to the selected folder in the Project view
        string assetPath = "Assets"; //GetSelectedPathOrFallback();
        string fileName = "DistinctTileGrid.png";
        string relativePath = Path.Combine(assetPath, fileName);
        string absolutePath = Path.Combine(Application.dataPath.Substring(0, Application.dataPath.Length - 6), relativePath);

        File.WriteAllBytes(absolutePath, texture.EncodeToPNG());
        Debug.Log($"Saved PNG to: {relativePath}");
        AssetDatabase.Refresh();
    }

    
}


