using PropertyChanged;
using SeguridadInformatica.MVVM.Models;
using SeguridadInformatica.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SeguridadInformatica.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class TeenViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<CategoryTeen> CategoriesTeen { get; set; }
        public ObservableCollection<MyTaskTeen> TasksTeen { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand NavigateToTaskPageCommand { get; }
        public TeenViewModel()
        {
            FillData();
            TasksTeen.CollectionChanged += Tasks_CollectionChanged;
            NavigateToTaskPageCommand = new Command<string>(async (taskName) => await NavigateToTaskPage(taskName));
        }
        private void Tasks_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            UpdateData();
        }
        public async Task NavigateToTaskPage(string taskName)
        {
            var navigation = Application.Current.MainPage.Navigation;

            if (taskName == "¿Qué es el Pishing?")
            {
                await navigation.PushAsync(new Teen1());
            }
            else if (taskName == "Como evitar el Pishing")
            {
                await navigation.PushAsync(new Teen2());
            }
            else if (taskName == "¿Porque son importantes las contraseñas?")
            {
                await navigation.PushAsync(new Teen3());
            }
            else if (taskName == "Como Crear una Contraseñas Segura")
            {
                await navigation.PushAsync(new Teen4());
            }
            else if (taskName == "¿Por qué importa la privacidad en redes?")
            {
                await navigation.PushAsync(new Teen5());
            }
            else if (taskName == "Privacidad en Redes Sociales")
            {
                await navigation.PushAsync(new Teen6());
            }
            else if (taskName == "¿Por qué cuidar nuestros dispositivos?")
            {
                await navigation.PushAsync(new Teen7());
            }
            else if (taskName == "Apps Maliciosas")
            {
                await navigation.PushAsync(new Teen8());
            }
            else if (taskName == "¿Que es el ciberacoso?")
            {
                await navigation.PushAsync(new Teen9());
            }
            else if (taskName == "Como Evitar el Ciberacoso")
            {
                await navigation.PushAsync(new Teen10());
            }
            else if (taskName == "¿Por qué importa lo que descargamos?")
            {
                await navigation.PushAsync(new Teen11());
            }
            else if (taskName == "Identificar Sitios Poco Confiables")
            {
                await navigation.PushAsync(new Teen12());
            }
            else if (taskName == "¿Por qué son necesarias las actualizaciones?")
            {
                await navigation.PushAsync(new Teen13());
            }
            else if (taskName == "Actualizaciones de Apps")
            {
                await navigation.PushAsync(new Teen14());
            }
            else if (taskName == "¿Que es la Ingenieria Social?")
            {
                await navigation.PushAsync(new Teen15());
            }
            else if (taskName == "Como funciona la Ingenieria Social")
            {
                await navigation.PushAsync(new Teen16());
            }
            else
            {
                Console.WriteLine($"No se encontró una página para la tarea: {taskName}");
            }
        }
        private void FillData()
        {
            CategoriesTeen = new ObservableCollection<CategoryTeen>
            {
                new CategoryTeen{Id = 1,CategoryName = "Phishing",Color = "#CF14DF"},
                new CategoryTeen{Id = 2,CategoryName = "Contraseñas Seguras",Color = "#FFA500"},
                new CategoryTeen{Id = 3,CategoryName = "Privacidad en Redes Sociales",Color = "#008000"},
                new CategoryTeen{Id = 4,CategoryName = "Seguridad en Dispositivos Móviles",Color = "#0000FF"},
                new CategoryTeen{Id = 5,CategoryName = "Ciberacoso",Color = "#800080"},
                new CategoryTeen{Id = 6,CategoryName = "Descargas Seguras",Color = "#FFD700"},
                new CategoryTeen{Id = 7,CategoryName = "Actualizaciones de Software",Color = "#DC143C"},
                new CategoryTeen{Id = 8,CategoryName = "Ingeniería Social",Color = "#8A2BE2"}
            };
            TasksTeen = new ObservableCollection<MyTaskTeen>
               {
                    new MyTaskTeen{TaskName = "¿Qué es el Pishing?",Completed = false,CategoryId = 1},
                    new MyTaskTeen{TaskName = "Como evitar el Pishing",Completed = false,CategoryId = 1},
                    new MyTaskTeen{TaskName = "¿Porque son importantes las contraseñas?",Completed = false,CategoryId = 2},
                    new MyTaskTeen{TaskName = "Como Crear una Contraseñas Segura",Completed = false,CategoryId = 2},
                    new MyTaskTeen{TaskName = "¿Por qué importa la privacidad en redes?",Completed = false,CategoryId = 3},
                    new MyTaskTeen{TaskName = "Privacidad en Redes Sociales",Completed = false,CategoryId = 3},
                    new MyTaskTeen{TaskName = "¿Por qué cuidar nuestros dispositivos?",Completed = false,CategoryId = 4},
                    new MyTaskTeen{TaskName = "Apps Maliciosas",Completed = false,CategoryId = 4},
                    new MyTaskTeen{TaskName = "¿Que es el ciberacoso?",Completed = false,CategoryId = 5},
                    new MyTaskTeen{TaskName = "Como Evitar el Ciberacoso",Completed = false,CategoryId = 5},
                    new MyTaskTeen{TaskName = "¿Por qué importa lo que descargamos?",Completed = false,CategoryId = 6},
                    new MyTaskTeen{TaskName = "Identificar Sitios Poco Confiables",Completed = false,CategoryId = 6},
                    new MyTaskTeen{TaskName = "¿Por qué son necesarias las actualizaciones?",Completed = false,CategoryId = 7},
                    new MyTaskTeen{TaskName = "Actualizaciones de Apps",Completed = false,CategoryId = 7},
                    new MyTaskTeen{TaskName = "¿Que es la Ingenieria Social?",Completed = false,CategoryId = 8},
                    new MyTaskTeen{TaskName = "Como funciona la Ingenieria Social",Completed = false,CategoryId = 8}
               };
            UpdateData();
        }
        public void UpdateData()
        {
            foreach (var c in CategoriesTeen)
            {
                var tasks = from t in TasksTeen
                            where t.CategoryId == c.Id
                            select t;

                var completed = from t in tasks
                                where t.Completed == true
                                select t;

                var notCompleted = from t in tasks
                                   where t.Completed == false
                                   select t;



                c.PendingTasks = notCompleted.Count();
                c.Percentage = (float)completed.Count() / (float)tasks.Count();
            }
            foreach (var t in TasksTeen)
            {
                var catColor =
                     (from c in CategoriesTeen
                      where c.Id == t.CategoryId
                      select c.Color).FirstOrDefault();
                t.TaskColor = catColor;
            }
        }
    }
}
