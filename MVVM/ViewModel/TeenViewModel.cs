using PropertyChanged;
using SeguridadInformatica.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguridadInformatica.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class TeenViewModel
    {
        public ObservableCollection<CategoryTeen> CategoriesTeen { get; set; }
        public ObservableCollection<MyTaskTeen> TasksTeen { get; set; }
        public TeenViewModel()
        {
            FillData();
            TasksTeen.CollectionChanged += Tasks_CollectionChanged;
        }
        private void Tasks_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            UpdateData();
        }
        public async Task NavigateToTaskPage(string taskName)
        {
            var navigation = Application.Current.MainPage.Navigation;

            if (taskName == "¿Qué son las estafas en línea?")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "Cómo Evitar Estafas en Internet")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "¿Por qué son importantes las contraseñas fuertes?")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "Como crear contraseñas fuertes")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "Riesgos de Compartir Demasiado en Redes Sociales")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "Recomendaciones para proteger tu información")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "¿Por qué es importante proteger tu celular?")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "Cómo Proteger mi Celular de Malware y Hacker")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "¿Qué es el phishing?")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "Cómo Evitar Ataques de Phishing")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "¿Por qué son importantes las actualizaciones?")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "Ventajas y Desventaja de Actualizar")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "Cómo Comprar de Forma Segura en Internet")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "¿Cómo evitar fraudes en compras por internet?")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "Riesgos de Usar Redes Wi-Fi Abiertas")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "¿Cómo Protegerme para Navegar Seguro al usar una Red WiFi Pública?")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "¿Qué es la nube?")
            {
                await navigation.PushAsync(new ());
            }
            else if (taskName == "La Seguridad en la Nube")
            {
                await navigation.PushAsync(new ());
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
                new CategoryTeen{Id = 7,CategoryName = "Descargas Seguras",Color = "#FFD700"},
                new CategoryTeen{Id = 8,CategoryName = "Actualizaciones de Software",Color = "#DC143C"},
                new CategoryTeen{Id = 9,CategoryName = "Ingeniería Social",Color = "#8A2BE2"}
            };
            TasksTeen = new ObservableCollection<MyTaskTeen>
               {
                    new MyTaskTeen{TaskName = "Upload exercise files",Completed = false,CategoryId = 1},
                    new MyTaskTeen{TaskName = "Plan next course",Completed = false,CategoryId = 1},
                    new MyTaskTeen{TaskName = "Upload new ASP.NET video on YouTube",Completed = false,CategoryId = 2},
                    new MyTaskTeen{TaskName = "Fix Settings.cs class of the project",Completed = false,CategoryId = 2},
                    new MyTaskTeen{TaskName = "Update github repository",Completed = false,CategoryId = 2},
                    new MyTaskTeen{TaskName = "Buy eggs",Completed = false,CategoryId = 3},
                    new MyTaskTeen{TaskName = "Go for the pepperoni pizza",Completed = false,CategoryId = 3},
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
