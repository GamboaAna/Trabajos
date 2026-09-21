using System;

class Program
{
    //Crea el tablero
    static void Main()
    {
        char[,] tablero = new char[8, 8];

        for (int f = 0; f < 8; f++)
            for (int c = 0; c < 8; c++)
                tablero[f, c] = '.';

        for (int f = 0; f < 3; f++)
            for (int c = 0; c < 8; c++)
                if ((f + c) % 2 == 1) tablero[f, c] = 'x';

        for (int f = 5; f < 8; f++)
            for (int c = 0; c < 8; c++)
                if ((f + c) % 2 == 1) tablero[f, c] = 'o';

        string[] historial = new string[200];
        int totalMovimientos = 0;

        char turno = 'x';
        int fichasX = 12;
        int fichasO = 12;

        // Variables para manejar la captura múltiple en cadena
        bool debeSeguirCapturando = false;
        int filaObligada = -1;
        int colObligada = -1;

        //Verifica el ganadorjej
        while (true)
        {
            Imprimir(tablero);
            Console.WriteLine("Fichas x: " + fichasX + "   Fichas o: " + fichasO);

            if (fichasX == 0)
            {
                Console.WriteLine("¡Gana el jugador 'o' :DDDDD!");
                break;
            }
            if (fichasO == 0)
            {
                Console.WriteLine("¡Gana el jugador 'x' :DDDDD!");
                break;
            }

            bool hayCapturaObligatoria = HayCapturaDisponible(tablero, turno);

            Console.WriteLine("Turno del jugador: " + turno);

            if (debeSeguirCapturando)
            {
                Console.WriteLine("Debes seguir capturando con la ficha en (" + filaObligada + "," + colObligada + ")");
            }
            else if (hayCapturaObligatoria)
            {
                Console.WriteLine("Hay una captura disponible: es obligatorio comer.");
            }

            Console.Write("Escribe 'historial' para ver jugadas, o presiona ENTER para mover: ");
            string opcion = Console.ReadLine();

            if (opcion.Trim().ToLower() == "historial")
            {
                Console.WriteLine("\n--- Historial ---");
                for (int i = 0; i < totalMovimientos; i++)
                    Console.WriteLine(historial[i]);
                Console.WriteLine("-----------------\n");
                continue;
            }

            Console.Write("Fila origen: ");
            int fo = int.Parse(Console.ReadLine());
            Console.Write("Columna origen: ");
            int co = int.Parse(Console.ReadLine());
            Console.Write("Fila destino: ");
            int fd = int.Parse(Console.ReadLine());
            Console.Write("Columna destino: ");
            int cd = int.Parse(Console.ReadLine());

            if (fo < 0 || fo > 7 || co < 0 || co > 7 || fd < 0 || fd > 7 || cd < 0 || cd > 7)
            {
                Console.WriteLine("Movimiento inválido: fuera del tablero D:");
                continue;
            }

            char pieza = tablero[fo, co];

            if (pieza == '.' || Tipo(pieza) != turno)
            {
                Console.WriteLine("Movimiento inválido: ahí no tienes una ficha tuya D:");
                continue;
            }

            // Si venimos de una captura en cadena, solo se puede mover esa misma ficha
            if (debeSeguirCapturando && (fo != filaObligada || co != colObligada))
            {
                Console.WriteLine("Movimiento inválido: debes seguir capturando con la misma ficha D:");
                continue;
            }

            bool esRey = EsRey(pieza);

            bool direccionValida;
            if (esRey)
                direccionValida = true; // los reyes se mueven en cualquier dirección
            else if (turno == 'x')
                direccionValida = (fd > fo);
            else
                direccionValida = (fd < fo);

            if (!direccionValida)
            {
                Console.WriteLine("Movimiento invalido: esa ficha no puede moverse hacia atras lol");
                continue;
            }

            bool esIntentoDeCaptura = Math.Abs(fd - fo) == 2 && Math.Abs(cd - co) == 2;

            // Si hay captura obligatoria en el tablero, no se permite mover sin comer
            if (hayCapturaObligatoria && !esIntentoDeCaptura)
            {
                Console.WriteLine("Movimiento inválido: es obligatorio capturar D:");
                continue;
            }

            if (tablero[fd, cd] == '.' && Math.Abs(fd - fo) == 1 && Math.Abs(cd - co) == 1)
            {
                tablero[fd, cd] = pieza;
                tablero[fo, co] = '.';

                bool coronado = Coronar(tablero, fd, cd);

                historial[totalMovimientos] = turno + ": (" + fo + "," + co + ") -> (" + fd + "," + cd + ")" + (coronado ? " [corona]" : "");
                totalMovimientos++;

                debeSeguirCapturando = false;
                if (turno == 'x')
                    turno = 'o';
                else
                    turno = 'x';
            }
            else if (tablero[fd, cd] == '.' && esIntentoDeCaptura)
            {
                int filaMedio = (fo + fd) / 2;
                int colMedio = (co + cd) / 2;

                if (tablero[filaMedio, colMedio] != '.' && Tipo(tablero[filaMedio, colMedio]) != turno)
                {
                    tablero[fd, cd] = pieza;
                    tablero[fo, co] = '.';

                    if (Tipo(tablero[filaMedio, colMedio]) == 'x') fichasX--;
                    else fichasO--;

                    tablero[filaMedio, colMedio] = '.';

                    bool coronado = Coronar(tablero, fd, cd);

                    historial[totalMovimientos] = turno + ": (" + fo + "," + co + ") -> (" + fd + "," + cd + ") [captura]" + (coronado ? " [corona]" : "");
                    totalMovimientos++;

                    Console.WriteLine("¡Capturaste una ficha! :DDD");

                    // verifica si puede comer 2 veces osiosi
                    if (PuedeCapturarDesde(tablero, fd, cd, turno))
                    {
                        debeSeguirCapturando = true;
                        filaObligada = fd;
                        colObligada = cd;
                        Console.WriteLine("¡Puedes seguir capturando con la misma ficha!");
                    }
                    else
                    {
                        debeSeguirCapturando = false;
                        if (turno == 'x')
                            turno = 'o';
                        else
                            turno = 'x';
                    }
                }
                else
                {
                    Console.WriteLine("Movimiento inválido D:");
                }
            }
            else
            {
                Console.WriteLine("Movimiento inválido D:");
            }
        }
    }

