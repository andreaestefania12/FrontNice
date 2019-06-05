using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proyecto.ViewModel
{
   
    public class ListaAsignaturasViewModel
    {
        public ObservableCollection<ModeloAsignatura> ListaAsignaturas { get; set; }

        public ListaAsignaturasViewModel()
        {
            ListaAsignaturas = new ObservableCollection<ModeloAsignatura>();
            ListaAsignaturas.Add(new ModeloAsignatura { nombre = "Asignatura", nota = "Nota aculumada: 1.0", inasistencia = "Inasistencia: 18%" });
            ListaAsignaturas.Add(new ModeloAsignatura { nombre = "Asignatura", nota = "Nota aculumada: 1.0",  inasistencia = "Inasistencia: 18%" });
        }
    }
}
