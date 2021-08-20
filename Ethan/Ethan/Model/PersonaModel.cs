using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
namespace Ethan.Model
{
    public class PersonaModel:INotifyPropertyChanged
    {
        private int IdPago;
        private string Descripcion;
        private double Monto;
        private DateTime Fecha;
        private string foto;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propiedad) 
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(propiedad));
            }
        }

        [PrimaryKey,AutoIncrement]
        public int IdPag
        {
            get { return IdPag; }
            set
            {
                if(IdPag !=value)
                {
                    IdPag = value;
                    OnPropertyChanged("IdPag");
                }
            }
        }
        public string Descrip
        {
            get { return Descrip; }
            set
            {
                if (Descrip != value)
                {
                    Descrip = value;
                    OnPropertyChanged("Descrip");
                }
            }
        }
        public string Fech
        {
            get { return Fech; }
            set
            {
                if (Fech != value)
                {
                    Fech = value;
                    OnPropertyChanged("Fech");
                }
            }
        }
        public string Mont
        {
            get { return Mont; }
            set
            {
                if (Mont != value)
                {
                    Mont = value;
                    OnPropertyChanged("Mont");
                }
            }
        }
        public string Fot
        {
            get { return Fot; }
            set
            {
                if (Fot != value)
                {
                    Fot = value;
                    OnPropertyChanged("Fot");
                }
            }
        }


    }
}
