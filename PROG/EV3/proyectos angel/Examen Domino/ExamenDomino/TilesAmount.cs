namespace ExamenDomino;

/// <summary>
/// Represents a list of domino tiles.
/// </summary>
public class TilesAmount
{
    private List<DominoTile> _amount = new();

    /// <summary>
    /// Gets the count of domino tiles in the list.
    /// </summary>
    public int Count => _amount.Count;
    
    /// <summary>
    /// Gets the first domino tile in the list, or null if the list is empty.
    /// </summary>
    public DominoTile? First => _amount.Count > 0 ? _amount[0] : null;
    
    /// <summary>
    /// Gets the last domino tile in the list, or null if the list is empty.
    /// </summary>
    public DominoTile? Last => _amount.Count > 0 ? _amount[^1] : null;
    
    /// <summary>
    /// Gets the domino tile at the specified index.
    /// </summary>
    /// <param name="index">The index of the domino tile to get.</param>
    /// <returns>The domino tile at the specified index, or null if the index is out of range.</returns>
    public DominoTile? GetTileAt(int index)
    {
        if (index < 0 || index >= _amount.Count)
            return null;
        return _amount[index];
    }
    
    /// <summary>
    /// Removes the domino tile at the specified index.
    /// </summary>
    /// <param name="index">The index of the domino tile to remove.</param>
    public void RemoveTileAt(int index)
    {
        if (index < 0 || index >= _amount.Count)
            return;
        _amount.RemoveAt(index);
    }
    
    /// <summary>
    /// Adds a domino tile to the list.
    /// </summary>
    /// <param name="dominoTile">The domino tile to add.</param>
    public void AddTile(DominoTile dominoTile)
    {
        if(dominoTile != null)
            _amount.Add(dominoTile);
    }

    /// <summary>
    /// Gets the index of the specified domino tile in the list.
    /// </summary>
    /// <param name="dominoTile">The domino tile to locate in the list.</param>
    /// <returns>The index of the domino tile if found in the list; otherwise, -1.</returns>
    public int IndexOf(DominoTile dominoTile)
    {
        if (dominoTile == null)
            return -1;
        for (int i = 0; i < _amount.Count; i++)
        {
            if (_amount[i].UpperPart == dominoTile.UpperPart && _amount[i].ButtonPart == dominoTile.ButtonPart)
                return i;
        }
        return -1;
    }
    
    /// <summary>
    /// Removes the first occurrence of the specified domino tile from the list.
    /// </summary>
    /// <param name="dominoTile">The domino tile to remove from the list.</param>
    public void RemoveTile(DominoTile dominoTile)
    {
        if (dominoTile == null)
            return;
        RemoveTileAt(IndexOf(dominoTile));
    }
    
    /// <summary>
    /// Shuffles the order of the domino tiles in the list.
    /// </summary>
    public void Shuffle()
    {
        Random random = new();
        for (int i = 0; i < _amount.Count; i++)
        {
            int r = random.Next(_amount.Count);
            var temp = _amount[i];
            _amount[i] = _amount[r];
            _amount[r] = temp;
        }
    }
    
    /// <summary>
    /// Removes all domino tiles from the list.
    /// </summary>
    public void Clear()
    {
        _amount.Clear();
    }
    
    /// <summary>
    /// Sets the list to contain all possible domino tiles.
    /// </summary>
    public void SetDominoTiles()
    {
        _amount.Clear();
        for (int i = 0; i <= 6; i++)
        {
            for (int j = i; j <= 6; j++)
                _amount.Add(new DominoTile(i, j));
        }
    }
}