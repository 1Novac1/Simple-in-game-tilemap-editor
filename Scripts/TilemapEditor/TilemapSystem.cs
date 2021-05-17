using UnityEngine;
using UnityEngine.Tilemaps;

public static class TilemapSystem
{
    public static Grid Grid { get; set; }

    public static Tilemap Tilemap { get; set; }

    public static RuleTile GrassTile { get; private set; }
    public static RuleTile WaterTile { get; private set; }

    public static void Initialize()
    {
        Tilemap = GameObject.FindObjectOfType<Tilemap>();
        Grid = GameObject.FindObjectOfType<Grid>();
        GrassTile = Resources.Load<RuleTile>(Constants.GroundRuleTileName);
        WaterTile = Resources.Load<RuleTile>(Constants.WaterRuleTileName);
    }

    public static bool HasTile(Tilemap tilemap, Vector3Int cellWorldPos)
    {
        return tilemap.HasTile(tilemap.WorldToCell(cellWorldPos));
    }
}
