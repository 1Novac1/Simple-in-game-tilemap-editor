using UnityEngine;

public class WaterTile : MonoBehaviour, ITile
{
    public RuleTile Tile { get => TilemapSystem.WaterTile; }

    public bool CanInstantiate()
    {
        if(TilemapSystem.HasTile(TilemapSystem.Tilemap, CursorGridMovement.GetCoordinate()))
        {
            return false;
        }
        return true;
    }
}