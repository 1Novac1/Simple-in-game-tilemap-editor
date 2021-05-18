using UnityEngine;
using UnityEngine.EventSystems;

public class TilemapEditor : MonoBehaviour
{
    private GameObject flyingTile;
    private ITile Tile;

    private void Awake()
    {
        TilemapSystem.Initialize();
    }

    public void InstantiateTile(GameObject tile)
    {
        if (flyingTile != null)
        {
            Destroy(flyingTile.gameObject);
            return;
        }

        flyingTile = Instantiate(tile.gameObject);
        if (flyingTile.GetComponent<ITile>() is ITile _tile)
        {
            Tile = _tile;
        }
        else
        {
            Destroy(flyingTile.gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            TilemapSystem.Tilemap.SetTile(CursorGridMovement.GetCoordinate(), null);
        }

        if (flyingTile != null)
        {
            flyingTile.transform.position = CursorGridMovement.Move();
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (Tile.CanInstantiate())
                    {
                        TilemapSystem.Tilemap.SetTile(CursorGridMovement.GetCoordinate(), Tile.Tile);
                    }
                }
            }
        }
    }
}
