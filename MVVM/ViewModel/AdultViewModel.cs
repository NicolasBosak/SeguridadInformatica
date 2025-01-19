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
    public class AdultViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<CategoryAdult> CategoriesAdult { get; set; }

        public ObservableCollection<MyTaskAdult> TasksAdult { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand NavigateToTaskPageCommand { get; }

        public AdultViewModel()
        {
            FillData();
            TasksAdult.CollectionChanged += Tasks_CollectionChanged;
            NavigateToTaskPageCommand = new Command<string>(async (taskName) => await NavigateToTaskPage(taskName));
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
                await navigation.PushAsync(new Protection1());
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
            else
            {
                Console.WriteLine($"No se encontró una página para la tarea: {taskName}");
            }
        }
        private void FillData()
        {
            CategoriesAdult = new ObservableCollection<CategoryAdult>
            {
                new CategoryAdult{Id = 1, CategoryName = "Protección Contra Estafas en Línea", Color = "#CF14DF"},
                new CategoryAdult{Id= 2, CategoryName = "Uso Seguro de Contraseñas", Color = "#FFA500"},
                new CategoryAdult{Id = 3, CategoryName = "Privacidad en Redes Sociales", Color = "#14df80"},
                new CategoryAdult{Id = 4, CategoryName = "Seguridad en Dispositivos Móviles", Color = "#0000FF"},
                new CategoryAdult{Id = 5, CategoryName = "Phishing", Color = "#FF69B4"},
                new CategoryAdult{Id = 6, CategoryName = "Actualizaciones de Software", Color = "#800080"},
                new CategoryAdult{Id = 7, CategoryName = "Seguridad en Compras en Línea", Color = "#FFD700"},
                new CategoryAdult{Id = 8, CategoryName = "Uso Seguro de Wi-Fi Público", Color = "#0000FF"},
                new CategoryAdult{Id = 9, CategoryName = "Ciberacoso y Fraude", Color = "#DC143C"},
                new CategoryAdult{Id = 10, CategoryName = "Seguridad en la Nube", Color = "#8A2BE2"}
            };

            TasksAdult = new ObservableCollection<MyTaskAdult>
               {
                    new MyTaskAdult{TaskName = "¿Qué son las estafas en línea?", Completed = false, CategoryId = 1},
                    new MyTaskAdult{TaskName = "Cómo Evitar Estafas en Internet", Completed = false, CategoryId = 1},
                    new MyTaskAdult{TaskName = "¿Por qué son importantes las contraseñas fuertes?", Completed = false, CategoryId = 2},
                    new MyTaskAdult{TaskName = "Como crear contraseñas fuertes", Completed = false, CategoryId = 2},
                    new MyTaskAdult{TaskName = "Riesgos de Compartir Demasiado en Redes Sociales", Completed = false, CategoryId = 3},
                    new MyTaskAdult{TaskName = "Recomendaciones para proteger tu información", Completed = false, CategoryId = 3},
                    new MyTaskAdult{TaskName = "¿Por qué es importante proteger tu celular?", Completed = false, CategoryId = 4},
                    new MyTaskAdult{TaskName = "Cómo Proteger mi Celular de Malware y Hackers", Completed = false, CategoryId = 4},
                    new MyTaskAdult{TaskName = "¿Qué es el phishing?", Completed = false, CategoryId = 5},
                    new MyTaskAdult{TaskName = "Cómo Evitar Ataques de Phishing", Completed = false, CategoryId = 5},
                    new MyTaskAdult{TaskName = "¿Por qué son importantes las actualizaciones?", Completed = false, CategoryId = 6},
                    new MyTaskAdult{TaskName = "Ventajas y Desventaja de Actualizar", Completed = false, CategoryId = 6},
                    new MyTaskAdult{TaskName = "Cómo Comprar de Forma Segura en Internet", Completed = false, CategoryId = 7},
                    new MyTaskAdult{TaskName = "¿Cómo evitar fraudes en compras por internet?", Completed = false, CategoryId = 7},
                    new MyTaskAdult{TaskName = "Riesgos de Usar Redes Wi-Fi Abiertas", Completed = false, CategoryId = 8},
                    new MyTaskAdult{TaskName = "¿Cómo Protegerme para Navegar Seguro al usar una Red WiFi Pública?", Completed = false, CategoryId = 8},
                    new MyTaskAdult{TaskName = "¿Qué es el ciberacoso?", Completed = false, CategoryId = 9},
                    new MyTaskAdult{TaskName = "Qué Debe Hacer si es Víctima de Ciberacoso", Completed = false, CategoryId = 9},
                    new MyTaskAdult{TaskName = "¿Qué es la nube?", Completed = false, CategoryId = 10},
                    new MyTaskAdult{TaskName = "La Seguridad en la Nube", Completed = false, CategoryId = 10},
               };

            UpdateData();
        }
        public void UpdateData()
        {
            foreach (var c in CategoriesAdult)
            {
                var tasks = from t in TasksAdult
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
            foreach (var t in TasksAdult)
            {
                var catColor =
                     (from c in CategoriesAdult
                      where c.Id == t.CategoryId
                      select c.Color).FirstOrDefault();
                t.TaskColor = catColor;
            }
        }
    }
}
