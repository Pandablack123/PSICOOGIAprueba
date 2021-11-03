using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_PRESENTACION
{
    public class Class1
    {
        public static Color PanelPadre;
        public static Color PanelBotones;
        public static Color panlebotones;
        public static Color BarraTitulo;
        public static Color TextBusqueda;
        public static Color FuenteIconos;


        //Colores Defecto
        private static readonly Color PanelPadreD = Color.FromArgb(237, 215, 168);
        private static readonly Color PanelBotonesDL = Color.FromArgb(217, 198, 163);
        private static readonly Color PanelBotonesDF = Color.FromArgb(217, 198, 163);
        private static readonly Color BarraTituloD = Color.FromArgb(214, 185, 144);
        private static readonly Color TextBusquedaD = Color.FromArgb(194, 181, 134);
        private static readonly Color FuenteIconosD = Color.White;

        //Tema Morado
        private static readonly Color PanelPadreM = Color.FromArgb(92, 36, 97);
        private static readonly Color PanelBotonesML = Color.FromArgb(149, 240, 137);
        private static readonly Color PanelBotonesMF = Color.FromArgb(157, 235, 200);
        private static readonly Color BarraTituloM = Color.FromArgb(164, 64, 173);
        private static readonly Color TextBusquedaM = Color.FromArgb(223, 154, 230);
        private static readonly Color FuenteIconosM = Color.White;

        //Tema Verde
        private static readonly Color PanelPadreV = Color.FromArgb(157, 235, 200);
        private static readonly Color PanelBotonesVL = Color.FromArgb(164, 217, 170);
        private static readonly Color PanelBotonesVF = Color.FromArgb(170, 240, 191);
        private static readonly Color BarraTituloV = Color.FromArgb(176, 240, 170);
        private static readonly Color TextBusquedaV = Color.FromArgb(181, 230, 63);
        private static readonly Color FuenteIconosV = Color.White;

        //Tema Celeste
        private static readonly Color PanelPadreC = Color.FromArgb(60, 101, 138);
        private static readonly Color PanelBotonesCL = Color.FromArgb(95,158,160);
        private static readonly Color PanelBotonesCF = Color.FromArgb(0, 206, 209);
        private static readonly Color BarraTituloC = Color.FromArgb(95, 158, 160);
        private static readonly Color TextBusquedaC = Color.FromArgb(164,221,224);
        private static readonly Color FuenteIconosC = Color.White;

        //Tema Acua
        private static readonly Color PanelPadreA = Color.FromArgb(17, 47, 51);
        private static readonly Color PanelBotonesAL = Color.FromArgb(33, 92, 99);
        private static readonly Color PanelBotonesAF = Color.FromArgb(95, 158, 160);
        private static readonly Color BarraTituloA = Color.FromArgb(37, 115, 125);
        private static readonly Color TextBusquedaA = Color.FromArgb(58, 162, 176);
        private static readonly Color FuenteIconosA = Color.White;



        //SeleccionarColores
        #region -> Metodos
        public static void ElegirTema(string Tema)
        {
            if (Tema == "Defecto")
            {
                PanelPadre = PanelPadreD;
                PanelBotones = PanelBotonesDL;
                panlebotones = PanelBotonesDF;
                BarraTitulo = BarraTituloD;
                TextBusqueda = TextBusquedaD;
                FuenteIconos = FuenteIconosD;
            }
            if (Tema == "Morado")
            {
                PanelPadre = PanelPadreM;
                PanelBotones = PanelBotonesML;
                panlebotones = PanelBotonesMF;
                BarraTitulo = BarraTituloM;
                TextBusqueda = TextBusquedaM;
                FuenteIconos = FuenteIconosM;
            }
            if (Tema == "Verde")
            {
                PanelPadre = PanelPadreV;
                PanelBotones = PanelBotonesVL;
                panlebotones = PanelBotonesVF;
                BarraTitulo = BarraTituloV;
                TextBusqueda = TextBusquedaV;
                FuenteIconos = FuenteIconosV;
            }
            if (Tema == "Celeste")
            {
                PanelPadre = PanelPadreC;
                PanelBotones = PanelBotonesCL;
                panlebotones = PanelBotonesCF;
                BarraTitulo = BarraTituloC;
                TextBusqueda = TextBusquedaC;
                FuenteIconos = FuenteIconosC;
            }
            if (Tema == "Acua")
            {
                PanelPadre = PanelPadreA;
                PanelBotones = PanelBotonesAL;
                panlebotones = PanelBotonesAF;
                BarraTitulo = BarraTituloA;
                TextBusqueda = TextBusquedaA;
                FuenteIconos = FuenteIconosA;
            }

        }
        #endregion
    }
}