    // Devuelve 'x' u 'o' sin importar si la ficha es normal o rey
    static char Tipo(char pieza)
    {
        return char.ToLower(pieza);
    }

    static bool EsRey(char pieza)
    {
        return pieza == 'X' || pieza == 'O';
    }

    // Si una ficha llega a la última fila la convierte en rey. Devuelve verda si coronó.
    static bool Coronar(char[,] tablero, int f, int c)
    {
        if (tablero[f, c] == 'x' && f == 7)
        {
            tablero[f, c] = 'X';
            return true;
        }
        if (tablero[f, c] == 'o' && f == 0)
        {
            tablero[f, c] = 'O';
            return true;
        }
        return false;
    }

    // Revisa si la ficha ubicada en (f,c) puede capturar alguna ficha enemiga 
    static bool PuedeCapturarDesde(char[,] tablero, int f, int c, char turno)
    {
        char pieza = tablero[f, c];
        if (pieza == '.' || Tipo(pieza) != turno) return false;

        bool esRey = EsRey(pieza);

        int[] direccionesFila = esRey ? new int[] { -1, -1, 1, 1 } : (turno == 'x' ? new int[] { 1, 1 } : new int[] { -1, -1 });
        int[] direccionesCol = esRey ? new int[] { -1, 1, -1, 1 } : new int[] { -1, 1 };

        for (int i = 0; i < direccionesFila.Length; i++)
        {
            int df = direccionesFila[i];
            int dc = direccionesCol[i];

            int fMedio = f + df;
            int cMedio = c + dc;
            int fFin = f + 2 * df;
            int cFin = c + 2 * dc;

            if (fFin < 0 || fFin > 7 || cFin < 0 || cFin > 7) continue;

            if (tablero[fMedio, cMedio] != '.' && Tipo(tablero[fMedio, cMedio]) != turno && tablero[fFin, cFin] == '.')
                return true;
        }

        return false;
    }

    // Revisa si el jugador en tiene alguna captura disponible en todo el tablero jeje
    static bool HayCapturaDisponible(char[,] tablero, char turno)
    {
        for (int f = 0; f < 8; f++)
            for (int c = 0; c < 8; c++)
                if (tablero[f, c] != '.' && Tipo(tablero[f, c]) == turno)
                    if (PuedeCapturarDesde(tablero, f, c, turno))
                        return true;

        return false;
    }

    // Códigos ANSI de color verdadero (24-bit). Esto funciona igual en cualquier
    // terminal (VS Code, Windows Terminal, etc.) porque no depende del tema de la
    // terminal como sí pasa con Console.ForegroundColor / BackgroundColor.
    const string RESET = "\u001b[0m";
    const string CASILLA_CLARA = "\u001b[48;2;222;184;135m"; // fondo beige
    const string CASILLA_OSCURA = "\u001b[48;2;101;67;33m";  // fondo café oscuro
    const string FICHA_X = "\u001b[38;2;220;20;60m";         // rojo
    const string FICHA_X_REY = "\u001b[38;2;139;0;0m";       // rojo oscuro
    const string FICHA_O = "\u001b[38;2;255;215;0m";         // dorado
    const string FICHA_O_REY = "\u001b[38;2;184;134;11m";    // dorado oscuro
    const string TEXTO_VACIO = "\u001b[38;2;90;60;40m";      // apenas visible sobre la casilla

    // Imprime el tablero con colores: casillas claras/oscuras y fichas de colores
    static void Imprimir(char[,] tablero)
    {
        Console.WriteLine();
        Console.WriteLine("    0   1   2   3   4   5   6   7");

        for (int f = 0; f < 8; f++)
        {
            Console.WriteLine("  +---+---+---+---+---+---+---+---+");

            Console.Write(f + " |");
            for (int c = 0; c < 8; c++)
            {
                bool casillaOscura = (f + c) % 2 == 1;
                string fondo = casillaOscura ? CASILLA_OSCURA : CASILLA_CLARA;

                char pieza = tablero[f, c];
                string colorFicha;

                if (pieza == '.')
                    colorFicha = TEXTO_VACIO;
                else if (Tipo(pieza) == 'x')
                    colorFicha = EsRey(pieza) ? FICHA_X_REY : FICHA_X;
                else
                    colorFicha = EsRey(pieza) ? FICHA_O_REY : FICHA_O;

                Console.Write(fondo + colorFicha + " " + pieza + " " + RESET + "|");
            }
            Console.WriteLine();
        }
        Console.WriteLine("  +---+---+---+---+---+---+---+---+");
        Console.WriteLine();
    }
}