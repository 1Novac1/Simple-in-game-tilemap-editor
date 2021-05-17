using UnityEngine;

public interface ITile
{
    public RuleTile Tile { get; }
    public bool CanInstantiate();
}
