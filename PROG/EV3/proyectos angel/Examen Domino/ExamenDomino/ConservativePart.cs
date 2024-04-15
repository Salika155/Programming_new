using System.Diagnostics;

namespace ExamenDomino;

/// <summary>
/// Represents a conservative participant in the game.
/// Inherits from the Participant base class.
/// </summary>
public class ConservativePart : Participant
{
    /// <summary>
    /// Performs a round of the game for the conservative participant.
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
        var maxP = GetMaxPlayableTiles(playableTiles);
        dominoGame.AddTile(maxP);
        if (!RemoveTile(maxP))
            throw new Exception("Fallo al eliminar ficha.");
        Debug.WriteLine($"El jugador {Name} conservador ha jugado una ficha.");
        return true;
    }
    
    /// <summary>
    /// Gets the maximum playable domino tile from a list of playable tiles.
    /// </summary>
    /// <param name="playableFichas">List of playable domino tiles.</param>
    /// <returns>The maximum playable domino tile.</returns>
    private DominoTile GetMaxPlayableTiles(List<DominoTile> playableFichas)
    {
        var maxP = playableFichas[0];
        for (int i = 1; i < playableFichas.Count; i++)
        {
            var f = playableFichas[i];
            if (f.UpperPart + f.ButtonPart > maxP.UpperPart + maxP.ButtonPart)
                maxP = f;
        }
        return maxP;
    }
}