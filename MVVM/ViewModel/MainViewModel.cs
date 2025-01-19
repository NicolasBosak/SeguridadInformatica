using PropertyChanged;
using SeguridadInformatica.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using SeguridadInformatica.MVVM.Views;

namespace SeguridadInformatica.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]

    public class MainViewModel
    {
        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<MyTask> Tasks { get; set; }

        public ICommand NavigateToTaskPageCommand { get; }

        public MainViewModel()
        {
            FillData();
            Tasks.CollectionChanged += Tasks_CollectionChanged;
            NavigateToTaskPageCommand = new Command<string>(async (taskName) => await NavigateToTaskPage(taskName));
        }

        private void Tasks_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            UpdateData();
        }

        public async Task NavigateToTaskPage(string taskName)
        {
            var navigation = Application.Current.MainPage.Navigation;

            if (taskName == "No Compartir Contraseñas")
            {
                await navigation.PushAsync(new Password1());
            }
            else if (taskName == "Crear Contraseñas Fuertes")
            {
                await navigation.PushAsync(new Password2());
            }
            else
            {
                Console.WriteLine($"No se encontró una página para la tarea: {taskName}");
            }
        }



        private void FillData()
        {
            Categories = new ObservableCollection<Category>
            {
                new Category{Id = 1, CategoryName = "Cuidado con las Contraseñas", Color = "#CF14DF"},
                new Category{Id = 2, CategoryName = "No Hables con Extraños en Línea", Color = "#df6f14"},
                new Category{Id = 3, CategoryName = "Reconoce el Contenido Falso o Peligroso", Color = "#14df80"},
                new Category{Id = 4, CategoryName = "Actualiza y Protege tus Dispositivos", Color = "#0000FF"},
                new Category{Id = 5, CategoryName = "Seguridad en Juegos en Líneas", Color = "#FF69B4"}
            };

            Tasks = new ObservableCollection<MyTask>
            {
                new MyTask { TaskName = "No Compartir Contraseñas", Completed = false, CategoryId = 1 },
                new MyTask { TaskName = "Crear Contraseñas Fuertes", Completed = false, CategoryId = 1 },
                new MyTask { TaskName = "No Compartir Información Personal", Completed = false, CategoryId = 2 },
                new MyTask { TaskName = "Identificar Qué Información es Privada", Completed = false, CategoryId = 2 },
                new MyTask { TaskName = "No Todo en Internet es Real", Completed = false, CategoryId = 3 },
                new MyTask { TaskName = "Identificar Señales de Alerta", Completed = false, CategoryId = 3 },
                new MyTask { TaskName = "Actualizaciones", Completed = false, CategoryId = 4 },
                new MyTask { TaskName = "Antivirus", Completed = false, CategoryId = 4 },
                new MyTask { TaskName = "Jugar de Manera Segura", Completed = false, CategoryId = 5 },
                new MyTask { TaskName = "Proteger tu Información", Completed = false, CategoryId = 5 }
            };

            UpdateData();
        }

        public void UpdateData()
        {
            foreach (var c in Categories)
            {
                var tasks = from t in Tasks
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
            foreach (var t in Tasks)
            {
                var catColor =
                     (from c in Categories
                      where c.Id == t.CategoryId
                      select c.Color).FirstOrDefault();
                t.TaskColor = catColor;
            }
        }
    }
}