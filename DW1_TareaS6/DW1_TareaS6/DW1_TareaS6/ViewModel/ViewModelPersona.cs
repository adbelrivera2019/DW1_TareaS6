using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using DW1_TareaS6.Models;

namespace DW1_TareaS6.ViewModel

{
    public class ViewModelCalculadora : INotifyPropertyChanged
    {

        public ViewModelCalculadora() {

            crearCalculadora = new Command(() => {

                Calculadora c = new Calculadora() {
                    numero1 = this.numero1, 
                    numero2 = this.numero2
                };

                Mensaje = p.ToString();



            });


        }

        string mensaje;
        public string Mensaje {

            get => mensaje;
            set {
                mensaje = value;
                var args = new PropertyChangedEventArgs(nameof(Mensaje));
                PropertyChanged?.Invoke(this, args);
            
            }
        
        }


        string numero1;

        public string Numero1 {

            get => numero1;
            set {

                numero1 = value;
                var args = new PropertyChangedEventArgs(nameof(Numero1));
                PropertyChanged?.Invoke(this, args);

            }
            
       }

        string numero2;

        public string Numero2
        {

            get => numero2;
            set
            {

                numero2 = value;
                var args = new PropertyChangedEventArgs(nameof(Numero2));
                PropertyChanged?.Invoke(this, args);

            }

        }



        public Command crearCalculadora { get; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
