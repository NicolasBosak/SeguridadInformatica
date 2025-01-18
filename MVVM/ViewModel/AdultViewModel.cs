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
    public class AdultViewModel
    {
        public ObservableCollection<CategoryAdult> CategoriesAdult { get; set; }

        public ObservableCollection<MyTaskAdult> TasksAdult { get; set; }

        public AdultViewModel()
        {
            FillData();
            TasksAdult.CollectionChanged += Tasks_CollectionChanged;
        }
        private void Tasks_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            UpdateData();
        }
        private void FillData()
        {
            CategoriesAdult = new ObservableCollection<CategoryAdult>
            {
                new CategoryAdult
                {
                    Id = 1,
                    CategoryName = "Protección Contra Estafas en Línea",
                    Color = "#CF14DF"
                },
                new CategoryAdult
                {
                    Id= 2,
                    CategoryName = "Uso Seguro de Contraseñas",
                    Color = "#FFA500"
                },
                new CategoryAdult
                {
                    Id = 3,
                    CategoryName = "Privacidad en Redes Sociales",
                    Color = "#14df80"
                },
                new CategoryAdult
                {
                    Id = 4,
                    CategoryName = "Seguridad en Dispositivos Móviles",
                    Color = "#0000FF"
                },
                new CategoryAdult
                {
                    Id = 5,
                    CategoryName = "Phishing",
                    Color = "#FF69B4"
                },
                new CategoryAdult
                {
                    Id = 6,
                    CategoryName = "Actualizaciones de Software",
                    Color = "#800080"
                },
                new CategoryAdult
                {
                    Id = 7,
                    CategoryName = "Seguridad en Compras en Línea",
                    Color = "#FFD700"
                },
                new CategoryAdult
                {
                    Id = 8,
                    CategoryName = "Uso Seguro de Wi-Fi Público",
                    Color = "#DC143C"
                },
                new CategoryAdult
                {
                    Id = 9,
                    CategoryName = "Ciberacoso y Fraude",
                    Color = "#DC143C"
                },
                new CategoryAdult
                {
                    Id = 10,
                    CategoryName = "Seguridad en la Nube",
                    Color = "#8A2BE2"
                }
            };

            TasksAdult = new ObservableCollection<MyTaskAdult>
               {
                    new MyTaskAdult
                    {
                         TaskName = "Upload exercise files",
                         Completed = false,
                         CategoryId = 1
                    },
                    new MyTaskAdult
                    {
                         TaskName = "Plan next course",
                         Completed = false,
                         CategoryId = 1
                    },
                    new MyTaskAdult
                    {
                         TaskName = "Upload new ASP.NET video on YouTube",
                         Completed = false,
                         CategoryId = 2
                    },
                    new MyTaskAdult
                    {
                         TaskName = "Fix Settings.cs class of the project",
                         Completed = false,
                         CategoryId = 2
                    },
                    new MyTaskAdult
                    {
                         TaskName = "Update github repository",
                         Completed = true,
                         CategoryId = 2
                    },
                    new MyTaskAdult
                    {
                         TaskName = "Buy eggs",
                         Completed = false,
                         CategoryId = 3
                    },
                    new MyTaskAdult
                    {
                         TaskName = "Go for the pepperoni pizza",
                         Completed = false,
                         CategoryId = 3
                    },
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
