using System.ComponentModel.DataAnnotations;

namespace Web_API_.Model
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }    
        public string? Title { get; set; }   
        public string? Brand { get; set; }
        public Departments Departments { get; set; }



    }
}
