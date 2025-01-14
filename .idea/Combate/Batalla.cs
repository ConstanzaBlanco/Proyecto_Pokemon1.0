﻿namespace Library.Combate;


public class Batalla
{
    private bool turnos { get; set; }
    private Jugador jugador2 { get; set; }
    private Jugador jugador1 { get; set; }
    private bool batallaTerminada { get; set; }

    private Batalla()
    {
        Random random = new Random();
        bool randomBool = random.Next(2) == 0; // Genera un 0 o 1 aleatoriamente
        this.turnos = randomBool;
        this.batallaTerminada = false;
    }

    public void IniciarBatalla()
    {
        //Cuando ambos jugadores tengan su equipo armado, se dara inicio a la batalla
    }

    public void TerminarBatalla()
    {
        //Aqui se revisa quien gano
    }

    public void AvanzarTurno()
    {
        //En este metodo lo que se hace es camiar el turno constantemente entre el jugador 1 y 2 haciendo un "toggle"
        if (this.turnos == true)
        {
            this.turnos = false;
        }
        else
        {
            this.turnos = true;
        }
        
    }
    
}