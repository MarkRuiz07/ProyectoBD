﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class Solicitud
    {
        public int idsolicitud { get; set; }

        public String aula { get; set; }

        public String nivel { get; set; }

        public DateTime fechasolicitud { get; set; }
        
        public DateTime fechauso { get; set; }

        public String horainicio { get; set; }

        public String horafinal { get; set; }

        public String carrera { get; set; }

        public int idrecursos { get; set; }

        public int idusuario { get; set; }

        public String asignatura { get; set; }
        

    }
}
