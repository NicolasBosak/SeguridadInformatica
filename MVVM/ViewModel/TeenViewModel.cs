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
        private void FillData()
        {
            CategoriesTeen = new ObservableCollection<CategoryTeen>
            {
                new CategoryTeen 
                { 
                    Id = 1,
                    CategoryName = "Phishing",
                    Color = "#CF14DF" 
                },
                new CategoryTeen
                { 
                    Id = 2, 
                    CategoryName = "Contraseñas Seguras",
                    Color = "#FFA500" 
                },
                new CategoryTeen 
                { 
                    Id = 3, 
                    CategoryName = "Privacidad en Redes Sociales",
                    Color = "#008000" 
                },
                new CategoryTeen 
                { 
                    Id = 4,
                    CategoryName = "Seguridad en Dispositivos Móviles",
                    Color = "#0000FF" 
                },
                new CategoryTeen
                { 
                    Id = 5, 
                    CategoryName = "Uso Seguro de Wi-Fi Público",
                    Color = "#FF69B4"
                },
                new CategoryTeen 
                { 
                    Id = 6, 
                    CategoryName = "Ciberacoso",
                    Color = "#800080" 
                },
                new CategoryTeen 
                { 
                    Id = 7, 
                    CategoryName = "Descargas Seguras",
                    Color = "#FFD700"
                },
                new CategoryTeen 
                {
                    Id = 8, 
                    CategoryName = "Actualizaciones de Software", 
                    Color = "#DC143C"
                },
                new CategoryTeen
                { 
                    Id = 9, 
                    CategoryName = "Seguridad en la Nube",
                    Color = "#DC143C"
                },
                new CategoryTeen 
                { 
                    Id = 10,
                    CategoryName = "Ingeniería Social",
                    Color = "#8A2BE2" 
                }
            };

            TasksTeen = new ObservableCollection<MyTaskTeen>
               {
                    new MyTaskTeen
                    {
                         TaskName = "Upload exercise files",
                         Completed = false,
                         CategoryId = 1
                    },
                    new MyTaskTeen
                    {
                         TaskName = "Plan next course",
                         Completed = false,
                         CategoryId = 1
                    },
                    new MyTaskTeen
                    {
                         TaskName = "Upload new ASP.NET video on YouTube",
                         Completed = false,
                         CategoryId = 2
                    },
                    new MyTaskTeen
                    {
                         TaskName = "Fix Settings.cs class of the project",
                         Completed = false,
                         CategoryId = 2
                    },
                    new MyTaskTeen
                    {
                         TaskName = "Update github repository",
                         Completed = true,
                         CategoryId = 2
                    },
                    new MyTaskTeen
                    {
                         TaskName = "Buy eggs",
                         Completed = false,
                         CategoryId = 3
                    },
                    new MyTaskTeen
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
