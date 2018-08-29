using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.GenerarModificacionReserva
{
    class ActualizadorReserva
    {
        private ListadoReserva listadoReserva;
        private string p1;
        private string p2;
        private string p3;
        private string p4;
        private string p5;
        private string p6;
        private string p7;

        public ActualizadorReserva(ListadoReserva listadoReserva)
        {
            // TODO: Complete member initialization
            this.listadoReserva = listadoReserva;
        }

        public ActualizadorReserva()
        {
            // TODO: Complete member initialization
        }

        public ActualizadorReserva(string p1, string p2, string p3, string p4, string p5, string p6, string p7)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.p6 = p6;
            this.p7 = p7;
        }
        internal void modificar()
        {
            throw new NotImplementedException();
        }
    }
}
