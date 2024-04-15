namespace ExamenDomino;

/// <summary>
/// Represents a domino tile with two faces.
/// </summary>
public class DominoTile
{
    private readonly int _upperPart;
    private readonly int _buttonPart;
    
    /// <summary>
    /// Gets the value of the top face of the domino tile.
    /// </summary>
    public int UpperPart => _upperPart;
    
    /// <summary>
    /// Gets the value of the bottom face of the domino tile.
    /// </summary>
    public int ButtonPart => _buttonPart;
    
    /// <summary>
    /// Gets a value indicating whether the domino tile is a double (i.e., both ends have the same value).
    /// </summary>
    public bool IsDouble => _upperPart == _buttonPart;
    
    /// <summary>
    /// Initializes a new instance of the <see cref="DominoTile"/> class.
    /// </summary>
    /// <param name="upperPart">The value of the top face of the domino tile.</param>
    /// <param name="buttonPart">The value of the bottom face of the domino tile.</param>
    /// <exception cref="ArgumentException">Thrown when the values of the faces are not between 0 and 6.</exception>
    public DominoTile(int upperPart, int buttonPart)
    {
        if (upperPart < 0 || upperPart > 6 || buttonPart < 0 || buttonPart > 6)
            throw new ArgumentException("Los valores de las caras de la ficha deben estar entre 0 y 6");
        _upperPart = upperPart;
        _buttonPart = buttonPart;
    }
    
}