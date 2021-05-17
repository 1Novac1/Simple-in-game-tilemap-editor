using UnityEngine;

public class GrassTile : MonoBehaviour, ITile
{
    public RuleTile Tile { get => TilemapSystem.GrassTile; }

    public bool CanInstantiate()
    {
        if(TilemapSystem.HasTile(TilemapSystem.Tilemap, CursorGridMovement.GetCoordinate()))
        {
            return false;
        }
        return true;
    }
}