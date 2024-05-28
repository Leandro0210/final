namespace TestDemo;

public static class Fisica { 
    public static float Fuerza(float masa, float aceleracion)
        {
            return masa * aceleracion;
        }

        public static float Trabajo(float fuerza, float distancia)
        {
            return fuerza * distancia;
        }

        public static float EnergiaC(float masa, float velocidad, float dato)
        {
            return dato * masa * velocidad * velocidad;
        }
    }


