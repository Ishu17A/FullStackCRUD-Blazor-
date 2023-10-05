using System.ComponentModel.DataAnnotations;

namespace Blazor_CRUD.Model
{
    public class EmployeeViewMdel
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Brand { get; set; }

        public DaysEnum DayEnums
        {
            get;
            set;
        }



    }
}
