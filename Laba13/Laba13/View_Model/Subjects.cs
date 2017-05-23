using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Laba13.Commands;

namespace Laba13.View_Model
{
    class Subjects: ViewModelBase
    {
        public Model.Subjects subjects;

        public Subjects(Model.Subjects modSubjects)
        {
            subjects = modSubjects;
        }


        public string Name
        {
            get { return subjects.Name; }
        }

        public int CountOfLection
        {
            get { return subjects.CountOfLection; }
        }
        public int CountOfLabs
        {
            get { return subjects.CountOfLabs; }
        }
        public int CountOfStudents
        {
            get { return subjects.CountOfStudents; }
            set
            {
                subjects.CountOfStudents = value;
                OnPropertyChanged("CountOfStudents");
            }
        }
        public int MaxCountOfStudents
        {
            get { return subjects.MaxCountOfStudents; }
        }
        public string TypeOfControlling
        {
            get { return subjects.TypeOfControlling; }
        }
        public string NameOfLector
        {
            get { return subjects.NameOfLector; }
        }

        private Commands.DelegateCommand Subscribe;

        public ICommand subscribe_
        {
            get
            {
                if (Subscribe == null)
                {
                    Subscribe = new DelegateCommand(subs, CanSub);
                }

                return Subscribe;

            }
          
        }

        private void subs()
        {
            CountOfStudents++;
            subjects.updateCountOfStudents(Name, CountOfStudents);
        }

        private bool CanSub()
        {
            if (CountOfStudents > MaxCountOfStudents)
            {
                return false;
            }
            return true;
        }

        private Commands.DelegateCommand UnSubscribe;

        public ICommand unSubscribe_
        {
            get
            {
                if (UnSubscribe == null)
                {
                    UnSubscribe = new DelegateCommand(unSubs, CanUnSub);
                }

                return UnSubscribe;

            }

        }

        private void unSubs()
        {
            CountOfStudents--;
            subjects.updateCountOfStudents(Name, CountOfStudents);
        }

        private bool CanUnSub()
        {
            if (CountOfStudents == 0)
            {
                return false;
            }
            return true;
        }
    }
}
