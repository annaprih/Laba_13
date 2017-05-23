using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Laba13.Model
{
   
    public class Subjects
    {
        [Key]
        [Required]
        public string Name { get; set; }
        [Required]
        public int CountOfLection { get; set; }
        [Required]
        public int CountOfLabs { get; set; }
        [Required]
        public int CountOfStudents { get; set; }
        [Required]
        public int MaxCountOfStudents { get; set; }
        [Required]
        public string TypeOfControlling { get; set; }
        [Required]
        public string NameOfLector { get; set; }

        public void updateCountOfStudents(string name, int count)
        {
            using (DataBaseContext dataBaseContext = new DataBaseContext())
            {
                dataBaseContext.setSubjectses.Where(a => a.Name.Trim().Equals(name)).First().CountOfStudents = count;
                dataBaseContext.SaveChanges();
            }
        }
    }
}
