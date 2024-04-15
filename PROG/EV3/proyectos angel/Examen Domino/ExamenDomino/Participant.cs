namespace ExamenDomino;

/// <summary>
/// Represents a participant in the game.
/// This is an abstract class and cannot be instantiated directly.
/// </summary>
public abstract class Participant
{
    private List<DominoTile> _tiles = new();
    
    /// <summary>
    /// Gets the count of domino tiles the participant has.
    /// </summary>
    public int Count => _tiles.Count;
    
    /// <summary>
    /// Gets a value indicating whether the participant has no domino tiles.
    /// </summary>
    public bool IsEmpty => _tiles.Count == 0;
    
    /// <summary>
    /// Gets or sets the name of the participant.
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    /// Gets or sets the points of the participant.
    /// </summary>
    public int Points { get; set; }

    
    /// <summary>
    /// Adds a domino tile to the participant's list.
    /// </summary>
    /// <param name="dominoTile">The domino tile to add.</param>
    public void ReceiveTiles(DominoTile dominoTile)
    {
        if (dominoTile != null)
            _tiles.Add(dominoTile);
    }

    /// <summary>
    /// Counts the points of the participant based on the domino tiles they have.
    /// </summary>
    public void CountPoints()
    {
        if (_tiles.Count == 0)
            return;
        Points = 0;
        foreach (var f in _tiles)
            Points += f.UpperPart + f.ButtonPart;
    }

    /// <summary>
    /// Gets a list of domino tiles from the participant's list that can be played.
    /// </summary>
    /// <param name="startValue">The value of the start tile of the game.</param>
    /// <param name="endValue">The value of the end tile of the game.</param>
    /// <returns>A list of playable domino tiles.</returns>
    public List<DominoTile> GetPlayableTiles(int startValue, int endValue)
    {
        return _tiles.FindAll(
            f => f.UpperPart == startValue 
                 || f.UpperPart == endValue 
                 || f.ButtonPart == startValue 
                 || f.ButtonPart == endValue);
    }
    
    /// <summary>
    /// Removes the specified domino tile from the participant's list.
    /// </summary>
    /// <param name="dominoTile">The domino tile to remove.</param>
    /// <returns>True if the domino tile was found and removed; otherwise, false.</returns>
    public bool RemoveTile(DominoTile dominoTile)
    {
        if (dominoTile == null) 
            return false;
        for (int i = 0; i < _tiles.Count; i++)
        {
            var f = _tiles[i];
            if (f.UpperPart == dominoTile.UpperPart && f.ButtonPart == dominoTile.ButtonPart)
            {
                _tiles.RemoveAt(i);
                return true;
            }
        }
        return false;
    }
    
    /// <summary>
    /// Removes all domino tiles from the participant's list.
    /// </summary>
    public void ClearTiles()
    {
        _tiles.Clear();
    }
    
    /// <summary>
    /// Performs a shift in the game for the participant.
    /// This is an abstract method and must be implemented in any class that directly inherits from Participant.
    /// </summary>
    /// <param name="dominoGame">The current state of the game.</param>
    /// <returns>True if the shift was successful, false in case of the Participant don't do any shift.</returns>
    public abstract bool MakeShift(DominoGame dominoGame);
}