using System.Reflection.Metadata.Ecma335;

namespace Classes
{
    public enum CoinValor
    {
        //C500 = 50000
        UNKNOWN
        C500,
        C200,
        C100,
        C50,
        C20,
        C10,
        C5,
        C2,
        C1,
        C05,
        C02,
        C01,
        C005,
        C002,
        C001
    }

    //resultado 34.15
    //[20, 10, 2, 2, 0.1, 0.5]
    public class CoinChange
    {
        //private static int[] __monedaValue = { 10000, 10000, 1000 };
        private CoinValor coinValor;

        //constructor estatico para acceder a la clase static de characterclass -> que esta predefinida en el programa, y no en la clase creada
        //existen elementos dentro del objeto que estan dentro de este, y otros que no pertenecen a este sino a la clase $CharacterClass = new -> que esta predefinida.
        //static CoinChange()
        //{
        //    _monedaValue = new int[] { 10000, 1000, 100 };
        //}

        //posibilidad de hacer estas dos funciones con diccionario
        public static Dictionary<int, CoinValor> _diccionario = new Dictionary<int, CoinValor>();


        //static CoinChange()
        //{
        //    _diccionario.Add(10000, Moneda.C100);
        //    _diccionario.Add(1000, Moneda.C10);
        //}

        //+ToNumber(coin:moneda):int

        public static int ToNumber(CoinValor coinValor) //son en centimos
        {
            //return _monedaValue[(int)moneda];

            //return(int)moneda; -> solucion 1
            if (coinValor == CoinValor.C500)
                return 50000;
            if (coinValor == CoinValor.C200)
                return 20000;
            if (coinValor == CoinValor.C100)
                return 10000;
            if (coinValor == CoinValor.C50)
                return 5000;
            if (coinValor == CoinValor.C20)
                return 2000;
            if (coinValor == CoinValor.C10)
                return 1000;
            if (coinValor == CoinValor.C5)
                return 500;
            if (coinValor == CoinValor.C2)
                return 200;
            if (coinValor == CoinValor.C1)
                return 100;
            if (coinValor == CoinValor.C05)
                return 50;
            if (coinValor == CoinValor.C02)
                return 20;
            if (coinValor == CoinValor.C01)
                return 10;
            if (coinValor == CoinValor.C005)
                return 5;
            if (coinValor == CoinValor.C002)
                return 2;
            if (coinValor == CoinValor.C001)
                return 1;
            return 0;



        }

        //+ToMoneda(centims:int):Moneda
        //+ToMoneda(centims: int): CoinValor
        public static CoinValor ToMoneda(int centimos)
        {
        //return (CoinValor)centimos; -> solucion basica
            if (centimos == 50000)
                return CoinValor.C500;
            else if (centimos == 20000)
                return CoinValor.C200;
            else if (centimos == 10000)
                return CoinValor.C100;
            else if (centimos == 5000)
                return CoinValor.C50;
            else if (centimos == 2000)
                return CoinValor.C20;
            else if (centimos == 1000)
                return CoinValor.C10;
            else if (centimos == 500)
                return CoinValor.C5;
            else if (centimos == 200)
                return CoinValor.C2;
            else if (centimos == 100)
                return CoinValor.C1;
            else if (centimos == 50)
                return CoinValor.C05;
            else if (centimos == 20)
                return CoinValor.C02;
            else if (centimos == 10)
                return CoinValor.C01;
            else if (centimos == 5)
                return CoinValor.C005;
            else if (centimos == 2)
                return CoinValor.C002;
            else if (centimos == 1)
                return CoinValor.C001;
            else
                return 0; // Retorna la denominación más pequeña por defecto si no hay coincidencia.

            //CoinValor result;
            //if (_diccionario.TryGetValue(centims, out result) == false -> PARAMETROS DE SALIDA 
                //return CoinValor.UNKNOWN;
            //return result;
        }

        //+GetCoins(centims:int):List<Moneda>
        //hacer la lista para ir añadiendo conforme divides el numero por los billetes o monedas que necesites, e ir añadiendolos a la lista

        public static List<CoinValor> GetCoin(int centims)
        {
            List<CoinValor> result = new List<CoinValor>();

            while (centims > 0)
            {
                CoinValor moneda = CoinValor.UNKNOWN;

                if (centims >= ToNumber(CoinValor.C500))
                    moneda = CoinValor.C500;
                else if (centims >= ToNumber(CoinValor.C50))
                    moneda = CoinValor.C50;

                result.Add(moneda);
                centims -= ToNumber(moneda);
            }

            return result;
        }

    }
}
