namespace Classes
{
    public enum CoffeeMachineState
    {
        Esperando,
        Procesando_Moneda,
        Retirando_Producto,
        Devolviendo_Cambio,
    }

    class CoffeeMachine
    {
        private CoffeeMachineState _state;

        public CoffeeMachine()
        {
            _state = CoffeeMachineState.Esperando;
        }

        public CoffeeMachineState GetState()
        {
            return _state;
        }

        public void ChangeToNextState()
        {
            if (_state == CoffeeMachineState.Esperando)
                _state = CoffeeMachineState.Procesando_Moneda;
            else if (_state == CoffeeMachineState.Procesando_Moneda)
                _state = CoffeeMachineState.Retirando_Producto;
            else if (_state == CoffeeMachineState.Retirando_Producto)
                _state = CoffeeMachineState.Devolviendo_Cambio;
            else
                _state = CoffeeMachineState.Esperando;
        }
    }
}
