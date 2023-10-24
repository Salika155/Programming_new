namespace Classes
{
    public enum State
    {
        esperando,
        procesando_moneda,
        retirando_producto,
        devolviendo_cambio
    }

    public class CoffeeMachine
    {

        private State _state = State.esperando;

        public State GetState()
        {
            return _state;
        }
        public void ChangeToNextState()
        {
            if (_state < State.devolviendo_cambio) {
                _state++;
            } else if (_state == State.devolviendo_cambio)
            {
                _state = State.esperando;
            }
            
        }
    }
}
