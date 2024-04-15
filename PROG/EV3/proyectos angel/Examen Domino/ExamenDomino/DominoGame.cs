using System.Diagnostics;

namespace ExamenDomino;

/// <summary>
/// Represents a game of Domino.
/// </summary>
public class DominoGame
{
    private List<Participant> _participants = new();
    private TilesAmount _tilesAmount = new();
    private bool _isStarted;
    private bool _isEnded;
    private int _startValue, _endValue;

    /// <summary>
    /// Gets the start value of the game.
    /// </summary>
    public int StartValue => _startValue;
    
    /// <summary>
    /// Gets the end value of the game.
    /// </summary>
    public int EndValue => _endValue;
    
    /// <summary>
    /// Gets the last tile of the game.
    /// </summary>
    public DominoTile? LastTile => _tilesAmount.Last;

    /// <summary>
    /// Initializes a new instance of the DominoGame class.
    /// </summary>
    public DominoGame()
    {
    }

    /// <summary>
    /// Initializes a new instance of the DominoGame class with a list of participants.
    /// </summary>
    /// <param name="part">The list of participants.</param>
    public DominoGame(List<Participant> part) : this()
    {
        _participants = part;
    }

    
    /// <summary>
    /// Adds a participant to the game.
    /// </summary>
    /// <param name="part">The participant to add.</param>
    public void AddParticipants(Participant part)
    {
        if (part != null && !_isStarted && _participants.Count <= 28 && !_isEnded)
            _participants.Add(part);
    }
    
    /// <summary>
    /// Adds a list of participants to the game.
    /// </summary>
    /// <param name="part">The list of participants to add.</param>
    public void AddParticipants(List<Participant> part)
    {
        if (part != null && !_isStarted && _participants.Count + part.Count <= 28 && !_isEnded)
            _participants.AddRange(part);
    }

    /// <summary>
    /// Removes a participant from the game at the specified index.
    /// </summary>
    /// <param name="index">The index of the participant to remove.</param>
    public void RemoveParticipantsAt(int index)
    {
        var pCount = _participants.Count;
        if (_isStarted || pCount < 1 || index < 0 || index > pCount)
            return;
        _participants.RemoveAt(index);
    }

    
    /// <summary>
    /// Removes a participant from the game.
    /// </summary>
    /// <param name="part">The participant to remove.</param>
    public void RemoveParticipant(Participant part)
    {
        if(part == null)
            return;
        for (int i = 0; i < _participants.Count; i++)
        {
            var p = _participants[i];
            if (part == p && part.Equals(p))
            {
                _participants.RemoveAt(i);
                return;
            }
        }
    }
    
    /// <summary>
    /// Starts the game.
    /// </summary>
    public void StartGame()
    {
        if (_participants.Count < 2 || _isStarted || _isEnded)
            return;
        _tilesAmount.SetDominoTiles();
        _isStarted = true;
    }

    /// <summary>
    /// Distributes the tiles among the participants.
    /// </summary>
    public void DistributeTiles()
    {
        while (_tilesAmount.Count > 0)
        {
            foreach (var p in _participants)
            {
                var f = _tilesAmount.First;
                if (f != null)
                {
                    p.ReceiveTiles(f);
                    _tilesAmount.RemoveTile(f);
                }
            }
        }
    }

    /// <summary>
    /// Plays a round of the game.
    /// </summary>
    public void PlayRound()
    {
        if (!_isStarted || _isEnded) 
            return;
        var missed = 0; 
        for (int i = 0; i < _participants.Count; i++)
        {
            var p = _participants[i];
            var played = p.MakeShift(this);
            missed += played ? 0 : 1;
            if (p.IsEmpty || missed >= _participants.Count)
            {
                EliminateLosingPlayers();
                _tilesAmount.SetDominoTiles();
                _tilesAmount.Shuffle();
                DistributeTiles();
            }
            
        }
    }

    /// <summary>
    /// Simulates a game.
    /// </summary>
    /// <returns>The winner of the game.</returns>
    public Participant? SimulateGame()
    {
        if (_isStarted && !_isEnded)
        {
            _tilesAmount.Shuffle();
            DistributeTiles();
            while (_participants.Count > 1)
                PlayRound();
            _isEnded = true;
            return _participants[0];
        }
        return null;
    }
    
    /// <summary>
    /// Eliminates the losing players from the game.
    /// </summary>
    public void EliminateLosingPlayers()
    {
        foreach (var p in _participants)
        {
            p.CountPoints();
            p.ClearTiles();
        }
        var count = _participants.Count;
        _participants.Sort((p1, p2) => p2.Points.CompareTo(p1.Points));
        if (count > 2 && _participants[0].Points == _participants[1].Points)
        {
            Debug.WriteLine($"Los jugadores {_participants[0].Name} y {_participants[1].Name} han sido eliminados.");
            _participants.RemoveAt(0);
            _participants.RemoveAt(1);
            return;
        }
        if (count > 2 && _participants.Take(count - 1).All(p => p.Points == _participants[0].Points))
        {
            Debug.WriteLine("Todos los jugadores han empatado. Por lo que no se elimina a nadie.");
            return;
        }
        Debug.WriteLine($"El jugador {_participants[0].Name} ha sido eliminado.");
        _participants.RemoveAt(0);
    }
    
    /// <summary>
    /// Adds a tile to the game.
    /// </summary>
    /// <param name="dominoTile">The tile to add.</param>
    public void AddTile(DominoTile dominoTile)
    {
        if (dominoTile == null)
            return;
        _tilesAmount.AddTile(dominoTile);
        if (_tilesAmount.Count == 1)
        {
            _startValue = dominoTile.UpperPart;
            _endValue = dominoTile.ButtonPart;
            return;
        }
        if (dominoTile.UpperPart == _startValue || dominoTile.ButtonPart == _startValue)
            _startValue = dominoTile.UpperPart == _startValue ? dominoTile.ButtonPart : dominoTile.UpperPart;
        else if (dominoTile.UpperPart == _endValue || dominoTile.ButtonPart == _endValue)
            _endValue = dominoTile.UpperPart == _endValue ? dominoTile.ButtonPart : dominoTile.UpperPart;
        else
            throw new Exception("Ficha no jugable");
    }
}