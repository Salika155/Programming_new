using System.Diagnostics;

namespace ExamenDomino;
/// <summary>
/// Represents an impulsive participant in the game.
/// Inherits from the Participant base class.
/// </summary>
public class ImpulsivePart : Participant
{
    /// <summary>
    /// Performs a round of the game for the impulsive participant.
    /// </summary>
    /// <param name="dominoGame">The current state of the game.</param>
    /// <returns>True if the round was successful, false otherwise.</returns>
    public override bool MakeShift(DominoGame dominoGame)
    {
        if (dominoGame == null)
            return false;
        var startValue = dominoGame.StartValue;
        var endValue = dominoGame.EndValue;
        var playableTiles = GetPlayableTiles(startValue, endValue);
        if (playableTiles.Count <= 0)
        {
            Debug.WriteLine($"Participante {Name} no ha hecho ninguna jugada.");
            return false;
        }
        var maxP = GetMaxPlayableDoubleTiles(playableTiles);
        dominoGame.AddTile(maxP);
        if (!RemoveTile(maxP))
            throw new Exception("Fallo al eliminar ficha.");
        Debug.WriteLine($"El jugador {Name} impulsivo ha jugado una ficha.");
        return true;
    }
    
    /// <summary>
    /// Gets the maximum playable domino tile from a list of playable tiles giving priority to doubles.
    /// </summary>
    /// <param name="playableTiles">List of playable domino tiles.</param>
    /// <returns>The maximum playable double domino tile otherwise the maximum domino tile.</returns>
    private DominoTile GetMaxPlayableDoubleTiles(List<DominoTile> playableTiles)
    {
        var maxP = playableTiles[0];
        for (int i = 1; i < playableTiles.Count; i++)
        {
            var f = playableTiles[i];
            if (f.IsDouble && !maxP.IsDouble)
            {
                maxP = f;
                continue;
            }
            if (f.IsDouble && maxP.IsDouble)
            {
                if (f.UpperPart + f.ButtonPart > maxP.UpperPart + maxP.ButtonPart)
                    maxP = f;
            }
        }
        return maxP;
    }
}