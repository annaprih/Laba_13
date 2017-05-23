using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Laba13.Model;
using Laba13.View;
using Laba13.View_Model;

namespace Laba13
{
   public class Main_Program: Application
    {
        [STAThread()]
        public static void Main()
        {
           
            DataBaseContext dataBaseContext = new DataBaseContext();
           /dataBaseContext.setSubjectses.Add(new Model.Subjects
            {
                Name = "DataBase",
                CountOfStudents = 1,
                MaxCountOfStudents = 3,
                CountOfLabs = 17,
                NameOfLector = "Pustovalova",
                CountOfLection = 25,
                TypeOfControlling = "Exam"
            });

            dataBaseContext.setSubjectses.Add(new Model.Subjects
            {
                Name = "OOP",
                CountOfStudents = 1,
                MaxCountOfStudents = 3,
                CountOfLabs = 17,
                NameOfLector = "Patsei",
                CountOfLection = 25,
                TypeOfControlling = "Exam"
            });

            dataBaseContext.setSubjectses.Add(new Model.Subjects
            {
                Name = "MathProgramming",
                CountOfStudents = 1,
                MaxCountOfStudents = 3,
                CountOfLabs = 17,
                NameOfLector = "Brakovich",
                CountOfLection = 22,
                TypeOfControlling = "Exam"
            });

            dataBaseContext.setSubjectses.Add(new Model.Subjects
            {
                Name = "ComputerGraph",
                CountOfStudents = 1,
                MaxCountOfStudents = 3,
                CountOfLabs = 12,
                NameOfLector = "Dzyadko",
                CountOfLection = 20,
                TypeOfControlling = "Exam"
            });
            dataBaseContext.SaveChanges();

            Main_Program main_pr = new Main_Program();
            View.MainWindow window = new MainWindow();
            View_Model.ViewModel viewModel = new ViewModel(dataBaseContext.setSubjectses.ToList());
            dataBaseContext.Dispose();
            window.DataContext = viewModel;
            main_pr.Run(window);
        }
    }
}
