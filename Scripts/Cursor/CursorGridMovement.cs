using UnityEngine;

public static class CursorGridMovement
{
    public static Vector3Int GetCoordinate() 
    {
        Vector3 _mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3Int _coordinate = TilemapSystem.Grid.WorldToCell(_mouseWorldPosition);

        return _coordinate;
    }

    public static Vector2 Move()
    {
        float _x = Mathf.RoundToInt(GetCoordinate().x);
        float _y = Mathf.RoundToInt(GetCoordinate().y);

        return new Vector2(_x + 0.5f, _y + 0.5f);
    }
}
