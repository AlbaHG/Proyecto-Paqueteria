﻿using System.ComponentModel;
using System.Data.Entity;

namespace BL.Entregas
{
    public class TiposBL
    {
        Contexto _contexto;
        public BindingList<Tipo> listaTipos { get; set; }

        public TiposBL()
        {
            _contexto = new Contexto();
            listaTipos = new BindingList<Tipo>();

        }

        public BindingList<Tipo> ObtenerTipos()
        {
            _contexto.Tipos.Load();
            listaTipos = _contexto.Tipos.Local.ToBindingList();

            return listaTipos;
        }



    }


    public class Tipo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
